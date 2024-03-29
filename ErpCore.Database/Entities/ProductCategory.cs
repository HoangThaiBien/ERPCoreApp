﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErpCore.Database.Entities
{
    public class ProductCategory : BaseEntity
    {
        public int ProductId { get; set; }
        public virtual Product? Product { get; set; }
        public int CategoryId { get; set; }
        public virtual Category? Category { get; set; }
    }
}
