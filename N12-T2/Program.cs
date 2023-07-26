using System.Reflection.Metadata.Ecma335;

var users = new Queue<User>();
users.Enqueue(new User { firstName = "Azizbek", lastName = "Abdurahmonov", sname = "Alisherovich" });
users.Enqueue(new User { firstName = "Mirzohid", lastName = "Mirzohidov", sname = "Gayratovich" });
users.Enqueue(new User { firstName = "Qodirali", lastName = "Gayratov", sname = "Qodirovich" });
users.Enqueue(new User { firstName = "Elyozbek", lastName = "Ergashboyev", sname = "Dostonivich" });

var firstname = default(string);
var lastname = default(string);
var sname = default(string);

Console.WriteLine("Ismingizni kiriting: ");
firstname = Console.ReadLine();

Console.WriteLine("Familiyangizni kiriting: ");
lastname = Console.ReadLine();

Console.WriteLine("Sharifingizni kiriting: ");
sname = Console.ReadLine();

var newUser = new User
{
    firstName = firstname,
    lastName = lastname,
    sname = sname
};

foreach (var user in users)
{
    if (user.Equals(newUser))
    {
        Console.WriteLine($"{newUser.firstName} uje navbatdasanku!");
        return;
    }
}

users.Enqueue(newUser);
foreach (var user in users)
{
    Console.WriteLine($"{user.firstName} {user.lastName} {user.sname}");
}

public class User
{
    public string firstName;
    public string lastName;
    public string sname;

    public override int GetHashCode()
    {
        return this.firstName.GetHashCode() + this.lastName.GetHashCode() + this.sname.GetHashCode();
    }

    public override bool Equals(object? obj)
    {
        return obj.GetHashCode() == this.GetHashCode();
    }
}

