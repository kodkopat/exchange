using Exchange.Communicator.Fixer.io;
using Exchange.Contract.Request.Query;
using Exchange.Contract.Response.Query;
using FluentValidation;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Dynamic;
using Exchange.DataAccess;
using Microsoft.EntityFrameworkCore;
using AutoMapper.QueryableExtensions;
using Exchange.Domain.DataTransferObjects;
using AutoMapper;

namespace Exchange.Application.Handlers.Queries
{
    public class GetTransactionsQueryHandler : IRequestHandler<GetTransactionsQuery, GetTransactionsQueryResult>
    {


        private readonly IValidator<GetTransactionsQuery> _validator;
        private readonly AppDbContext _appDbContext;
        public IMapper _mapper { get; }
        public GetTransactionsQueryHandler(IValidator<GetTransactionsQuery> validator,
                                           AppDbContext appDbContext,
                                           IMapper mapper)
        {
            _validator = validator;
            _appDbContext = appDbContext;
            _mapper = mapper;
        }


        public async Task<GetTransactionsQueryResult> Handle(GetTransactionsQuery request, CancellationToken cancellationToken)
        {
            _validator.ValidateAndThrow(request);

            var res = _appDbContext.Transactions
                .Include(c => c.TransactionDetail)
                .Where(c => c.AccountId == request.AccountId)
                .ProjectTo<TransactionGetDTO>(_mapper.ConfigurationProvider)
                .ToList()
                ;

            return new GetTransactionsQueryResult()
            {
                Transactions = res

            };
        }


    }
}
