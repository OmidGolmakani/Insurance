using Domain.Models.Entities;
using Domain.Interfaces.Fundamentals.Repository;
using Domain.Models.Dtos.Requests.Users;
using Domain.Models.Dtos.Responses.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Models.Dtos.Requests.InsuranceTitles;
using Domain.Models.Dtos.Responses.InsuranceTitles;

namespace Domain.Interfaces.Globals.Repositories
{
    public interface IInsuranceTitleRepository : IRepository<int,
                                                             InsuranceTitle,
                                                             GetInsuranceTitleRequest,
                                                             GetInsuranceTitlesRequest,
                                                             InsuranceTitleResponse>
    {

    }
}
