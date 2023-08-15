using N24_Task1;

var service = new EmployeeService();

var random = new Random();
int min = 1_000_000, max = 10_000_000;
for (var i = 1; i <= 50; i++)
{
    service.Add(new Employee(i, $"Gishtmat{i}", $"Toshmatov{i}", random.Next(min, max), random.Next(0, 11)));
}

service.GetBySalary(10, 4).ForEach(Console.WriteLine);