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
    public class UserDetailFieldLanguageData : ProperesConfig<long, Models.Entities.UserDetailFieldLanguageData>
    {
        public override void Configure(EntityTypeBuilder<Models.Entities.UserDetailFieldLanguageData> builder)
        {
            builder.ToTable("UserDetailFieldLanguageData");
            builder.Property(p=> p.LanguageId).IsRequired();
            builder.Property(p => p.KeyId).IsRequired();
            builder.Property(p => p.Name).HasMaxLength(100).IsRequired();
            builder.Property(p => p.DisplayName).HasMaxLength(100).IsRequired();

            builder.HasOne(p=> p.Language)
                   .WithMany(p=> p.UserDetailFieldLanguageDatas)
                   .OnDelete(DeleteBehavior.NoAction)
                   .HasForeignKey(p=> p.LanguageId);

            builder.HasOne(p => p.UserDetailField)
                  .WithMany(p => p.UserDetailFieldLanguageDatas)
                  .OnDelete(DeleteBehavior.Cascade)
                  .HasForeignKey(p => p.KeyId);

            base.Configure(builder);
        }
    }
}
