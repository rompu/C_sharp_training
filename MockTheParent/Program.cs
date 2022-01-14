using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MockTheParent
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class Parent : IParent
    {
        public List<Child> Children { get; }

        public void AddChild(Child child)
        {
            Children.Add(child);
        }
    }

    public class Child
    {
        public Child(IParent parent)
        {
            Parent = parent;
        }

        public IParent Parent { get; set; }

        public void Add()
        {
            Parent.AddChild(new Child(Parent));
        }
    }
}
