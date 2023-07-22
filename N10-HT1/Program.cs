var book1 = new Book()
{
    Id = Guid.NewGuid(),
    Title = "Sariq devni minib",
    Author = "Xudoyberdi To'xtaboyev"
};

var book2 = new Book()
{
    Id = Guid.NewGuid(),
    Title = "Raqamli Qal'a",
    Author = "Dan Brown",
};

var book3 = new Book()
{
    Id = Guid.NewGuid(),
    Title = "Dunyoning ishlari",
    Author = "O'tkir Hoshimov"
};

#region Kitoblarni qo'shamiz
var library = new LibraryManagement();
library.Books.Add(book1, 5);
library.Books.Add(book2, 2);
library.Books.Add(book3, 0);
#endregion


// tekshiramiz
Console.WriteLine($"{book2.Title} kitobi misolida tekshiramiz\nUndan hozir unda 2 ta nusxa bor");
Console.WriteLine($"{library.Checkout(book2.Id)} - bitta nusxa muvaffaqiyatli olindi");
Console.WriteLine($"{library.Checkout(book2.Id)} - ikkinchi nusxa ham muvaffaqiyatli olindi");
Console.WriteLine($"{library.Checkout(book2.Id)} - Nusxalar qolmaganligi uchun False qaytardi");




public class Book
{
    public Guid Id;
    public string Title;
    public string Author;

}

public class LibraryManagement
{
    public Dictionary<Book, int> Books = new Dictionary<Book, int>();

    public bool Checkout(Guid bookId)
    {
        foreach (var book in Books)
        {
            if (book.Key.Id == bookId && book.Value > 0)
            {
                Books[book.Key] = book.Value - 1;
                return true;
            }

        }
        return false;
    }
}
