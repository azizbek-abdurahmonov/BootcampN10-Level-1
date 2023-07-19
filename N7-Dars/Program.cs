var workStartTime = new TimeOnly(9, 0);
var workEndTime = new TimeOnly(20, 0);

DateTime[] meetingStartTimes = new DateTime[10]
        {
            new DateTime(2023, 7, 2, 8, 30, 0),
            new DateTime(2023, 7, 5, 10, 0, 0),
            new DateTime(2023, 7, 9, 19, 15, 0),
            new DateTime(2023, 7, 11, 16, 30, 0),
            new DateTime(2023, 7, 14, 9, 45, 0),
            new DateTime(2023, 7, 18, 5, 0, 0),
            new DateTime(2023, 7, 22, 13, 30, 0),
            new DateTime(2023, 7, 24, 15, 45, 0),
            new DateTime(2023, 7, 27, 10, 30, 0),
            new DateTime(2023, 7, 31, 22, 0, 0)
        };

TimeSpan[] meetingDuring = new TimeSpan[10]
        {
            TimeSpan.FromMinutes(30),
            TimeSpan.FromMinutes(10),
            TimeSpan.FromMinutes(120),
            TimeSpan.FromMinutes(45),
            TimeSpan.FromMinutes(30),
            TimeSpan.FromMinutes(15),
            TimeSpan.FromMinutes(20),
            TimeSpan.FromMinutes(45),
            TimeSpan.FromMinutes(10),
            TimeSpan.FromMinutes(30)
        };


Console.WriteLine("Bad meetings: ");
for (var i = 0; i < 10; i++)
{
    if (meetingStartTimes[i].Hour < workStartTime.Hour
        || meetingStartTimes[i].Hour > workEndTime.Hour
        || meetingStartTimes[i].Hour + meetingDuring[i].Hours > workEndTime.Hour)
    {
        Console.WriteLine(meetingStartTimes[i]);
    }
}

Console.WriteLine("\n30 daqiqadan oshadigan meetinglar: ");
for (var i = 0; i < 10; i++)
{
    if (meetingDuring[i].TotalMinutes > 30)
    {
        Console.WriteLine(meetingStartTimes[i]);
    }
}

var count = 0D;
foreach (var meeting in meetingDuring)
{
    count += meeting.TotalMinutes;
}
Console.WriteLine($"\nUmumiy meetinglar vaqti (minutlarda): {count}");

var times = new TimeSpan[9];

for (int i = 1; i < 10; i++)
{
    var time = meetingStartTimes[i] - (meetingStartTimes[i - 1] + meetingDuring[i - 1]);
    times[i - 1] = time;
}

var maxTime = default(double);
var minTime = times[0].TotalHours;

for (int i = 0; i < 9; i++)
{
    if (times[i].TotalHours > maxTime)
        maxTime = times[i].TotalHours;
    if (times[i].TotalHours < minTime)
        minTime = times[i].TotalHours;
}

for (var i = 0; i < 9; i++)
{
    if (times[i].TotalHours == maxTime)
        Console.WriteLine($"meetinglar orasidagi eng ko'p vaqt {meetingStartTimes[i]} va {meetingStartTimes[i+1]} orasida : {times[i].TotalHours} soat");
    if (times[i].TotalHours == minTime)
        Console.WriteLine($"meetinglar orasidagi eng kam vaqt {meetingStartTimes[i]} va {meetingStartTimes[i + 1]} orasida : {times[i].TotalHours} soat");

}