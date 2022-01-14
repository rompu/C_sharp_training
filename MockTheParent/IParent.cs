using System.Collections.Generic;

namespace MockTheParent
{
    public interface IParent
    {
        List<Child> Children { get; }

        void AddChild(Child child);
    }
}