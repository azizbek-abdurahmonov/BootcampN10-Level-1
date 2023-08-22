namespace N28_HT1.Interfaces;

public interface IEvent
{
    Guid Id { get; set; }
    string Name { get; set; }
    DateTime Date { get; set; }
}