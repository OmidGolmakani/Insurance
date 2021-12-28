using Domain.Data.SchemaDefinitions.Fundamentals;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace Domain.Data.SchemaDefinitions
{
    public class RolePermission :
        ProperesConfig<long,Domain.Models.Entities.RolePermission>
    {
        public override void Configure(EntityTypeBuilder<Domain.Models.Entities.RolePermission> builder)
        {
            builder.ToTable("RolePermission");
            builder.Property(p => p.RoleId).IsRequired();
            builder.Property(p => p.Url).IsRequired().HasMaxLength(300);
            builder.HasOne(p => p.Role).WithMany(p => p.RolePermissions).
                HasForeignKey(p => p.RoleId).OnDelete(DeleteBehavior.NoAction);
            base.Configure(builder);
        }
    }
}
