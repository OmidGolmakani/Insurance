using Domain.Interfaces.Fundamentals.DataSeeding;
using System;
using System.Collections.Generic;

namespace Domain.Data.Seeding
{
    public class UserDetailField : ISeeding<Models.Entities.UserDetailField, long>
    {
        public List<Models.Entities.UserDetailField> GetSeeding()
        {
            var Result = new List<Models.Entities.UserDetailField>();
            Result.Add(new Models.Entities.UserDetailField()
            {
                Id = 1,
                Active = true,
                CreatedBy = Helpers.ConstVariables.Globals.SystemUserName,
                CreatedDate = DateTime.Now,
                DisplayName = "تلفن ثابت",
                IsDefault = true,
                IsDeleted = false,
                Name = "Tel",
                Order = 1,
                TypeId = (byte)Models.Enums.UserDetailField.DataType.Number
            });
            return Result;
        }
    }
}
