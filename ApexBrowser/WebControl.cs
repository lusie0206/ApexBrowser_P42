using ApexBrowser.Interfaces;
using Microsoft.Web.WebView2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApexBrowser
{
    public partial class WebControl : UserControl, IWebControl
    {
        private const string startupUrl = "https://developer.microsoft.com/en-us/microsoft-edge/webview2/?form=MA13LH";

        public WebControl()
        {
            InitializeComponent();

            this.Load += WebControl_Load;
        }

        private void WebControl_Load(object sender, EventArgs e)
        {
            InitializeWebView();
            webView2Component.EnsureCoreWebView2Async();
        }

        private void InitializeWebView()
        {
            if (webView2Component != null)
            {
                // 1. Event to get state that Core is loaded
                webView2Component.CoreWebView2InitializationCompleted += (sender, e) =>
                {
                    if (e.IsSuccess)
                    {
                        // 2. Event to get state that new page is loaded
                        webView2Component.CoreWebView2.NavigationCompleted += (sender, e2) =>
                        {
                            if (!e.IsSuccess)
                            {
                                MessageBox.Show($"Page loading error {e2.WebErrorStatus}");
                            }

                            //UpdateNavigationButtons();
                            //UpdateNavigationUrl();
                        };

                        // Make naviagtion
                        Navigate(startupUrl);
                    }
                    else
                    {
                        Debug.WriteLine($"WebView2 initialization error: {e.InitializationException.Message}");
                    }
                };
            }
        }

        #region IWebControl

        public WebView2 GetWebView2Instance() => webView2Component;

        public string GetActualUrl() => webView2Component.Source?.AbsoluteUri ?? string.Empty;

        public void GoBack()
        {
            webView2Component.GoBack();
        }

        public void GoForward()
        {
            webView2Component.GoForward();
        }

        public void Reload()
        {
            webView2Component.Reload();
        }

        public void Navigate(string url)
        {
            webView2Component.Source = new Uri(url);
        }

        #endregion

        private void WebControl_Click(object sender, EventArgs e)
        {
            WebControlStorage.Instance.SetActiveWebControl(this);
        }
    }
}
