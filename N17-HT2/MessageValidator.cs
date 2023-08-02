using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N17_HT2
{
    internal static class MessageValidator
    {
        public static bool IsValidMessage(string content)
        {
            if (string.IsNullOrEmpty(content) || string.IsNullOrWhiteSpace(content))
            {
                return false;
            }
            return true;
        }
    }
}
