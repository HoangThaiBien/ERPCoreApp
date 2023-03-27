using ErpCore.Database.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErpCore.Database.Configurations
{
    public class InventoryOutConfiguration : IEntityTypeConfiguration<InventoryOut>
    {
        public void Configure(EntityTypeBuilder<InventoryOut> builder)
        {
            builder.ToTable("InventoryOuts");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
        }
    }
}
