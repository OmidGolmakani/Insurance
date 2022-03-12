using Domain.Data.SchemaDefinitions.Fundamentals;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Domain.Data.SchemaDefinitions
{
    public class UserDetailLookupField : ProperesConfig<long, Models.Entities.UserDetailLookupField>
    {
        public override void Configure(EntityTypeBuilder<Models.Entities.UserDetailLookupField> builder)
        {
            builder.ToTable("UserDetailLookupField");
            builder.Property(p => p.FieldId).IsRequired();
            builder.Property(p => p.Name).HasMaxLength(150);
            builder.Property(p => p.Active).HasComputedColumnSql("1");
            builder.Property(p => p.IsDefault).HasComputedColumnSql("0");
            builder.Property(p => p.Order).IsRequired();
            builder.Property(p => p.Value).HasMaxLength(100);
            builder.HasOne(p => p.Field).
                WithMany(p => p.UserDetailLookupFields).
                HasForeignKey(p => p.FieldId).OnDelete(DeleteBehavior.NoAction);
            builder.HasIndex(p => new { p.FieldId, p.Name, p.IsDeleted }).IsUnique();

            base.Configure(builder);
        }
    }
}
