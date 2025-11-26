namespace Optimizer
{
    partial class HelperForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HelperForm));
            this.lblMessage = new System.Windows.Forms.Label();
            this.btnYes = new CuoreUI.Controls.cuiButton();
            this.btnNo = new CuoreUI.Controls.cuiButton();
            this.SuspendLayout();
            // 
            // lblMessage
            // 
            this.lblMessage.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lblMessage.Location = new System.Drawing.Point(10, 7);
            this.lblMessage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(432, 74);
            this.lblMessage.TabIndex = 0;
            this.lblMessage.Text = "Restart to apply changes?";
            // 
            // btnYes
            // 
            this.btnYes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnYes.CheckButton = false;
            this.btnYes.Checked = false;
            this.btnYes.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnYes.CheckedForeColor = System.Drawing.Color.White;
            this.btnYes.CheckedImageTint = System.Drawing.Color.White;
            this.btnYes.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnYes.Content = "Yes";
            this.btnYes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnYes.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.btnYes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnYes.ForeColor = System.Drawing.Color.White;
            this.btnYes.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.btnYes.HoverForeColor = System.Drawing.Color.White;
            this.btnYes.HoverImageTint = System.Drawing.Color.White;
            this.btnYes.HoverOutline = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnYes.Image = null;
            this.btnYes.ImageAutoCenter = true;
            this.btnYes.ImageExpand = new System.Drawing.Point(0, 0);
            this.btnYes.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnYes.Location = new System.Drawing.Point(288, 120);
            this.btnYes.Margin = new System.Windows.Forms.Padding(2);
            this.btnYes.Name = "btnYes";
            this.btnYes.NormalBackground = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnYes.NormalForeColor = System.Drawing.Color.White;
            this.btnYes.NormalImageTint = System.Drawing.Color.White;
            this.btnYes.NormalOutline = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnYes.OutlineThickness = 1F;
            this.btnYes.PressedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.btnYes.PressedForeColor = System.Drawing.Color.Gray;
            this.btnYes.PressedImageTint = System.Drawing.Color.Gray;
            this.btnYes.PressedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnYes.Rounding = new System.Windows.Forms.Padding(8);
            this.btnYes.Size = new System.Drawing.Size(110, 45);
            this.btnYes.TabIndex = 31;
            this.btnYes.Tag = "dontTheme";
            this.btnYes.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnYes.TextOffset = new System.Drawing.Point(0, 0);
            this.btnYes.Click += new System.EventHandler(this.btnYes_Click);
            // 
            // btnNo
            // 
            this.btnNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNo.CheckButton = false;
            this.btnNo.Checked = false;
            this.btnNo.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnNo.CheckedForeColor = System.Drawing.Color.White;
            this.btnNo.CheckedImageTint = System.Drawing.Color.White;
            this.btnNo.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnNo.Content = "No";
            this.btnNo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNo.DialogResult = System.Windows.Forms.DialogResult.No;
            this.btnNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnNo.ForeColor = System.Drawing.Color.White;
            this.btnNo.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.btnNo.HoverForeColor = System.Drawing.Color.White;
            this.btnNo.HoverImageTint = System.Drawing.Color.White;
            this.btnNo.HoverOutline = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnNo.Image = null;
            this.btnNo.ImageAutoCenter = true;
            this.btnNo.ImageExpand = new System.Drawing.Point(0, 0);
            this.btnNo.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnNo.Location = new System.Drawing.Point(168, 120);
            this.btnNo.Margin = new System.Windows.Forms.Padding(2);
            this.btnNo.Name = "btnNo";
            this.btnNo.NormalBackground = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnNo.NormalForeColor = System.Drawing.Color.White;
            this.btnNo.NormalImageTint = System.Drawing.Color.White;
            this.btnNo.NormalOutline = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnNo.OutlineThickness = 1F;
            this.btnNo.PressedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.btnNo.PressedForeColor = System.Drawing.Color.Gray;
            this.btnNo.PressedImageTint = System.Drawing.Color.Gray;
            this.btnNo.PressedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnNo.Rounding = new System.Windows.Forms.Padding(8);
            this.btnNo.Size = new System.Drawing.Size(110, 45);
            this.btnNo.TabIndex = 32;
            this.btnNo.Tag = "dontTheme";
            this.btnNo.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnNo.TextOffset = new System.Drawing.Point(0, 0);
            this.btnNo.Click += new System.EventHandler(this.btnNo_Click);
            // 
            // HelperForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(409, 176);
            this.Controls.Add(this.btnNo);
            this.Controls.Add(this.btnYes);
            this.Controls.Add(this.lblMessage);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HelperForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Optimizer";
            this.Load += new System.EventHandler(this.Messager_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblMessage;
        private CuoreUI.Controls.cuiButton btnYes;
        private CuoreUI.Controls.cuiButton btnNo;
    }
}