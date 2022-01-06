using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moq
{
    public class WeigthObjectViewModel
    {

        public WeigthObjectViewModel()
        {
            Children = new List<WeigthObjectViewModel>();
        }
        public IEnumerable<WeigthObjectViewModel> Children { get; set; }
        public event EventHandler ChildAdded;

        public void AddChild()
        {
            var childList = Children as List<WeigthObjectViewModel>;
            childList.Add(new WeigthObjectViewModel());
            OnChildAdded();
        }

        protected virtual void OnChildAdded()
        {
            ChildAdded?.Invoke(this, EventArgs.Empty);
        }
    }
}
