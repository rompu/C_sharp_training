using System;

namespace Static_methods
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(Calculator.Add(1.34, 8));
        }
    }
    public class Calculator
    {

        // not possible to declare instance memebers if class is static such as "public int exampleNumber;"
        public static double Add(double number1, double number2)
        {
            return number1 + number2;
        }
    }
}
