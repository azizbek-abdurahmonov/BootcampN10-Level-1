using System.Diagnostics.CodeAnalysis;

var date1 = new DateTime(2008, 01, 7);
var date2 = new DateTime(2004, 10, 1);
var date3 = new DateTime(2010, 2, 8);
var date4 = new DateTime(2000, 5, 9);
var date5 = new DateTime(2000, 6, 3);

DateTime[] days = new[] { date1, date2, date3, date4, date5 };
var names = new[] { "Azizbek", "Ahmadjon", "Doston", "Said", "Bekzod" };

for (int i = 0; i < days.Length; i++)
{
    for (int j = 0; j < names.Length; j++)
    {
        if (days[i].DayOfYear < days[j].DayOfYear)
        {
            var temp = days[i];
            days[i] = days[j];
            days[j] = temp;
            var temp2 = names[i];
            names[i] = names[j];
            names[j] = temp2;
        }
    }
}

for (var i = 0; i < days.Length; i++)
{
    Console.WriteLine($"{names[i]} - {days[i]}");
}