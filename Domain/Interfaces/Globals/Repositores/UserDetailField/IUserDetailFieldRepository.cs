using Domain.Models.Entities;
using Domain.Interfaces.Fundamentals.Repository;
using Domain.Models.Dtos.Requests.Users;
using Domain.Models.Dtos.Responses.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Models.Dtos.Requests.UserDetailFields;
using Domain.Models.Dtos.Responses.UserDetailFields;

namespace Domain.Interfaces.Globals.Repositories
{
    public interface IUserDetailFieldRepository : IRepository<long,
                                                              UserDetailField,
                                                              GetUserDetailFieldRequest,
                                                              GetUserDetailFieldsRequest,
                                                              UserDetailFieldResponse>
    {

    }
}
