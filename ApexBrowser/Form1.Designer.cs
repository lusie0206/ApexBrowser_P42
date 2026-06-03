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
            buttonAdd = new Button();
            buttonBack = new Button();
            buttonReload = new Button();
            textBoxUrl = new TextBox();
            buttonSearch = new Button();
            tabControl1 = new TabControl();
            buttonNote = new Button();
            buttonForward = new Button();
            buttonRemove = new Button();
            tabControl2 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            button1 = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            tabControl2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // buttonAdd
            // 
            buttonAdd.Image = Properties.Resources.add;
            buttonAdd.Location = new Point(1003, 10);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(54, 44);
            buttonAdd.TabIndex = 0;
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonBack
            // 
            buttonBack.Image = Properties.Resources.back;
            buttonBack.Location = new Point(12, 12);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(54, 44);
            buttonBack.TabIndex = 2;
            buttonBack.UseVisualStyleBackColor = true;
            buttonBack.Click += buttonBack_Click;
            // 
            // buttonReload
            // 
            buttonReload.Image = Properties.Resources.refresh;
            buttonReload.Location = new Point(132, 12);
            buttonReload.Name = "buttonReload";
            buttonReload.Size = new Size(54, 42);
            buttonReload.TabIndex = 4;
            buttonReload.UseVisualStyleBackColor = true;
            buttonReload.Click += buttonReload_Click;
            // 
            // textBoxUrl
            // 
            textBoxUrl.Font = new Font("Segoe UI", 14F);
            textBoxUrl.Location = new Point(192, 13);
            textBoxUrl.Name = "textBoxUrl";
            textBoxUrl.Size = new Size(721, 39);
            textBoxUrl.TabIndex = 5;
            textBoxUrl.KeyDown += textBoxUrl_KeyDown;
            // 
            // buttonSearch
            // 
            buttonSearch.Image = Properties.Resources.browse;
            buttonSearch.Location = new Point(931, 10);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(54, 44);
            buttonSearch.TabIndex = 6;
            buttonSearch.UseVisualStyleBackColor = true;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // tabControl1
            // 
            tabControl1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl1.Location = new Point(2, 423);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1186, 290);
            tabControl1.TabIndex = 7;
            tabControl1.Selected += tabControl1_Selected;
            // 
            // buttonNote
            // 
            buttonNote.Image = Properties.Resources.comment;
            buttonNote.Location = new Point(1123, 10);
            buttonNote.Name = "buttonNote";
            buttonNote.Size = new Size(54, 44);
            buttonNote.TabIndex = 9;
            buttonNote.UseVisualStyleBackColor = true;
            buttonNote.Click += buttonNote_Click;
            // 
            // buttonForward
            // 
            buttonForward.Image = Properties.Resources.forward;
            buttonForward.Location = new Point(72, 12);
            buttonForward.Name = "buttonForward";
            buttonForward.Size = new Size(54, 44);
            buttonForward.TabIndex = 3;
            buttonForward.UseVisualStyleBackColor = true;
            buttonForward.Click += buttonForward_Click;
            // 
            // buttonRemove
            // 
            buttonRemove.Image = Properties.Resources.remove;
            buttonRemove.Location = new Point(1063, 10);
            buttonRemove.Name = "buttonRemove";
            buttonRemove.Size = new Size(54, 44);
            buttonRemove.TabIndex = 8;
            buttonRemove.UseVisualStyleBackColor = true;
            buttonRemove.Click += buttonRemove_Click;
            // 
            // tabControl2
            // 
            tabControl2.Controls.Add(tabPage1);
            tabControl2.Controls.Add(tabPage2);
            tabControl2.Location = new Point(12, 304);
            tabControl2.Name = "tabControl2";
            tabControl2.SelectedIndex = 0;
            tabControl2.Size = new Size(757, 113);
            tabControl2.TabIndex = 10;
            // 
            // tabPage1
            // 
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(749, 80);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(749, 306);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(3, 3);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 11;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.Controls.Add(button1, 0, 0);
            tableLayoutPanel1.Location = new Point(117, 107);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(812, 125);
            tableLayoutPanel1.TabIndex = 12;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1189, 714);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(tabControl2);
            Controls.Add(buttonNote);
            Controls.Add(buttonRemove);
            Controls.Add(tabControl1);
            Controls.Add(buttonSearch);
            Controls.Add(textBoxUrl);
            Controls.Add(buttonReload);
            Controls.Add(buttonForward);
            Controls.Add(buttonBack);
            Controls.Add(buttonAdd);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            tabControl2.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonAdd;
        private Button buttonBack;
        private Button buttonReload;
        private TextBox textBoxUrl;
        private Button buttonSearch;
        private TabControl tabControl1;
        private Button buttonNote;
        private Button buttonForward;
        private Button buttonRemove;
        private TabControl tabControl2;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Button button1;
        private TableLayoutPanel tableLayoutPanel1;
    }
}
