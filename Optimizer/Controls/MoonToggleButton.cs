using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Optimizer
{
    public sealed class MoonToggleButton : Button
    {
        bool _state;

        string _captionYes;
        string _captionNo;

        public MoonToggleButton()
        {
            this.DoubleBuffered = true;
            CheckForIllegalCrossThreadCalls = false;

            _captionYes = Options.TranslationList["btnYes"].ToString();
            _captionNo = Options.TranslationList["btnNo"].ToString();

            ToggleState = false;
            this.Click += MoonToggleButton_Click;
        }

        private void MoonToggleButton_Click(object sender, EventArgs e)
        {
            ToggleState = !_state;
        }

        public bool ToggleState
        {
            get { return this._state; }
            set
            {
                _state = value;
                this.ForeColor = Options.TextColor;

                if (_state)
                {
                    this.Text = _captionYes;
                    this.BackColor = Options.ForegroundColor;
                }
                else
                {
                    this.Text = _captionNo;
                    this.BackColor = Options.BackAccentColor;
                }
            }
        }


    }
}
