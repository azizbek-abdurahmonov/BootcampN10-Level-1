using System.Net.Http.Headers;

Console.Write("Enter a number: ");
var num1 = Convert.ToInt32(Console.ReadLine());

while (true)
{
    Console.Write("Enter a command: ");
    var command = Console.ReadLine();
    var result = (object)default;

    if (command == "e")
    {
        Console.WriteLine("Thank you for using calculator!");
        break;
    }
    else if (command == "*")
    {
        Console.Write("Enter a number: ");
        result = Convert.ToInt32(Console.ReadLine()) * num1;
        Console.WriteLine($"Result: {result}");
    }
    else if (command == "/")
    {
        Console.Write("Enter a number: ");
        result = Convert.ToInt32(Console.ReadLine()) / num1;
        Console.WriteLine($"Result: {result}");

    }
    else if (command == "+")
    {
        Console.Write("Enter a number: ");
        result = Convert.ToInt32(Console.ReadLine()) + num1;
        Console.WriteLine($"Result: {result}");
    }
    else if (command == "-")
    {
        Console.Write("Enter a number: ");
        result = Convert.ToInt32(Console.ReadLine()) - num1;
        Console.WriteLine($"Result: {result}");
    }
    else
    {
        Console.WriteLine("Bunday amal yo'q!");
    }

    
}
