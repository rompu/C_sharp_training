using System;
using System.Collections.Generic;
using System.Text;

namespace Casting
{
    public class TestCollection : ITable, ITestList
    {
        public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Size { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public List<int> List { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Add()
        {
            throw new NotImplementedException();
        }
    }
}
