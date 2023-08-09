using N20_HT2;

var register = new RegistrationService();

var name = default(string);
var surname = default(string);
var patronymic = default(string);
var emailAddress = default(string);
var username = default(string);

Console.Write("Ismingizni kiriting: ");
name = Console.ReadLine();

Console.Write("Familiyangizni kiriting: ");
surname = Console.ReadLine();

Console.Write("Sharifingizni kiriting: ");
patronymic = Console.ReadLine();

Console.Write("Email addressingizni kiriting: ");
emailAddress = Console.ReadLine();

Console.Write("Username kiriting: ");
username = Console.ReadLine();



register.Register(name, surname, patronymic, emailAddress, username);
register.Display();