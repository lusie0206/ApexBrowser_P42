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
            buttonBack = new Button();
            buttonForward = new Button();
            buttonReload = new Button();
            textBoxUrl = new TextBox();
            buttonSearch = new Button();
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
            // buttonBack
            // 
            buttonBack.Location = new Point(12, 12);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(48, 48);
            buttonBack.TabIndex = 2;
            buttonBack.Text = "<";
            buttonBack.UseVisualStyleBackColor = true;
            buttonBack.Click += buttonBack_Click;
            // 
            // buttonForward
            // 
            buttonForward.Location = new Point(66, 12);
            buttonForward.Name = "buttonForward";
            buttonForward.Size = new Size(48, 48);
            buttonForward.TabIndex = 3;
            buttonForward.Text = ">";
            buttonForward.UseVisualStyleBackColor = true;
            buttonForward.Click += buttonForward_Click;
            // 
            // buttonReload
            // 
            buttonReload.Location = new Point(120, 12);
            buttonReload.Name = "buttonReload";
            buttonReload.Size = new Size(48, 48);
            buttonReload.TabIndex = 4;
            buttonReload.Text = "R";
            buttonReload.UseVisualStyleBackColor = true;
            buttonReload.Click += buttonReload_Click;
            // 
            // textBoxUrl
            // 
            textBoxUrl.Location = new Point(174, 23);
            textBoxUrl.Name = "textBoxUrl";
            textBoxUrl.Size = new Size(907, 27);
            textBoxUrl.TabIndex = 5;
            textBoxUrl.KeyDown += textBoxUrl_KeyDown;
            // 
            // buttonSearch
            // 
            buttonSearch.Location = new Point(1087, 12);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(96, 48);
            buttonSearch.TabIndex = 6;
            buttonSearch.Text = "Search";
            buttonSearch.UseVisualStyleBackColor = true;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1328, 714);
            Controls.Add(buttonSearch);
            Controls.Add(textBoxUrl);
            Controls.Add(buttonReload);
            Controls.Add(buttonForward);
            Controls.Add(buttonBack);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(buttonTest);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonTest;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button buttonBack;
        private Button buttonForward;
        private Button buttonReload;
        private TextBox textBoxUrl;
        private Button buttonSearch;
    }
}
