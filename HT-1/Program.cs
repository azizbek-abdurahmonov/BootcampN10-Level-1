// HT - 1
// Task - 1
Console.WriteLine("Task - 1");
Console.Write("Enter your first name: ");
string firstname = Console.ReadLine();

Console.Write("Last name: ");
string lastname = Console.ReadLine();

Console.Write("Enter your age: ");
byte age = byte.Parse(Console.ReadLine());

Console.WriteLine($"\nFirst name: {firstname}\nLast name: {lastname}\nAge: {age}");

//Task - 2
Console.WriteLine("\nTask - 2");
DateTime today = DateTime.Now;
DateTime date = new DateTime(1970, 1, 1);
byte ageB = 75;
float balance = 35.5F;
string name = "Max Developer";

Console.WriteLine(today);
Console.WriteLine(date);
Console.WriteLine(ageB);
Console.WriteLine(balance);
Console.WriteLine(name);

//Task - 3
Console.WriteLine("\nTask - 3");
//Primitive
bool isAlive = true;
int price = 170_000;

Console.WriteLine($"Primitive types: {isAlive}, {price}");

//complex
DateTime now = DateTime.Now;

Console.WriteLine($"Complex type: {now}");

// value type
char letter = 'A';
int population = 34_920_000;

Console.WriteLine($"Value types: {letter}, {population}");

//reference type
string modelName = "HP Laptop";

Console.WriteLine($"Reference type: {modelName}");