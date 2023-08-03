using N18_HT1;

var management = new OrderManagementService();
management.Add(100);
management.Add(50);
management.Add(150);
management.Add(162);
Console.WriteLine($"Sum: {management.Sum()}");
Console.WriteLine($"Sum: {management.Sum()}");
management.Add(130);
Console.WriteLine($"Sum: {management.Sum()}");


Console.WriteLine($"Max: {management.Max()}");
Console.WriteLine($"Min: {management.Min()}");

management.Add(662);
management.Add(431);
Console.WriteLine($"Sum: {management.Sum()}");
Console.WriteLine($"Max: {management.Max()}");
Console.WriteLine($"Min: {management.Min()}");