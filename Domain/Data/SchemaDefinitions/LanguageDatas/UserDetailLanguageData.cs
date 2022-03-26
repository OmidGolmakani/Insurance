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
    public class UserDetailLanguageData : ProperesConfig<long, Models.Entities.UserDetailLanguageData>
    {
        public override void Configure(EntityTypeBuilder<Models.Entities.UserDetailLanguageData> builder)
        {
            builder.ToTable("UserDetailLanguageData");
            builder.Property(p=> p.LanguageId).IsRequired();
            builder.Property(p => p.KeyId).IsRequired();
            builder.Property(p => p.Value).IsRequired();

            builder.HasOne(p=> p.Language)
                   .WithMany(p=> p.UserDetailLanguageDatas)
                   .OnDelete(DeleteBehavior.NoAction)
                   .HasForeignKey(p=> p.LanguageId);

            builder.HasOne(p => p.UserDetail)
                  .WithMany(p => p.UserDetailLanguageDatas)
                  .OnDelete(DeleteBehavior.Cascade)
                  .HasForeignKey(p => p.KeyId);

            base.Configure(builder);
        }
    }
}
