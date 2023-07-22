Console.Write("Enter your first-name: ");
var firstname = Console.ReadLine();

Console.Write("Enter your last name: ");
var lastname = Console.ReadLine();

Console.Write("Enter your age: ");
var age = int.Parse(Console.ReadLine());

var user1 = new User()
{
    FirstName = firstname,
    LastName = lastname,
    Age = age
};
Console.WriteLine($"Firstname: {user1.FirstName}\nlastname: {user1.LastName}\nAge: {user1.Age}");
public class User
{
    public string FirstName;
    public string LastName;
    public int Age;
}