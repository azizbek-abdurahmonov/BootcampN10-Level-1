var numbers = "1234567890";
var letters = "abcdefghijklmnopqrstuvwxyz";
var symbols = "!@#$%^&*";

Console.Write("Sonlar qatnashsinmi? (y/n)");
var numbersB = Convert.ToChar(Console.ReadLine());

Console.Write("Harflar qatnashsinmi? (y/n)");
var lettersB = Convert.ToChar(Console.ReadLine());

Console.Write("Simvollar qatnashsinmi? (y/n)");
var symbolsB = Convert.ToChar(Console.ReadLine());

Console.Write("Password uzunligi: ");
var len = Convert.ToInt32(Console.ReadLine());

Random random = new Random();
var all_characters = string.Empty;

if (numbersB == 'y')
{
    all_characters += numbers;
}
if (lettersB == 'y')
{
    all_characters += letters;
}
if (symbolsB == 'y')
{
    all_characters += symbols;
}


var password = string.Empty;
if (all_characters.Length == 0)
{
    Console.WriteLine("Siz birortasini tanlamadingiz!");
}
else
{
    for (int i = 0; i < len; i++)
    {
        var next = random.Next(0, all_characters.Length);
        password += all_characters[next];
    }

    Console.WriteLine($"Your password is: {password}");
}
