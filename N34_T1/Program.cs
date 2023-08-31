var customers = new List<Customer>
{
    new Customer("John", 16, 5_000_000),
    new Customer("Alice", 25, 2_500_000),
    new Customer("Bob", 32, 1_200_000),
    new Customer("Emily", 28, 3_750_000),
    new Customer("David", 40, 6_800_000),
    new Customer("Sophia", 22, 1_800_000),
    new Customer("Michael", 35, 4_500_000),
    new Customer("Olivia", 30, 3_200_000),
    new Customer("James", 45, 7_500_000),
    new Customer("Emma", 27, 2_300_000),
    new Customer("William", 38, 6_000_000),
    new Customer("Ava", 29, 3_400_000),
    new Customer("Joseph", 48, 8_200_000),
    new Customer("Mia", 26, 2_100_000),
    new Customer("Daniel", 42, 7_000_000),
    new Customer("Sophie", 24, 2_000_000),
    new Customer("Alexander", 36, 4_800_000),
    new Customer("Chloe", 31, 3_600_000),
    new Customer("Matthew", 50, 9_000_000),
    new Customer("Lily", 23, 1_900_000),
};

var filterModel = new CustomerFilterModel(20, 5_000_000);

var query = customers
    .AsQueryable()
    .Where(customer => customer.Age >= filterModel.Age && customer.Balance >= filterModel.Balance);

Console.WriteLine("Before");
query.ToList().ForEach(Console.WriteLine);

Console.WriteLine("\nAfter");
customers.Add(new Customer("Gishtmat", 56, 19_000_000));
query.ToList().ForEach(Console.WriteLine);


public class CustomerFilterModel
{
    public int Age { get; set; }
    public decimal Balance { get; set; }

    public CustomerFilterModel(int age, decimal balance)
    {
        Age = age;
        Balance = balance;
    }
}


public class Customer
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public decimal Balance { get; set; }

    public Customer(string name, int age, decimal balance)
    {
        Id = Guid.NewGuid();
        Name = name;
        Age = age;
        Balance = balance;

    }

    public override string ToString()
    {
        return $"{Name} {Age} {Balance}";
    }
}