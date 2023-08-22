using System.Diagnostics.Tracing;
using N28_HT1.Interfaces;

namespace N28_HT1.Models;

public class Event : IEvent
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public DateTime Date { get; set; }

    public Event(string name, DateTime date)
    {
        Id = Guid.NewGuid();
        Name = name;
        Date = date;
    }

    public override string ToString()
    {
        return $"{Name} {Date}";
    }
}