Console.WriteLine("Enter some text: ");
var text = Console.ReadLine();

Console.Write("index: ");
var idx = Convert.ToInt32(Console.ReadLine());

Console.Write("uzunlik: ");
var len =  Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Your text: {text}\nFirst letter: {text[0]}\nText length: {text.Length}\nsubstring text: {text.Substring(idx, len)}");