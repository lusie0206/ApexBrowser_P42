using ApexBrowser.Interfaces;
using Microsoft.Web.WebView2.WinForms;
using System.Windows.Forms;

namespace ApexBrowser
{
    public partial class Form1 : Form
    {
        
        NavigationBarControl barControl = new();
        INavigationManager navigationManager;
        public Form1()
        {
            InitializeComponent();

            navigationManager = WebControlStorage.Instance;
            navigationManager.WebControlSelected += Instance_WebControlSelected;
            navigationManager.WebControlNavigationCompleted += Instance_WebControlNavigationCompleted;
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            barControl = navigationBarControl;
            barControl.SetNavigator(navigationManager);
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
            if (navigationManager.GetActiveWebControl() is IWebControl webControl
                && webControl.GetWebView2Instance() is WebView2 webView2Element)
            {
                barControl.CanGoBack(webView2Element.CanGoBack);
                barControl.CanGoForward(webView2Element.CanGoForward);
                barControl.SearchBar(webControl.GetActualUrl());
                
            }
        }

        private void buttonTest_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Add(new WebControl() { Width = 400, Height = 300 });
        }
       

    }
}
