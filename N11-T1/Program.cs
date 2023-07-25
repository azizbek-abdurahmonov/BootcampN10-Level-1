using System.Security.Cryptography.X509Certificates;


public class DocumentAnalyzer
{
    public int Analyzing(Document document)
    {
        var score = 100;
        var sentences = document.essay.Split('.', '?', '!');
        var words = document.essay.Split();

        if (words.Length < 500)
            score -= 5;

        var wordsB = new List<string>();
        foreach (var word in words)
        {
            if (!wordsB.Contains(word.ToLower()))
            {
                var count = 0;
                foreach (var nword in words)
                {
                    if (nword.Equals(word, StringComparison.OrdinalIgnoreCase))
                    {
                        count++;
                    }
                }
                if (count * 0.2 < 20)
                    score -= 5;

                wordsB.Add(word.ToLower());
            }
        }


        foreach (var sentence in sentences)
        {
            var wordsInSentence = sentence.Trim().Split();
            var word = wordsInSentence[0];
            var capitalized = string.Concat(
                word.Substring(0, 1).ToUpper(),
                word.Substring(1).ToLower()
                );

            if (capitalized != word)
                score -= 5;

        }

        foreach (var sentence in sentences)
        {

            var wordsInSentence = sentence.Trim().Split();
            for (var i = 1; i < wordsInSentence.Length - 1; i++)
            {
                if (wordsInSentence[i] != wordsInSentence[i].ToLower())
                    score -= 10;
            }
        }

        foreach (var word in words)
        {
            if (word.Length > 20)
                score -= 20;
        }

        return score;
    }
}

public class Document
{
    public string essay;
}