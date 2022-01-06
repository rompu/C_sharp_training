using System;

namespace Interfaces2
{
    class Program
    {
        static void Main(string[] args)
        {
            var prVersion = new ProjectVersion();

    

        }
    }

    public class WeightObject{

        private readonly IProjectVersion projectVersion;

        public WeightObject(IProjectVersion projectVersion)
        {
            this.projectVersion = projectVersion;
        }
    }

    public class ProjectVersion : IProjectVersion
    {
        public int Version { get; set; }
        public string Comment { get; set; }
    }

    public class WMeasure
    {
        private double _value;
        private string _unit;
    
    public void SetMeasurable(double value)
        {
            //implementation
        }
    }
}
