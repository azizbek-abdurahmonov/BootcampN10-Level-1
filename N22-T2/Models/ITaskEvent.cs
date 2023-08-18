namespace N22_T1.Models;

public interface ITaskEvent
{
    Guid Id { get; }
    string Name { get; }
    byte Priority { get; }

    static bool operator <(ITaskEvent eventA, ITaskEvent eventB)
    {
        return eventA.Priority < eventB.Priority;
    }
    static bool operator >(ITaskEvent eventA, ITaskEvent eventB)
    {
        return eventA.Priority > eventB.Priority;
    }
}