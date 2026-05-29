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



}
