using N28_HT1.Interfaces;

namespace N28_HT1.Models;

public class EventStack<T> where T : IEvent
{
    private List<T> _events;

    public EventStack()
    {
        _events = new List<T>();
    }

    public void Push(T item)
    {
        if (_events.All(x => x.Date < item.Date))
        {
            _events.Add(item);
            return;
        }

        throw new Exception("Event date is not valid");
    }

    public T Peek()
    {
        if (_events.Count == 0) throw new Exception("Stack is empty");

        return _events.Last();
    }

    public T Pop()
    {
        if (_events.Count == 0) throw new Exception("Stack is empty");

        var eventB = _events.Last();
        _events.Remove(eventB);
        return eventB;
    }
}