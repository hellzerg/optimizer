using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Optimizer
{
    public sealed class MoonToggle : CheckBox
    {
        private readonly Timer _animationTimer = new Timer();

        private int _circlePosX = 3, _circlePosY = 3;
        private int _circleColorR = 255, _circleColorG = 255, _circleColorB = 255;
        private int _alpha = 0;

        public MoonToggle()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.OptimizedDoubleBuffer, true);
            DoubleBuffered = true;
            Height = 22; Width = 46;
            _animationTimer.Interval = 1;
            _animationTimer.Tick += new EventHandler(AnimationTick);
        }

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            _animationTimer.Start();
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
            pevent.Graphics.FillPath(new SolidBrush(Color.FromArgb(_alpha, Options.ForegroundColor)), backRect);
            pevent.Graphics.FillEllipse(new SolidBrush(Color.FromArgb(_circleColorR, _circleColorG, _circleColorB)), new RectangleF(_circlePosX, _circlePosY, (Width / 2) - 7, Height - 6));
        }

        private void AnimationTick(object sender, EventArgs e)
        {
            if (Checked)
            {
                if (Options.TextColor == Color.Black)
                {
                    if (_circleColorR != 0 && _circleColorG != 0 && _circleColorB != 0)
                    {
                        _circleColorR -= 15; _circleColorG -= 15; _circleColorB -= 15;
                        Invalidate();
                    }
                }
                else
                {
                    if (_circleColorR != 255 && _circleColorG != 255 && _circleColorB != 255)
                    {
                        _circleColorR += 15; _circleColorG += 15; _circleColorB += 15;
                        Invalidate();
                    }
                }

                if (_circlePosX < (Width / 2) + 4)
                    _circlePosX += 2; Invalidate();

                if (_alpha < 255)
                    _alpha += 15; Invalidate();
            }
            else
            {
                if (_circleColorR != 255 && _circleColorG != 255 && _circleColorB != 255)
                {
                    _circleColorR += 15; _circleColorG += 15; _circleColorB += 15;
                    Invalidate();
                }

                if (_circlePosX > 3)
                    _circlePosX -= 2; Invalidate();

                if (_alpha > 0)
                    _alpha -= 15; Invalidate();
            }
        }
    }
}
