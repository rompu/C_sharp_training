using System;
using System.Collections.Generic;

namespace WeightObjectTest
{
    class Program
    {

        static void Main(string[] args)
        {

            var weightModel = new WeightModel();

            weightModel.AddWeightList("Machinery");

            var machinery = weightModel.GetWeightList("Machinery");

            machinery.AddWeightItem("Main engine1");
            machinery.AddWeightItem("Main engine2");

            var mainEngine1 = machinery.GetWeightItem("Main engine1");
            var mainEngine2 = machinery.GetWeightItem("Main engine2");


            mainEngine1.Weight.Value = 1000;
            mainEngine2.Weight.Value = 2000;
            

            Console.WriteLine("total machinery weight {0} tonnes", machinery.Weight.Value);







        }
    }
}
