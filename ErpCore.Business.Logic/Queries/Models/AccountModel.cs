using ErpCore.Business.Logic.Queries.Repositories;
using ErpCore.Common.Shared.Model;
using ErpCore.Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErpCore.Business.Logic.Queries.Models
{
    public class AccountModel : BaseEntity
    {
        public int Id { get; set; }
        public string? Username { get; set; }
        public string? Password { get; set; }
        public int CustomerId { get; set; }
        public virtual CustomerModel? Customer { get; set; }
       
    }
}
