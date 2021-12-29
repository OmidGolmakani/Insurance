using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

<<<<<<< HEAD
namespace Domain.Models.Dtos.Requests.Users
{
    public class GetUsersRequest : Models.Dtos.Fundamentals.Request.PageRequest
=======
namespace ZarvanOrder.Model.Dtos.Requests.Users
{
    public class GetUsersRequest : Pages.PageRequest
>>>>>>> d44051f3664bbfd70054e5d55cc220612852a298
    {
        public string UserName { get; set; }
        public string Name { get; set; }
        public string Family { get; set; }
        public string PhoneNUmber { get; set; }
        public string Email { get; set; }
    }
}
