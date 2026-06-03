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
        private const string startupUrl = "https://www.google.com/";

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
                    webView2Component.CoreWebView2.NewWindowRequested += CoreWebView2_NewWindowRequested;
                    webView2Component.CoreWebView2.DocumentTitleChanged += CoreWebView2_DocumentTitleChanged;

                    if (e.IsSuccess)
                    {
                        // 2. Event to get state that new page is loaded
                        webView2Component.CoreWebView2.NavigationCompleted += (sender, e2) =>
                        {
                            if (!e.IsSuccess)
                            {
                                MessageBox.Show($"Page loading error {e2.WebErrorStatus}");
                            }

                            WebControlStorage.Instance.NotifyNavigationCompleted();
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

        private void CoreWebView2_DocumentTitleChanged(object? sender, object e)
        {
            Debug.WriteLine("Title changed: " + webView2Component.CoreWebView2.DocumentTitle);
        }

        private void CoreWebView2_NewWindowRequested(object? sender, Microsoft.Web.WebView2.Core.CoreWebView2NewWindowRequestedEventArgs e)
        {
            e.Handled = true;
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

        public void SetActive()
        {
            WebControlStorage.Instance.SetActiveWebControl(this);
        }

        #endregion

    }
}
