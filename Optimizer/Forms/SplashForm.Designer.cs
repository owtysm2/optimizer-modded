
namespace Optimizer
{
    partial class SplashForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SplashForm));
            this.progressTracker = new CuoreUI.Controls.cuiProgressTrackerVertical();
            this.cuiFormDrag1 = new CuoreUI.Components.cuiFormDrag(this.components);
            this.cuiControlDrag1 = new CuoreUI.Components.cuiControlDrag(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.txtVersion = new System.Windows.Forms.Label();
            this.pictureBox1 = new CuoreUI.Controls.cuiPictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // progressTracker
            // 
            this.progressTracker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.progressTracker.AutoRounding = true;
            this.progressTracker.CompletedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.progressTracker.CurrentTaskForeColor = System.Drawing.Color.Gainsboro;
            this.progressTracker.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.progressTracker.LineThickness = 4;
            this.progressTracker.Location = new System.Drawing.Point(14, 69);
            this.progressTracker.Name = "progressTracker";
            this.progressTracker.Rounding = 5;
            this.progressTracker.ShowSymbols = true;
            this.progressTracker.Size = new System.Drawing.Size(184, 158);
            this.progressTracker.TabIndex = 0;
            this.progressTracker.TaskForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.progressTracker.Tasks = new string[] {
        "Check for Updates",
        "Check for Requirements",
        "Load Startup & Hosts Items",
        "Fetch Apps & Trash",
        "Inspect Hardware"};
            this.progressTracker.TasksProgress = 1;
            this.progressTracker.Text = "cuiProgressTrackerVertical1";
            this.progressTracker.TrackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            // 
            // cuiFormDrag1
            // 
            this.cuiFormDrag1.TargetForm = this;
            // 
            // cuiControlDrag1
            // 
            this.cuiControlDrag1.TargetControl = null;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(58, 16);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 22);
            this.label2.TabIndex = 77;
            this.label2.Text = "Optimizer";
            // 
            // txtVersion
            // 
            this.txtVersion.AutoSize = true;
            this.txtVersion.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVersion.ForeColor = System.Drawing.Color.DarkGray;
            this.txtVersion.Location = new System.Drawing.Point(60, 37);
            this.txtVersion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtVersion.Name = "txtVersion";
            this.txtVersion.Size = new System.Drawing.Size(81, 15);
            this.txtVersion.TabIndex = 76;
            this.txtVersion.Text = "Version: {VN}";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Content = global::Optimizer.Properties.Resources.logo;
            this.pictureBox1.ImageTint = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(16, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.OutlineThickness = 1F;
            this.pictureBox1.PanelOutlineColor = System.Drawing.Color.Empty;
            this.pictureBox1.Rotation = 0;
            this.pictureBox1.Rounding = new System.Windows.Forms.Padding(8);
            this.pictureBox1.Size = new System.Drawing.Size(38, 38);
            this.pictureBox1.TabIndex = 78;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.txtVersion);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(360, 69);
            this.panel1.TabIndex = 79;
            // 
            // SplashForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(360, 223);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.progressTracker);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SplashForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Optimizer Modded Splash";
            this.TopMost = true;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        internal CuoreUI.Controls.cuiProgressTrackerVertical progressTracker;
        private CuoreUI.Components.cuiFormDrag cuiFormDrag1;
        private CuoreUI.Components.cuiControlDrag cuiControlDrag1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label txtVersion;
        private CuoreUI.Controls.cuiPictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
    }
}