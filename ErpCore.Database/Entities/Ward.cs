using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErpCore.Database.Entities
{
    public class Ward
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int DistrictId { get; set; }
        public virtual District? District { get; set; }
        public virtual ICollection<Location>? Locations { get; set; }
    }
}
