using ErpCore.Business.Logic.Queries.Repositories;
using ErpCore.Common.Shared.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErpCore.Business.Logic.Queries.Models
{
    public class LocationModel : BaseEntity
    {
        public int Id { get; set; }
        public int CountryId { get; set; }
        public virtual CountryModel? Country { get; set; }
        public int StateId { get; set; }
        public virtual StateModel? State { get; set; }
        public int CityId { get; set; }
        public virtual CityModel? City { get; set; }
        public virtual ICollection<EmployeeModel>? Employes { get; set; }
        public virtual ICollection<CustomerModel>? Customers { get; set; }
    }
}
