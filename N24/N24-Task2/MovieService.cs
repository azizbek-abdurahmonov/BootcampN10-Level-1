namespace N24_Task2;

public class MovieService
{
    private List<Movie> _movies;

    public MovieService() => _movies = new();

    public List<Movie> Search(string searchKeyword)
    {
        return _movies.Where(movie =>
        {
            return movie.name.ToLower().Contains(searchKeyword.ToLower()) ||
                   movie.author.ToLower().Contains(searchKeyword.ToLower());
        }).ToList();
    }

    public void Add(string name, string author, int rating)
    {
        if (!_movies.Any(m => m.name == name && m.author == author && m.rating == rating))
            _movies.Add(new Movie(name, author, rating));
    }

    public List<Movie> GetByMovie()
    {
        return _movies.OrderBy(m => m.rating).ToList();
    }
}