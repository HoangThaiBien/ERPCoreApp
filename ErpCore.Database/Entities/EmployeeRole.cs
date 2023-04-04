using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErpCore.Database.Entities
{
    public class EmployeeRole :BaseEntity
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public virtual ICollection<Employee>? Employees { get; set; }
    }
}
