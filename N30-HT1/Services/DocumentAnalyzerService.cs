using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N30_HT1.Services
{
    public class DocumentAnalyzerService
    {
        public string Essay { get; set; }
        public int Score { get; set; }

        public async Task<int> Analyze(string path)
        {
            Score = 100;
            Essay = File.ReadAllText(path);

            await WordsCountLess500();
            await WordRetryingCheck();
            await CheckCapitalize();
            await CheckLowercase();
            await CheckLongWords();

            return Score;
        }

        public async Task WordsCountLess500()
        {
            if (Essay.Split(' ').Length < 500)
                Score -= 5;
        }

        public async Task WordRetryingCheck()
        {
            var words = Essay.Split(' ');

            foreach (string word in words)
            {
                var count = words.Count(x => string.Equals(x, word));

                if ((count / words.Length) * 100 >= 20)
                {
                    Score -= 5;
                }
            }
        }

        public async Task CheckCapitalize()
        {
            var sentences = Essay.Split('.', '!', '?');
            foreach (var sentence in sentences)
            {
                var words = sentence.Trim().Split();
                var targetWord = words[0];
                if (targetWord !=
                    string.Concat(targetWord.Substring(0, 1).ToUpper(), targetWord.Substring(1).ToLower()))
                {
                    Score -= 5;
                    return;
                }
            }
        }

        public async Task CheckLowercase()
        {
            var sentences = Essay.Split('.', '?', '!');
            foreach (var sentence in sentences)
            {
                var words = sentence.Trim().Split();
                for (var i = 1; i < words.Length; i++)
                {
                    var target = words[i];
                    if (target != target.ToLower())
                        Score -= 10;
                }
            }
        }

        public async Task CheckLongWords()
        {
            var words = Essay.Split();
            var count = words.Count(word => word.Length >= 20);
            Score -= (count) * 20;
        }
    }
}