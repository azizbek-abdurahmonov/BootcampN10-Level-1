using System.Text;

Console.WriteLine("Misol kiriting: ");
var misol = new StringBuilder(Console.ReadLine());

//15+205-10
var sum = default(int);
var numbers = misol.ToString().Split('+', '-', '/', '*');
for (var i = 0; i < numbers.Length; i++)
{
    try
    {
        if (misol[numbers[i].Length] == '+')
        {
            misol.Remove(0, numbers[i].Length + 1);
            sum += int.Parse(numbers[i]) + int.Parse(numbers[i + 1]);
        }
    }
    catch
    {
        break;
    }
}

Console.WriteLine(sum);