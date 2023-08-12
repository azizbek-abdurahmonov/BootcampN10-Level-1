using N23_HT2;

var users = new List<User>
{
    new User("John", "Doe", "johndoe@example.com"),
    new User("Jane", "Doe", "janedoe@example.com"),
    new User("Bob", "Smith", "bobsmith@example.com"),
    new User("Alice", "Johnson", "alicejohnson@example.com"),
    new User("Mike", "Brown", "mikebrown@example.com"),
    new User("Emily", "Davis", "emilydavis@example.com"),
    new User("David", "Wilson", "davidwilson@example.com"),
    new User("Sarah", "Taylor", "sarahtaylor@example.com"),
    new User("Tom", "Anderson", "tomanderson@example.com"),
    new User("Lisa", "Thomas", "lisathomas@example.com")
};

Console.WriteLine("Qidirish uchun keyword kiriting: ");
var keyword = Console.ReadLine();

var result = users.Where(user => user.firstName.ToLower().Contains(keyword.ToLower()) || user.lastName.ToLower().Contains(keyword.ToLower()) || user.emailAddress.ToLower().Contains(keyword.ToLower()));
result.ToList().ForEach(Console.WriteLine);