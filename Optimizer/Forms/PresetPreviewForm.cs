using Optimizer.Controls;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace Optimizer.Forms
{
    public partial class PresetPreviewForm : Form
    {
        public static Region RegionFromImageAlpha(Image image)
        {
            Bitmap bitmap = image as Bitmap ?? new Bitmap(image);

            GraphicsPath path = new GraphicsPath();

            Rectangle rect = new Rectangle(0, 0, bitmap.Width, bitmap.Height);
            BitmapData data = bitmap.LockBits(
                rect,
                ImageLockMode.ReadOnly,
                PixelFormat.Format32bppArgb);

            unsafe
            {
                byte* scan0 = (byte*)data.Scan0;
                int stride = data.Stride;

                for (int y = 0; y < bitmap.Height; y++)
                {
                    byte* row = scan0 + (y * stride);
                    int x = 0;

                    while (x < bitmap.Width)
                    {
                        // skip transparent
                        while (x < bitmap.Width && row[x * 4 + 3] < 32) // 32 is the threshold
                            x++;

                        if (x >= bitmap.Width)
                            break;

                        int startX = x;

                        // find opaque
                        while (x < bitmap.Width && row[x * 4 + 3] != 0)
                            x++;

                        path.AddRectangle(new Rectangle(startX, y, x - startX, 1));
                    }
                }
            }

            bitmap.UnlockBits(data);

            return new Region(path);
        }

        public PresetPreviewForm()
        {
            InitializeComponent();
            if (!DesignMode)
            {
                throw new Exception("Use the correct constructor which takes in the (Image, string) array");
            }
        }

        Control lastDangerControl;

        public PresetPreviewForm(string presetName, Color presetColor, (Image, string)[] dangerousItems)
        {
            InitializeComponent();

            Region = Region.FromHrgn(Program.CreateRoundRectRgn(0, 0, Width, Height - 1, 13, 13));
            cuiButton1.Region = Region.FromHrgn(Program.CreateRoundRectRgn(1, 1, cuiButton1.Width, cuiButton1.Height, 13, 13));
            cuiPanelGradient1.Region = Region.FromHrgn(Program.CreateRoundRectRgn(1, 1, cuiPanelGradient1.Width, cuiPanelGradient1.Height - 1, 9, 9));
            pictureBox1.Region = RegionFromImageAlpha(pictureBox1.Image);

            Text = $"Preset: {presetName}";
            nameLabel.Text = presetName;
            nameLabel.ForeColor = presetColor;

            dangerFlowLayoutPanel.SuspendLayout();
            foreach (var dangerousItemEntry in dangerousItems)
            {
                DangerousItem newDangerousItemControl = new DangerousItem();
                newDangerousItemControl.Image = dangerousItemEntry.Item1;
                newDangerousItemControl.Text = dangerousItemEntry.Item2;
                newDangerousItemControl.Invalidate();

                dangerFlowLayoutPanel.Controls.Add(newDangerousItemControl);
            }
            dangerFlowLayoutPanel.ResumeLayout();

            lastDangerControl = dangerFlowLayoutPanel.Controls[dangerFlowLayoutPanel.Controls.Count - 1];
            lastDangerControl.Paint += LastWarningBecameVisible;

            int maxFlowPanelHeight = 5 * 48;
            dangerFlowLayoutPanel.Height = Math.Min(maxFlowPanelHeight, 24 + (dangerousItems.Length * 48));
            dangerFlowLayoutPanel.AutoScroll = dangerFlowLayoutPanel.Height == maxFlowPanelHeight;
            scrollToUnlockLabel.Visible = dangerFlowLayoutPanel.AutoScroll;

            Height = 220 + dangerFlowLayoutPanel.Height;
            panel1.Top = dangerFlowLayoutPanel.Bottom - 17;
            btnOK.Top = panel1.Bottom - 4;
            cuiButton1.Top = btnOK.Top;
        }

        private void LastWarningBecameVisible(object sender, PaintEventArgs e)
        {
            lastDangerControl.Paint -= LastWarningBecameVisible;
            btnOK.Enabled = true;
            btnOK.NormalBackground = Color.FromArgb(255, btnOK.NormalBackground);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Yes;
            Close();
        }

        private void cuiButton1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.No;
            Close();
        }
    }
}
