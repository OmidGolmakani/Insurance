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
    public class UserDetailLookupFieldLanguageData : ProperesConfig<long, Models.Entities.UserDetailLookupFieldLanguageData>
    {
        public override void Configure(EntityTypeBuilder<Models.Entities.UserDetailLookupFieldLanguageData> builder)
        {
            builder.ToTable("UserDetailLookupFieldLanguageData");
            builder.Property(p=> p.LanguageId).IsRequired();
            builder.Property(p => p.KeyId).IsRequired();
            builder.Property(p => p.Name).HasMaxLength(150).IsRequired();
            builder.Property(p => p.Value).HasMaxLength(100).IsRequired();


            builder.HasOne(p=> p.Language)
                   .WithMany(p=> p.UserDetailLookupFieldLanguageDatas)
                   .OnDelete(DeleteBehavior.NoAction)
                   .HasForeignKey(p=> p.LanguageId);

            builder.HasOne(p => p.UserDetailLookupField)
                  .WithMany(p => p.UserDetailLookupFieldLanguageDatas)
                  .OnDelete(DeleteBehavior.Cascade)
                  .HasForeignKey(p => p.KeyId);

            base.Configure(builder);
        }
    }
}
