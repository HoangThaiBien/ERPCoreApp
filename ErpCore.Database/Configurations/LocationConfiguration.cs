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
    public class LocationConfiguration  : IEntityTypeConfiguration<Location>
    {
        public void Configure(EntityTypeBuilder<Location> builder)
        {
            builder.ToTable("Locations");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.HasOne(l => l.Province)
                  .WithMany(c => c.Locations)
                  .HasForeignKey(l => l.ProvinceId).OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(l => l.District)
                   .WithMany(s => s.Locations)
                   .HasForeignKey(l => l.DistrictId).OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(l => l.Ward)
                   .WithMany(c => c.Locations)
                   .HasForeignKey(l => l.WardId).OnDelete(DeleteBehavior.Restrict);

        }
    }
}
