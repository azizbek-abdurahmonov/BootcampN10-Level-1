using N28_HT1.Models;

var eventStack = new EventStack<Event>();

eventStack.Push(new Event("First event", new DateTime(2023, 7, 10)));
eventStack.Push(new Event("Second event", new DateTime(2023, 7, 15)));

//throw qilingan exception chiqadi sababi event vaqti stackdagi eventlardan keyin bo'lmagan
//eventStack.Push(new Event("Thrist event", new DateTime(2023, 6, 20)));

Console.WriteLine(eventStack.Peek()); // oxirgi qo'shilgan event consolega chiqadi lekin o'chirilmaydi

Console.WriteLine(eventStack.Pop()); // consolga chiqadi va o'chiriladi
