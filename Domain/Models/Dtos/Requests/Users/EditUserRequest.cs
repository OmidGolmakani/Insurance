using Domain.Models.Dtos.Fundamentals.Requests;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models.Dtos.Requests.Users
{
    public class EditUserRequest : EditRequest<long>
    {
        public long? ParentId { get; set; }
        [Required]
        public string UserName { get; set; }
        public string Tel { get; set; }
        public string Address { get; set; }
        [Required]
        public string NationalCode { get; set; }
        [DefaultValue(false)]
        public bool ImageEdited { get; set; }
        public IFormFile Image { get; set; }
    }
}
