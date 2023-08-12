using N23_T2;

var books = new List<Book>
{
    new Book("Dunyoning ishlari", 7, "O'tkir Hoshimov"),
    new Book("Raqamli qal'a", 8, "Secret"),
    new Book("Daftar HB", 10, "O'tkir Hoshimov"),
    new Book("first book", 6, "Author name"),
};

var sortedBooks = books.OrderByDescending(book => book.Rating);

Console.WriteLine(sortedBooks.First(book => book.Author == "O'tkir Hoshimov"));
Console.WriteLine(sortedBooks.Last(book => book.Author == "O'tkir Hoshimov"));