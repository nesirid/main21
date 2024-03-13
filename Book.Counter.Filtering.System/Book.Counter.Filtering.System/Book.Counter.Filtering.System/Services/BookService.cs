using System;
using System.Collections.Generic;

namespace Book.Counter.Filtering.System.Services
{  
    class BookService
    {
        // Delegatin predelekati
        public delegate bool PredicateDelegate(Books book);

        // Nizami ni tapan metod
        public static int CountBooksByAuthor(List<Books> books, PredicateDelegate predicate)
        {
            int count = 0;
            foreach (var book in books)
            {
                if (predicate(book))
                {
                    Console.WriteLine($"ID - {book.Id}, Adi: - {book.Title} : Muellifi: - {book.Author} ");
                    count++;
                }
            }
            return count;
        }
    }
}
