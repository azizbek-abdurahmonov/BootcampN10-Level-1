namespace N24_Task1;

public class EmployeeService
{
    private List<Employee> _employees;

    public EmployeeService() => _employees = new List<Employee>();


    public List<Employee> GetBySalary(int pageSize, int pageToken)
    {
        return _employees.Skip((pageToken - 1) * pageSize).Take(pageSize).OrderByDescending(e => e.Salary).ToList();
    }

    public void Add(Employee employee)
    {
        _employees.Add(employee);
    }

}