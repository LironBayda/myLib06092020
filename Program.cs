using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibary02092020
{
    class Program
    {
        static void display_books(List<Book> books)
        {
            foreach (Book book in books)
            {
                Console.WriteLine(book.ToString());
            }
        }
        static void Main(string[] args)
        {
            MyLibrary myLibrary = new MyLibrary();
            Book book1 = new Book("title1", "content1", "r author1", " category1");
            Book book2 = new Book("title2", "content2", "a author2", " category2");
            Book book3 = new Book("title3", "content3", "b author3", " category3");

            myLibrary.AddBook(book1);
            myLibrary.AddBook(book2);
            myLibrary.AddBook(book3);
            myLibrary.AddBook(book3);

            Console.WriteLine(myLibrary.ToString());


            Console.WriteLine(myLibrary.GetBookByAuthor("a author2").ToString());

            List<Book> books = myLibrary.GetBooksSortedByAuthorName();
            display_books(books);
            Console.ReadLine();

        }
    }
}
