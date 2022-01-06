using System;
using System.Collections.Generic;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            var arrangement = new Arrangement();
            List<int> list=arrangement.PopulateList();
            Console.WriteLine(list.Count);
        }
    }

    public interface IHierarchicalArrangement:IGeneralObject
    {
        public int Id { get; set; }

        public void AddArrangement();

        //IHierarchicalArrangement AddSubArrangement(string name);
    }
    public interface IGeneralObject
    {
        public string Name { get; set; }
    }
        class DefaultArrangement
    {
        public int Id { get; set; }
        public string Type { get; set; }
    }

    class Arrangement : IHierarchicalArrangement
    {
        public string Name { get; set; }
        public int Id { get; set; }
        private List<int> _list = new List<int>(); 
        public void AddArrangement()
        {
            Console.WriteLine("Arrangement added");
        }

        public List<int> PopulateList()
        {
            List<int> list = new List<int>();

            for(int i = 1; i<=20; i++)
            {
                list.Add(i);
            }

            return list;
        }
        
        //IHierarchicalArrangement AddSubArrangement(string name)
        //{
        //    return new IHierarchicalArrangement();
        //}
    }
}
