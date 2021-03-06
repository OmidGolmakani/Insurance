using Domain.Models.Dtos.Fundamentals.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models.Dtos.Requests.Languages
{
    public class GetLanguagesRequest : GetsRequest
    {
        public string LanguageName { get; set; }
        public byte? Direction { get; set; }
        public string AcceptLanguage { get; set; }
    }
}
