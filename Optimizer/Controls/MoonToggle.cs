using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Optimizer
{
    public sealed class MoonToggle : CheckBox
    {
        private readonly Timer AnimationTimer = new Timer();
        private int CirclePos = 3;
        private int CircleColorR = 255;
        private int CircleColorG = 255;
        private int CircleColorB = 255;
        private int Alpha = 0;

        public MoonToggle()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.OptimizedDoubleBuffer, true);
            DoubleBuffered = true;
            Height = 22; Width = 46;
            AnimationTimer.Interval = 1;
            AnimationTimer.Tick += new EventHandler(AnimationTick);
        }

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            AnimationTimer.Start();
        }

        protected override void OnResize(EventArgs e)
        {
            Height = 22; Width = 44;
            Invalidate();
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            pevent.Graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
            pevent.Graphics.InterpolationMode = InterpolationMode.High;

            pevent.Graphics.Clear(Parent.BackColor);

            GraphicsPath backRect = new GraphicsPath();
            backRect.AddArc(new RectangleF(0.5f, 0.5f, Height - 1, Height - 1), 90, 180);
            backRect.AddArc(new RectangleF(Width - Height + 0.5f, 0.5f, Height - 1, Height - 1), 270, 180);
            backRect.CloseAllFigures();

            pevent.Graphics.FillPath(new SolidBrush(Options.BackAccentColor), backRect);
            pevent.Graphics.FillPath(new SolidBrush(Color.FromArgb(Alpha, Options.ForegroundColor.R, Options.ForegroundColor.G, Options.ForegroundColor.B)), backRect);
            pevent.Graphics.FillEllipse(new SolidBrush(Color.FromArgb(CircleColorR, CircleColorG, CircleColorB)), new RectangleF(CirclePos, 3, 16, 16));
        }

        private void AnimationTick(object sender, EventArgs e)
        {
            if (Checked)
            {
                if (Options.TextColor == Color.Black)
                {
                    if (CircleColorR != 0 && CircleColorG != 0 && CircleColorB != 0)
                    {
                        CircleColorR -= 15;
                        CircleColorG -= 15;
                        CircleColorB -= 15;
                        Invalidate();
                    }
                }
                else
                {
                    if (CircleColorR != 255 && CircleColorG != 255 && CircleColorB != 255)
                    {
                        CircleColorR += 15;
                        CircleColorG += 15;
                        CircleColorB += 15;
                        Invalidate();
                    }
                }
                if (CirclePos < 26)
                {
                    CirclePos += 2;
                    Invalidate();
                }

                if (Alpha < 255)
                {
                    Alpha += 15;
                    Invalidate();
                }
            }
            else
            {
                if (CircleColorR != 255 && CircleColorG != 255 && CircleColorB != 255)
                {
                    CircleColorR += 15;
                    CircleColorG += 15;
                    CircleColorB += 15;
                    Invalidate();
                }

                if (CirclePos > 3)
                {
                    CirclePos -= 2;
                    Invalidate();
                }

                if (Alpha > 0)
                {
                    Alpha -= 15;
                    Invalidate();
                }
            }
        }
    }
}
