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
        public string? EmployeId { get; set;}
        public string? CustomerID { get; set; }
    }
}
