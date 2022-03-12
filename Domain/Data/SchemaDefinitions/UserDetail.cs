using Domain.Data.SchemaDefinitions.Fundamentals;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Domain.Data.SchemaDefinitions
{
    public class UserDetail : ProperesConfig<long, Models.Entities.UserDetail>
    {
        public override void Configure(EntityTypeBuilder<Models.Entities.UserDetail> builder)
        {
            builder.ToTable("UserDetail");
            builder.Property(p => p.FieldId).IsRequired();
            builder.Property(p=> p.Value).IsRequired();
            builder.HasOne(p => p.UserDetailField)
                 .WithMany(p => p.UserDetails)
                 .HasForeignKey(p => p.FieldId)
                 .OnDelete(DeleteBehavior.NoAction);

            base.Configure(builder);
        }
    }
}
