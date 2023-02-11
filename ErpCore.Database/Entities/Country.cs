using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErpCore.Database.Entities
{
    public class Country : BaseEntity
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public virtual ICollection<State>? States { get; set; }
    }
}
