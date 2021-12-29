<<<<<<< HEAD
﻿using Domain.Models.Dtos.Fundamentals.Request;

namespace Domain.Models.Dtos.Requests.Users
{
    public class AddUserRequest : AddRequest
=======
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZarvanOrder.Model.Dtos.Requests.Users
{
    public class AddUserRequest : Bases.AddRequest
>>>>>>> d44051f3664bbfd70054e5d55cc220612852a298
    {
        public string Name { get; set; }
        public string Family { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
    }
}
