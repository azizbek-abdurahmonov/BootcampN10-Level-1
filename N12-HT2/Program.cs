using System.Text.RegularExpressions;

Console.WriteLine("Check with valid values");
try
{
    var email1 = new Email();
    email1.To = "durov@t.me";
    email1.From = "azizbek@mail.ru";
    email1.Subject = "Telegram istoriya haqida";
    email1.Content = "Telegramga umuman story funksiyasi kerak emas edi.";
    Console.WriteLine(email1);
}
catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}

Console.WriteLine("\nCheck with invalid values");
//Har bir xatoni ko'rsatish uchun hammasini alohida try catch blocklarida yozib chiqdim!
var email2 = new Email();
try
{
    email2.To = "durov@.me";
}
catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}

try
{
    email2.From = "azizbekmail.ru";
}
catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}

try
{
    email2.Subject = "  "; //white spaces
}
catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}

try
{
    email2.Content = "hi";
}
catch(Exception e)
{
    Console.WriteLine(e.Message);
}

public class Email
{
    private string _to;
    private string _from;
    private string _subject;
    private string _content;

    public string To
    {
        get
        {
            return _to;
        }
        set
        {
            string pattern = @"^[a-zA-Z0-9.]+@[a-zA-Z0-9]+\.[a-zA-Z0-9]+$";
            var regEx = new Regex(pattern);
            if (regEx.IsMatch(value))
                _to = value;
            else
                throw new FormatException("To email xato!");
        }
    }

    public string From
    {
        get
        {
            return _from;
        }
        set
        {
            string pattern = @"^[a-zA-Z0-9.]+@[a-zA-Z0-9]+\.[a-zA-Z0-9]+$";
            var regEx = new Regex(pattern);
            if (regEx.IsMatch(value))
                _from = value;
            else
                throw new FormatException("From email xato!");
        }
    }

    public string Subject
    {
        get
        {
            return _subject;
        }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new FormatException("Subject bo'sh bo'lishi mumkin emas!");

            if(value.Length < 5)
                throw new FormatException("Subject kamida 5 harfdan iborat bo'lishi kerak!");
        
            _subject = value;
        }
    }

    public string Content
    {
        get
        {
            return _content;
        }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new FormatException("Content bo'sh bo'lishi mumkin emas!");

            if (value.Length < 5)
                throw new FormatException("Content kamida 5 harfdan iborat bo'lishi kerak!");

            _content = value;
        }
    }

    public override string ToString()
    {
        return $"To: {_to}\nFrom: {_from}\nSubject: {_subject}\nContent: {_content}";
    }
}