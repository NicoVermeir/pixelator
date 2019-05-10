namespace Pixelator {
    partial class FrmMain {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.pnlColors = new System.Windows.Forms.Panel();
            this.lblImageTitle = new System.Windows.Forms.Label();
            this.txtImage = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.lblGridSizeTitle = new System.Windows.Forms.Label();
            this.lblGridSize = new System.Windows.Forms.Label();
            this.tbGridSize = new System.Windows.Forms.TrackBar();
            this.lblColorsTitle = new System.Windows.Forms.Label();
            this.pnlImage = new System.Windows.Forms.Panel();
            this.picImage = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.print2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showGridToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.interpolationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.middlePixelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dominantPixelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.weightedAverageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.webDemoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.tbGridSize)).BeginInit();
            this.pnlImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlColors
            // 
            this.pnlColors.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlColors.AutoScroll = true;
            this.pnlColors.Location = new System.Drawing.Point(483, 148);
            this.pnlColors.Margin = new System.Windows.Forms.Padding(4);
            this.pnlColors.Name = "pnlColors";
            this.pnlColors.Size = new System.Drawing.Size(399, 454);
            this.pnlColors.TabIndex = 1;
            // 
            // lblImageTitle
            // 
            this.lblImageTitle.AutoSize = true;
            this.lblImageTitle.Location = new System.Drawing.Point(16, 41);
            this.lblImageTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblImageTitle.Name = "lblImageTitle";
            this.lblImageTitle.Size = new System.Drawing.Size(50, 17);
            this.lblImageTitle.TabIndex = 2;
            this.lblImageTitle.Text = "Image:";
            // 
            // txtImage
            // 
            this.txtImage.AllowDrop = true;
            this.txtImage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtImage.Location = new System.Drawing.Point(96, 37);
            this.txtImage.Margin = new System.Windows.Forms.Padding(4);
            this.txtImage.Name = "txtImage";
            this.txtImage.Size = new System.Drawing.Size(676, 22);
            this.txtImage.TabIndex = 3;
            this.txtImage.DragDrop += new System.Windows.Forms.DragEventHandler(this.txtImage_DragDrop);
            this.txtImage.DragOver += new System.Windows.Forms.DragEventHandler(this.txtImage_DragOver);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowse.Location = new System.Drawing.Point(781, 34);
            this.btnBrowse.Margin = new System.Windows.Forms.Padding(4);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(100, 28);
            this.btnBrowse.TabIndex = 4;
            this.btnBrowse.Text = "&Browse...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // lblGridSizeTitle
            // 
            this.lblGridSizeTitle.AutoSize = true;
            this.lblGridSizeTitle.Location = new System.Drawing.Point(16, 86);
            this.lblGridSizeTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGridSizeTitle.Name = "lblGridSizeTitle";
            this.lblGridSizeTitle.Size = new System.Drawing.Size(68, 17);
            this.lblGridSizeTitle.TabIndex = 5;
            this.lblGridSizeTitle.Text = "Grid size:";
            // 
            // lblGridSize
            // 
            this.lblGridSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGridSize.Location = new System.Drawing.Point(781, 86);
            this.lblGridSize.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGridSize.Name = "lblGridSize";
            this.lblGridSize.Size = new System.Drawing.Size(100, 16);
            this.lblGridSize.TabIndex = 6;
            this.lblGridSize.Text = "16x16";
            // 
            // tbGridSize
            // 
            this.tbGridSize.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbGridSize.LargeChange = 8;
            this.tbGridSize.Location = new System.Drawing.Point(96, 69);
            this.tbGridSize.Margin = new System.Windows.Forms.Padding(4);
            this.tbGridSize.Maximum = 64;
            this.tbGridSize.Minimum = 4;
            this.tbGridSize.Name = "tbGridSize";
            this.tbGridSize.Size = new System.Drawing.Size(677, 56);
            this.tbGridSize.TabIndex = 7;
            this.tbGridSize.TickFrequency = 4;
            this.tbGridSize.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.tbGridSize.Value = 16;
            this.tbGridSize.ValueChanged += new System.EventHandler(this.tbGridSize_ValueChanged);
            // 
            // lblColorsTitle
            // 
            this.lblColorsTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblColorsTitle.AutoSize = true;
            this.lblColorsTitle.Location = new System.Drawing.Point(479, 128);
            this.lblColorsTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblColorsTitle.Name = "lblColorsTitle";
            this.lblColorsTitle.Size = new System.Drawing.Size(150, 17);
            this.lblColorsTitle.TabIndex = 8;
            this.lblColorsTitle.Text = "Used colors: (max. 64)";
            // 
            // pnlImage
            // 
            this.pnlImage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlImage.AutoScroll = true;
            this.pnlImage.Controls.Add(this.picImage);
            this.pnlImage.Location = new System.Drawing.Point(20, 132);
            this.pnlImage.Margin = new System.Windows.Forms.Padding(4);
            this.pnlImage.Name = "pnlImage";
            this.pnlImage.Size = new System.Drawing.Size(455, 470);
            this.pnlImage.TabIndex = 9;
            // 
            // picImage
            // 
            this.picImage.Location = new System.Drawing.Point(0, 0);
            this.picImage.Margin = new System.Windows.Forms.Padding(4);
            this.picImage.Name = "picImage";
            this.picImage.Size = new System.Drawing.Size(64, 64);
            this.picImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picImage.TabIndex = 1;
            this.picImage.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.imageToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(897, 28);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openImageToolStripMenuItem,
            this.printToolStripMenuItem,
            this.print2ToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // openImageToolStripMenuItem
            // 
            this.openImageToolStripMenuItem.Name = "openImageToolStripMenuItem";
            this.openImageToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openImageToolStripMenuItem.Size = new System.Drawing.Size(298, 26);
            this.openImageToolStripMenuItem.Text = "&Open Image...";
            this.openImageToolStripMenuItem.Click += new System.EventHandler(this.openImageToolStripMenuItem_Click);
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Enabled = false;
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.printToolStripMenuItem.Size = new System.Drawing.Size(298, 26);
            this.printToolStripMenuItem.Text = "&Print...";
            this.printToolStripMenuItem.Click += new System.EventHandler(this.printToolStripMenuItem_Click);
            // 
            // print2ToolStripMenuItem
            // 
            this.print2ToolStripMenuItem.Enabled = false;
            this.print2ToolStripMenuItem.Name = "print2ToolStripMenuItem";
            this.print2ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.P)));
            this.print2ToolStripMenuItem.Size = new System.Drawing.Size(298, 26);
            this.print2ToolStripMenuItem.Text = "&Print without grid...";
            this.print2ToolStripMenuItem.Click += new System.EventHandler(this.printToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(295, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(298, 26);
            this.exitToolStripMenuItem.Text = "&Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // imageToolStripMenuItem
            // 
            this.imageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showGridToolStripMenuItem,
            this.toolStripMenuItem2,
            this.interpolationToolStripMenuItem});
            this.imageToolStripMenuItem.Name = "imageToolStripMenuItem";
            this.imageToolStripMenuItem.Size = new System.Drawing.Size(63, 24);
            this.imageToolStripMenuItem.Text = "&Image";
            // 
            // showGridToolStripMenuItem
            // 
            this.showGridToolStripMenuItem.Checked = true;
            this.showGridToolStripMenuItem.CheckOnClick = true;
            this.showGridToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.showGridToolStripMenuItem.Name = "showGridToolStripMenuItem";
            this.showGridToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G)));
            this.showGridToolStripMenuItem.Size = new System.Drawing.Size(204, 26);
            this.showGridToolStripMenuItem.Text = "&Show Grid";
            this.showGridToolStripMenuItem.Click += new System.EventHandler(this.showGridToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(201, 6);
            // 
            // interpolationToolStripMenuItem
            // 
            this.interpolationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.middlePixelToolStripMenuItem,
            this.dominantPixelToolStripMenuItem,
            this.weightedAverageToolStripMenuItem});
            this.interpolationToolStripMenuItem.Name = "interpolationToolStripMenuItem";
            this.interpolationToolStripMenuItem.Size = new System.Drawing.Size(204, 26);
            this.interpolationToolStripMenuItem.Text = "Inter&polation";
            // 
            // middlePixelToolStripMenuItem
            // 
            this.middlePixelToolStripMenuItem.Checked = true;
            this.middlePixelToolStripMenuItem.CheckOnClick = true;
            this.middlePixelToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.middlePixelToolStripMenuItem.Name = "middlePixelToolStripMenuItem";
            this.middlePixelToolStripMenuItem.Size = new System.Drawing.Size(205, 26);
            this.middlePixelToolStripMenuItem.Text = "&Middle pixel";
            this.middlePixelToolStripMenuItem.Click += new System.EventHandler(this.InterpolationModeChanged);
            // 
            // dominantPixelToolStripMenuItem
            // 
            this.dominantPixelToolStripMenuItem.CheckOnClick = true;
            this.dominantPixelToolStripMenuItem.Name = "dominantPixelToolStripMenuItem";
            this.dominantPixelToolStripMenuItem.Size = new System.Drawing.Size(205, 26);
            this.dominantPixelToolStripMenuItem.Text = "&Dominant pixel";
            this.dominantPixelToolStripMenuItem.Click += new System.EventHandler(this.InterpolationModeChanged);
            // 
            // weightedAverageToolStripMenuItem
            // 
            this.weightedAverageToolStripMenuItem.CheckOnClick = true;
            this.weightedAverageToolStripMenuItem.Name = "weightedAverageToolStripMenuItem";
            this.weightedAverageToolStripMenuItem.Size = new System.Drawing.Size(205, 26);
            this.weightedAverageToolStripMenuItem.Text = "&Weighted average";
            this.weightedAverageToolStripMenuItem.Click += new System.EventHandler(this.InterpolationModeChanged);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.webDemoToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // webDemoToolStripMenuItem
            // 
            this.webDemoToolStripMenuItem.Name = "webDemoToolStripMenuItem";
            this.webDemoToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.webDemoToolStripMenuItem.Text = "&Web Demo";
            this.webDemoToolStripMenuItem.Click += new System.EventHandler(this.WebDemoToolStripMenuItem_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 617);
            this.Controls.Add(this.pnlImage);
            this.Controls.Add(this.lblColorsTitle);
            this.Controls.Add(this.tbGridSize);
            this.Controls.Add(this.lblGridSize);
            this.Controls.Add(this.lblGridSizeTitle);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.txtImage);
            this.Controls.Add(this.lblImageTitle);
            this.Controls.Add(this.pnlColors);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(595, 292);
            this.Name = "FrmMain";
            this.Text = "Pixelator";
            ((System.ComponentModel.ISupportInitialize)(this.tbGridSize)).EndInit();
            this.pnlImage.ResumeLayout(false);
            this.pnlImage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlColors;
        private System.Windows.Forms.Label lblImageTitle;
        private System.Windows.Forms.TextBox txtImage;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Label lblGridSizeTitle;
        private System.Windows.Forms.Label lblGridSize;
        private System.Windows.Forms.TrackBar tbGridSize;
        private System.Windows.Forms.Label lblColorsTitle;
        private System.Windows.Forms.Panel pnlImage;
        private System.Windows.Forms.PictureBox picImage;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem print2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showGridToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem interpolationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem middlePixelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dominantPixelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem weightedAverageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem webDemoToolStripMenuItem;
    }
}

