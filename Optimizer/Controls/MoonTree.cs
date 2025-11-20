using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;

namespace Optimizer
{
    public sealed class MoonTree : TreeView
    {
        string[] rootNodes =
        {
            "cpu", "ram", "mobo", "gpu", "disk", "inet", "audio", "dev"
        };

        string _primaryItemTag = "_primary";

        public MoonTree()
        {
            DrawMode = TreeViewDrawMode.OwnerDrawAll;
            BackColor = Color.FromArgb(20, 20, 20);
            ForeColor = Color.White;
            BorderStyle = BorderStyle.None;
        }

        protected override void OnDrawNode(DrawTreeNodeEventArgs e)
        {
            Rectangle nodeRectangle = new Rectangle(0, e.Bounds.Y, Width, e.Bounds.Height);

            if (e.Node.IsSelected)
            {
                using (SolidBrush nodeBrush = new SolidBrush(Color.FromArgb(50, 50, 50)))
                {
                    e.Graphics.FillRectangle(nodeBrush, nodeRectangle);
                }
            }

            // draw text in a nicer place (e.Bounds only has a getter)
            // e.Node.Bounds.Left is an awkward place to draw text at
            nodeRectangle.X = e.Node.Bounds.Left - 7;
            nodeRectangle.Width = e.Node.Bounds.Width;

            if (rootNodes.Contains(e.Node.Name))
            {
                TextRenderer.DrawText(e.Graphics, e.Node.Text, Font, nodeRectangle, Color.Silver);
            }
            else if (e.Node.Tag?.ToString() == _primaryItemTag)
            {
                TextRenderer.DrawText(e.Graphics, e.Node.Text, Font, nodeRectangle, OptionsHelper.ForegroundColor);
            }
            else
            {
                TextRenderer.DrawText(e.Graphics, e.Node.Text, Font, nodeRectangle, Color.White);
            }

            if (!DesignMode)
            {
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                if (ImageList != null && ImageList.Images.Count > e.Node.SelectedImageIndex && e.Node.SelectedImageIndex > -1)
                {
                    e.Graphics.DrawImage(ImageList.Images[e.Node.SelectedImageIndex], (e.Bounds.Left + 5) + (15 * e.Node.Level) + 24, e.Bounds.Top);

                    Rectangle nodeExpanderRect = new Rectangle(7, e.Bounds.Top + 7, 14, 14);
                    using (GraphicsPath expanderPath = CuoreUI.Helpers.GeneralHelper.RoundTriangle(
                        nodeExpanderRect, rounding: 2, pointingDown: e.Node.IsExpanded))
                    {
                        e.Graphics.FillPath(Brushes.DimGray, expanderPath);
                    }
                }
            }
        }
    }
}
