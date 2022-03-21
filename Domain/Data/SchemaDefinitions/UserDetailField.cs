using Domain.Data.SchemaDefinitions.Fundamentals;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Domain.Data.SchemaDefinitions
{
    public class UserDetailField : ProperesConfig<long, Models.Entities.UserDetailField>
    {
        public override void Configure(EntityTypeBuilder<Models.Entities.UserDetailField> builder)
        {
            builder.ToTable("UserDetailField");
            builder.Property(p => p.UserId);
            builder.Property(p => p.Name).IsRequired().HasMaxLength(100);
            builder.Property(p => p.Order).IsRequired();
            builder.Property(p => p.TypeId).IsRequired();
            builder.Property(p => p.DisplayName).HasMaxLength(100).IsRequired();
            builder.Property(p => p.Active).IsRequired().HasDefaultValue(true);
            builder.Property(p => p.IsDefault).HasDefaultValue(false);
            builder.HasIndex(p => new { p.UserId, p.Order, p.IsDeleted }).IsUnique();
            base.Configure(builder);
        }
    }
}
