using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;


namespace Book
{
    public class Book : IComparable<Book>
    {
        
        public string title;
        public string author;
        public string id;
        public double price;
        public Book()
        {
            this.title = string.Empty;
            this.author = string.Empty;
            this.id = string.Empty;
            this.price = 0;
        }
        public Book(string title, string author, string id, double price)
        {
            this.title = title;
            this.author = author;
            this.id = id;
            this.price = price;
        }

        public string getBookInformation()
        {
            return $"{this.author}, {this.title}, {this.id},{this.price:F2}";
        }
        public void SetId(string idValue)
        {
            this.id = idValue;

            if (idValue.Length == 5)
            {
                this.id = idValue;
            }
            else
            {
                this.id = "Not valid";
            }
        }
        public void CompareBook(Book book)
        {
            if (this.price > book.price)
            {
                Console.WriteLine($"{this.title} on kalliimpi kuin {book.title}");
            }
            else if (this.price < book.price)
            {
                Console.WriteLine($"{book.title} on kalliimpi kuin {this.title}");
            }
            else
            {
                Console.WriteLine($"{this.title} on samanhintainen kuin {book.title}");
            }
            Console.WriteLine($"Kutsuva olio: {this.title} {this.price}");

            Console.WriteLine($"Parametrinä tuleva olio: {book.title} {book.price}");
        }
        

        public int CompareTo([AllowNull] Book other)
        {
            return (this.price.CompareTo(other.price));
            //throw new NotImplementedException();
        }

        public override string ToString()
        {
            return $"{this.price},{this.title}";
        }
    }
}
