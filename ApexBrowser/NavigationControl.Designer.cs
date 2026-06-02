namespace ApexBrowser
{
    partial class NavigationControl
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
            buttonNext = new Button();
            buttonRefresh = new Button();
            textBoxUrl = new TextBox();
            buttonSearch = new Button();
            SuspendLayout();
            // 
            // buttonBack
            // 
            buttonBack.BackColor = Color.Transparent;
            buttonBack.Image = Properties.Resources.previous;
            buttonBack.Location = new Point(3, 3);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(41, 31);
            buttonBack.TabIndex = 0;
            buttonBack.UseVisualStyleBackColor = false;
            buttonBack.Click += buttonBack_Click;
            // 
            // buttonNext
            // 
            buttonNext.BackColor = Color.Transparent;
            buttonNext.Image = Properties.Resources.forward;
            buttonNext.Location = new Point(50, 3);
            buttonNext.Name = "buttonNext";
            buttonNext.Size = new Size(41, 31);
            buttonNext.TabIndex = 1;
            buttonNext.UseVisualStyleBackColor = false;
            buttonNext.Click += buttonNext_Click;
            // 
            // buttonRefresh
            // 
            buttonRefresh.BackgroundImage = Properties.Resources.refresh;
            buttonRefresh.BackgroundImageLayout = ImageLayout.Stretch;
            buttonRefresh.Cursor = Cursors.Hand;
            buttonRefresh.Location = new Point(97, 3);
            buttonRefresh.Name = "buttonRefresh";
            buttonRefresh.Size = new Size(31, 31);
            buttonRefresh.TabIndex = 2;
            buttonRefresh.UseVisualStyleBackColor = true;
            buttonRefresh.Click += buttonRefresh_Click;
            // 
            // textBoxUrl
            // 
            textBoxUrl.Location = new Point(134, 5);
            textBoxUrl.Name = "textBoxUrl";
            textBoxUrl.Size = new Size(997, 27);
            textBoxUrl.TabIndex = 3;
            textBoxUrl.KeyDown += textBoxUrl_KeyDown;
            // 
            // buttonSearch
            // 
            buttonSearch.BackColor = Color.Transparent;
            buttonSearch.BackgroundImage = Properties.Resources.search;
            buttonSearch.BackgroundImageLayout = ImageLayout.Stretch;
            buttonSearch.Location = new Point(1137, 3);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(31, 31);
            buttonSearch.TabIndex = 4;
            buttonSearch.UseVisualStyleBackColor = false;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // NavigationControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(buttonSearch);
            Controls.Add(textBoxUrl);
            Controls.Add(buttonRefresh);
            Controls.Add(buttonNext);
            Controls.Add(buttonBack);
            Name = "NavigationControl";
            Size = new Size(1171, 37);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonBack;
        private Button buttonNext;
        private Button buttonRefresh;
        private TextBox textBoxUrl;
        private Button buttonSearch;
    }
}
