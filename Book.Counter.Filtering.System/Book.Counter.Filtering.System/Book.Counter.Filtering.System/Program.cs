using Book.Counter.Filtering.System.Services;

class Program
{
    static void Main(string[] args)
    {
        // Burda Kitablarimiz var
        List<Books> books = new List<Books>
        {
            new Books { Title = "Xosrov ve Sirin", Author = "Nizami", Id = 1 },
            new Books { Title = "Leyli ve Mejnun", Author = "Nizami", Id = 2 },
            new Books { Title = "Hoja Nesreddin Divani", Author = "Hoja Nesreddin", Id = 3 },
            new Books { Title = "Iskendername", Author = "Nizami", Id = 4 },
            new Books { Title = "Şerqin neğmeleri", Author = "Molla Penah Veli", Id = 5 }
        };

        // Predicate yaradirig ki Nizamini siyahidan tapag authordan 
        BookService.PredicateDelegate predicate = book => book.Author == "Nizami";

        // Kitablar servisi vasitesi ile Nizami müellifinin kitablarinin sayini aliriq.
        int count = BookService.CountBooksByAuthor(books, predicate);

        Console.WriteLine($"Nizami Gencevinin kitablarinin sayi: {count}");
    }
}