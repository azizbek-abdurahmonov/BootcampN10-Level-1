Console.WriteLine("Enter >>> ");
var misol = Console.ReadLine();
var calc = new Calculator();
calc.simple(misol);

public class Calculator
{
    public void simple(string misol)
    {
        var numbers = misol.Split('+', '-', '*', '/');
        var amallar = new List<string>();
        var single = new List<string>();

        foreach (var c in misol)
        {
            if (!char.IsDigit(c))
            {
                amallar.Add(c.ToString());
            }
        }

        for (var i = 0; i < numbers.Length - 1; i++)
        {
            single.Add($"{numbers[i]}{amallar[i]}{numbers[i + 1]}");
        }

        if (findKB(single))
        {
            // ccall method with *, /
        }
        else
        {
            // call without *, /
        }
    }


    public bool findKB(List<string> misol)
    {
        foreach (var m in misol)
        {
            if (m.Contains("*") || m.Contains("/"))
                return true;
        }

        return false;
    }

    public string 
}

//  35+2/4*12-10
