using System.Text.Json;

var departments = new List<Department>
{
    new Department { DepartmentId = 1, Name = "HR" },
    new Department { DepartmentId = 2, Name = "Finance" },
    new Department { DepartmentId = 3, Name = "Engineering" }
};

var employees = new List<Employee>
{
    new Employee { EmployeeId = 1, Name = "John", DepartmentId = 1 },
    new Employee { EmployeeId = 2, Name = "Alice", DepartmentId = 1 },
    new Employee { EmployeeId = 3, Name = "Bob", DepartmentId = 2 },
    new Employee { EmployeeId = 4, Name = "Eva", DepartmentId = 3 },
    new Employee { EmployeeId = 5, Name = "Michael", DepartmentId = 2 },
};

var result = departments.GroupJoin(
    employees,
    department => department.DepartmentId,
    employee => employee.DepartmentId,
    (department, employees) => new
    {
        DepartmentName = department.Name,
        Employees = employees.ToList()
    }
    ).ToList();


Console.WriteLine(JsonSerializer.Serialize(result));

public class Department
{
    public int DepartmentId { get; set; }
    public string Name { get; set; }
}

public class Employee
{
    public int EmployeeId { get; set; }
    public string Name { get; set; }
    public int DepartmentId { get; set; }
}
