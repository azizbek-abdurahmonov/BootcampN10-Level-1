var ages = new[] { 12, 15, 25, 12, 56, 13, 81, 55, 25, 12 };
var diff = new Dictionary<int, int>();

for (var i = 0; i < ages.Length; i++)
{
    var c = 0;
    foreach (var age in ages)
        if (age == ages[i])
            c++;
    diff[ages[i]] = c;
}

foreach (var i in diff)
{
    if(i.Value > 1)
        Console.WriteLine(i.Key + " - " + i.Value);
}