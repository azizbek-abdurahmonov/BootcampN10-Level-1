Console.BackgroundColor = ConsoleColor.White;
Console.ForegroundColor = ConsoleColor.DarkGreen;

while(true)
{
    Random random = new Random();
    Console.Write(random.Next(10, 99) + " ");
}