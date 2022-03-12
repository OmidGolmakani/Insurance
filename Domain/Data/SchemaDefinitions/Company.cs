using Domain.Data.SchemaDefinitions.Fundamentals;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Domain.Data.SchemaDefinitions
{
    public class Company : ProperesConfig<long, Models.Entities.Company>
    {
        public override void Configure(EntityTypeBuilder<Models.Entities.Company> builder)
        {
            builder.ToTable("Company");
            builder.Property(p => p.Name).HasMaxLength(150);
            builder.Property(p => p.UserId).IsRequired();
            builder.Property(p => p.RegisterCode).HasMaxLength(10).IsRequired();
            builder.Property(p => p.RegisterDate).IsRequired();
            builder.HasOne(p => p.User)
                 .WithMany(p => p.Companies)
                 .HasForeignKey(p => p.UserId)
                 .OnDelete(DeleteBehavior.NoAction)
                 .HasForeignKey(p => p.UserId);
            base.Configure(builder);
        }
    }
}
