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
    public class CartModel:BaseEntity
    {
        public int Id { set; get; }
        public int Quantity { set; get; }
        public decimal Price { set; get; }
        public int CustomerId { get; set; }
        public virtual CustomerModel? Customer { get; set; }
        public int ProductId { set; get; }
        public virtual ProductModel? Product { get; set; }

    }
}
