using Domain.Models.Entities.Fundamentals;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Domain.Data.SchemaDefinitions.Fundamentals
{
    public class ProperesConfig<TIdentityType, TEntity> : IEntityTypeConfiguration<TEntity>
        where TIdentityType : struct
        where TEntity : AuditDeleteEntity<TIdentityType>
    {
        public virtual void Configure(EntityTypeBuilder<TEntity> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.LastModified);
            builder.Property(p => p.LastModifiedBy).HasMaxLength(120);
            builder.Property(p => p.CreatedDate);
            builder.Property(p => p.CreatedBy).HasMaxLength(120);
            builder.Property(p => p.DeletedDate);
            builder.Property(p => p.DeletedBy).HasMaxLength(120);
            builder.Property(p => p.LanguageId).IsRequired();
            builder.HasOne(p => p.Language)
                                 .WithMany()
                                 .OnDelete(DeleteBehavior.NoAction)
                                 .HasForeignKey(p => p.LanguageId);
        }
    }
}
