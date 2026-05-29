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
        }


        private void Instance_WebControlSelected(object? sender, EventArgs e)
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

                buttonBack.Enabled = canGoBack;
                buttonForward.Enabled = canGoForward;
                textBoxUrl.Text = actualUrl;
            }
        }

        private void buttonTest_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Add(new WebControl() { Width = 400, Height = 300 });
        }

        #region Navigation
        private IWebControl GetWebControl() => WebControlStorage.Instance.GetActiveWebControl();


        private void buttonBack_Click(object sender, EventArgs e)
        {
            GetWebControl()?.GoBack();
        }

        private void buttonForward_Click(object sender, EventArgs e)
        {
            GetWebControl()?.GoForward();
        }

        private void buttonReload_Click(object sender, EventArgs e)
        {
            GetWebControl()?.Reload();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            GetWebControl()?.Navigate(textBoxUrl.Text);
        }

        private void textBoxUrl_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                GetWebControl()?.Navigate(textBoxUrl.Text);
            }
        }

        #endregion
    }
}
