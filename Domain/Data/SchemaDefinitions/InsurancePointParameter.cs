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
    public class InsurancePointParameter : ProperesConfig<long, Models.Entities.InsurancePointParameter>
    {
        public override void Configure(EntityTypeBuilder<Models.Entities.InsurancePointParameter> builder)
        {
            builder.ToTable("InsurancePointParameter");
            builder.Property(p => p.InsuranceId).IsRequired();
            builder.Property(p => p.PointParameterId).IsRequired();
            builder.HasOne(p => p.InsuranceCompany).
                    WithMany(p => p.InsurancePoints).
                    HasForeignKey(p => p.InsuranceId).
                    OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(p => p.PointParameter).
                    WithMany(p => p.InsurancePointParameters).
                    HasForeignKey(p => p.PointParameterId).
                    OnDelete(DeleteBehavior.NoAction);
            builder.HasIndex(p => new { p.InsuranceId, p.PointParameterId, p.IsDeleted }).IsUnique();
            base.Configure(builder);
        }
    }
}
