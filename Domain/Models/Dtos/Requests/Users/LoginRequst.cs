<<<<<<< HEAD
﻿using Domain.Models.Dtos.Fundamentals.Request;
using System.ComponentModel;

namespace Domain.Models.Dtos.Requests.Users
{
    public class LoginRequst : BaseRequest
=======
﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZarvanOrder.Model.Dtos.Requests.Users
{
    public class LoginRequst : Bases.BaseRequest
>>>>>>> d44051f3664bbfd70054e5d55cc220612852a298
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        [DefaultValue(false)]
        public bool isPersistent { get; set; }
    }
}
