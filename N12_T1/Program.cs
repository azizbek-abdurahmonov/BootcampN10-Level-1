var movies = new[]
{
     "Inception",
    "Dark Knight",
    "Top Gun 2",
    "Don't Look Up",
    "Top Gun"
};

for (var i = 0; i < movies.Length; i++)
{
    for (var j = 0; j < movies.Length; j++)
    {
        if (movies[i].CompareTo(movies[j]) == -1)
        {
            var temp = movies[i];
            movies[i] = movies[j];
            movies[j] = temp;   
        }
    }
}

Console.WriteLine("O'sish tartibida");

foreach(var m in movies)
{
    Console.WriteLine(m);
}

for (var i = 0; i < movies.Length; i++)
{
    for (var j = 0; j < movies.Length; j++)
    {
        if (movies[i].CompareTo(movies[j]) == 1)
        {
            var temp = movies[i];
            movies[i] = movies[j];
            movies[j] = temp;
        }
    }
}


Console.WriteLine("kamayish tartibida");

foreach (var m in movies)
{
    Console.WriteLine(m);
}