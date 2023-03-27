using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErpCore.Database.Entities
{
    public class User:IdentityUser
    {
        public int? EmployeId { get; set;}
        public int? CustomerId { get; set; }
        public Employee? Employee { get; set; }
        public Customer? Customer { get; set; }

    }
}
