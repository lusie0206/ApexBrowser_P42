using ApexBrowser.Interfaces;
using Microsoft.Web.WebView2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApexBrowser
{
    public partial class NavigationControl : UserControl
    {
        private IWebControl GetWebControl() => WebControlStorage.Instance.GetActiveWebControl();
        public NavigationControl()
        {
            InitializeComponent();
        }

        public void UpdateNavigationPanel(bool canGoBack, bool canGoForward, string actualUrl)
        {
            buttonBack.Enabled = canGoBack;
            buttonNext.Enabled = canGoForward;
            textBoxUrl.Text = actualUrl;
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            GetWebControl().GoBack();
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            GetWebControl().GoForward();
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            GetWebControl().Reload();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            GetWebControl().Navigate(textBoxUrl.Text);
        }

        private void textBoxUrl_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                GetWebControl()?.Navigate(textBoxUrl.Text);
            }
        }
    }
}
