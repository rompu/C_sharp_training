using System;

namespace Exception_handling
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = "Kristoffer";
            var engine = new WeightItem();
            double[] test = new double[3];

            var classPath=Convert.ToString(engine.GetType()).Split(".");
            if (classPath[classPath.Length - 1] != "WeightObject")
                throw new ArrayTypeMismatchException("Attribute must be of WeightObject type");

            Console.WriteLine(name.GetType()); 
            Console.WriteLine(engine.GetType()); 
            Console.WriteLine(engine.GetHashCode()); 
        }
        
    }
    class WeightObject
    {

    }
    class WeightItem
    {

    }
}
