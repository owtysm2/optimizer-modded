
namespace Optimizer
{
    partial class AppCard
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
            this.appTitle = new CuoreUI.Controls.cuiCheckbox();
            this.appImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.appImage)).BeginInit();
            this.SuspendLayout();
            // 
            // appTitle
            // 
            this.appTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.appTitle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.appTitle.Checked = false;
            this.appTitle.CheckedForeground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.appTitle.CheckedOutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.appTitle.CheckedSymbolColor = System.Drawing.Color.White;
            this.appTitle.Content = "App Title";
            this.appTitle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.appTitle.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appTitle.Location = new System.Drawing.Point(36, 4);
            this.appTitle.MinimumSize = new System.Drawing.Size(16, 16);
            this.appTitle.Name = "appTitle";
            this.appTitle.OutlineStyle = true;
            this.appTitle.OutlineThickness = 1F;
            this.appTitle.Rounding = 4;
            this.appTitle.ShowSymbols = true;
            this.appTitle.Size = new System.Drawing.Size(161, 24);
            this.appTitle.TabIndex = 165;
            this.appTitle.UncheckedForeground = System.Drawing.Color.Empty;
            this.appTitle.UncheckedOutlineColor = System.Drawing.Color.Gray;
            this.appTitle.UncheckedSymbolColor = System.Drawing.Color.Empty;
            // 
            // appImage
            // 
            this.appImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.appImage.Location = new System.Drawing.Point(6, 4);
            this.appImage.Name = "appImage";
            this.appImage.Size = new System.Drawing.Size(24, 24);
            this.appImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.appImage.TabIndex = 166;
            this.appImage.TabStop = false;
            // 
            // AppCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.Controls.Add(this.appTitle);
            this.Controls.Add(this.appImage);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "AppCard";
            this.Size = new System.Drawing.Size(200, 33);
            ((System.ComponentModel.ISupportInitialize)(this.appImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal CuoreUI.Controls.cuiCheckbox appTitle;
        internal System.Windows.Forms.PictureBox appImage;
    }
}
