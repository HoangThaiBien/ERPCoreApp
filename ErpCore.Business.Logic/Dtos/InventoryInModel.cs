using ErpCore.Common.Shared.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErpCore.Business.Logic.Dtos
{
    public class InventoryInModel : BaseEntity
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public int Quantity { get; set; }
        public DateTime TimeIn { get; set; }
        public int IdProduct { get; set; }
        public virtual ProductModel? Product { get; set; }
        public int IdWareHouse { get; set; }
        public virtual WareHouseModel? WareHouse { get; set; }
    }
}
