using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Sample
{
    internal class Book
    {

        public string author;
        public string title;
        public int pages;

        // Contructor

        public Book() { }
        public Book(string aAuthor,string aTitle ,int aPages) {
            //Console.WriteLine("Creating Book");
            title = aTitle;
            author = aAuthor;   
            pages = aPages;
        }
    }
}
