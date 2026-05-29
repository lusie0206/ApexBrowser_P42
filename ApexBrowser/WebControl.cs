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
    public partial class WebControl : UserControl
    {
        public WebControl()
        {
            InitializeComponent();
        }

        private void AddWebView2()
        {
            this.Controls.Add(new WebView2() { Width = 400, Height = 300});
        }
    }
}
