using N27_HT1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N27_HT1.Services
{
    internal class UserService
    {
        private List<User> _users;

        public UserService()
        {
            _users = new List<User>
            {
                new User("abdura@gmail.com", "Qwerty1234", true),
                new User("admin@gm.com", "Qwerty1234", true),
                new User("gishtmat@gmail.com", "AaAa1010", true),
            };
        }

        public void Add(string emailAddress, string password)
        {
            if (_users.FirstOrDefault(x => x.EmailAddress == emailAddress) != null) return;

            if (Validator.IsValidEmailAddress(emailAddress) && Validator.IsValidPassword(password))
            {
                _users = _users.Prepend(new User(emailAddress, password)).ToList();
            }
        }

        public List<User> GetUsers() => _users;
    }
}
