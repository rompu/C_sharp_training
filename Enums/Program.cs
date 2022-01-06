using System;

namespace Enums
{// Enums are to create sting-value pairs
    public enum StiffenerType
    {
        Flatbar=1,
        Bulb=2,
        Anglebar=3
    }
    class Program
    {
        static void Main(string[] args)
        {
            var stiffener = StiffenerType.Flatbar;

            Console.WriteLine((int)stiffener);//cast Stiffener type into integer
            Console.WriteLine(stiffener.ToString()); //convert enum to string (acutally console.writeline does this automatically)

            Console.WriteLine((StiffenerType)3); //cast integer into Stiffenertype

            var stiffenerName = "Bulb";
            var stiffenerType=(StiffenerType)Enum.Parse(typeof(StiffenerType), stiffenerName); //change a string into StiffenerType enumration
            Console.WriteLine((int)stiffenerType);
        }
    }
}
