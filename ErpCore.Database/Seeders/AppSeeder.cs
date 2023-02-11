using ErpCore.Database.Entities;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErpCore.Database.Seeders
{
    public class AppSeeder
    {
        public static async Task InitializeAsync(AppDatabase database, UserManager<User> user, RoleManager<IdentityRole> role)
        {
            database.Database.EnsureCreated();
            if(!role.Roles.Any()) 
            {
                await role.CreateAsync(new IdentityRole
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = "Admin",
                    NormalizedName = "ADMIN"
                });

                await role.CreateAsync(new IdentityRole
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = "User",
                    NormalizedName = "USER"
                });
            }
        }
    }
}
