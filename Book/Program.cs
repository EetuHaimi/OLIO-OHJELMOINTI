using System;
using System.Collections.Generic;


namespace Book
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Book Exercise");
            Book book1 = new Book();
            book1.title = "Matematiikka 1";
            book1.SetId("73737");
            book1.price = 14.9;
            Console.WriteLine("Ensimmäinen kirja: " + book1.getBookInformation());

            Book book2 = new Book();
            book2.title = "Kokkikirja";
            book2.SetId("8484");
            book2.price = 78.0;
            Console.WriteLine("Toinen kirja: " + book2.getBookInformation());

            Book book3 = new Book();
            book3.title = "Harry potter";
            book3.SetId("45673");
            book3.price = 55.0;

            Console.WriteLine("Kolmas kirja: " + book3.getBookInformation());

            book3.CompareBook(book2);

            book2.CompareBook(book3);

            book1.CompareBook(book2);

            List<Book> books = new List<Book>();
            books.Add(new Book("Kirjavaan", "Jamppa", "4345", 55.9));
            books.Add(new Book("Kirjjaja", "Jami", "48457", 95.4));
            books.Add(new Book("Tossaja", "Jamppa", "4375", 55.0));
            books.Add(new Book("Miron elämä", "Miro Ite", "4200", 19.5));
            books.Sort();
            foreach (Book book in books)
            {
                Console.WriteLine(book.ToString());

            }




        }
    }
}
