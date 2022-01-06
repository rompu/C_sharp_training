using System;
using System.Collections.Generic;
using System.Linq;

namespace TestingLINQ
{
    class Program
    {

        static void Main(string[] args)
        {
            var books = new BookRepository().GetBooks();

            //LINQ Query operators (equivalent to extension methdos but slightly more resoruce intensive(there are not keywords for every extension method)) 
            var cheapBooks0 =
                from b in books
                where b.Price < 10
                orderby b.Title
                select b.Title;


            //LINQ extension methods
            var cheapBooks = books
                    .Where(b => b.Price < 10)
                    .OrderBy(b=>b.Title)
                    .Select(b=>b.Title);

            foreach (var book in cheapBooks)
            {
                Console.WriteLine(book);
                //Console.WriteLine(book.Title+" "+ book.Price);
            }

            var book2=books.SingleOrDefault(b => b.Title == "ASP.NET MVC"); //gets the single book with this title

            Console.WriteLine(book2.Title);

            var book3 = books.First(b => b.Title == "C# advanced topics");

        }

        public class Book
        {
            public string Title { get; set; }
            public float Price { get; set; }
        }
        public class BookRepository
        {
            public IEnumerable<Book> GetBooks() //IEnumerable is read only so you cannot add items such as when using List
            {
                return new List<Book>
            {
                new Book() {Title="ADO.Net step by step", Price = 5},
                new Book() {Title="ASP.NET MVC", Price = 9.99f},
                new Book() {Title="ASP.NET Web API", Price = 12},
                new Book() {Title="C# Advanced Topics", Price =7},
                new Book() {Title="C# Advanced Topics", Price =9}
            };
            }
        }
    }
}
