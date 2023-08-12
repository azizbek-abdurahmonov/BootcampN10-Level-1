using System.Threading.Channels;

var numbers = new List<int>
{
    322, -1, 11, 3, 6, 10
};

Console.WriteLine($"Hammasi musbatmi : {numbers.All(num => num > 0)}");
Console.WriteLine($"Ichida Toq sonlar bormi : {numbers.Any(num => num % 2 == 1)}");
Console.WriteLine($"ichida 3 && 9 sonlari bormi : {numbers.Contains(3) && numbers.Contains(9)}");

