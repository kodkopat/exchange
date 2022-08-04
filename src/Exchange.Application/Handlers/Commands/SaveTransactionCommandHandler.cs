using Exchange.Communicator.Fixer.io;
using Exchange.Contract.Response.Query;
using FluentValidation;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Dynamic;
using Exchange.Contract.Request.Command;
using Exchange.DataAccess;

namespace Exchange.Application.Handlers.Queries
{
    public class SaveTransactionCommandHandler : IRequestHandler<SaveTransactionCommand, SaveTransactionCommandResult>
    {
     
        private readonly IFixerioCommunicator _communicator;
        private readonly IValidator<SaveTransactionCommand> _validator;
        private readonly AppDbContext _appDbContext;
        public SaveTransactionCommandHandler(IFixerioCommunicator communicator,
                                             AppDbContext appDbContext,
                                             IValidator<SaveTransactionCommand> validator)
        {
            _communicator = communicator;
            _appDbContext = appDbContext;
            _validator = validator;
        }

        //this method will not use /convert API of fixer.io service
        public async Task<SaveTransactionCommandResult> Handle(SaveTransactionCommand request, CancellationToken cancellationToken)
        {
            _validator.ValidateAndThrow(request);

            //get new rates after sending request
            var rates = _communicator.GetRates(new Communicator.Fixer.io.Request.FixerioGetRatesRequest
            {
                Source = request.Source,
                Destenations = request.Destination
            });

            //open a new transaction fo insert transaction row and its details
            //this lines commented because of not supporting of transaction method in in-memory database
            //using (var tra = _appDbContext.Database.BeginTransaction())
            //{
            //    try
            //    {

            //        tra.Commit();
            //    }
            //    catch (Exception ex)
            //    {
            //        tra.Rollback();
            //        throw;
            //    }

            //}

            //adding new request to database
            var transaction = new Domain.Models.Transaction
            {
                AccountId = request.AccountId,
                Date = DateTime.Now,
                Source = request.Source,
                SourceAmount = request.SourceAmount,

            };
            _appDbContext.Transactions.Add(transaction);
            _appDbContext.SaveChanges();

            foreach (var dest in request.Destination)
            {
                _appDbContext.TransactionDetail.Add(new Domain.Models.TransactionDetail
                {
                    TransactionId = transaction.Id,
                    Destination = dest,
                    DestinationAmount = request.SourceAmount * decimal.Parse(rates.rates.ToList().FirstOrDefault(c => c.Key == dest).Value.ToString()),
                });

            }

            return new SaveTransactionCommandResult() { Success = _appDbContext.SaveChanges() > 0 };
        }


    }
}