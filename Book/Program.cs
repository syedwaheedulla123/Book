using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book
{public class Book {
        private string AuthorName;
        private string Title;
        private double Price;

        public Book(string authorName, double price, string title)
        {
            AuthorName = authorName;
            Price = price;
            Title = title;
        }

        public void DisplayDetails() {
            Console.WriteLine("The author name is " + AuthorName + "\nBook title is " + Title + "\nBook price is " + Price);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Book obj = new Book("Martin", 229.45, "Game of thrones");
            obj.DisplayDetails();

        }
    }
}
