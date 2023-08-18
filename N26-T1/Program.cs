using N26_T1;

var meetings = new List<Meeting>
{
    new Meeting("Nimadir", TimeSpan.MinValue),
    new Meeting("Nimadir2", TimeSpan.MaxValue),
    new Meeting("Nimadir3", TimeSpan.FromDays(15)),
    new Meeting("Nimadir4", TimeSpan.FromDays(48)),
};

var Sum = new TimeSpan();

foreach (var meeting in meetings)
{
    Sum += meeting;
}

Console.WriteLine(Sum.TotalDays);