using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N17_HT2
{
    internal class Chat
    {
        public List<ChatMessage> Messages = new List<ChatMessage>();


        public Guid Add(string content)
        {
            if (MessageValidator.IsValidMessage(content))
            {
                var message = new ChatMessage(content);
                Messages.Add(message);
                return message.Id;
            }
            else
                throw new Exception("Invalid message");

        }

        public void Update(Guid Id, string content)
        {
            foreach (var message in Messages)
            {
                if (message.Id == Id)
                {
                    if (MessageValidator.IsValidMessage(content))
                    {
                        var copy = new ChatMessage(message);
                        Messages.Remove(message);
                        copy.Content = content;
                        Messages.Add(copy);
                        return;
                    }
                    else
                        throw new Exception("Invalid Message");

                }
            }
            throw new Exception("Message not found!");
        }

        public void Display()
        {
            foreach (var message in Messages)
            {
                Console.WriteLine($"{message.Content} - {message.SentTime}");
            }
        }
    }
}
