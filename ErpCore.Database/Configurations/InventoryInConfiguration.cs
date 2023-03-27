using ErpCore.Database.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErpCore.Database.Configurations
{
    public class InventoryInConfiguration : IEntityTypeConfiguration<InventoryIn>
    {
        public void Configure(EntityTypeBuilder<InventoryIn> builder)
        {
            builder.ToTable("InventoryIns");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
        }
    }
}
