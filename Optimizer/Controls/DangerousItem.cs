using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Optimizer.Controls
{
    public partial class DangerousItem : UserControl
    {
        private Image _privateImage;

        public Image Image
        {
            get
            {
                return _privateImage;
            }
            set
            {
                _privateImage = value; Invalidate();
            }
        }

        public DangerousItem()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            using (SolidBrush roundedImageBgBrush = new SolidBrush(Color.FromArgb(32, 32, 32)))
            using (GraphicsPath roundedImageBackground = CuoreUI.Helpers.GeneralHelper.RoundRect(new Rectangle(6, 6, 36, 36), 8))
            {
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                e.Graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

                e.Graphics.FillPath(roundedImageBgBrush, roundedImageBackground);
                if (_privateImage != null)
                {
                    e.Graphics.DrawImage(Image, new Rectangle(12, 12, 24, 24));
                }
            }

            TextRenderer.DrawText(e.Graphics, Text, Font, new Point(48, 16), ForeColor);

            base.OnPaint(e);
        }
    }
}
