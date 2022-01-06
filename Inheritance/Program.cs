using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {

            var plate1 = new Plate();
            plate1.Modulus = 210000;
            plate1.Density = 7850; //kg/m^3
            Console.WriteLine(plate1.Modulus);
            Console.WriteLine(plate1.GetWeight());
        }
    }
    class Material
    {   
        public string Name { get; private set; }
        public double Density { get; set; }
        public double Modulus { get; set; }

        public void SetNameOfMaterial(string name)
        {
            this.Name = name;
        }

    }
    class Plate : Material
    {
        
        public double Thickness { get; set; }

        public void GiveCornerCoordinates(double[] plateCorners)
        {
            //some code goes here
        }

        public double GetWeight()
        {

            double plateVolume = 1000;
            return Density * plateVolume;
        }
    }
}
        
