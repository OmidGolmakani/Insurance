using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.Fundamentals.Request
{
    public interface IListDataLanguageRequest<TForeignKeyType, TLanguageData>
       where TForeignKeyType : struct
       where TLanguageData : class, ILanguageDataRequest<TForeignKeyType>
    {
        List<TLanguageData> LanguageDatas { get; set; }
    }
}
