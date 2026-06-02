namespace ApexBrowser
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            buttonTest = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            navigationControl1 = new NavigationControl();
            SuspendLayout();
            // 
            // buttonTest
            // 
            buttonTest.Location = new Point(1222, 71);
            buttonTest.Name = "buttonTest";
            buttonTest.Size = new Size(94, 29);
            buttonTest.TabIndex = 0;
            buttonTest.Text = "Test";
            buttonTest.UseVisualStyleBackColor = true;
            buttonTest.Click += buttonTest_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Location = new Point(12, 71);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1171, 631);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // navigationControl1
            // 
            navigationControl1.Location = new Point(12, 12);
            navigationControl1.Name = "navigationControl1";
            navigationControl1.Size = new Size(1171, 41);
            navigationControl1.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1328, 714);
            Controls.Add(navigationControl1);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(buttonTest);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Browser";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button buttonTest;
        private FlowLayoutPanel flowLayoutPanel1;
        private NavigationControl navigationControl1;
    }
}
