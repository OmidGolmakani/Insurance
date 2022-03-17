using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Domain.Data.SchemaDefinitions
{
    public class User :
       IEntityTypeConfiguration<Models.Entities.User>
    {
        public void Configure(EntityTypeBuilder<Models.Entities.User> builder)
        {
            builder.ToTable("AspNetUsers")
                .HasKey(p => p.Id);
            builder.Property(p => p.LastModified);
            builder.Property(p => p.LastModifiedBy).HasMaxLength(120);
            builder.Property(p => p.CreatedDate);
            builder.Property(p => p.CreatedBy).HasMaxLength(120);
            builder.Property(p => p.DeletedDate);
            builder.Property(p => p.DeletedBy).HasMaxLength(120);
            builder.Property(p => p.LanguageId).IsRequired();

            builder.Property(p => p.Name).HasMaxLength(60);
            builder.Property(p => p.Family).HasMaxLength(60);
            builder.Property(p => p.UserName).HasMaxLength(100);
            builder.Property(p => p.NormalizedUserName).HasMaxLength(100);
            builder.Property(p => p.PasswordHash).HasMaxLength(200);
            builder.Property(p => p.Email).HasMaxLength(70);
            builder.Property(p => p.NormalizedEmail).HasMaxLength(70);
            builder.Property(p => p.PhoneNumber).HasMaxLength(12);
            builder.Property(p => p.PhoneNumberConfirmed).HasDefaultValue(false);
            builder.Property(p => p.EmailConfirmed).HasDefaultValue(false);
            builder.Property(p => p.AccessFailedCount).HasDefaultValue(0);
            builder.Property(p => p.ConcurrencyStamp).HasMaxLength(200).IsRequired();
            builder.Property(p => p.SecurityStamp).HasMaxLength(2000).IsRequired();
            builder.Property(p => p.TwoFactorEnabled);
            builder.Property(p => p.LockoutEnd);
            builder.Property(p => p.LockoutEnabled);
            builder.Property(p => p.NationalId).HasMaxLength(10);
            builder.Property(p => p.ReasonDeactivation).HasMaxLength(11);
            builder.Property(p => p.PersonType).IsRequired();
            builder.Property(p => p.Block).HasDefaultValueSql("0");

            builder.HasOne(p => p.Language)
                   .WithMany(p => p.User)
                   .OnDelete(DeleteBehavior.NoAction)
                   .HasForeignKey(p => p.LanguageId);

        }
    }
}
