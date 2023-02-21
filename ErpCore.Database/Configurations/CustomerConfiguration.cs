using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ErpCore.Database.Entities;

namespace ErpCore.Database.Configurations
{
    public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.ToTable("Customers");
            builder.HasKey(o => o.Id);
            builder.Property(o => o.Id).UseIdentityColumn();
            builder.HasOne(x => x.Account).WithOne(y => y.Customer).HasForeignKey<Account>(z => z.CustomerId);
        }
    }
}
