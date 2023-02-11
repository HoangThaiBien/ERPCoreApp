using ErpCore.Database.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErpCore.Database.EF
{
    public class ErpDbContext : IdentityDbContext<User>
    {
        public ErpDbContext() { }
        public ErpDbContext(DbContextOptions<ErpDbContext> options) : base(options) { }

        public virtual DbSet<Country> Countries => Set<Country>();
        public virtual DbSet<City> Cities => Set<City>();
        public virtual DbSet<State> States => Set<State>();
        public virtual DbSet<Category> Categories => Set<Category>();
        public virtual DbSet<ProductCategory> ProductCategories => Set<ProductCategory>();
        public virtual DbSet<Product> Products => Set<Product>();
        public virtual DbSet<Employee> Employees => Set<Employee>();
        public virtual DbSet<Customer> Customers => Set<Customer>();
        public virtual DbSet<PayRoll> PayRolls => Set<PayRoll>();
    }
}
