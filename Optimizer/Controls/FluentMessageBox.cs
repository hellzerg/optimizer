using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;

namespace Optimizer {
    internal static class FluentMessageBox {
        internal static DialogResult Show(string text)
        {
            return Show(null, text, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.None);
        }

        internal static DialogResult Show(string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon)
        {
            return Show(null, text, caption, buttons, icon);
        }

        internal static DialogResult Show(IWin32Window owner, string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon)
        {
            OptionsHelper.SyncPalette();

            using (FluentMessageBoxForm dialog = new FluentMessageBoxForm(text, caption, buttons, icon))
            {
                IWin32Window resolvedOwner = owner ?? GetActiveOwner();
                dialog.StartPosition = resolvedOwner == null ? FormStartPosition.CenterScreen : FormStartPosition.CenterParent;
                return resolvedOwner == null ? dialog.ShowDialog() : dialog.ShowDialog(resolvedOwner);
            }
        }

        static IWin32Window GetActiveOwner()
        {
            Form active = Form.ActiveForm;
            if (active != null && !active.IsDisposed && active.Visible) return active;

            foreach (Form form in Application.OpenForms)
            {
                if (!form.IsDisposed && form.Visible) return form;
            }

            return null;
        }

        static string Translate(string key, string fallback)
        {
            try
            {
                JObject translations = OptionsHelper.TranslationList as JObject;
                JToken value;
                if (translations != null && translations.TryGetValue(key, out value))
                {
                    string text = value.ToString();
                    if (!string.IsNullOrWhiteSpace(text)) return text;
                }
            }
            catch { }

            return fallback;
        }

        sealed class FluentMessageBoxForm : Form {
            const int MaxTextWidth = 620;
            const int MaxMessageHeight = 440;

            readonly MessageBoxButtons _buttonSet;
            readonly List<FluentButton> _buttons = new List<FluentButton>();

            internal FluentMessageBoxForm(string text, string caption, MessageBoxButtons buttonSet, MessageBoxIcon icon)
            {
                _buttonSet = buttonSet;
                Build(text ?? string.Empty, caption, icon);
            }

            void Build(string message, string caption, MessageBoxIcon icon)
            {
                Palette palette = ThemeManager.Current;
                Font messageFont = Typography.Get(10f, Typography.Weight.Regular);
                Font buttonFont = Typography.Get(9.5f, Typography.Weight.Semibold);
                TextFormatFlags measureFlags = TextFormatFlags.WordBreak | TextFormatFlags.TextBoxControl | TextFormatFlags.NoPadding;

                int padding = Draw.SI(24);
                int gap = Draw.SI(10);
                int iconSize = icon == MessageBoxIcon.None ? 0 : Draw.SI(42);
                int iconGap = iconSize > 0 ? Draw.SI(16) : 0;
                int maxTextWidth = Draw.SI(MaxTextWidth);
                Size measured = TextRenderer.MeasureText(message.Length == 0 ? " " : message, messageFont,
                    new Size(maxTextWidth, 10000), measureFlags);
                int textWidth = Math.Max(Draw.SI(240), Math.Min(maxTextWidth, measured.Width));
                int textHeight = Math.Max(Draw.SI(24), measured.Height);
                int messageHeight = Math.Max(iconSize, Math.Min(textHeight, Draw.SI(MaxMessageHeight)));

                List<ButtonSpec> specs = CreateButtons(_buttonSet);
                int buttonRowWidth = 0;
                foreach (ButtonSpec spec in specs)
                {
                    int width = Math.Max(Draw.SI(88), TextRenderer.MeasureText(spec.Text, buttonFont).Width + Draw.SI(34));
                    spec.Width = Math.Min(Draw.SI(160), width);
                    buttonRowWidth += spec.Width;
                }
                buttonRowWidth += Math.Max(0, specs.Count - 1) * gap;

                int contentWidth = iconSize + iconGap + textWidth;
                int clientWidth = Math.Max(Draw.SI(360), Math.Max(contentWidth + padding * 2, buttonRowWidth + padding * 2));
                int footerHeight = Draw.SI(58);
                int clientHeight = padding + messageHeight + Draw.SI(16) + footerHeight;

                Text = string.IsNullOrWhiteSpace(caption) ? Application.ProductName : caption;
                FormBorderStyle = FormBorderStyle.FixedDialog;
                StartPosition = FormStartPosition.CenterParent;
                ShowInTaskbar = false;
                ShowIcon = false;
                MinimizeBox = false;
                MaximizeBox = false;
                ControlBox = true;
                AutoScaleMode = AutoScaleMode.None;
                ClientSize = new Size(clientWidth, clientHeight);
                MinimumSize = Size.Empty;
                Font = messageFont;
                BackColor = palette.WindowBg;
                ForeColor = palette.TextPrimary;
                KeyPreview = true;

                bool rightToLeft = IsRightToLeftLanguage(OptionsHelper.CurrentOptions.LanguageCode);
                RightToLeft = rightToLeft ? RightToLeft.Yes : RightToLeft.No;
                RightToLeftLayout = rightToLeft;

                Panel messagePanel = new Panel {
                    AutoScroll = textHeight > messageHeight,
                    BackColor = palette.WindowBg,
                    Location = new Point(padding, padding),
                    Size = new Size(clientWidth - padding * 2, messageHeight),
                    TabStop = false
                };
                Controls.Add(messagePanel);

                int textX = 0;
                if (iconSize > 0)
                {
                    FluentMessageIcon iconView = new FluentMessageIcon(icon) {
                        Location = new Point(0, Math.Max(0, (messageHeight - iconSize) / 2)),
                        Size = new Size(iconSize, iconSize)
                    };
                    messagePanel.Controls.Add(iconView);
                    textX = iconSize + iconGap;
                }

                int scrollbarWidth = messagePanel.AutoScroll ? SystemInformation.VerticalScrollBarWidth : 0;
                int availableTextWidth = Math.Max(Draw.SI(80), messagePanel.ClientSize.Width - textX - scrollbarWidth);
                Label messageLabel = new Label {
                    AutoSize = true,
                    BackColor = palette.WindowBg,
                    Font = messageFont,
                    Location = new Point(textX, Math.Max(0, (messageHeight - textHeight) / 2)),
                    MaximumSize = new Size(availableTextWidth, 0),
                    Text = message,
                    UseMnemonic = false,
                    TextAlign = rightToLeft ? ContentAlignment.MiddleRight : ContentAlignment.MiddleLeft
                };
                ThemeManager.SetRole(messageLabel, TextRole.Primary);
                messagePanel.Controls.Add(messageLabel);

                int footerY = padding + messageHeight + Draw.SI(16);
                int x = clientWidth - padding;
                FluentButton[] createdButtons = new FluentButton[specs.Count];
                for (int i = specs.Count - 1; i >= 0; i--)
                {
                    ButtonSpec spec = specs[i];
                    FluentButton button = new FluentButton {
                        DialogResult = spec.Result,
                        Font = buttonFont,
                        Kind = spec.Result == DialogResult.No || spec.Result == DialogResult.Cancel ? ButtonKind.Standard : ButtonKind.Primary,
                        Location = new Point(x - spec.Width, footerY),
                        Name = "button" + i,
                        Size = new Size(spec.Width, Draw.SI(34)),
                        TabIndex = i,
                        Text = spec.Text
                    };
                    Controls.Add(button);
                    createdButtons[i] = button;
                    x -= spec.Width + gap;
                }
                _buttons.AddRange(createdButtons);

                if (_buttons.Count > 0)
                {
                    AcceptButton = _buttons[0];
                    FluentButton cancel = _buttons.FirstOrDefault(b => b.DialogResult == DialogResult.Cancel || b.DialogResult == DialogResult.No);
                    CancelButton = cancel ?? _buttons[0];
                }

                FormClosing += (s, e) =>
                {
                    if (DialogResult != DialogResult.None) return;
                    FluentButton cancel = _buttons.FirstOrDefault(b => b.DialogResult == DialogResult.Cancel || b.DialogResult == DialogResult.No);
                    DialogResult = cancel != null ? cancel.DialogResult : (_buttons.Count > 0 ? _buttons[0].DialogResult : DialogResult.OK);
                };

                ThemeManager.Apply(this);
            }

            static List<ButtonSpec> CreateButtons(MessageBoxButtons buttonSet)
            {
                switch (buttonSet)
                {
                    case MessageBoxButtons.OK:
                        return new List<ButtonSpec> { new ButtonSpec(Translate("btnOk", "OK"), DialogResult.OK) };
                    case MessageBoxButtons.YesNo:
                        return new List<ButtonSpec> {
                            new ButtonSpec(Translate("btnYes", "Yes"), DialogResult.Yes),
                            new ButtonSpec(Translate("btnNo", "No"), DialogResult.No)
                        };
                    case MessageBoxButtons.OKCancel:
                        return new List<ButtonSpec> {
                            new ButtonSpec(Translate("btnOk", "OK"), DialogResult.OK),
                            new ButtonSpec(Translate("cancelBackup", "Cancel"), DialogResult.Cancel)
                        };
                    case MessageBoxButtons.YesNoCancel:
                        return new List<ButtonSpec> {
                            new ButtonSpec(Translate("btnYes", "Yes"), DialogResult.Yes),
                            new ButtonSpec(Translate("btnNo", "No"), DialogResult.No),
                            new ButtonSpec(Translate("cancelBackup", "Cancel"), DialogResult.Cancel)
                        };
                    default:
                        throw new NotSupportedException("The requested message box button set is not supported.");
                }
            }

            static bool IsRightToLeftLanguage(LanguageCode language)
            {
                return language == LanguageCode.AR || language == LanguageCode.KU ||
                    language == LanguageCode.FA || language == LanguageCode.UR;
            }
        }

        sealed class ButtonSpec {
            internal readonly string Text;
            internal readonly DialogResult Result;
            internal int Width;

            internal ButtonSpec(string text, DialogResult result)
            {
                Text = text;
                Result = result;
            }
        }

        sealed class FluentMessageIcon : Control, IThemeable {
            readonly MessageBoxIcon _icon;

            internal FluentMessageIcon(MessageBoxIcon icon)
            {
                _icon = icon;
                SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint |
                    ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw | ControlStyles.SupportsTransparentBackColor, true);
                TabStop = false;
                BackColor = Color.Transparent;
            }

            public void ApplyTheme(Palette palette)
            {
                BackColor = Color.Transparent;
                Invalidate();
            }

            protected override void OnPaint(PaintEventArgs e)
            {
                base.OnPaint(e);

                Palette palette = ThemeManager.Current;
                Color foreground;
                string glyph;
                switch (_icon)
                {
                    case MessageBoxIcon.Error:
                        foreground = palette.Danger;
                        glyph = "×";
                        break;
                    case MessageBoxIcon.Warning:
                        foreground = palette.IsDark ? Color.FromArgb(255, 190, 70) : Color.FromArgb(153, 92, 0);
                        glyph = "!";
                        break;
                    case MessageBoxIcon.Question:
                        foreground = palette.AccentText;
                        glyph = "?";
                        break;
                    default:
                        foreground = palette.AccentText;
                        glyph = "i";
                        break;
                }

                int diameter = Math.Min(Width, Height) - Draw.SI(2);
                Rectangle bounds = new Rectangle((Width - diameter) / 2, (Height - diameter) / 2, diameter, diameter);
                Color background = ColorMath.Blend(foreground, palette.WindowBg, 0.88);
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                using (SolidBrush brush = new SolidBrush(background)) e.Graphics.FillEllipse(brush, bounds);
                TextRenderer.DrawText(e.Graphics, glyph, Typography.Get(14f, Typography.Weight.Semibold), bounds, foreground,
                        TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter | TextFormatFlags.NoPadding);
            }
        }
    }
}
