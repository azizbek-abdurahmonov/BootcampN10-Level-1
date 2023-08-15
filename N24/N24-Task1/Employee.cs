using System.Security.Cryptography.X509Certificates;

namespace N24_Task1;

public class Employee
{
    public int id { get; set; }
    public string firstName { get; set; }
    public string lastName { get; set; }
    public int Salary { get; set; }
    public int kpi { get; set; }

    public Employee(int id,string firstName, string lastName, int salary, int kpi)
    {
        this.id = id;
        this.firstName = firstName;
        this.lastName = lastName;
        Salary = salary;
        this.kpi = kpi;
    }

    public override string ToString()
    {
        return $"{id}. {firstName} {lastName} {Salary} {kpi}";
    }
}