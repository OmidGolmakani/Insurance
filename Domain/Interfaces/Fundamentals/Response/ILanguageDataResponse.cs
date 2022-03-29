using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.Fundamentals.Response
{
    public interface ILanguageDataResponse<TForeignKeyType>
        where TForeignKeyType : struct
    {
       public TForeignKeyType KeyId { get; set; }
       public int LanguageId { get; set; }
       public string AcceptLanguage { get; set; }
    }
}
