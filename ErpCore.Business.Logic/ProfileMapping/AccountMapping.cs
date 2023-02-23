using AutoMapper;
using ErpCore.Business.Logic.Queries.Models;
using ErpCore.Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErpCore.Business.Logic.Helpers
{
    public class AccountMapping : Profile
    {
        public AccountMapping()
        {
            CreateMap<AccountModel,Account>().ReverseMap();
        }
    }
}
