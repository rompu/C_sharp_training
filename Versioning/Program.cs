using System;
using System.Collections.Generic;
using System.Linq;

namespace Versioning
{
    class Program
    {

        public int CurrentWVersion { get; set; }
        static void Main(string[] args)
        {
            
            var wObject = new WeightObject(1);
            wObject.AddWeight(100,1);
            wObject.AddWeight(200,2);

            wObject.ShowHistory();
        }
    }
    public class WeightManager
    {


    }

    public class WeightObject
    {

        private int _version; 
        public WeightObject(int version)
        {
            Weight = new Dictionary<int, double>();
            Version = version;
        }
        public Dictionary<int, double> Weight { get; set; }
        public int Version { get{return _version;} set { _version =value; } }

        public double GetWeight(int version)
        {
            var weight = new double();
            Weight.TryGetValue(version, out weight);
            return weight;
        }

        public void AddWeight(double weight, int version)
        {
            Weight.Add(version, weight);
        }

        public void ShowHistory()
        {
            foreach(KeyValuePair<int,double> entry in Weight)
            {
                Console.WriteLine(entry.Key+" "+entry.Value);
            }
        }
    }
}
