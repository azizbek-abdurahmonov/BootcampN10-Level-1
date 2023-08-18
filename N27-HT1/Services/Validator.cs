using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace N27_HT1.Services
{
    internal static class Validator
    {
        public static bool IsValidEmailAddress(string emailAddress)
        {
            return Regex.IsMatch(emailAddress, @"^[a-zA-Z0-9.]+@[a-zA-Z0-9]+\.[a-zA-Z0-9]+$");
        }

        public static bool IsValidPassword(string password)
        {
            return Regex.IsMatch(password, "^.{8,}$");
        }
    }
}
