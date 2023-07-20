using System.ComponentModel.Design;

var names = new List<string>();
names.Add("John");
names.Add("G'ayrat");
names.Add("Qodirali");
names.Add("G'ishmat");

var flightTimes = new Dictionary<DateTime, int>();
flightTimes.Add(new DateTime(2023, 7, 5, 10, 30, 0), 2);
flightTimes.Add(new DateTime(2023, 7, 15, 8, 45, 0), 4);
flightTimes.Add(new DateTime(2023, 7, 25, 12, 0, 0), 5);

const string? CompanyName = "The Travel Guru";
const string NameToken = "{{Name}}";
const string CompanyNameToken = "{{CompanyName}}";
const string TicketDateToken = "{{TicketDate}}";

var messages = new Dictionary<string, string>();
messages.Add("Underage", "Uzr, hurmatli {{Name}} siz loyihadan foydalanish uchun kichkinasiz");
messages.Add("GoldenAger", "Uzr, hurmatli {{Name}} loyiha yoshlar uchun mo'ljallangan");

var emails = new LinkedList<string>();
emails.AddLast("Hello {{Name}}. Welcome to onboard. {{CompanyName}} Team.");
emails.AddLast("Your data is being processed and we will inform updates for you as soon as possible. {{CompanyName}} Team");
emails.AddLast("Congratulations! Your flight ticket is booked for {{TicketDate}}. {{CompanyName}} Team.");

var name = string.Empty;
while (true)
{
    Console.Write("Enter your name: ");
    name = Console.ReadLine();

    if (string.IsNullOrEmpty(name) || string.IsNullOrWhiteSpace(name))
    {
        Console.WriteLine("Iltimos ism kiriting!");
    }
    else
    {
        var count = 0;
        for (int i = 0; i < name.Length; i++)
        {
            if (name[i] >= '0' && name[i] <= '9')
            {
                Console.WriteLine("Invalid name");
                break;
            }
            else
            {
                count++;
            }
        }
        if (count == name.Length)
        {
            break;
        }
    }
}

string age;
while (true)
{
    Console.Write("Enter your age: ");
    age = Console.ReadLine();
    if (string.IsNullOrEmpty(age) || string.IsNullOrWhiteSpace(age))
    {
        Console.WriteLine("Siz hech narsa kiritmadingiz!");
    }
    else
    {
        var count = 0;
        for (var i = 0; i < age.Length; i++)
        {
            if (((age[i] >= 'a' && age[i] <= 'z') || (age[i] >= 'A' && age[i] <= 'Z')))
            {
                Console.WriteLine("Iltimos, faqat sonlardan foydalaning!");
                break;
            }
            else
            {
                count++;
            }
        }
        if (count == age.Length)
        {
            break;
        }
    }
}

var Age = Convert.ToInt32(age);

var FlightTime = default(DateTime);
if (Age < 18)
{
    Console.WriteLine(messages["Underage"].Replace(NameToken, name));
    return;
}
else if (Age > 18 && Age < 90)
{
    names.Add(name);
    foreach (var time in flightTimes.Keys)
    {
        if (flightTimes[time] >= names.Count)
        {
            FlightTime = time;
            break;
        }
    }
    var idx = 0;
    foreach (var ism in names)
    {
        foreach(var email in emails)
        {
            Console.WriteLine(email
                .Replace(CompanyNameToken, CompanyName)
                .Replace(NameToken, names[idx])
                .Replace(TicketDateToken, FlightTime.ToString("dd.MM.yyyy HH:mm:ss")));
        }
        Console.WriteLine();
        idx++;
    }
}else if(Age > 90)
{
    Console.WriteLine(messages["GoldenAger"].Replace(NameToken, name));
    return;
}