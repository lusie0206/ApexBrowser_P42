using ApexBrowser.Interfaces;
using Microsoft.Web.WebView2.WinForms;

namespace ApexBrowser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            WebControlStorage.Instance.WebControlSelected += Instance_WebControlSelected;
            WebControlStorage.Instance.WebControlNavigationCompleted += Instance_WebControlNavigationCompleted;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SetInitialStateForNavigationPanel();
        }

        private void SetInitialStateForNavigationPanel()
        {
            navigationControl1.UpdateNavigationPanel(false, false, string.Empty);
        }

        private void Instance_WebControlSelected(object? sender, EventArgs e)
        {
            UpdateNavigationPanel();
        }

        private void Instance_WebControlNavigationCompleted(object? sender, EventArgs e)
        {
            UpdateNavigationPanel();
        }

        private void UpdateNavigationPanel()
        {
            if (GetWebControl() is IWebControl webControl && webControl.GetWebView2Instance() is WebView2 webView2Element)
            {
                bool canGoBack = webView2Element.CanGoBack;
                bool canGoForward = webView2Element.CanGoForward;
                string actualUrl = webControl.GetActualUrl();

                navigationControl1.UpdateNavigationPanel(canGoBack, canGoForward, actualUrl);
            }
        }

        private void buttonTest_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Add(new WebControl() { Width = 400, Height = 300 });
        }

        #region Navigation
        private IWebControl GetWebControl() => WebControlStorage.Instance.GetActiveWebControl();

        

        #endregion

    }
}
