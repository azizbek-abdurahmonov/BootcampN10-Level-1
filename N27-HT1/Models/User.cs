using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N27_HT1.Models
{
    internal class User
    {
        public Guid Id { get; set; }
        public string EmailAddress { get; set; }
        public string Password { get; set; }
        public bool IsAdmin { get; set; }

        public User(string emailAddress, string password, bool isAdmin = false)
        {
            Id = Guid.NewGuid();
            EmailAddress = emailAddress;
            Password = password;
            IsAdmin = isAdmin;
        }

        public override string ToString()
        {
            return $"{EmailAddress} {Password}, IsAdmin : {IsAdmin}";
        }
    }
}
