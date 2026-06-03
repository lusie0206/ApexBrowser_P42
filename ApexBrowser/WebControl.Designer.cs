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
            ((System.ComponentModel.ISupportInitialize)webView2Component).BeginInit();
            SuspendLayout();
            // 
            // webView2Component
            // 
            webView2Component.AllowExternalDrop = true;
            webView2Component.CreationProperties = null;
            webView2Component.DefaultBackgroundColor = Color.White;
            webView2Component.Dock = DockStyle.Fill;
            webView2Component.Location = new Point(0, 0);
            webView2Component.Name = "webView2Component";
            webView2Component.Size = new Size(400, 300);
            webView2Component.TabIndex = 0;
            webView2Component.ZoomFactor = 1D;
            // 
            // WebControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            Controls.Add(webView2Component);
            Name = "WebControl";
            Size = new Size(400, 300);
            ((System.ComponentModel.ISupportInitialize)webView2Component).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Microsoft.Web.WebView2.WinForms.WebView2 webView2Component;
    }
}
