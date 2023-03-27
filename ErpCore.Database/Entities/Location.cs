using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErpCore.Database.Entities
{
    public class Location : BaseEntity
    {
        public int Id { get; set; }
        public int ProvinceId { get; set; }
        public virtual Province? Province { get; set; }
        public int DistrictId { get; set; }
        public virtual District? District { get; set; }
        public int WardId { get; set; }
        public virtual Ward? Ward { get; set; }
        public int EmployeeId { get; set; }
        public virtual Employee? Employee { get; set; }
        public int CustomerId { get; set; }
        public virtual Customer? Customer { get; set; }
    }
}
