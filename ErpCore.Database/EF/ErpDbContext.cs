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
            builder.ApplyConfiguration(new WardConfiguration());
            builder.ApplyConfiguration(new DistrictConfiguration());
            builder.ApplyConfiguration(new ProvinceConfiguration());
            builder.ApplyConfiguration(new CustomerConfiguration());
            builder.ApplyConfiguration(new EmployeeConfiguration());
            builder.ApplyConfiguration(new LocationConfiguration());
            builder.ApplyConfiguration(new OrderConfiguration());
            builder.ApplyConfiguration(new OrderDetailConfiguration());
            builder.ApplyConfiguration(new PayRollConfiguration());
            builder.ApplyConfiguration(new ProductCategoryConfiguration());
            builder.ApplyConfiguration(new ProductConfiguration());
            builder.ApplyConfiguration(new PromotionConfiguration());
            builder.ApplyConfiguration(new TransactionConfiguration());
            builder.ApplyConfiguration(new UserConfiguration());
            builder.ApplyConfiguration(new SupplierConfiguration());
            builder.ApplyConfiguration(new TagConfiguration());
            builder.ApplyConfiguration(new InventoryInConfiguration());
            builder.ApplyConfiguration(new InventoryOutConfiguration());
            builder.ApplyConfiguration(new WareHouseConfiguration());
            builder.ApplyConfiguration(new UserRefreshTokenConfiguration());
        }
        public virtual DbSet<Ward> Wards => Set<Ward>();
        public virtual DbSet<District> Districts => Set<District>();
        public virtual DbSet<Province> Provinces => Set<Province>();
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
        public virtual DbSet<Supplier> Suppliers => Set<Supplier>();
        public virtual DbSet<Tag> Tags => Set<Tag>();
        public virtual DbSet<InventoryIn> InventoryIns=> Set<InventoryIn>();
        public virtual DbSet<InventoryOut> InventoryOuts => Set<InventoryOut>();
        public virtual DbSet<WareHouse> WareHouses => Set<WareHouse>();
        public virtual DbSet<UserRefreshToken> UserRefreshTokens => Set<UserRefreshToken>(); 
    }
}
