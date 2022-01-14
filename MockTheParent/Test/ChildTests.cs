using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MockTheParent.Test
{[TestFixture]
    public class ChildTests
    {
        [Test]
        public void ChildShouldBeAddedToListInParentWhenAdding()
        {
            var parentMock = new Mock<IParent>();
            var testChild = new Child(parentMock.Object);
            parentMock.Setup(p => p.Children).Returns(new List<Child>());

            testChild.Add();
            parentMock.Verify(pm => pm.AddChild(It.IsAny<Child>()), Times.Once);
        }
    }
}
