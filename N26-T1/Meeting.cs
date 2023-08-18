namespace N26_T1;

public class Meeting
{
    public string Name { get; set; }
    public TimeSpan Duration { get; set; }

    public Meeting(string name, TimeSpan duration)
    {
        Name = name;
        Duration = duration;
    }

    public static TimeSpan operator +(TimeSpan m1, Meeting m2)
    {
        return m1 + m2.Duration;
    }
}