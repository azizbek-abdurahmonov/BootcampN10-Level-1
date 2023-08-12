namespace N23_T2;

public class Book
{
    public string Name { get; set; }
    public int Rating { get; set; }
    public string Author { get; set; }

    public Book(string name, int rating, string author)
    {
        Name = name;
        Rating = rating;
        Author = author;
    }
    
    public override string ToString()
    {
        return $"{Author} - {Name} {Rating}";
    }
}