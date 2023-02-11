using ErpCore.Database.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace ErpCore.Database.Entities
{
    public class State : BaseEntity
    {
        public int Id { get; set; }
        public string? Name { get; set; } 
        public int CountryId { get; set; }
        public virtual Country? Country { get; set; }
        public virtual ICollection<City>? Cities { get; set; }
    }
}
