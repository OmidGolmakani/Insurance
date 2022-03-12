using Domain.Interfaces.Fundamentals.Entity;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Domain.Models.Entities
{
    public class User : IdentityUser<long>, IAuditEntity<long>, IDeleteEntity
    {
        public User()
        {
        }
        public string Name { get; set; }
        public string Family { get; set; }
        public override string UserName { get => base.UserName; set => base.UserName = value; }
        public override string NormalizedUserName { get => base.NormalizedUserName; set => base.NormalizedUserName = value; }
        public override string PasswordHash { get => base.PasswordHash; set => base.PasswordHash = value; }
        public override string PhoneNumber { get => base.PhoneNumber; set => base.PhoneNumber = value; }
        public override string Email { get => base.Email; set => base.Email = value; }
        public override string NormalizedEmail { get => base.NormalizedEmail; set => base.NormalizedEmail = value; }
        public override string SecurityStamp { get => base.SecurityStamp; set => base.SecurityStamp = value; }
        public override string ConcurrencyStamp { get => base.ConcurrencyStamp; set => base.ConcurrencyStamp = value; }
        public bool? HasImage { get; set; }
        public string ReasonDeactivation { get; set; }
        public byte PersonType { get; set; }
        public string NationalId { get; set; }
        public bool Block { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? LastModified { get; set; }
        public string LastModifiedBy { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? DeletedDate { get; set; }
        public string DeletedBy { get; set; }
        public int LanguageId { get; set; }
        public Language Language { get; set; }
        public ICollection<Company> Companies { get; set; }
        public ICollection<Person> People { get; set; }
        public ICollection<UserDetail> UserDetails { get; set; }
        public ICollection<UserGroup> UserGroups { get; set; }



    }
}
