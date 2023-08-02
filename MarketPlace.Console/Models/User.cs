using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketPlace.Console.Models
{
    internal class User
    {
        public int Id { get; set; }
        public string userName { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string passwordHash { get; set; }
        public string passwordSalt { get; set; }
        public string email { get; set; }
        public string PhoneNumber { get; set; }

        
    }
}
