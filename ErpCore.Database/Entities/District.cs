using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErpCore.Database.Entities
{
    public class District
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int ProvinceId { get; set; }
        public virtual Province? Province { get; set; }
        public virtual ICollection<Ward>? Wards { get; set; }
        public virtual ICollection<Location>? Locations { get; set; }
    }
}
