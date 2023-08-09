using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N20_HT2
{
    internal class User
    {
        public string Name { get; init; }
        public string SurName { get; init; }
        public string MiddleName { get; init; }

        public string EmailAddress { get; init; }
        public string UserName { get; init; }
        public bool IsActive { get; set; }

        public User(string name, string surName, string middleName, string emailAddress, string userName)
        {
            Name = name;
            SurName = surName;
            MiddleName = middleName;
            EmailAddress = emailAddress;
            UserName = userName;
            IsActive = false;
        }
    }
}
