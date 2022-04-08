using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;
using Domain.Models.Entities;
using System.Reflection;
using System.Linq;

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
            var configs = AppDomain.CurrentDomain.GetAssemblies()
                       .SelectMany(t => t.GetTypes())
                       .Where(t => t.IsClass && t.Namespace == "Domain.Data.SchemaDefinitions").ToList();
            foreach (var config in configs)
            {
            }
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
            modelBuilder.ApplyConfiguration(new SchemaDefinitions.CompanyLanguageData());
            modelBuilder.ApplyConfiguration(new SchemaDefinitions.InsuranceTitleLanguageData());
            modelBuilder.ApplyConfiguration(new SchemaDefinitions.PersonLanguageData());
            modelBuilder.ApplyConfiguration(new SchemaDefinitions.PointParameterLanguageData());
            modelBuilder.ApplyConfiguration(new SchemaDefinitions.UserDetailFieldLanguageData());
            modelBuilder.ApplyConfiguration(new SchemaDefinitions.UserDetailLanguageData());
            modelBuilder.ApplyConfiguration(new SchemaDefinitions.UserDetailLookupFieldLanguageData());
            #endregion SchemaDefinitions

            #region Seeding
            modelBuilder.Entity<Language>().HasData(new Seeding.Language().GetSeeding());
            modelBuilder.Entity<User>().HasData(new Seeding.User().GetSeeding());
            modelBuilder.Entity<Role>().HasData(new Seeding.Role().GetSeeding());
            modelBuilder.Entity<UserRole>().HasData(new Seeding.UserRoles().GetSeeding());

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
        public DbSet<CompanyLanguageData> CompanyLanguageDatas { get; set; }
        public DbSet<InsuranceTitleLanguageData> InsuranceTitleLanguageDatas { get; set; }
        public DbSet<PersonLanguageData> PersonLanguageDatas { get; set; }
        public DbSet<PointParameterLanguageData> PointParameterLanguageDatas { get; set; }
        public DbSet<UserDetailFieldLanguageData> UserDetailFieldLanguageDatas { get; set; }
        public DbSet<UserDetailLanguageData> UserDetailLanguageDatas { get; set; }
        public DbSet<UserDetailLookupFieldLanguageData> UserDetailLookupFieldLanguageDatas { get; set; }

        #endregion DbSets




    }
}
