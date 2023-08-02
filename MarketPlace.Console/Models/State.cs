using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketPlace.Console.Models
{
    internal class State
    {
        public int Id { get; set; }
        public string code { get; set; }
        public string shortName { get; set; }
        public string fullName { get; set; }
        public DateTime CreatedDate { get; set; }

    }
}
