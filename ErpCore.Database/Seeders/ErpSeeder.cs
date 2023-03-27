using ErpCore.Database.EF;
using ErpCore.Database.Entities;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErpCore.Database.Seeders
{
    public class ErpSeeder
    {
        public static async Task InitializeAsync(ErpDbContext database,UserManager<User> user, RoleManager<IdentityRole> role)
        {
            database.Database.EnsureCreated();
            if (!role.Roles.Any())
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
                    Name = "Manager",
                    NormalizedName = "MANAGER"
                });

                await role.CreateAsync(new IdentityRole
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = "Employee",
                    NormalizedName = "EMPLOYEE"
                });

                await role.CreateAsync(new IdentityRole
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = "Customer",
                    NormalizedName = "CUSTOMER"
                });
            }

            if (!user.Users.Any())
            {

                //Create 1 Admin
                var createAdminResult = await user.CreateAsync(new User
                {
                    Id = Guid.NewGuid().ToString(),
                    UserName = "admin@email.com",
                    Email = "admin@email.com",
                    LockoutEnabled = false
                }, "Admin@123");

                if (createAdminResult.Succeeded)
                {
                    var userResult = await user.FindByNameAsync("admin");
                    await user.AddToRoleAsync(userResult, "Admin");
                }

                //Create 1 Manager
                var createManagerResult = await user.CreateAsync(new User
                {
                    Id = Guid.NewGuid().ToString(),
                    UserName = "manager@email.com",
                    Email = "manager@email.com",
                    LockoutEnabled = false
                }, "Manager@123");

                if (createManagerResult.Succeeded)
                {
                    var userResult = await user.FindByNameAsync("Manager");
                    await user.AddToRoleAsync(userResult, "Manager");
                }

                //Create 1 Customer
                var createCustomerResult = await user.CreateAsync(new User
                {
                    Id = Guid.NewGuid().ToString(),
                    UserName = "customer@email.com",
                    Email = "customer@email.com",
                    LockoutEnabled = false
                }, "Customer@123");

                if (createCustomerResult.Succeeded)
                {
                    var userResult = await user.FindByNameAsync("Customer");
                    await user.AddToRoleAsync(userResult, "Customer");
                }

                //Create 1 Employee
                var createEmployeeResult = await user.CreateAsync(new User
                {
                    Id = Guid.NewGuid().ToString(),
                    UserName = "employee@email.com",
                    Email = "employee@email.com",
                    LockoutEnabled = false
                }, "Employee@123");

                if (createEmployeeResult.Succeeded)
                {
                    var userResult = await user.FindByNameAsync("Employee");
                    await user.AddToRoleAsync(userResult, "Employee");
                }
            }
        }
    }
}
