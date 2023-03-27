 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErpCore.Database.Entities
{
    public class InventoryIn : BaseEntity
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public int Quantity { get; set; }
        public DateTime TimeIn { get; set; }
        public int IdProduct { get; set; }
        public virtual Product? Product { get; set; }
        public int IdWareHouse { get; set; }
        public virtual WareHouse? WareHouse { get; set; }
    }
}
