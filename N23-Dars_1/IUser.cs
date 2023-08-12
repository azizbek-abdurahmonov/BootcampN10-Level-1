public interface IUser
{
    string Name { get; set; }
    string Surname { get; set; }
    int Age { get; set; }

    string ToString();
}