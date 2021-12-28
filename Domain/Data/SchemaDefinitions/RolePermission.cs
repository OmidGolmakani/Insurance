using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZarvanOrder.Data.SchemaDefinitions
{
    public class RolePermission :
        BaseProperesConfig<long,RolePermission>
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
