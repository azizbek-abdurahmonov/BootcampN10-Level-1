using N27.Models;

var dbContext = new EFCoreContext();

var person = new PersonDB()
{
    Login = "admin2",
    Age = 95,
    Email = "admin2@gm.com",
};

//dbContext.Person.Add(person);


var person2 = new PersonDB()
{
    Login = "Gishtmat",
    Email = "GishtmatOfficial@gmail.com",
    Age = 19
};

dbContext.Person.Add(person2);
dbContext.SaveChanges();


