using System.Text.RegularExpressions;

x:
Console.Write("Enter your email: ");
var email = Console.ReadLine();

var p = @"^[a-zA-Z0-9.]+@[a-zA-Z0-9]+\.[a-zA-Z0-9]+$";
var check = new Regex(p);

var ch = check.IsMatch(email);

if (ch)
{
    Console.WriteLine("Done!");
}
else
{
    Console.WriteLine("Invalid email");
}

goto x;