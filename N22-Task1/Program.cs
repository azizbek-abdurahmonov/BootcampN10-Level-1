using N22_Task1;

var student1 = new Student<Guid, int>(Guid.NewGuid(), "Azizbek", 2);
var student2 = new Student<Guid, int>(Guid.NewGuid(), "Firdavs", 1);

var course1 = new Course(Guid.NewGuid(), "Bla bla bla");

var university = new University<Student<Guid, int>, Guid, int>();

university.EnrollStudent(student1, course1);
university.EnrollStudent(student2, course1);

university.Display();