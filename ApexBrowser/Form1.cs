using ApexBrowser.Interfaces;

namespace ApexBrowser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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

        private void buttonForvard_Click(object sender, EventArgs e)
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
