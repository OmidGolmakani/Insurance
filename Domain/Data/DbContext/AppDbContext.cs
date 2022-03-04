using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;
using Domain.Models.Entities;

namespace Domain.Data.DbContext
{
    public class AppDbContext : IdentityDbContext<AspNetUsers,
                                                  Role,
                                                  long,
                                                  UserClaim,
                                                  UserRole,
                                                  UserLogin,
                                                  RoleClaim,
                                                  UserToken>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {


        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new SchemaDefinitions.User());
            modelBuilder.ApplyConfiguration(new SchemaDefinitions.RolePermission());
            modelBuilder.ApplyConfiguration(new SchemaDefinitions.InsuranceCompany());
            modelBuilder.ApplyConfiguration(new SchemaDefinitions.PointParameters());
            modelBuilder.ApplyConfiguration(new SchemaDefinitions.InsurancePointParameter());
            modelBuilder.ApplyConfiguration(new SchemaDefinitions.InsurancePoint());

            base.OnModelCreating(modelBuilder);

        }
        public DbSet<RolePermission> RolePermissions { get; set; }
        public DbSet<InsuranceCompany> InsuranceCompanies { get; set; }
        public DbSet<PointParameter> PointParameters { get; set; }
        public DbSet<InsurancePoint> InsurancePoints { get; set; }
        public DbSet<InsurancePointParameter> InsurancePointParameters { get; set; }




    }
}
