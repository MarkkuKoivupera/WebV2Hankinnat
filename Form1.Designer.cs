namespace WebView2Test
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtAdress = new System.Windows.Forms.TextBox();
            this.btnGo = new System.Windows.Forms.Button();
            this.lstTrends = new System.Windows.Forms.ListBox();
            this.btnGetTrends = new System.Windows.Forms.Button();
            this.wbvw_Selain = new Microsoft.Web.WebView2.WinForms.WebView2();
            ((System.ComponentModel.ISupportInitialize)(this.wbvw_Selain)).BeginInit();
            this.SuspendLayout();
            // 
            // txtAdress
            // 
            this.txtAdress.Location = new System.Drawing.Point(13, 13);
            this.txtAdress.Name = "txtAdress";
            this.txtAdress.Size = new System.Drawing.Size(382, 20);
            this.txtAdress.TabIndex = 0;
            this.txtAdress.Text = "https://www.hankintailmoitukset.fi/fi/search?top=4503&of=tendersOrRequestsToParti" +
    "cipateDueDateTime&od=desc&m=0";
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(485, 9);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(75, 23);
            this.btnGo.TabIndex = 1;
            this.btnGo.Text = "Go";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // lstTrends
            // 
            this.lstTrends.FormattingEnabled = true;
            this.lstTrends.Location = new System.Drawing.Point(15, 51);
            this.lstTrends.Name = "lstTrends";
            this.lstTrends.Size = new System.Drawing.Size(379, 56);
            this.lstTrends.TabIndex = 2;
            // 
            // btnGetTrends
            // 
            this.btnGetTrends.Enabled = false;
            this.btnGetTrends.Location = new System.Drawing.Point(485, 51);
            this.btnGetTrends.Name = "btnGetTrends";
            this.btnGetTrends.Size = new System.Drawing.Size(72, 25);
            this.btnGetTrends.TabIndex = 3;
            this.btnGetTrends.Text = "Get Trends";
            this.btnGetTrends.UseVisualStyleBackColor = true;
            this.btnGetTrends.Click += new System.EventHandler(this.btnGetTrends_Click);
            // 
            // wbvw_Selain
            // 
            this.wbvw_Selain.AllowExternalDrop = true;
            this.wbvw_Selain.CreationProperties = null;
            this.wbvw_Selain.DefaultBackgroundColor = System.Drawing.Color.White;
            this.wbvw_Selain.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.wbvw_Selain.Location = new System.Drawing.Point(0, 113);
            this.wbvw_Selain.Name = "wbvw_Selain";
            this.wbvw_Selain.Size = new System.Drawing.Size(800, 337);
            this.wbvw_Selain.TabIndex = 4;
            this.wbvw_Selain.ZoomFactor = 1D;
            this.wbvw_Selain.NavigationCompleted += new System.EventHandler<Microsoft.Web.WebView2.Core.CoreWebView2NavigationCompletedEventArgs>(this.webView21_NavigationCompleted);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.wbvw_Selain);
            this.Controls.Add(this.btnGetTrends);
            this.Controls.Add(this.lstTrends);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.txtAdress);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.wbvw_Selain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAdress;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.ListBox lstTrends;
        private System.Windows.Forms.Button btnGetTrends;
        private Microsoft.Web.WebView2.WinForms.WebView2 wbvw_Selain;
    }
}

