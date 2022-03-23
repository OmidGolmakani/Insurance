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
    public class Language : ProperesConfig<int, Models.Entities.Language>
    {
        public override void Configure(EntityTypeBuilder<Models.Entities.Language> builder)
        {
            builder.ToTable("Language");
            builder.Property(p => p.LanguageName).IsRequired().HasMaxLength(150);
            builder.Property(p => p.Direction).IsRequired();
            builder.Property(p => p.AcceptLanguage).HasMaxLength(20).IsRequired();
            builder.Property(p => p.Active).IsRequired().HasDefaultValueSql("1");

            base.Configure(builder);

        }
    }
}
