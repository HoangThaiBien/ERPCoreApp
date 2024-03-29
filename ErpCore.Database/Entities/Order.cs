﻿using ErpCore.Database.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErpCore.Database.Entities
{
    public class Order : BaseEntity
    {
        public int Id { set; get; }
        public DateTime OrderDate { set; get; }
        public int CustomerId { set; get; }
        public string? ShipName { set; get; }
        public string? ShipAddress { set; get; }
        public string? ShipEmail { set; get; }
        public string? ShipPhoneNumber { set; get; }
        public OrderStatus Status { set; get; }
        public virtual ICollection<OrderDetail>? OrderDetails { get; set; }
        public virtual Customer? Customer { get; set; }


    }
}
