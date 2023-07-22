using System.Text.RegularExpressions;

var validator = new Validator();

Console.WriteLine("Ism kiriting: ");
var name = Console.ReadLine();

Console.WriteLine("Familiya kiriting: ");
var sname = Console.ReadLine();

Console.WriteLine("Yosh kiriting: ");
var age = int.Parse(Console.ReadLine());

Console.WriteLine("Email address kiriting: ");
var email = Console.ReadLine();

Console.WriteLine("Telefon raqam kiriting [+9980000000]: ");
var number = Console.ReadLine();

Console.WriteLine($"{name} - {validator.IsValidFirstName(name)}");
Console.WriteLine($"{sname} - {validator.IsValidLastName(sname)}");
Console.WriteLine($"{age} - {validator.IsValidAge(age)}");
Console.WriteLine($"{email} - {validator.IsValidEmailAddress(email)}");
Console.WriteLine($"{number} - {validator.IsValidPhoneNumber(number)}");





public class Validator
{
    public bool IsValidAge(int age)
    {
        if (age >= 18 && age <= 90)
            return true;
        else
            return false;
    }

    public bool IsValidFirstName(string firstName)
    {
        if (firstName.Any(char.IsDigit))
        {
            return false;
        }
        else
            return true;
    }

    public bool IsValidLastName(string lastName)
    {
        if (lastName.Any(char.IsDigit))
        {
            return false;
        }
        else
            return true;
    }

    public bool IsValidEmailAddress(string email)
    {
        string pattern = @"^[a-zA-Z0-9.]+@[a-zA-Z0-9]+\.[a-zA-Z0-9]+$";
        var regEx = new Regex(pattern);

        if (regEx.IsMatch(email))
            return true;
        else
            return false;
    }

    public bool IsValidPhoneNumber(string phoneNubmer)
    {
        string pattern = @"^\+998\d{9}$";
        var regEx = new Regex(pattern);

        if (regEx.IsMatch(phoneNubmer))
            return true;
        else
            return false;
    }
}