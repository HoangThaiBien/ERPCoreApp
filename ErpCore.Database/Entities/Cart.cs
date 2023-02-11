﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErpCore.Database.Entities
{
    public class Cart : BaseEntity
    {
        public int Id { set; get; }
        public int ProductId { set; get; }
        public int Quantity { set; get; }
        public decimal Price { set; get; }
        public Guid CustomerId { get; set; }
        public Product? Product { get; set; }
        public DateTime DateCreated { get; set; }
        public Customer? Customer { get; set; }
    }
}
