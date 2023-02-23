using ErpCore.Business.Logic.Queries.Repositories;
using ErpCore.Common.Shared.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErpCore.Business.Logic.Queries.Models
{
    public class CityModel : BaseEntity
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int StateId { get; set; }
        public virtual StateModel? State { get; set; }

    }
}
