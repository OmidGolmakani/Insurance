<<<<<<< HEAD
﻿using System.Collections.Generic;

namespace Domain.Models.Dtos.Requests.Users
{
    public class AddUserToRoleRequest : Models.Dtos.Fundamentals.Request.DeleteRequest<long>
    {
=======
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZarvanOrder.Model.Dtos.Requests.Users
{
    public class AddUserToRoleRequest
    {
        public long Id { get; set; }
>>>>>>> d44051f3664bbfd70054e5d55cc220612852a298
        public List<string> Roles { get; set; }
    }
}
