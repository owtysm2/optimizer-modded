
using CuoreUI.Controls;

namespace Optimizer
{
    partial class ToggleCard
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ToggleCard));
            this.Label = new System.Windows.Forms.Label();
            this.Panel = new System.Windows.Forms.Panel();
            this.cardHelp = new CuoreUI.Controls.cuiButton();
            this.Toggle = new CuoreUI.Controls.cuiSwitch();
            this.cuiTooltipHover1 = new CuoreUI.Components.cuiTooltipHover(this.components);
            this.Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Label
            // 
            this.Label.AutoSize = true;
            this.Label.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Label.Font = new System.Drawing.Font("Microsoft JhengHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label.Location = new System.Drawing.Point(73, 3);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(51, 19);
            this.Label.TabIndex = 1;
            this.Label.Text = "label1";
            // 
            // Panel
            // 
            this.Panel.Controls.Add(this.cardHelp);
            this.Panel.Controls.Add(this.Toggle);
            this.Panel.Controls.Add(this.Label);
            this.Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel.Location = new System.Drawing.Point(0, 0);
            this.Panel.Name = "Panel";
            this.Panel.Size = new System.Drawing.Size(334, 25);
            this.Panel.TabIndex = 0;
            // 
            // cardHelp
            // 
            this.cardHelp.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cardHelp.BackColor = System.Drawing.Color.Transparent;
            this.cardHelp.CheckButton = false;
            this.cardHelp.Checked = false;
            this.cardHelp.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.cardHelp.CheckedForeColor = System.Drawing.Color.White;
            this.cardHelp.CheckedImageTint = System.Drawing.Color.White;
            this.cardHelp.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.cardHelp.Content = "";
            this.cardHelp.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.cardHelp.DialogResult = System.Windows.Forms.DialogResult.None;
            this.cardHelp.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cardHelp.ForeColor = System.Drawing.Color.Gray;
            this.cardHelp.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            this.cardHelp.HoverForeColor = System.Drawing.Color.Gainsboro;
            this.cardHelp.HoverImageTint = System.Drawing.Color.Gainsboro;
            this.cardHelp.HoverOutline = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            this.cardHelp.Image = ((System.Drawing.Image)(resources.GetObject("cardHelp.Image")));
            this.cardHelp.ImageAutoCenter = true;
            this.cardHelp.ImageExpand = new System.Drawing.Point(0, 0);
            this.cardHelp.ImageOffset = new System.Drawing.Point(-1, -1);
            this.cardHelp.Location = new System.Drawing.Point(49, 1);
            this.cardHelp.Name = "cardHelp";
            this.cardHelp.NormalBackground = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.cardHelp.NormalForeColor = System.Drawing.Color.Gray;
            this.cardHelp.NormalImageTint = System.Drawing.Color.Gray;
            this.cardHelp.NormalOutline = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.cardHelp.OutlineThickness = 1F;
            this.cardHelp.PressedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.cardHelp.PressedForeColor = System.Drawing.Color.DimGray;
            this.cardHelp.PressedImageTint = System.Drawing.Color.DimGray;
            this.cardHelp.PressedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.cardHelp.Rounding = new System.Windows.Forms.Padding(10);
            this.cardHelp.Size = new System.Drawing.Size(22, 22);
            this.cardHelp.TabIndex = 13;
            this.cardHelp.Tag = "dontTheme";
            this.cardHelp.TextAlignment = System.Drawing.StringAlignment.Center;
            this.cardHelp.TextOffset = new System.Drawing.Point(0, 0);
            // 
            // Toggle
            // 
            this.Toggle.AutoSize = true;
            this.Toggle.Checked = true;
            this.Toggle.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.Toggle.CheckedForeground = System.Drawing.Color.White;
            this.Toggle.CheckedOutlineColor = System.Drawing.Color.Empty;
            this.Toggle.CheckedSymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.Toggle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Toggle.ForeColor = System.Drawing.Color.White;
            this.Toggle.Location = new System.Drawing.Point(0, -1);
            this.Toggle.MinimumSize = new System.Drawing.Size(46, 22);
            this.Toggle.Name = "Toggle";
            this.Toggle.OutlineThickness = 1F;
            this.Toggle.ShowSymbols = false;
            this.Toggle.Size = new System.Drawing.Size(46, 26);
            this.Toggle.TabIndex = 2;
            this.Toggle.ThumbSizeModifier = new System.Drawing.Size(0, 0);
            this.Toggle.UncheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Toggle.UncheckedForeground = System.Drawing.Color.White;
            this.Toggle.UncheckedOutlineColor = System.Drawing.Color.Empty;
            this.Toggle.UncheckedSymbolColor = System.Drawing.Color.Gray;
            this.Toggle.CheckedChanged += new System.EventHandler(this.Toggle_CheckedChanged);
            // 
            // cuiTooltipHover1
            // 
            this.cuiTooltipHover1.BackColor = System.Drawing.Color.Black;
            this.cuiTooltipHover1.Content = "";
            this.cuiTooltipHover1.ForeColor = System.Drawing.Color.White;
            this.cuiTooltipHover1.TargetControl = this.cardHelp;
            this.cuiTooltipHover1.TooltipPosition = CuoreUI.Components.cuiTooltipHover.Position.Bottom;
            this.cuiTooltipHover1.TooltipPositionOffset = new System.Drawing.Size(0, -4);
            // 
            // ToggleCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.Controls.Add(this.Panel);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "ToggleCard";
            this.Size = new System.Drawing.Size(334, 25);
            this.Panel.ResumeLayout(false);
            this.Panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel Panel;
        internal System.Windows.Forms.Label Label;
        internal cuiSwitch Toggle;
        private cuiButton cardHelp;
        private CuoreUI.Components.cuiTooltipHover cuiTooltipHover1;
    }
}
