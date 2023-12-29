using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Optimizer {
    public sealed class MoonToggle : CheckBox {
        bool solidStyle = true;

        [Browsable(true)]
        public override string Text {
            get { return base.Text; }
            set { }
        }

        [DefaultValue(true)]
        public bool SolidStyle {
            get { return solidStyle; }
            set {
                solidStyle = value;
                this.Invalidate();
            }
        }

        public MoonToggle() {
            this.DoubleBuffered = true;
            this.MinimumSize = new Size(46, 22);
            this.ForeColor = Color.White;
        }

        private GraphicsPath GetFigurePath() {
            int arcSize = this.Height - 1;
            Rectangle leftArc = new Rectangle(0, 0, arcSize, arcSize);
            Rectangle rightArc = new Rectangle(this.Width - arcSize - 2, 0, arcSize, arcSize);

            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(leftArc, 90, 180);
            path.AddArc(rightArc, 270, 180);
            path.CloseFigure();

            return path;
        }

        protected override void OnPaint(PaintEventArgs pevent) {
            int toggleSize = this.Height - 5;
            pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            pevent.Graphics.Clear(this.Parent.BackColor);

            if (this.Checked) //ON
            {
                if (solidStyle)
                    pevent.Graphics.FillPath(new SolidBrush(OptionsHelper.ForegroundColor), GetFigurePath());
                else pevent.Graphics.DrawPath(new Pen(OptionsHelper.ForegroundColor, 2), GetFigurePath());
                //Draw the toggle
                pevent.Graphics.FillEllipse(new SolidBrush(OptionsHelper.TextColor),
                  new Rectangle(this.Width - this.Height + 1, 2, toggleSize, toggleSize));
            }
            else //OFF
            {
                if (solidStyle)
                    pevent.Graphics.FillPath(new SolidBrush(OptionsHelper.BackAccentColor), GetFigurePath());
                else pevent.Graphics.DrawPath(new Pen(OptionsHelper.BackAccentColor, 2), GetFigurePath());
                //Draw the toggle
                pevent.Graphics.FillEllipse(new SolidBrush(Color.White),
                  new Rectangle(2, 2, toggleSize, toggleSize));
            }
        }
    }
}