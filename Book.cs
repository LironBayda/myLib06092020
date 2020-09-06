using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibary02092020
{
    class Book
    {
        public string Title { get; private set; }
        public string Content { get; private set; }
        public string Author { get; private set; }
        public string Category { get; private set; }

        public Book(string title, string content, string author, string category)
        {
            Title = title;
            Content = content;
            Author = author;
            Category = category;
        }

        public override string ToString()
        {
            return base.ToString() + $"{Title}  { Content}   { Author}  { Category}";
        }
    }
}
