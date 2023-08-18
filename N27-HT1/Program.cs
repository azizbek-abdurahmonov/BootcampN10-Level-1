using N27_HT1.Services;

var service = new UserService();
service.Add("john@gmail.com", "Pass1234");
service.Add("johndoe@gmail.com", "Pass12345");

service.GetUsers().ForEach(Console.WriteLine);
