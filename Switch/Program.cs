using System;

namespace Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert a number 1, 2 or 3:");
            int switchCase = Convert.ToInt32(Console.ReadLine());

            switch (switchCase)
            {
                case 1:
                    Console.WriteLine("Case 1");
                    break;
                case 2:
                    Console.WriteLine("Case 2");
                    break;
                case 3:
                    Console.WriteLine("Case 3");
                    break;
            }


        }
    }
}
