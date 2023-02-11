using ErpCore.Database.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErpCore.Database.Configurations
{
    public class PayRollConfiguration : IEntityTypeConfiguration<PayRoll>
    {
        public void Configure(EntityTypeBuilder<PayRoll> builder)
        {
            builder.ToTable("PayRolls");
            builder.HasKey(o => o.Id);
            builder.Property(o => o.Id).UseIdentityColumn();
            builder.Property(o => o.PaymentDate)
                    .HasDefaultValueSql("getutcdate()");
            builder.Property(o => o.SalaryMonth)
                    .HasDefaultValueSql("Month(getutcdate())");
        }
    }
}
