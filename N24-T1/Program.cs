using System.Text.Json;
using System.Text.Json.Serialization;
using N24_T1;
using Newtonsoft.Json;

var path = @"D:\PROJECTS\BootcampN10-Level-1\N24-T1\person.txt";

//json formatda faylga yozish

var persons = new List<Person>
{
    new Person { Id = 1, Name = "Gishtmat", Age = 909 },
    new Person { Id = 2, Name = "Johnbek", Age = 50 }
};

var jsonPerson = JsonConvert.SerializeObject(persons, Formatting.Indented);  
using (StreamWriter sw = new StreamWriter(path))
{
    sw.Write(jsonPerson);
}

//fayldan o'qish

// var persons = new List<Person>();
// using (StreamReader sr = new StreamReader(path))
// {
//     persons = JsonSerializer.Deserialize<List<Person>>(sr.ReadToEnd());
//
//     foreach (var people in persons)
//     {
//         Console.WriteLine($"{people.Id} : {people.Name}, {people.Age}");
//     }
// }


