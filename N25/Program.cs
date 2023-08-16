using System.Threading.Channels;

Level i = Level.Intern;
// Console.WriteLine(i.GetType()); // Level.
Console.WriteLine((double)Level.Intern);
Console.WriteLine((double)Level.Junior);
Console.WriteLine(Level.Middle);

Console.WriteLine(Level.Senior.ToString());

public enum Level
{
    Intern,
    Junior = 50,
    Middle,
    Senior,
    TeamLead,
}