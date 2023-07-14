Console.WriteLine("essay kiriting: ");
var essay = Console.ReadLine();

var mistakes = string.Empty;
var score = 100;

var words = essay.Split(' ');
var sentences = essay.Split('.', '?', '!');

if (words.Length < 500)
{
    mistakes += $"So'zlar soni 500 dan kamligi uchun: -5\n";
    score -= 5;
}

foreach (var word in words)
{
    var count = (int)default;
    foreach (var nword in words)
        if (nword.Equals(word, StringComparison.OrdinalIgnoreCase))
            count++;
    if ((words.Length / 100 * count) > 20)
    {
        mistakes += $"Essayda {word} so'zi barcha so'zlarning 20% dan ko'pini tashkil qilgani uchun: -5\n";
        score -= 5;
    }
}


var ccap = string.Empty;
foreach (var sentence in sentences)
{
    var wordsInSentence = sentence.Trim().Split();
    var firstW = wordsInSentence[0];

    try
    {
        var correctForm = string.Concat(firstW.Substring(0, 1).ToUpper(), firstW.Substring(1).ToLower());
        if (firstW != correctForm)
        {
            ccap += $"{firstW},";
        }
    }
    catch { }

}
if (ccap.Length != 0)
{
    mistakes += $"Capital bo'lmagan birinchi so'zlar uchun ({ccap}): -5\n";
    score -= 5;
}

var incorrectWords = string.Empty;
foreach (var sentence in sentences)
{
    var wordsB = sentence.Trim().Split();
    for (int i = 1; i < wordsB.Length; i++)
    {
        if (wordsB[i] != wordsB[i].ToLower())
        {
            incorrectWords += $"{wordsB[i]},";
        }
    }
}
if (incorrectWords.Length != 0)
{
    mistakes += $"Birinchi so'z bo'lmagan va faqat kichik harflar bilan yozilmagan so'zlar uchun ({incorrectWords}): -10\n";
    score -= 10;
}

var incorrectWordsB = string.Empty;
foreach (var word in words)
{
    if (word.Length > 20)
    {
        incorrectWordsB += $"{word} ";
    }
}
if (incorrectWordsB.Length != 0)
{
    mistakes += $"Uzunligi 20 dan oshib ketgan so'zlar uchun ({incorrectWordsB}): -20";
    score -= 20;
}

Console.WriteLine(mistakes);
Console.WriteLine($"\nResult: {score} ball");