namespace ApexBrowser
{
    partial class NavigationBarControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonBack = new Button();
            buttonForward = new Button();
            buttonRefresh = new Button();
            buttonSearch = new Button();
            textBoxUrl = new TextBox();
            SuspendLayout();
            // 
            // buttonBack
            // 
            buttonBack.BackgroundImage = Properties.Resources.angle_left3;
            buttonBack.BackgroundImageLayout = ImageLayout.Center;
            buttonBack.Location = new Point(3, 7);
            buttonBack.Name = "buttonBack";
            buttonBack.Padding = new Padding(5);
            buttonBack.Size = new Size(69, 68);
            buttonBack.TabIndex = 0;
            buttonBack.UseVisualStyleBackColor = true;
            buttonBack.Click += buttonBack_Click;
            // 
            // buttonForward
            // 
            buttonForward.BackgroundImage = Properties.Resources.angle_right;
            buttonForward.BackgroundImageLayout = ImageLayout.Center;
            buttonForward.Location = new Point(78, 7);
            buttonForward.Name = "buttonForward";
            buttonForward.Size = new Size(73, 68);
            buttonForward.TabIndex = 1;
            buttonForward.UseVisualStyleBackColor = true;
            buttonForward.Click += buttonForward_Click;
            // 
            // buttonRefresh
            // 
            buttonRefresh.BackgroundImage = Properties.Resources.refresh1;
            buttonRefresh.BackgroundImageLayout = ImageLayout.Center;
            buttonRefresh.Image = Properties.Resources.refresh;
            buttonRefresh.Location = new Point(157, 7);
            buttonRefresh.Name = "buttonRefresh";
            buttonRefresh.Size = new Size(80, 68);
            buttonRefresh.TabIndex = 2;
            buttonRefresh.UseVisualStyleBackColor = true;
            buttonRefresh.Click += buttonRefresh_Click;
            // 
            // buttonSearch
            // 
            buttonSearch.BackgroundImage = Properties.Resources.search;
            buttonSearch.BackgroundImageLayout = ImageLayout.Center;
            buttonSearch.Location = new Point(243, 7);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(71, 68);
            buttonSearch.TabIndex = 3;
            buttonSearch.UseVisualStyleBackColor = true;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // textBoxUrl
            // 
            textBoxUrl.Font = new Font("Segoe UI", 11F);
            textBoxUrl.Location = new Point(320, 24);
            textBoxUrl.Name = "textBoxUrl";
            textBoxUrl.Size = new Size(568, 32);
            textBoxUrl.TabIndex = 4;
            textBoxUrl.KeyDown += textBoxUrl_KeyDown;
            // 
            // NavigationBarControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(textBoxUrl);
            Controls.Add(buttonSearch);
            Controls.Add(buttonRefresh);
            Controls.Add(buttonForward);
            Controls.Add(buttonBack);
            Name = "NavigationBarControl";
            Size = new Size(902, 88);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonBack;
        private Button buttonForward;
        private Button buttonRefresh;
        private Button buttonSearch;
        private TextBox textBoxUrl;
    }
}
