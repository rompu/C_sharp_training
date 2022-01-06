using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;

namespace temp
{
    class Temp
    {

        public int MyProperty { get; set; }
        static void Main(string[] args)
        {
            var parameters = new Dictionary<string, double>();
            parameters.Add("L", 100);
            parameters.Add("B", 20);
            var converter = new Converter();
            var equation = "L*B+10";
            var test = nameof(MyProperty);
            var numericalEquation = converter.Convert(equation, parameters);
            Console.WriteLine(numericalEquation);
        }

    }

    class Converter
    {

        public string Convert(string equation, Dictionary<string, double> parameters)
        {
            foreach(var parameter in parameters)
            {
                if (equation.Contains(parameter.Key))
                    equation = equation.Replace(parameter.Key, parameter.Value.ToString()); 
            }
            return equation;
        }
    }

}


