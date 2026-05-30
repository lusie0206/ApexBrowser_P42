using ApexBrowser.Interfaces;

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
            buttonTest = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            navigationBarControl = new NavigationBarControl();
            SuspendLayout();
            // 
            // buttonTest
            // 
            buttonTest.BackgroundImage = Properties.Resources.add;
            buttonTest.BackgroundImageLayout = ImageLayout.Center;
            buttonTest.Location = new Point(1189, 101);
            buttonTest.Name = "buttonTest";
            buttonTest.Size = new Size(89, 81);
            buttonTest.TabIndex = 0;
            buttonTest.UseVisualStyleBackColor = true;
            buttonTest.Click += buttonTest_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Location = new Point(12, 101);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1171, 601);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // navigationBarControl
            // 
            navigationBarControl.Location = new Point(12, 12);
            navigationBarControl.Name = "navigationBarControl";
            navigationBarControl.Size = new Size(1171, 81);
            navigationBarControl.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1328, 714);
            Controls.Add(navigationBarControl);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(buttonTest);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button buttonTest;
        private FlowLayoutPanel flowLayoutPanel1;
        private NavigationBarControl navigationBarControl;
    }
}
