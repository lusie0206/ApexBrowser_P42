namespace ApexBrowser
{
    partial class WebControl
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
            webView2Component = new Microsoft.Web.WebView2.WinForms.WebView2();
            labelHeader = new Label();
            ((System.ComponentModel.ISupportInitialize)webView2Component).BeginInit();
            SuspendLayout();
            // 
            // webView2Component
            // 
            webView2Component.AllowExternalDrop = true;
            webView2Component.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            webView2Component.CreationProperties = null;
            webView2Component.DefaultBackgroundColor = Color.White;
            webView2Component.Location = new Point(0, 34);
            webView2Component.Name = "webView2Component";
            webView2Component.Size = new Size(400, 266);
            webView2Component.TabIndex = 0;
            webView2Component.ZoomFactor = 1D;
            // 
            // labelHeader
            // 
            labelHeader.AutoSize = true;
            labelHeader.Location = new Point(3, 7);
            labelHeader.Name = "labelHeader";
            labelHeader.Size = new Size(75, 20);
            labelHeader.TabIndex = 1;
            labelHeader.Text = "<header>";
            // 
            // WebControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            Controls.Add(labelHeader);
            Controls.Add(webView2Component);
            Name = "WebControl";
            Size = new Size(400, 300);
            Click += WebControl_Click;
            ((System.ComponentModel.ISupportInitialize)webView2Component).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Microsoft.Web.WebView2.WinForms.WebView2 webView2Component;
        private Label labelHeader;
    }
}
