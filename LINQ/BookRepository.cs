using System.Collections.Generic;
using System;


namespace LINQtraining
{
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
