//var planner = new Planner();
//planner.Add("Learn C#", new TimeOnly(10, 30));
//planner.Add("Do homeworks", new TimeOnly(12, 0));
//planner.Add("Sleep!", new TimeOnly(4, 0));
//planner.Display();


var planner = new UltimatePlanner();
planner.Add("play CS 1.6", new TimeOnly(1, 1));
planner.Add("play PUBG", new TimeOnly(1, 1));
planner.Add("Have lunch", new TimeOnly(12, 30));

planner.Add("Go to the NT", new DateOnly(2023, 12, 1));
planner.Add("Create PROGRAM!", new DateOnly(2023, 10, 5));
planner.Add("Sing", new DateOnly(2024, 5, 10));


planner.Display();

public class Planner
{
    public Dictionary<string, TimeOnly> Plans = new Dictionary<string, TimeOnly>();
    public virtual void Add(string title, TimeOnly date)
    {
        Plans[title] = date;
    }

    public virtual void Display()
    {
        foreach (var item in Plans)
        {
            Console.WriteLine($"{item.Key} - {item.Value}");
        }
    }

}

public class UltimatePlanner : Planner
{
    public Dictionary<string, DateOnly> calendarEvents = new Dictionary<string, DateOnly>();
    public override void Add(string title, TimeOnly time)
    {
        var check = default(bool);
        foreach (var item in Plans)
        {
            if (item.Value.Hour == time.Hour)
            {
                Console.WriteLine($"You have conflict in daily plan : {item.Key} and {title}");
                check = true;
                break;
            }
        }
        if (!check)
            Plans[title] = time;

    }

    public new void Add(string title, DateOnly date)
    {
        calendarEvents[title] = date;
    }

    public override void Display()
    {
        Console.WriteLine("Calendar events: ");
        foreach(var item in calendarEvents)
        {
            Console.WriteLine($"{item.Key} - {item.Value}");
        }
        Console.WriteLine("\nDaily events: ");

        foreach(var item in Plans)
        {
            Console.WriteLine($"{item.Key} - {item.Value}");
        }
    }
}