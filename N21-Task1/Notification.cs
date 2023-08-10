using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N21_Task1
{
    internal class Notification
    {
        public Developer Recipient { get; set; }
        public string Message { get; set; }
        public DateTime TimeStamp { get; set; }

        public Notification(Developer user, string message, DateTime timestamp)
        {
            Recipient = user;
            Message = message;
            TimeStamp = timestamp;
        }

        
    }
}


