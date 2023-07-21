using System.Text.RegularExpressions;

var emails = new[]
{
    "azizbek10@gmail.com", "ilhom@.com", "abdug'ani@example.com",
    "abdurahmon@mail.ru", "firdavs.doter@email.uz"
};

var pattern = @"^[a-zA-Z0-9.]+@[a-zA-Z0-9]+\.[a-zA-Z0-9]+$";
var regEx = new Regex(pattern);

foreach (var email in emails)
{
    if (regEx.IsMatch(email))
        Console.WriteLine($"{email} - valid");
    else
        Console.WriteLine(email + " - invalid");
}

