using ErpCore.Database.Configurations;
using ErpCore.Database.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace ErpCore.Database.EF
{
    public class ErpDbContext : IdentityDbContext<User>
    {
        public ErpDbContext() { }
        public ErpDbContext(DbContextOptions<ErpDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfiguration(new CartConfiguration());
            builder.ApplyConfiguration(new CategoryConfiguration());
            builder.ApplyConfiguration(new CityConfiguration());
            builder.ApplyConfiguration(new CountryConfiguration());
            builder.ApplyConfiguration(new CustomerConfiguration());
            builder.ApplyConfiguration(new EmployeeConfiguration());
            builder.ApplyConfiguration(new LocationConfiguration());
            builder.ApplyConfiguration(new OrderConfiguration());
            builder.ApplyConfiguration(new OrderDetailConfiguration());
            builder.ApplyConfiguration(new PayRollConfiguration());
            builder.ApplyConfiguration(new ProductCategoryConfiguration());
            builder.ApplyConfiguration(new ProductConfiguration());
            builder.ApplyConfiguration(new PromotionConfiguration());
            builder.ApplyConfiguration(new StateConfiguration());
            builder.ApplyConfiguration(new TransactionConfiguration());
            builder.ApplyConfiguration(new UserConfiguration());
        }
        public virtual DbSet<Country> Countries => Set<Country>();
        public virtual DbSet<City> Cities => Set<City>();
        public virtual DbSet<State> States => Set<State>();
        public virtual DbSet<Location> Locations => Set<Location>();
        public virtual DbSet<Category> Categories => Set<Category>();
        public virtual DbSet<ProductCategory> ProductCategories => Set<ProductCategory>();
        public virtual DbSet<Product> Products => Set<Product>();
        public virtual DbSet<Employee> Employees => Set<Employee>();
        public virtual DbSet<Customer> Customers => Set<Customer>();
        public virtual DbSet<PayRoll> PayRolls => Set<PayRoll>();
        public virtual DbSet<Cart> Carts => Set<Cart>();
        public virtual DbSet<Order> Orders => Set<Order>();
        public virtual DbSet<OrderDetail> OrderDetails => Set<OrderDetail>();
        public virtual DbSet<Transaction> Transactions => Set<Transaction>();
        public virtual DbSet<Promotion> Promotions => Set<Promotion>();
    }
}
