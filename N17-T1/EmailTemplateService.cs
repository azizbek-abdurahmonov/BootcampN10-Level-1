using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace N17_T1
{
    internal class EmailTemplateService
    {
        public List<EmailTemplates> Templates = new List<EmailTemplates>();

        public void Add(string subject, string content)
        {
            if (string.IsNullOrEmpty(subject) || string.IsNullOrEmpty(content))
                throw new Exception("Bo'sh bo'lishi mumkin emas!");

            Templates.Add(new EmailTemplates(subject, content));
        }

        public string GetRegistrationTemplate(string username, string email)
        {
            foreach (var template in Templates)
            {
                if (template.subject == "Account Registration")
                {
                    SendEmail(email, template.subject , template.content.Replace(MessageConstants.UserToken, username));
                    return "Yuborildi";
                }
            }

            return "Template not found!";
        }

        public string GetAccountBlockedTemplate(string username)
        {
            foreach(var template in Templates)
            {
                if(template.subject == "Account Blocked")
                {
                    return template.content.Replace(MessageConstants.UserToken, username);
                }
            }

            return null;
        }

        public void SendEmail(string receiverEmail, string subject, string content)
        {
            var senderEmail = "abdura52.uz@gmail.com";
            var senderPassword = "ucuhmntddpjlxhzf";

            var mail = new MailMessage(senderEmail, receiverEmail);
            mail.Subject = subject;
            mail.Body = content;

            var smtpClient = new SmtpClient("smtp.gmail.com", 587); // Replace with your SMTP server address and port
            smtpClient.Credentials = new NetworkCredential(senderEmail, senderPassword);
            smtpClient.EnableSsl = true;

            smtpClient.Send(mail);
        }
    }
}
