using Domain.Data.SchemaDefinitions.Fundamentals;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Domain.Data.SchemaDefinitions
{
    public class UserGroup : ProperesConfig<long, Models.Entities.UserGroup>
    {
        public override void Configure(EntityTypeBuilder<Models.Entities.UserGroup> builder)
        {
            builder.ToTable("UserGroup");
            builder.Property(p => p.Name).IsRequired().HasMaxLength(150);
            builder.Property(p => p.Description).HasMaxLength(500);
            builder.Property(p => p.UserId).IsRequired();
            builder.HasIndex(p => new { p.UserId, p.Name });
            builder.HasOne(p => p.User).
                WithMany(p => p.UserGroups).
                HasForeignKey(p => p.UserId).
                OnDelete(DeleteBehavior.NoAction);
            base.Configure(builder);
        }
    }
}
