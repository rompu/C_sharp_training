using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moq
{
    public class Program
    {
        static void Main(string[] args)
        {
            var model = new WeigthObjectViewModel();
            model.AddChild();
            Console.WriteLine(model.Children.Count());

        }
    }
}
