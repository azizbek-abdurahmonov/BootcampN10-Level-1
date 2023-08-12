using System.Threading.Channels;
using N23_T1;

var service = new RegistrationService();
string email, password;

Console.WriteLine("Emailingizni kiriting: ");
email = Console.ReadLine();

Console.WriteLine("Parolni kiriting: ");
password = Console.ReadLine();

service.Register(email, password);