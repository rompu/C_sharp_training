using System;
using System.Collections.Generic;
namespace ListFunctionality
{
    class Program
    {
        static void Main(string[] args)
        {
            var testList = new List<(double, double)>();
            var testList2 = new List<double[]>();

            var array = new double[2];
            array[0] = 8;
            array[1] = 7;


            testList2.Add(array);
            Console.WriteLine(array[1]);

            Console.WriteLine("testlist2: " + testList2[0][0]);

            testList.Add((1.2, 13));            
            testList.Add((1.3, 14));
            testList.Add((1.6, 15));

            Console.WriteLine("testlist: " + testList[0].Item1);

            for(int i=0; i < testList.Count; i++)
            {
                Console.WriteLine(testList[i]);

            }

        }

       
    }
}
