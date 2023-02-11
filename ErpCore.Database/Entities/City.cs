using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErpCore.Database.Entities
{
    public class City : BaseEntity
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int StateId { get; set; }
        public virtual State? State { get; set; }
    }
}
