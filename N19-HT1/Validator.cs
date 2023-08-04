using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace N19_HT1
{
    internal static class Validator
    {
        public static bool isValidName(in string name, out string formattedName)
        {
            formattedName = string.Empty;
            if (Regex.IsMatch(name.Trim(), "^[A-Za-z][A-Za-z0-9]*$"))
            {
                formattedName = name.Trim();
                return true;
            }
            return false;
        }

        public static bool IsValidEmailAddress(in string emailAddress, out string formattedEmailAddress)
        {
            formattedEmailAddress = string.Empty;
            if (Regex.IsMatch(emailAddress.Trim(), @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$"))
            {
                formattedEmailAddress = emailAddress.Trim();
                return true;
            }
            return false;
        }

        public static bool isValidAge(in int age)
        {
            if (age is int)
            {
                if (age >= 0 && age <= 150)
                    return true;
            }
            return false;
        }

        public static bool IsValidPhoneNumber(in string phoneNumber, out string formattedPhoneNumber)
        {
            formattedPhoneNumber = string.Empty;
            if(Regex.IsMatch(phoneNumber.Trim(), @"^\+998\d{9}$"))
            {
                formattedPhoneNumber = phoneNumber.Trim();
                return true;
            }
            return false;
        }
    }
}
