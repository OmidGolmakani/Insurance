using Domain.Data.SchemaDefinitions.Fundamentals;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Data.SchemaDefinitions
{
    public class InsurancePoint : ProperesConfig<long, Models.Entities.InsurancePoint>
    {
        public override void Configure(EntityTypeBuilder<Models.Entities.InsurancePoint> builder)
        {
            builder.ToTable("InsurancePoint");
            builder.Property(p => p.PointParameterId).IsRequired();
            builder.Property(p => p.StartDate).IsRequired();
            builder.Property(p => p.EndDate).IsRequired();
            builder.Property(p => p.RangeValue).IsRequired();
            builder.HasOne(p => p.InsurancePointParameter)
                   .WithMany(p => p.InsurancePoints)
                   .OnDelete(DeleteBehavior.NoAction)
                   .HasForeignKey(p => p.PointParameterId);
            base.Configure(builder);
        }
    }
}
