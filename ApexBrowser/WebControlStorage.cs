using ApexBrowser.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApexBrowser;

internal sealed class WebControlStorage
{
    #region Singleton
    public static WebControlStorage Instance { get; } = new();

    private WebControlStorage()
    {
    }

    static WebControlStorage()
    {
    }
    #endregion

    public event EventHandler WebControlSelected;
    public event EventHandler WebControlNavigationCompleted;

    private IWebControl activeWebControl;

    public IWebControl GetActiveWebControl() => activeWebControl;

    public void SetActiveWebControl(IWebControl webControl)
    {
        activeWebControl = webControl;

        WebControlSelected?.Invoke(null, EventArgs.Empty);
    }

    public void NotifyNavigationCompleted()
    {
        WebControlNavigationCompleted?.Invoke(null, EventArgs.Empty);
    }

}
