using Domain.Attributes;
using Domain.Models.Dtos.Fundamentals.Requests;
using System;
using System.ComponentModel.DataAnnotations;

namespace Domain.Models.Dtos.Requests.People
{
    public class GetPeopleRequest : GetsRequest
    {
        [Required]
        [Numeric]
        public long UserId { get; set; }
        public Models.Enums.Person.Gender Gender { get; set; }
        public string Name { get; set; }
        public string Family { get; set; }
        public DateTime? BirthDate { get; set; }
    }
}
