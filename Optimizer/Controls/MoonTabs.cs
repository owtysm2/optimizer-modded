using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using System.Windows.Forms;

namespace Optimizer
{
    [
        ComVisible(true), ClassInterface(ClassInterfaceType.AutoDispatch),
        DefaultProperty("TabPages"), DefaultEvent("SelectedIndexChanged")
    ]
    public sealed class MoonTabs : TabControl
    {
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern IntPtr SendMessage(IntPtr hWnd, int msg, IntPtr wp, IntPtr lp);

        [Category("Custom"), Description("Indicates whether or not you the components Tabpages Headers have border edges."), DefaultValue(false)]
        public bool BorderEdges { get; set; } = false;

        private int _BorderSize = 0;
        [Category("Custom"), Description("The size of the components border."), DefaultValue(0)]
        public int BorderSize
        {
            get => _BorderSize;
            set => _BorderSize = 0;
        }

        protected override CreateParams CreateParams
        {
            [SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.UnmanagedCode)]
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }

        // OVERRIDE TAB HEADER WIDTH
        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);

            // Send TCM_SETMINTABWIDTH
            string maxTitle = string.Empty;
            foreach (TabPage x in this.TabPages)
            {
                if (x.Text.Length > maxTitle.Length) maxTitle = x.Text;
            }
            Size textSize = TextRenderer.MeasureText(maxTitle, this.Font);

            SendMessage(this.Handle, 0x1300 + 49, IntPtr.Zero, (IntPtr)textSize.Width);
        }

        public MoonTabs()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer |
                     ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.CacheText, true);

            Alignment = TabAlignment.Top;

            Margin = new Padding(0);
            Padding = new Point(0, 0);

            this.SizeMode = TabSizeMode.Fixed;
        }

        protected override void OnLayout(LayoutEventArgs levent)
        {
            base.OnLayout(levent);
            ItemSize = new Size(ItemSize.Width, 36);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.Clear(Parent.BackColor);

            Rectangle container = new Rectangle(0, 0, Width - (BorderSize % 2), Height - (BorderSize % 2));
            Rectangle containerHead;

            if (TabCount > 0)
            {
                using (SolidBrush brushActive = new SolidBrush(OptionsHelper.ForegroundColor))
                using (SolidBrush brushInActive = new SolidBrush(Color.FromArgb(20, 20, 20)))
                using (SolidBrush brushAlternative = new SolidBrush(OptionsHelper.ForegroundColor))
                using (SolidBrush brushActiveIndicator = new SolidBrush(ControlPaint.Light(OptionsHelper.ForegroundColor)))
                using (SolidBrush brushInActiveIndicator = new SolidBrush(OptionsHelper.ForegroundColor))
                using (SolidBrush brushActiveText = new SolidBrush(OptionsHelper.TextColor))
                using (SolidBrush brushInActiveText = new SolidBrush(Color.White))
                {
                    e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                    e.Graphics.CompositingQuality = CompositingQuality.HighQuality;
                    e.Graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

                    for (int i = 0; i < TabCount; i++)
                    {
                        containerHead = GetTabRect(i);

                        Rectangle tabBackgroundRect = new Rectangle(containerHead.X, containerHead.Y, containerHead.Width - 1, containerHead.Height - 1);
                        using (GraphicsPath roundedTab = CuoreUI.Helpers.GeneralHelper.RoundRect(tabBackgroundRect, 8))
                        {
                            e.Graphics.FillPath((SelectedIndex == i) ? brushActive : brushInActive, roundedTab);
                        }

                        if (i < TabPages.Count && i >= 0)
                        {
                            TextRenderer.DrawText(e.Graphics, TabPages[i].Text, Font, tabBackgroundRect, (i == SelectedIndex) ? brushActiveText.Color : brushInActiveText.Color);
                        }

                        if (BorderEdges && (i == SelectedIndex))
                        {
                            Point ptA = new Point(0, 0); Point ptB = new Point(0, 0);
                            Point ptC = new Point(0, 0); Point ptD = new Point(0, 0);

                            ptA.X = ptB.X = ptD.X = containerHead.X;
                            ptA.Y = ptB.Y = ptC.Y = containerHead.Y;
                            ptA.Y = ptC.Y = ptD.Y = containerHead.Y + containerHead.Height - 1;

                            if (Alignment == TabAlignment.Top || Alignment == TabAlignment.Bottom)
                            {
                                ptD.X = ptC.X = containerHead.X + containerHead.Width;
                                ptC.Y = containerHead.Y;

                                if (Alignment == TabAlignment.Bottom)
                                {
                                    MoonTabHelper.Swap(ref ptA, ref ptB); MoonTabHelper.Swap(ref ptC, ref ptD);
                                }
                            }

                            if (Alignment == TabAlignment.Right || Alignment == TabAlignment.Left)
                            {
                                ptA.Y = containerHead.Y;
                                ptB.X = ptC.X = containerHead.X + containerHead.Width - 1;

                                if (Alignment == TabAlignment.Left)
                                {
                                    MoonTabHelper.Swap(ref ptA, ref ptC); MoonTabHelper.Swap(ref ptB, ref ptD);
                                }
                            }

                            e.Graphics.DrawLine(new Pen(ControlPaint.Light(brushActive.Color)), ptA, ptB);
                            e.Graphics.DrawLine(new Pen(ControlPaint.Light(brushActive.Color)), ptB, ptC);
                            e.Graphics.DrawLine(new Pen(ControlPaint.Dark(brushActive.Color)), ptC, ptD);
                        }
                    }
                }
            }
        }
    }

    public static class MoonTabHelper
    {
        public static void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b; b = temp;
        }
    }
}
