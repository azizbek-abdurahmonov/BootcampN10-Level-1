namespace N23_T1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

public class RegistrationService
{
    public List<User> users = new();

    public bool Register(string emailAddress, string password)
    {
        if (users.Any(user => user.EmailAddress.Equals(emailAddress, StringComparison.Ordinal)))
        {
            Console.WriteLine("Bu email allaqachon mavjud!");
            return false;
        }

        var random = new Random();
        var VerificationPassword = random.Next(100000, 999999).ToString();
        SendEmail(emailAddress, VerificationPassword);
        Console.WriteLine("Tasdiqlash kodini kiriting: ");
        if (Console.ReadLine() == VerificationPassword)
        {
            users.Add(new User(emailAddress, password));
            Console.WriteLine("Muvaffaqiyatli bajarildi!");
        }
        else
        {
            Console.WriteLine("Kod xato kiritildi");
            return false;
        }
        return true;
    }
    

    public bool Login(string emailAddress, string password)
    {
        var user = users.FirstOrDefault(user => user.EmailAddress == emailAddress && user.Password == password);
        if (!user.IsEmailVerified || !user.IsPhoneVerified)
        {
            Console.WriteLine("Sorry, you haven't verified your email address / phone number");
            return false;
        }

        return true;
    }
    
    public void SendEmail(string receiverEmail, string password)
    {
        var senderEmail = "abdura52.uz@gmail.com";
        var senderPassword = "ucuhmntddpjlxhzf";

        var mail = new MailMessage(senderEmail, receiverEmail);
        mail.Subject = "Sizga tasdiqlash uchun kod keldi";
        mail.Body = $"Tasdiqlash uchun kod : {password}";

        var smtpClient = new SmtpClient("smtp.gmail.com", 587); //
                                                                // Replace with your SMTP server address and port
        smtpClient.Credentials = new NetworkCredential(senderEmail, senderPassword);
        smtpClient.EnableSsl = true;

        smtpClient.Send(mail);
    }
}