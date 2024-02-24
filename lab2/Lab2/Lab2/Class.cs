using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class Book
    {
        public string Title {  get; set; }
        public string Author { get; set; }
        public int NumOfPages { get; set; }

        public Book(string title, string author) 
        {
            this.Title = title;
            this.Author = author;
        }

        public Book(string titile, string author, int numOfPages) 
        {
            this.Title = titile;
            this.Author = author;
            this.NumOfPages = numOfPages;
        }

        public override string ToString()
        {
            if (NumOfPages == 0)
            {
                return $"Title: {Title} Author: {Author}";
            }
            else
            {
                return $"Title: {Title} Author: {Author} Pages: {NumOfPages}";

            }
        }
    }
}
