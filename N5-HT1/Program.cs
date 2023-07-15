using System.Net.Http.Headers;

var questions = new[]
{
    "\"string\" - tipidagi o'zgaruvchilar qayerda saqlanadi",
    "string comparisonda '==' nima bo'yicha solishtiradi? ",
    "object - class memberlariga access beradimi? ",
    "C# dasturlash tili qachon yaratilgan? ",
    "C# asoschisini toping"
};

var correct = new[] { "HEAP xotirada", "Value", "Yo'q", "2002- yil", "Anders Hejlsberg" };
var uncorrect = new[] { "Stack da", "Reference", "Ha", "2000 - yil", "John Doe" };

string[] answers = new string[5];
var rd = new Random();
var ball = 0;

for (var num = 0; num < 5; num++)
{
    Console.Clear();
    Console.WriteLine(questions[num]);
    var check = rd.Next(0, 2);

    switch (check)
    {
        case 0:
            Console.WriteLine($"A) {correct[num]}");
            Console.WriteLine($"B) {uncorrect[num]}");
            break;
        case 1:
            Console.WriteLine($"A) {uncorrect[num]}");
            Console.WriteLine($"B) {correct[num]}");
            break;
    }

    var answer = Console.ReadLine();
    if (answer.ToUpper() == "A")
    {
        if (check == 0)
        {
            answers[num] = correct[num];
        }
        else
        {
            answers[num] = uncorrect[num];
        }
    }
    else if (answer.ToUpper() == "B")
    {
        if (check == 0)
        {
            answers[num] = uncorrect[num];
        }
        else
        {
            answers[num] = correct[num];
        }
    }
    else
    {
        Console.WriteLine("Unday variant yo'q, Iltimos qaytadan uruning");
        num--;
        Thread.Sleep(1000);
    }
}

var mistakes = string.Empty;

for (var num = 0; num < 5; num++)
{
    if (answers[num] == correct[num])
    {
        ball++;
    }
    else
    {
        mistakes += $"Question : {questions[num]}\nAnswer: {answers[num]}\n";
    }
}

Console.WriteLine($"Ball: {ball}");
if(mistakes.Length == 0)
{
    Console.WriteLine("Ajoyib, xato javoblar mavjud emas!");
}
else
{
    Console.WriteLine("Invalid answers: ");
    Console.WriteLine(mistakes);
}