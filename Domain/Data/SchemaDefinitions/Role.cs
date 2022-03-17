using Domain.Data.SchemaDefinitions.Fundamentals;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Data.SchemaDefinitions
{
    public class Role : IEntityTypeConfiguration<Models.Entities.Role>
    {
        public void Configure(EntityTypeBuilder<Models.Entities.Role> builder)
        {
            builder.Property(p=> p.DisplayName).HasMaxLength(120).IsRequired();
        }
    }
}
