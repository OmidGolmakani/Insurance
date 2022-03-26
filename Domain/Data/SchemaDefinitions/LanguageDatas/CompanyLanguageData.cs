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
    public class CompanyLanguageData : ProperesConfig<long, Models.Entities.CompanyLanguageData>
    {
        public override void Configure(EntityTypeBuilder<Models.Entities.CompanyLanguageData> builder)
        {
            builder.ToTable("CompanyLanguageData");
            builder.Property(p=> p.LanguageId).IsRequired();
            builder.Property(p => p.KeyId).IsRequired();
            builder.Property(p => p.Name).HasMaxLength(150);
            builder.Property(p => p.RegisterCode).HasMaxLength(10).IsRequired();
         
            builder.HasOne(p=> p.Language)
                   .WithMany(p=> p.CompanyLanguageDatas)
                   .OnDelete(DeleteBehavior.NoAction)
                   .HasForeignKey(p=> p.LanguageId);

            builder.HasOne(p => p.Company)
                  .WithMany(p => p.CompanyLanguageDatas)
                  .OnDelete(DeleteBehavior.Cascade)
                  .HasForeignKey(p => p.KeyId);

            base.Configure(builder);
        }
    }
}
