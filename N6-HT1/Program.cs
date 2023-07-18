using System.Threading.Channels;

var students = new[]
{
    "Ilxom", "G'ayarat", "Azizbek", "Firdavs", "Asilbek",
    "Shoxijahon", "Xusan", "Avazbek", "Shahroz", "Mehroj"
};

var balls = new[]
{
    92, 74, 85, 81, 66,
    72, 65, 88, 95, 67
};

// sorting
for (int i = 0; i < balls.Length; i++)
{
    for (int j = i + 1; j < balls.Length; j++)
    {
        if (balls[i] < balls[j])
        {
            var temp = balls[i];
            balls[i] = balls[j];
            balls[j] = temp;

            var temp2 = students[i];
            students[i] = students[j];
            students[j] = temp2;
        }
    }
}

var highScore = balls[0];
var averageScore = balls.Sum() / balls.Length;
var lowScore = balls[balls.Length - 1];
var balanceFrom80 = default(int);
var balanceFrom90 = default(int);
foreach (var ball in balls)
{
    if (ball > 90)
        balanceFrom90++;
    else if (ball > 80)
        balanceFrom80++;
}



Console.WriteLine($"Eng baland ball: {highScore}");
Console.WriteLine($"O'rtacha ball: {averageScore}");
Console.WriteLine($"Eng past ball: {lowScore}");
Console.WriteLine($"80 dan baland olgan studentlar soni: {balanceFrom80}");
Console.WriteLine($"90 dan baland olgan studentlar soni: {balanceFrom90}");
Console.WriteLine();

for (var i = 0; i < balls.Length; i++)
{
    if (balls[i] > 90)
        Console.WriteLine($"{students[i]} - Top ({balls[i]} ball)");
    else if (balls[i] > 80)
        Console.WriteLine($"{students[i]} - Good ({balls[i]} ball)");
    else
        Console.WriteLine($"{students[i]} - Fail ({balls[i]} ball)");

}