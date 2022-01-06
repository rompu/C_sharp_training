using System;
using System.Collections.Generic;
namespace Indexers
{
    class Program
    {
        static void Main(string[] args)
        {
            var weightItem = new WeightItem();

            weightItem["W"] = 10000.5;
            weightItem["VCG"] = 15.2;

            Console.WriteLine(weightItem["W"]);
        }
    }
    class WeightItem
    {
        private Dictionary<String, Double> _weight = new Dictionary<String, Double>(); //setting a privaet field

        public double this[string key]
        {
            get { return _weight[key]; }
            set { _weight[key] = value; }
        }

    }
}
