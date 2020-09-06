using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibary02092020
{
    class MyLibrary
    {
        private Dictionary<string, Book> _books;
        public MyLibrary()
        {
            _books = new Dictionary<string, Book>();
        }
        public bool AddBook(Book book)
        {
           // if (_books.ContainsKey(book.Title))
           //     return false;
            _books.Add(book.Title, book);
            return true;

        }

        public bool RemoveBook(string title)
        {
            if (_books.ContainsKey(title))
            {
               
                _books.Remove(title);
                return true;
            }
                return false;

        }

        public bool HaveThisBook(string title)
        {
            if (_books.ContainsKey(title))
            {
                return true;
            }
            return false;

        }

        public Book GetBook(string title)
        {
            if (_books.ContainsKey(title))
            {
                return _books[title];
            }
            return null;

        }

        public Book GetBookByAuthor(string author)
        {
            foreach (KeyValuePair<string, Book> book in _books)
            {
                if (book.Value.Author == author)
                    return book.Value;
            }

            return null;
        }

        public void Clear()
        {
            _books.Clear();
        }

        public List<string> GetAuthors()
        {
            List<string> authors = new List<string>();
            foreach (KeyValuePair<string, Book> book in _books)
            {
                authors.Add(book.Value.Author);
            }

            return authors;

        }

        
            public List<Book> GetBooksSortedByAuthorName()
        {
            List<string> authors = GetAuthors();
            authors.Sort();
            List<Book> books = new List<Book>();
            foreach (string author in authors)
            {
                books.Add(GetBookByAuthor(author));
            }

            return books;

        }

        public List<string> GetBooksTitleSorted()
        {
            List<string> books_title = new List<string>();
            foreach (KeyValuePair<string, Book> book in _books)
            {
                books_title.Add(book.Value.Title);
            }
            books_title.Sort();
            return books_title;

        }

        public int Count { 
            get

            {
                return _books.Count;
            } 
        }

        public override string ToString()
        {
            string str="";
            foreach (KeyValuePair<string, Book> book in _books)
            {
                str += book.ToString();
            }

            return str;
        }

    }
}
