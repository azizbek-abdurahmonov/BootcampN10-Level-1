var gr1 = new[]
{
    "John", "Tom", "Tim"
};

var gr2 = new[] { "John", "Tim", "Tom" };

for (var i = 0; i < gr1.Length; i++)
{
    for (var j = 0; j < gr2.Length; j++)
    {
        if (gr1[i].CompareTo(gr1[j]) == 1)
        {
            var temp = gr1[i];
            gr1[i] = gr1[j];
            gr1[j] = temp;

        }
    }
}
for (var i = 0; i < gr1.Length; i++)
{
    for (var j = 0; j < gr2.Length; j++)
    {
        if (gr2[i].CompareTo(gr2[j]) == 1)
        {
            var temp = gr2[i];
            gr2[i] = gr2[j];
            gr2[j] = temp;

        }
    }
}

var c = 0;

for (var i = 0; i < gr1.Length; i++)
{
    if (gr1[i] == gr2[i])
        c++;
}
if (c == gr1.Length)
    Console.WriteLine(true);
else
    Console.WriteLine(false);