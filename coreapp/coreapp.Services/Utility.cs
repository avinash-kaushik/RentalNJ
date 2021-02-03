using System;
using System.Collections.Generic;
using System.Text;
using coreapp.Models;
using System.Linq;

namespace coreapp.Services
{
    public static class Utility
    {
        public static object GetPropertyValue(this object obj, string propertyName)
        {
            return obj.GetType().GetProperty(propertyName).GetValue(obj);
        }

        private static IEnumerable<UserType> PopulateUserType()
        {
            ////List<UserType> days = Enum.GetValues(typeof(Days))
            ////                .Cast<Days>()
            ////                .ToList();
            //List<UserType> userTypes = new List<UserType>();
            //userTypes.Add()
            List<UserType> usertypes = Enum.GetValues(typeof(UserType))
                            .Cast<UserType>()
                            .ToList();
            return usertypes;
        }

        public enum UserType
        {
            Admin = 1,
            superAdmin = 2,
            Wednesday = 3,
            Thursday = 4,
            Friday = 5,
            Saturday = 6,
            Sunday = 7
        }

    }
}
