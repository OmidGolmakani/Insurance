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
    public class PointParameters : ProperesConfig<int, Models.Entities.PointParameter>
    {
        public override void Configure(EntityTypeBuilder<Models.Entities.PointParameter> builder)
        {
            builder.ToTable("PointParameter");
            builder.Property(p => p.Name).IsRequired().HasMaxLength(100).IsRequired();
            builder.Property(p => p.Active).HasDefaultValueSql("1").IsRequired();
            builder.HasIndex(p => new { p.Name, p.IsDeleted }).IsUnique();
            base.Configure(builder);
        }
    }
}
