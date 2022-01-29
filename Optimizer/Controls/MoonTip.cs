using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Optimizer
{
    class MoonTip : ToolTip
    {
        TextFormatFlags toolTipFlags = TextFormatFlags.VerticalCenter | TextFormatFlags.LeftAndRightPadding | TextFormatFlags.HorizontalCenter | TextFormatFlags.NoClipping;

        Font font = new Font("Segoe UI Semibold", 10f, FontStyle.Regular);

        public MoonTip()
        {
            this.OwnerDraw = true;
            this.IsBalloon = false;
            this.Popup += new PopupEventHandler(this.OnPopup);
            this.Draw += new DrawToolTipEventHandler(this.OnDraw);
        }

        private void OnPopup(object sender, PopupEventArgs e) // use this event to set the size of the tool tip
        {
            string toolTipText = (sender as ToolTip).GetToolTip(e.AssociatedControl);
            using (var g = e.AssociatedControl.CreateGraphics())
            {
                var textSize = Size.Add(TextRenderer.MeasureText(
                    g, toolTipText, font, Size.Empty, toolTipFlags), new Size(10, 10));

                e.ToolTipSize = textSize;
            }
            // e.ToolTipSize = new Size(400, 400);
        }

        private void OnDraw(object sender, DrawToolTipEventArgs e) // use this event to customise the tool tip
        {
            Graphics g = e.Graphics;

            LinearGradientBrush b = new LinearGradientBrush(e.Bounds,
                Color.FromArgb(40,40,40), Color.FromArgb(40, 40, 40), 45f);

            g.FillRectangle(b, e.Bounds);

            g.DrawRectangle(new Pen(Color.FromArgb(40, 40, 40), 1), new Rectangle(e.Bounds.X, e.Bounds.Y,
                e.Bounds.Width - 1, e.Bounds.Height - 1));

            
            g.DrawString(e.ToolTipText, font, Brushes.White,
                new PointF(e.Bounds.X + 6, e.Bounds.Y + 6)); // top layer

            b.Dispose();
        }
    }
}