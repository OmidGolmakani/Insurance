using Domain.Interfaces.Fundamentals.DataSeeding;
using System;
using System.Collections.Generic;

namespace Domain.Data.Seeding
{
    public class Language : ISeeding<Models.Entities.Language,int>
    {
        public Language()
        {

        }
        public List<Models.Entities.Language> GetSeeding()
        {
            var Result = new List<Models.Entities.Language>();
            Result.Add(new Models.Entities.Language()
            {
                Id = 1,
                CreatedDate = DateTime.Now,
                IsDeleted = false,
                LanguageName = "Persian",
                CreatedBy = Helpers.ConstVariables.Globals.SystemUserName,
                Direction = (byte)Models.Enums.Language.Direction.RightToLeft,
                AcceptLanguage ="fa-IR"
            });
            Result.Add(new Models.Entities.Language()
            {
                Id = 2,
                CreatedDate = DateTime.Now,
                IsDeleted = false,
                LanguageName = "English",
                CreatedBy = Helpers.ConstVariables.Globals.SystemUserName,
                Direction = (byte)Models.Enums.Language.Direction.LeftToRight,
                AcceptLanguage = "en-US"
            });
            return Result;
        }
    }
}
