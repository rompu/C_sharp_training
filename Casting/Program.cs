using System;

namespace Casting
{
    class Program
    {
        static void Main(string[] args)
        {
            var lista = new TestCollection() as ITable;
        }
    }
}
