using System.Threading.Tasks.Sources;

var standart = new List<string[]>();
standart.Add(new[] { "[standart] What is the capital city of Australia?", "Canberra" });
standart.Add(new[] { "[standart] Which river is the longest in South America?", "Amazon" });
standart.Add(new[] { "[standart] Which continent is known as the \"Land Down Under?", "Australia" });
standart.Add(new[] { "[standart] In which continent is the Sahara Desert located?", "Africa" });
standart.Add(new[] { "[standart] What is the highest mountain in the European Alps?", "Mont Blanc" });

var oson = new List<string[]>();
oson.Add(new[] { "[oson] Name the largest island in the world", "Greenland" });
oson.Add(new[] { "[oson] What is the largest lake by surface area in Africa?", "Victoria" });
oson.Add(new[] { "[oson] Name the smallest country in the world by land area.", "Vatican" });

var qiyin = new List<string[]>();
qiyin.Add(new[] { "[qiyin] Which country is home to the world's largest coral reef system?", "Australia" });
qiyin.Add(new[] { "[qiyin] What is the deepest oceanic trench in the world?", "Mariana" });
qiyin.Add(new[] { "[qiyin] Name the active volcano in Italy that famously erupted in AD 79, burying the city of Pompeii.", "Mount Vesuvius" });

var num = 0;
var correct = 0;
var incorrect = 0;

var qiyin_idx = 0;
var oson_idx = 0;

while (true)
{
    try
    {
        if (correct == 2)
        {
            correct = 0;
            standart.Insert(num, qiyin[qiyin_idx]);
            qiyin_idx++;
        }

        if (incorrect == 2)
        {
            incorrect = 0;
            standart.Insert(num, oson[oson_idx]);
            oson_idx++;
        }

        Console.WriteLine(standart[num][0]);
        var javob = Console.ReadLine();
        if (javob == standart[num][1])
        {
            correct++;
        }
        else
        {
            incorrect++;
        }


        num++;
    }
    catch
    {
        Console.WriteLine("The end!");
        return;
    }
}