using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime;

namespace ApexBrowser.Interfaces
{
    public interface INavigationManager
    {
        public IWebControl GetActiveWebControl();

        public event EventHandler WebControlSelected;
        public event EventHandler WebControlNavigationCompleted;

    }
}
