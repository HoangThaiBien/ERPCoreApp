using ErpCore.Database.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ErpCore.Database.Enums;

namespace ErpCore.Database.Configurations
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.ToTable("Categories");
            builder.HasKey(o => o.Id);
            builder.Property(o => o.Id).UseIdentityColumn();
            builder.Property(o => o.Status).HasDefaultValue(Status.Active);
        }
    }
}
