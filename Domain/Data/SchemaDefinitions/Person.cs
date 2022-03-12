using Domain.Data.SchemaDefinitions.Fundamentals;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Domain.Data.SchemaDefinitions
{
    public class Person : ProperesConfig<long, Models.Entities.Person>
    {
        public override void Configure(EntityTypeBuilder<Models.Entities.Person> builder)
        {
            builder.ToTable("Person");
            builder.Property(p=> p.UserId).IsRequired();
            builder.Property(p => p.Name).HasMaxLength(70);
            builder.Property(p => p.Family).HasMaxLength(70);
            builder.Property(p => p.BirthDate);
            builder.HasOne(p => p.User)
               .WithMany(p => p.People)
               .HasForeignKey(p => p.UserId)
               .OnDelete(DeleteBehavior.NoAction)
               .HasForeignKey(p => p.UserId);
            base.Configure(builder);
        }
    }
}
