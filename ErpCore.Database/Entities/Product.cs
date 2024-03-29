﻿using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErpCore.Database.Entities
{
    public class Product : BaseEntity
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public string? Name { get; set; } 
        public string? Code { get; set; } 
        public string? MetaTitle { get; set; } 
        public string? Description { get; set; } 

        public bool? Status { get; set; }
        public DateTime? TopHot { get; set; }
        public int? ViewCount { get; set; }
        public virtual ICollection<ProductCategory>? ProductCategories { get; set; }
        public virtual ICollection<Cart>? Carts { get; set; }
        public virtual ICollection<OrderDetail>? OrderDetails { get; set; }
        public int SupplierId { get; set; }
        public virtual Supplier? Supplier { get; set; }
        public virtual ICollection<InventoryIn>? InventoryIns { get; set; }
        public virtual ICollection<InventoryOut>? InventoryOuts { get; set; }
        public virtual ICollection<ImageProduct>? ImageProducts { get; set; }
    }
}
