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
    public class PointParameterLanguageData : ProperesConfig<long, Models.Entities.PointParameterLanguageData>
    {
        public override void Configure(EntityTypeBuilder<Models.Entities.PointParameterLanguageData> builder)
        {
            builder.ToTable("PointParameterLanguageData");
            builder.Property(p=> p.LanguageId).IsRequired();
            builder.Property(p => p.KeyId).IsRequired();
            builder.Property(p => p.Name).HasMaxLength(100).IsRequired();

            builder.HasOne(p=> p.Language)
                   .WithMany(p=> p.PointParameterLanguageDatas)
                   .OnDelete(DeleteBehavior.NoAction)
                   .HasForeignKey(p=> p.LanguageId);

            builder.HasOne(p => p.PointParameter)
                  .WithMany(p => p.PointParameterLanguageDatas)
                  .OnDelete(DeleteBehavior.Cascade)
                  .HasForeignKey(p => p.KeyId);

            base.Configure(builder);
        }
    }
}
