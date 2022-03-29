using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.Fundamentals.Response
{
    public interface ILisDataLanguageResponse<TForeignKeyType, TLanguageData>
        where TForeignKeyType : struct
        where TLanguageData : class, ILanguageDataResponse<TForeignKeyType>
    {
        public List<TLanguageData> LanguageDatas { get; set; }
    }
}
