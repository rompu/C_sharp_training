using System;
using System.Collections.Generic;
using System.Linq;

namespace Stuff
{
    class Program
    {
        static void Main(string[] args)
        {
            var lista = new List<int> { 1, 2, 3, 4, 5, 6 };

            var mindreSifforor= lista.Where(x => x < 3).ToList();

            var selectTest = lista.Select(x => "Nummer: "+x.ToString()).ToList();

            mindreSifforor.ForEach(x => Console.WriteLine(x));
            selectTest.ForEach(x => Console.WriteLine(x));
            
        }
        

    }



}
