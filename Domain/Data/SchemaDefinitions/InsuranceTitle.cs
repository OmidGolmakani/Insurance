using Domain.Data.SchemaDefinitions.Fundamentals;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Domain.Data.SchemaDefinitions
{
    public class InsuranceTitle : ProperesConfig<int, Models.Entities.InsuranceTitle>
    {
        public override void Configure(EntityTypeBuilder<Models.Entities.InsuranceTitle> builder)
        {
            builder.ToTable("InsuranceTitle");
            builder.Property(p => p.Code);
            builder.Property(p => p.Name).HasMaxLength(150).IsRequired();
            builder.Property(p => p.level).IsRequired();
            builder.Property(p => p.Description).HasMaxLength(500);
            builder.Property(p => p.Active).IsRequired().HasDefaultValueSql("1");
            base.Configure(builder);
        }
    }
}
