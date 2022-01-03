using Domain.Models.Dtos.Fundamentals.Requests;
using System.ComponentModel;

namespace Domain.Models.Dtos.Requests.Users
{
    public class LoginRequst : BaseRequest
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        [DefaultValue(false)]
        public bool isPersistent { get; set; }
    }
}