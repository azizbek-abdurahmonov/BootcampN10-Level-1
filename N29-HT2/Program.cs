using N29_HT2.Models;
using N29_HT2.Services;

var e1 = new Employee("Azizbek", "Abdurahmonov", "abdura52.uz@gmail.com");
var service = new EmployeeService();
await service.HireAsync(e1);

