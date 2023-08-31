using System.Globalization;
using System.Text.Json;
using System.Threading.Channels;
using N31_Amaliyot1.Models;

string StudenPath = @"D:\PROJECTS\BootcampN10-Level-1\N31-Amaliyot1\DataLayer\Student.json";
string LocationPath = @"D:\PROJECTS\BootcampN10-Level-1\N31-Amaliyot1\DataLayer\Location.json";
string SpecialityPath = @"D:\PROJECTS\BootcampN10-Level-1\N31-Amaliyot1\DataLayer\Speciality.json";

var students = JsonSerializer.Deserialize<List<Student>>(File.ReadAllText(StudenPath));
var locations = JsonSerializer.Deserialize<List<Location>>(File.ReadAllText(LocationPath));
var specialities = JsonSerializer.Deserialize<List<Speciality>>(File.ReadAllText(SpecialityPath));

var a = DateTime.Parse("10/05/2000");


// //Task - 1
// var result = specialities.GroupJoin(
//     students,
//     s => s.id,
//     student => student.speciality_id,
//     (speciality, students) => new
//     {
//         Speciality = speciality,
//         Students = students.ToList().Count
//     }
//     );
//     
// Console.WriteLine(JsonSerializer.Serialize(result));     

// //Task - 2
// var result = locations.GroupJoin(
//     students,
//     x => x.id,
//     s => s.location_id,
//     (location, students) => new
//     {
//         Location = location,
//         AverageAge = students.Average(x =>
//             (DateTime.Now.Year - ParseCrack(x.birth_day).Year))
//     }
// );
//
// DateTime ParseCrack(string date)
// {
//     var d = date.Split('/');
//     return DateTime.Parse($"{d[1]}/{d[0]}/{d[2]}");
// }
//
// Console.WriteLine(JsonSerializer.Serialize(result));

//Task - 3
var firstJoin = specialities.Join(
    students, 
    s => s.id,
    x => x.speciality_id,
    (speciality, student) => new
    {
        Speciality = speciality,
        Student = student,
    }
);

var result = locations.Join(
    firstJoin,
    l => l.id,
    f => f.Student.location_id,
        (l, f) => new
        {
            Student = f.Student,
            Speciality = f.Speciality,
            Location = l
        }
);


Console.WriteLine(JsonSerializer.Serialize(result));