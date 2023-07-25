using System.Text;

Console.WriteLine("Misol kiriting: ");
var misol = new StringBuilder(Console.ReadLine());

var sum = default(int);
var numbers = misol.ToString().Split('+', '-', '/', '*');
var amallar = string.Empty;

for (var i = 0; i < misol.Length; i++)
    if (!char.IsDigit(misol[i]))
        amallar += misol[i];

var idx = 0;
while (misol.ToString().Any(char.IsSymbol))
{
    if (amallar[idx] == '+')
    {
        misol.Replace($"{numbers[idx]}{amallar[idx]}{numbers[idx + 1]}", $"{int.Parse(numbers[idx]) + int.Parse(numbers[idx + 1])}");
        idx++;
    }

}
Console.WriteLine(misol);
