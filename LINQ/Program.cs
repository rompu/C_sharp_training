using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            var books = new BookRepository();

            var cheapBooks = books.Where(b => b.Price < 10);
  
        }
    }

    public class Book
    {
        public string Title { get; set; }
        public float Price { get; set; }
    }
}
