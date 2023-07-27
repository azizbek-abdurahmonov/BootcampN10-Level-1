var eventManager = new EventManager();
eventManager.Add("Do homweork", new DateTime(2023, 7, 28));
eventManager.Add("Do homweork2", new DateTime(2023, 7, 29));
eventManager.Add("Do homweork3", new DateTime(2023, 8, 28));

eventManager.Add("learn c#", new TimeOnly(12, 30, 0));
eventManager.Add("learn c#2", new TimeOnly(15, 30, 0));
eventManager.Add("learn c##", new TimeOnly(12, 30, 0));


eventManager.Display();



public class EventManager
{
    public Dictionary<string, DateTime> aniqKundagiEventlar = new Dictionary<string, DateTime>();
    public Dictionary<string, TimeOnly> HarKuniBajariladiganEventlar = new Dictionary<string, TimeOnly>();

    public void Add(string name, DateTime date)
    {
        aniqKundagiEventlar.Add(name, date);
    }
    public void Add(string name, TimeOnly time)
    {
        HarKuniBajariladiganEventlar.Add(name, time);
    }

    public void Display()
    {
        Console.WriteLine("Har kuni bajariladigan eventlar: ");
        foreach (var row in HarKuniBajariladiganEventlar)
        {
            Console.WriteLine($"{row.Key} - {row.Value}");
        }

        Console.WriteLine("Keyingi uch kundagi eventlar: ");
        var now = DateTime.Now;
        foreach (var row in aniqKundagiEventlar)
        {
            if((row.Value - now).Days <= 3)
                Console.WriteLine($"{row.Key} - {row.Value}");
        }
    }
}


