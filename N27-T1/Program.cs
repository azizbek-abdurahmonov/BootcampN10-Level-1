//var Authors = new List<Author>
//{
//    new Author {Id = 1,Name = "Gishtmat", Books = new List<string> { "Gishtmatolog hayoti", "Gishtmatlar armiyasi tarixi"} },
//    new Author {Id = 2, Name = "JohnDoe", Books = new List<string> {"Doelar oilasi", "john_book"}}
//};





//var result = Authors.Select(author => new { ID = author.Id, NAME = author.Name }).ToList();

//var fist = result[0];
//Console.WriteLine(fist.ID);



////var allBooks = Authors.SelectMany(x => x.Books);

//var allBooks = new List<string>();

//foreach(var author in Authors)
//{
//    foreach(var book in author.Books)
//    {
//        allBooks.Add(book);
//    }
//}

//allBooks.ToList().ForEach(Console.WriteLine);


//public class Author
//{
//    public int Id { get; set; }
//    public string Name { get; set; }
//    public List<string> Books { get; set; }
//}


//var nums = new List<string>
//{
//    "2", "12", "45", "ff"
//};

////var result = nums.Cast<int>().ToList(); // agar kolleksiyadagi biror element tipi to'g'ri kelmay qolsa exception
//var result = nums.OfType<int>().ToList();
//result.ForEach(Console.WriteLine);


// GroupBy - example N1

//using System.Text.Json;

//var articles = new List<Article>
//{
//    new Article("GIshtmatologiya", "Gishtmat"),
//    new Article("Raqamli qala", "JEck"),
//    new Article("Gishtmats familiy", "Gishtmat"),
//    new Article("Gishtmat kitobi", "Gishtmat")
//};

//var result = articles.GroupBy(
//        article => article.Author,
//        (author, articleGroup) => new
//        {
//            AuthorName = author,
//            Articles = articleGroup.Select(a => a.Title).ToList(),
//        }
//    ).ToList();

//Console.WriteLine(JsonSerializer.Serialize(result));


//public class Article
//{
//    public string Title { get; set; }
//    public string Author { get; set; }

//    public Article(string title, string author)
//    {
//        Title = title;
//        Author = author;
//    }
//}

// GroupBy - Example N2

//using System.Text.Json;
//using System.Text.Json.Serialization;

//var students = new List<Student>
//{
//    new Student {Name = "Qodirali", Age = 16},
//    new Student {Name = "John", Age = 20},
//    new Student {Name = "Odil", Age = 16}
//};

//var result = students.GroupBy(
//    student => student.Age,
//    (age, names) => new
//    {
//        Age = age,
//        Name = names.Select(x => x.Name).ToList()
//    }
//    );

//Console.WriteLine(JsonSerializer.Serialize(result));


//public class Student
//{
//    public string Name { get; set; }
//    public int Age { get; set; }
//}




// GroupJoin Example N1

using System.Text.Json;
using System.Text.Json.Serialization;

//var subjects = new List<string>
//{
//    "Math",
//    "History"
//};

var subjects = new List<Subject>
{
    new Subject {Id = 1, Name = "Math"},
    new Subject {Id = 2, Name = "Chemistry"},
    new Subject {Id = 3, Name = "History"}
};

var students = new List<Student>
{
    new Student {Name = "Azizbek", Subject = "Math"},
    new Student {Name = "Dostkn", Subject = "Chemistry"},
    new Student {Name = "Elyozbek", Subject = "History"},
    new Student {Name = "Behruz", Subject = "History"},
    new Student {Name = "Bekzod", Subject = "Math"}
};

var result = subjects.GroupJoin(
    students,
    subject => subject.Name,
    student => student.Subject,
    (subject, students) => new
    {
        Subject = subject.Name,
        Students = students.Select(x => x.Name)
    }
    );

Console.WriteLine(JsonSerializer.Serialize(result));


//GroupJoin
//var result = subjects.GroupJoin(
//    students,
//    subject => subject,
//    student => student.Subject,
//    (subject, students) => new
//    {
//        Subject = subject,
//        Students = students.Select(s => s.Name).ToList(),
//    }
//    );


//GroupBy
//var result = students.GroupBy(
//    student => student.Subject,
//    (subject, students) => new
//    {
//        Subject = subject,
//        Students = students.Select(s => s.Name).ToList()
//    }
//    );
//Console.WriteLine(JsonSerializer.Serialize(result));


public class Student
{
    public string Name { get; set; }
    public string Subject { get; set; }
}

public class Subject
{
    public int Id { get; set; }
    public string Name { get; set; }
}