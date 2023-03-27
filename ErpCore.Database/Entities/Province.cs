using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErpCore.Database.Entities
{
    public class Province
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public virtual ICollection<District>? Districts { get; set; }
        public virtual ICollection<Location>? Locations { get; set; }
    }
}
