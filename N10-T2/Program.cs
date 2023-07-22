Console.WriteLine("Sonlar qatnashsinmi ? true/false");
var digits = bool.Parse(Console.ReadLine());

Console.WriteLine("Harflar qatnashsinmi ? true/false");
var letters = bool.Parse(Console.ReadLine());

Console.WriteLine("Boshqa symbollar qatnashsinmi ? true/false");
var symbols = bool.Parse(Console.ReadLine());

Console.WriteLine("Password uzunligini kiriting: ");
var length = int.Parse(Console.ReadLine());

var passwordGenerator = new PasswordGenerator();
Console.WriteLine($"Password: {passwordGenerator.Generate(digits, letters, symbols, length)}");

public class PasswordGenerator
{
    public string Generate(bool hasDigits, bool hasLetters, bool hasSymbols, int length)
    {
        string digits = "1234567890";
        string letters = "abcdefghijklmnopqrstuvwxyz";
        string symbols = "~!@#$%^&*";
        string characters = string.Empty;

        if (hasDigits)
            characters += digits;
        if (hasLetters)
            characters += letters;
        if (hasSymbols)
            characters += symbols;

        if (characters.Length == 0)
            return "Hech narsa tanlanmadi!";

        var rd = new Random();
        var password = string.Empty;
        for (var i = 0; i < length; i++)
        {
            var idx = rd.Next(0, characters.Length - 1);
            password += characters[idx];
        }
        return password;
    }
}