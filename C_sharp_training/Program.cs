using System;

namespace C_sharp_training
{
    class Program
    {
        static void Main(string[] args)
        {
            Stiffener stiffener = new Stiffener();
            Console.WriteLine("Insert Y,Z doordinates");
            var yz=Console.ReadLine();
            var yz_vec=yz.Split(",");
            var y = Convert.ToDouble(yz_vec[0]);
            var z = Convert.ToDouble(yz_vec[1]);

            stiffener.SetCoordinates(y, z);

            var coordVec = stiffener.GetCoordinates();

            foreach(var dim in coordVec)
            { Console.WriteLine(dim); }
           
        }
    }
}
