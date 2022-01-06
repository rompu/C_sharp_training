using System;

namespace Properties
{
    class Program
    {
        static void Main(string[] args)
        {  
            var person = new Person(new DateTime(1983, 6, 15));
            person.Name = "Kristoffer";
            var myAge = person.Age;
            Console.WriteLine("{0}'s age is {1} years", person.Name, person.Age);
        }
    }
}
