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
    public class InsuranceTitleLanguageData : ProperesConfig<long, Models.Entities.InsuranceTitleLanguageData>
    {
        public override void Configure(EntityTypeBuilder<Models.Entities.InsuranceTitleLanguageData> builder)
        {
            builder.ToTable("InsuranceTitleLanguageData");
            builder.Property(p=> p.LanguageId).IsRequired();
            builder.Property(p => p.KeyId).IsRequired();
            builder.Property(p => p.Name).HasMaxLength(150).IsRequired();
            builder.Property(p => p.Description).HasMaxLength(500);

            builder.HasOne(p=> p.Language)
                   .WithMany(p=> p.InsuranceTitleLanguageDatas)
                   .OnDelete(DeleteBehavior.NoAction)
                   .HasForeignKey(p=> p.LanguageId);

            builder.HasOne(p => p.InsuranceTitle)
                  .WithMany(p => p.InsuranceTitleLanguageDatas)
                  .OnDelete(DeleteBehavior.Cascade)
                  .HasForeignKey(p => p.KeyId);

            base.Configure(builder);
        }
    }
}
