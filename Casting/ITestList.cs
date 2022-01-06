using System;
using System.Collections.Generic;
using System.Text;

namespace Casting
{
    public interface ITestList
    {
        public List<int> List { get; set; }
        public void Add();
    }
}
