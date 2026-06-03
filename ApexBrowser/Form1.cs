using ApexBrowser.Interfaces;
using Microsoft.Web.WebView2.WinForms;

namespace ApexBrowser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            tabControl1.SizeMode = TabSizeMode.Fixed;
            tabControl1.ItemSize = new Size(160, 28);

            WebControlStorage.Instance.WebControlSelected += Instance_WebControlSelected;
            WebControlStorage.Instance.WebControlNavigationCompleted += Instance_WebControlNavigationCompleted;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SetInitialStateForNavigationPanel();
        }

        private void SetInitialStateForNavigationPanel()
        {
            buttonBack.Enabled = false;
            buttonForward.Enabled = false;
            textBoxUrl.Text = string.Empty;
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

                buttonBack.Enabled = canGoBack;
                buttonForward.Enabled = canGoForward;
                textBoxUrl.Text = actualUrl;
            }
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


        private void buttonAdd_Click(object sender, EventArgs e)
        {
            var tab = new TabPage("<Tab name>");
            tab.Controls.Add(new WebControl() { AutoSize = true, Dock = DockStyle.Fill });
            tabControl1.TabPages.Add(tab);
            tabControl1.SelectTab(tabControl1.TabCount - 1);

            LinkNavigationPanel();
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab is TabPage pageToRemove)
            {
                tabControl1.TabPages.Remove(tabControl1.SelectedTab);
            }
        }

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            LinkNavigationPanel();
        }

        private void LinkNavigationPanel()
        {
            if (tabControl1.SelectedTab?.Controls.OfType<WebControl>().FirstOrDefault() is IWebControl webControl)
            {
                webControl.SetActive();
            }
        }

        private void buttonNote_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var tab = new TabPage("<Tab name>");

            tab.Controls.Add(new WebControl() { AutoSize = true, Dock = DockStyle.Fill });


            tabControl2.TabPages.Add(tab);
        }
    }
}
