using N32_T2.Models;

var obj1 = new ChatMessage("Nimadir", "qanaqadir message", Guid.Empty);
var obj2 = new ChatMessage("Nimadir", "qanaqadir message", Guid.Empty);

Console.WriteLine(obj1);
Console.WriteLine(obj1.Equals(obj2));