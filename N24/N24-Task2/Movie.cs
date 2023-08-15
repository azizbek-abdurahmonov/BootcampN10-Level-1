namespace N24_Task2;

public class Movie
{
    public string name { get; set; }
    public string author { get; set; }
    public int rating { get; set; }

    public Movie(string name, string author, int rating)
    {
        this.name = name;
        this.author = author;
        this.rating = rating;
    }

    public override string ToString()
    {
        return $"{name} {author} {rating}";
    }
}