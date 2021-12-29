<<<<<<< HEAD
﻿using Domain.Models.Dtos.Fundamentals.Request;

namespace Domain.Models.Dtos.Requests.Users
{
    public class DeleteUserRequest : DeleteRequest<long>
=======
﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZarvanOrder.Model.Dtos.Requests.Users
{
    public class DeleteUserRequest : Bases.DeleteRequest<long>
>>>>>>> d44051f3664bbfd70054e5d55cc220612852a298
    {
        public string ReasonDeactivation { get; set; }
    }
}
