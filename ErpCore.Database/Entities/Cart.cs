using System;
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
        public int CustomerId { get; set; }
        public virtual Product? Product { get; set; }
        public virtual Customer? Customer { get; set; }
    }
}
