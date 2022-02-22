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
    public class Company : ProperesConfig<long, Models.Entities.Company>
    {
        public override void Configure(EntityTypeBuilder<Models.Entities.Company> builder)
        {
            builder.ToTable("Company");
            builder.Property(p => p.Name).IsRequired().HasMaxLength(100);
            builder.Property(p => p.CustomerScore).IsRequired();
            builder.Property(p=> p.InsuranceScore).IsRequired();
            base.Configure(builder);
        }
    }
}
