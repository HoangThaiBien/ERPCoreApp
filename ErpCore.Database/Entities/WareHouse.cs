﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErpCore.Database.Entities
{
    public class WareHouse: BaseEntity
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? Address { get; set; }
        public string? Phone { get; set; }
        public virtual ICollection<InventoryIn>? InventoryIns { get; set; }
        public virtual ICollection<InventoryOut>? InventoryOuts { get; set; }


    }
}
