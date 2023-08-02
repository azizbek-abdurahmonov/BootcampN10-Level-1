using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N17_HT2
{
    internal class ChatMessage
    {
        public Guid Id;
        public DateTime SentTime;
        public DateTime EditedTime;
        public string Content;

        public ChatMessage(string content)
        {
            Id = Guid.NewGuid();
            SentTime = DateTime.Now;
            Content = content;
        }

        public ChatMessage(ChatMessage chatMessage)
        {
            this.Id = chatMessage.Id;
            this.SentTime = chatMessage.SentTime;
            this.EditedTime = DateTime.Now;
        }
    }
}
