using System.Linq.Expressions;

var dateTime = new DateOnly(2023, 6, 15);
var days = new[]
{
    dateTime.AddDays(1),
    dateTime.AddDays(20),
    dateTime.AddDays(13),
    dateTime.AddDays(10),
    dateTime.AddDays(5),
};

var durations = new[]
{
    TimeSpan.FromHours(8),
    TimeSpan.FromHours(7),
    TimeSpan.FromHours(7),
    TimeSpan.FromHours(8),
    TimeSpan.FromHours(10),
};

var divisions = new[] { 1, 0, 0, 1, 0 };

for (var i = 0; i < days.Length; i++)
{
    for (int j = 0; j < days.Length; j++)
    {
        if (days[i] > days[j])
        {
            var temp = days[i];
            days[i] = days[j];
            days[j] = temp;

            var temp2 = durations[i];
            durations[i] = durations[j];
            durations[j] = temp2;

            var temp3 = divisions[i];
            divisions[i] = divisions[j];
            divisions[j] = temp3;
        }
    }
}

// ishni boshlash
for (int i = 0; i < divisions.Length; i++)
{
    try
    {
        if (durations[i-1].TotalHours < 8)
        {
            var score = (durations[i].TotalHours - (divisions[i] / durations[i].TotalHours)) / (8 + (8 - durations[i - 1].TotalHours)) * 10;
            Console.WriteLine($"{days[i].ToString("dd.MM.yyyy")} - {durations[i].TotalHours} hour - {score:F2} score");
        }
        else
        {
            var score = (durations[i].TotalHours - (divisions[i] / durations[i].TotalHours)) / (8 + 0) * 10;
            Console.WriteLine($"{days[i].ToString("dd.MM.yyyy")} - {durations[i].TotalHours} hour - {score:F2} score");
        }

    }
    catch
    {
        var score = (durations[i].TotalHours - (divisions[i] / durations[i].TotalHours)) / (8 + 0) * 10;
        Console.WriteLine($"{days[i].ToString("dd.MM.yyyy")} - {durations[i].TotalHours} hour - {score:F2} score");
    }

}








