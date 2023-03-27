using ErpCore.Common.Shared.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErpCore.Business.Logic.Dtos
{
    public class WareHouseModel : BaseEntity
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? Address { get; set; }
        public string? Phone { get; set; }
        public virtual ICollection<InventoryInModel>? InventoryIns { get; set; }
        public virtual ICollection<InventoryOutModel>? InventoryOuts { get; set; }
    }
}
