using ErpCore.Business.Logic.Queries.Repositories;
using ErpCore.Common.Shared.Model;
using ErpCore.Database.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErpCore.Business.Logic.Queries.Models
{
    public class OrderModel : BaseEntity
    {
        public int Id { set; get; }
        public DateTime OrderDate { set; get; }
        public int CustomerId { set; get; }
        public string? ShipName { set; get; }
        public string? ShipAddress { set; get; }
        public string? ShipEmail { set; get; }
        public string? ShipPhoneNumber { set; get; }
        public OrderStatus Status { set; get; }
        public virtual ICollection<OrderDetailModel>? OrderDetails { get; set; }
        public virtual CustomerModel? Customer { get; set; }
    }
}
