using AutoMapper;
using System.Linq;
using System;
using Exchange.Domain.Models;
using Exchange.Domain.DataTransferObjects;

namespace Exchange.Domain.Automapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {

            #region Transaction
            CreateMap<Transaction, TransactionGetDTO>();
            CreateMap<TransactionDetail, TransactionDetailGetDTO>();
            #endregion

        }
    }
}
