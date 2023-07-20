//LinkedList

var linkedlist = new LinkedList<string>();

Console.WriteLine($"elementlar qo'shilmasdan oldin uning o'lchami: {linkedlist.Count}");

linkedlist.AddFirst("a");
linkedlist.AddLast("z");
linkedlist.AddLast("i");
linkedlist.AddLast("z");
linkedlist.AddLast("b");
linkedlist.AddLast("e");
linkedlist.AddLast("c");

Console.WriteLine(linked);

Console.WriteLine($"elementlar qo'shilgandan keyin uning o'lchami: {linkedlist.Count}");


foreach (var linked in linkedlist)
    Console.WriteLine(linked);