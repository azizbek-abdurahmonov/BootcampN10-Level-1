using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace N20_HT2
{
    internal class RegistrationService : IRegistrationSevice
    {
        private List<User> Users = new List<User>();


        bool CheckName(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
                return false;

            foreach (var letter in name)
                if (char.IsDigit(letter) || char.IsSymbol(letter) || letter == ' ')
                    return false;

            var formattedName = string.Concat(name.Substring(0, 1).ToUpper(), name.Substring(1).ToLower());
            if (name != formattedName)
                return false;

            return true;
        }

        private bool CheckEmailAddress(string email)
        {
            var pattern = @"^[a-zA-Z0-9.]+@[a-zA-Z0-9]+\.[a-zA-Z0-9]+$";
            if (Regex.IsMatch(email, pattern))
                return true;

            return false;
        }

        private string GenerateUserName(string firstName, string lastName)
        {
            // ism va familiyasini lowercase qilib username yasash
            var username = string.Empty;
            foreach (var letter in firstName + lastName)
                if (letter != ' ')
                    username += letter.ToString().ToLower();

            var random = new Random();

            //username unique ligini tekshirish agar unique bo'lmasa raqam yoki belgi qo'shib qaytadan tekshiradi
            while (true)
            {
                if (IsUniqueUserName(username))
                {
                    return username;
                }
                else
                {
                    username += random.Next(0, 2) == 0 ?
                        random.Next(1, 100).ToString() : // usernamega  raqam qo'shish
                        Convert.ToChar(random.Next(33, 48)); // belgi qo'shish
                }
            }
        }

        private bool Add(string name, string surname, string patronymic, string emailAddress, string username)
        {
            if (!CheckName(name))
            {
                Console.WriteLine($"Invalid name");
                return false;
            }

            if (!CheckName(surname))
            {
                Console.WriteLine($"Invalid surname");
                return false;
            }

            if (!CheckName(patronymic))
            {
                Console.WriteLine($"Invalid patronymic");
                return false;
            }

            if (!CheckEmailAddress(emailAddress))
            {
                Console.WriteLine($"Invalid email address");
                return false;
            }

            if ((!IsValidUserName(username)) || (!IsUniqueUserName(username)))
            {
                username = GenerateUserName(name, surname);
            }

            Users.Add(new User(name, surname, patronymic, emailAddress, username));
            return true;

        }

        public void Register(string name, string surname, string patronymic, string emailAddress, string username)
        {
            var res = Add(name, surname, patronymic, emailAddress, username);

            if (res)
            {
                Console.WriteLine("Kuting....\n");
                res = SendEmail(emailAddress, $"{name} {surname}");
                if (res)
                    Mark(username);
                else
                    Console.WriteLine("Email yuborish vaqtida nimadir xato ketdi!\n");
            }
        }

        private bool SendEmail(string receiverEmail, string fullName)
        {
            try
            {
                var senderEmail = "abdura52.uz@gmail.com";
                var senderPassword = "ucuhmntddpjlxhzf";

                var mail = new MailMessage(senderEmail, receiverEmail);
                mail.Subject = "Siz muvaffaqiyatli registratsiyadan o'tdingiz";
                mail.Body = "Hurmatli {{User}}, siz sistemadan muvaffaqiyatli o'tdingiz"
                    .Replace("{{User}}", fullName);

                var smtpClient = new SmtpClient("smtp.gmail.com", 587);
                smtpClient.Credentials = new NetworkCredential(senderEmail, senderPassword);
                smtpClient.EnableSsl = true;

                smtpClient.Send(mail);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public void Display()
        {
            foreach (var user in Users)
            {
                Console.WriteLine($"Ism: {user.Name}\nFamiliya: {user.SurName}\nSharif: {user.MiddleName}\nEmail: {user.EmailAddress}\nUsername: {user.UserName}\n");
            }
        }


        public bool IsUniqueUserName(string username)
        {
            foreach (var user in Users)
            {
                if (user.UserName == username) return false;
            }
            return true;
        }

        private bool IsValidUserName(string username)
        {
            if (string.IsNullOrWhiteSpace(username))
                return false;


            var pattern = @"^[A-Za-z][A-Za-z0-9-_]{5,14}$";
            if (Regex.IsMatch(username, pattern))
                return true;
            return false;
        }

        private void Mark(string username)
        {
            foreach (var user in Users)
                if (user.UserName == username)
                {
                    user.IsActive = true;
                    break;
                }
        }

    }
}
