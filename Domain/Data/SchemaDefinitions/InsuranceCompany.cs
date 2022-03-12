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
    public class InsuranceCompany : ProperesConfig<long, Models.Entities.InsuranceCompany>
    {
        public override void Configure(EntityTypeBuilder<Models.Entities.InsuranceCompany> builder)
        {
            builder.ToTable("InsuranceCompany");
            builder.Property(p => p.Name).IsRequired().HasMaxLength(100);
            base.Configure(builder);
        }
    }
}
