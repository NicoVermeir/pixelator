namespace Pixelator
{
    partial class FrmWebview
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
            this.WebviewControl = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // WebviewControl
            // 
            this.WebviewControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WebviewControl.Location = new System.Drawing.Point(0, 0);
            this.WebviewControl.MinimumSize = new System.Drawing.Size(20, 20);
            this.WebviewControl.Name = "WebviewControl";
            this.WebviewControl.Size = new System.Drawing.Size(800, 450);
            this.WebviewControl.TabIndex = 0;
            // 
            // FrmWebview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.WebviewControl);
            this.Name = "FrmWebview";
            this.Text = "FrmWebview";
            this.Load += new System.EventHandler(this.FrmWebview_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser WebviewControl;
    }
}