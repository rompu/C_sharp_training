using System;
using System.Collections.Generic;

namespace Internal
{
    class Internal
    {
        static void Main(string[] args)
        {
            var library = new Library();
            library.Name = "ABC";
            var libraryList = new LibraryList();
            var list = libraryList.GetLibraryList();
            list.ForEach(l => Console.WriteLine(l.Name));
        }
    }

    public class LibraryList
    {
        public List<ILibrary> GetLibraryList()
        {

            return new List<ILibrary> { new Library { Name = "Tapiola" }, new Library { Name = "Haukilahti" } };
        }
    }
    internal class Library : ILibrary //internal access modifier means that it is only accessible withing this assembly
    {
        public string Name { get; set; } //properties defined in interface cannot be made internal or private
        private string Address { get; set; }//if the address is set to private it cannot be accessed from outside class
    }

    public interface ILibrary
    {
        string Name { get; set; }
    }
}
