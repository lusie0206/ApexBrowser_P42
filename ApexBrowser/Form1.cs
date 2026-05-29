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
    }
}
