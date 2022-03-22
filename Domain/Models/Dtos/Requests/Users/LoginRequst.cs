using Domain.Models.Dtos.Fundamentals.Requests;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Domain.Models.Dtos.Requests.Users
{
    public class LoginRequst : BaseRequest
    {
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }
        [DefaultValue(false)]
        [Required]
        public bool isPersistent { get; set; }
    }
}