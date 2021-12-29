using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models.Dtos.Responses.Authentications
{
    public class GoogleResponse
    {
            public string ClientId { get; set; }
            public string ClientSecret { get; set; }
            public string RedirectUrl { get; set; }
        }
    }
