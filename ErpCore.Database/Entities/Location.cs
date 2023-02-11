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
        public int CountryId { get; set; }
        public virtual Country? Country { get; set; }
        public int StateId { get; set; }
        public virtual State? State { get; set; }
        public int CityId { get; set; }
        public virtual City? City { get; set; }
        public virtual ICollection<Employee>? Employes { get; set; }
        public virtual ICollection<Customer>? Customers { get; set; }
    }
}
