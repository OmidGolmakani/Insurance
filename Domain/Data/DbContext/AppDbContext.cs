using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;
using Domain.Models.Entities;

namespace Domain.Data.DbContext
{
    public class AppDbContext : IdentityDbContext<User,
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
            #region SchemaDefinitions
            modelBuilder.ApplyConfiguration(new SchemaDefinitions.User());
            modelBuilder.ApplyConfiguration(new SchemaDefinitions.RolePermission());
            modelBuilder.ApplyConfiguration(new SchemaDefinitions.InsuranceCompany());
            modelBuilder.ApplyConfiguration(new SchemaDefinitions.PointParameters());
            modelBuilder.ApplyConfiguration(new SchemaDefinitions.InsurancePointParameter());
            modelBuilder.ApplyConfiguration(new SchemaDefinitions.InsurancePoint());
            modelBuilder.ApplyConfiguration(new SchemaDefinitions.InsuranceTitle());
            modelBuilder.ApplyConfiguration(new SchemaDefinitions.Language());
            modelBuilder.ApplyConfiguration(new SchemaDefinitions.UserDetail());
            modelBuilder.ApplyConfiguration(new SchemaDefinitions.UserDetailField());
            modelBuilder.ApplyConfiguration(new SchemaDefinitions.UserDetailLookupField());
            modelBuilder.ApplyConfiguration(new SchemaDefinitions.Person());
            modelBuilder.ApplyConfiguration(new SchemaDefinitions.Company());
            modelBuilder.ApplyConfiguration(new SchemaDefinitions.UserGroup());


            #endregion SchemaDefinitions

            #region Seeding
            modelBuilder.Entity<Language>().HasData(new Seeding.Language().GetSeeding());
            modelBuilder.Entity<User>().HasData(new Seeding.User().GetSeeding());

            #endregion Seeding

            base.OnModelCreating(modelBuilder);

        }
        #region DbSets
        public DbSet<RolePermission> RolePermissions { get; set; }
        public DbSet<InsuranceCompany> InsuranceCompanies { get; set; }
        public DbSet<PointParameter> PointParameters { get; set; }
        public DbSet<InsurancePoint> InsurancePoints { get; set; }
        public DbSet<InsurancePointParameter> InsurancePointParameters { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<UserDetail> UserDetails { get; set; }
        public DbSet<UserDetailField> UserDetailFields { get; set; }
        public DbSet<UserDetailLookupField> UserDetailLookups { get; set; }
        public DbSet<Person> People { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<UserGroup> UserGroups { get; set; }


        #endregion DbSets




    }
}
