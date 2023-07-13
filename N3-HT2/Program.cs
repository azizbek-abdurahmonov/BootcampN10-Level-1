Console.Write("Enter your email : ");
var email = Console.ReadLine();

var changed = string.Empty;
var count = (int)default;
var count2 = (int)default;

foreach (var item in email)
{
    var code = Convert.ToInt32(item);
    if ((code >= 97 && code <= 122) || (code >= 65 && code <= 90) || (code >= 48 && code <= 57) || code == 46 || code == 64)
    {
        count++;
    }
    else
    {
        Console.WriteLine($"Xato: {item}");
    }

    if (code >= 65 && code <= 90)
    {
        changed += Convert.ToChar(code + 32);
        count2++;
    }
    else
    {
        changed += item;
    }
}

if(count == email.Length && count2 != 0)
{
    Console.WriteLine($"Bu versiya yaxshiroq: {changed}");
}