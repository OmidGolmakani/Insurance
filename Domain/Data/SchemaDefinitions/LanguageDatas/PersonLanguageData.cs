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
    public class PersonLanguageData : ProperesConfig<long, Models.Entities.PersonLanguageData>
    {
        public override void Configure(EntityTypeBuilder<Models.Entities.PersonLanguageData> builder)
        {
            builder.ToTable("PersonLanguageData");
            builder.Property(p=> p.LanguageId).IsRequired();
            builder.Property(p => p.KeyId).IsRequired();
            builder.Property(p => p.Name).HasMaxLength(70);
            builder.Property(p => p.Family).HasMaxLength(70);

            builder.HasOne(p=> p.Language)
                   .WithMany(p=> p.PersonLanguageDatas)
                   .OnDelete(DeleteBehavior.NoAction)
                   .HasForeignKey(p=> p.LanguageId);

            builder.HasOne(p => p.Person)
                  .WithMany(p => p.PersonLanguageDatas)
                  .OnDelete(DeleteBehavior.Cascade)
                  .HasForeignKey(p => p.KeyId);

            base.Configure(builder);
        }
    }
}
