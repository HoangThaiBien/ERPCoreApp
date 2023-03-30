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
    public class ImageConfiguration : IEntityTypeConfiguration<ImageProduct>
    {
        public void Configure(EntityTypeBuilder<ImageProduct> builder)
        {
            builder.ToTable("ImageProducts");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id).UseIdentityColumn();

            builder.Property(x => x.ImagePath).HasMaxLength(200);
            builder.Property(x => x.Caption).HasMaxLength(200);
            builder.HasOne(x => x.Product).WithMany(x => x.ImageProducts).HasForeignKey(x => x.ProductId);
        }
    }
}
