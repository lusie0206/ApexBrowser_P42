using ApexBrowser.Interfaces;
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
    public partial class NavigationBarControl : UserControl
    {
        INavigationManager? navigationManager;


        public NavigationBarControl()
        {
            InitializeComponent();
            SetInitialStateForNavigationPanel();
        }
        public void SetNavigator(INavigationManager navigationManager)
        {
            this.navigationManager = navigationManager;
        }
       
        private void buttonBack_Click(object sender, EventArgs e)
        {
           navigationManager?.GetActiveWebControl().GoBack();
        }

        private void buttonForward_Click(object sender, EventArgs e)
        {
            navigationManager?.GetActiveWebControl().GoForward();
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            if(navigationManager?.GetActiveWebControl() != null)
                navigationManager.GetActiveWebControl().Reload();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            navigationManager?.GetActiveWebControl().Navigate(textBoxUrl.Text);
        }

        private void textBoxUrl_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                navigationManager?.GetActiveWebControl().Navigate(textBoxUrl.Text);
            }
        }

        private void SetInitialStateForNavigationPanel()
        {
            buttonBack.Enabled = false;
            buttonForward.Enabled = false;
            textBoxUrl.Text = string.Empty;
        }

        public void CanGoBack(bool state)
        {
           buttonBack.Enabled = state;
        }

        public void CanGoForward(bool state)
        {
            buttonForward.Enabled = state;
        }

        public void SearchBar(string text)
        {
            textBoxUrl.Text = text;  
        }
    }
}
