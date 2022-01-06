using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moq
{
    [TestClass]
    public class WeightListViewModelTests
    {
        private bool _eventRaised;
        [TestMethod]
        public void RaiseEvent()
        {
            var weightObjectViewModelMock = new Mock<WeigthObjectViewModel>(); //normally would mock interface
            weightObjectViewModelMock.Raise(w => w.ChildAdded += weightObjectViewModelChildAdded);
            Assert.IsTrue(_eventRaised);
        }

        private void weightObjectViewModelChildAdded(object sender, EventArgs e)
        {
            _eventRaised = true;
        }


    }
}
