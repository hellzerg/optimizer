using Newtonsoft.Json.Linq;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Optimizer {
    /// <summary>Shared plumbing for the card-based Cleaner, Network and Hosts tabs.</summary>
    public sealed partial class MainForm {
        ToolTip _modernTips;

        static string T(string key, string fallback)
        {
            try
            {
                JObject list = (object)OptionsHelper.TranslationList as JObject;
                string value = list == null ? null : (string)list[key];
                return string.IsNullOrEmpty(value) ? fallback : value;
            }
            catch
            {
                return fallback;
            }
        }

        static void Place(Control c, int x, int y, int w, int h)
        {
            Rectangle r = new Rectangle(x, y, Math.Max(0, w), Math.Max(0, h));
            // Auto-sized controls must go through Bounds so DefaultLayout's cached anchor position is updated.
            if (c.AutoSize) { if (c.Location != r.Location || c.Size != r.Size) c.Bounds = r; }
            else LayoutUtil.Arrange(c, r);
        }

        static void Reparent(Control c, Control parent)
        {
            if (c.Parent == parent) return;
            if (c.Parent != null) c.Parent.Controls.Remove(c);
            c.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            c.Dock = DockStyle.None;
            parent.Controls.Add(c);
        }

        static int TextWidth(Control c)
        {
            return TextRenderer.MeasureText(c.Text, c.Font, Size.Empty, TextFormatFlags.NoPrefix).Width;
        }

        void UI(Action a)
        {
            if (IsDisposed || !IsHandleCreated) return;
            try { BeginInvoke(a); } catch (InvalidOperationException) { }
        }

        static CardPanel NewCard(Control parent)
        {
            CardPanel card = new CardPanel();
            parent.Controls.Add(card);
            return card;
        }

        static FluentLabel NewLabel(Control parent, float pt, Typography.Weight weight, LabelTone tone)
        {
            FluentLabel l = new FluentLabel(Typography.Get(pt, weight), tone) { AutoSize = false };
            parent.Controls.Add(l);
            return l;
        }

        static void SetCue(TextBox box, string text)
        {
            box.Tag = text;
            if (box.IsHandleCreated)
            {
                StartupNative.SendMessage(box.Handle, StartupNative.EM_SETCUEBANNER, (IntPtr)1, text);
                return;
            }
            EventHandler h = null;
            h = (s, e) =>
            {
                box.HandleCreated -= h;
                StartupNative.SendMessage(box.Handle, StartupNative.EM_SETCUEBANNER, (IntPtr)1, box.Tag as string ?? text);
            };
            box.HandleCreated += h;
        }

        static string CleanText(string s)
        {
            if (string.IsNullOrEmpty(s)) return string.Empty;
            s = s.Replace("&&", "&").Replace("\r", string.Empty).Replace("\n", " ");
            while (s.Contains("  ")) s = s.Replace("  ", " ");
            return s.Trim().TrimStart('•').Trim();
        }

        /// <summary>Modern label that follows a (hidden) designer control's translated text.</summary>
        static FluentLabel Mirror(Control source, Control parent, float pt, Typography.Weight weight, LabelTone tone, Action changed = null)
        {
            FluentLabel l = NewLabel(parent, pt, weight, tone);
            l.Text = CleanText(source.Text);
            source.TextChanged += (s, e) =>
            {
                l.Text = CleanText(source.Text);
                if (changed != null) changed();
            };
            return l;
        }

        static LinkLabel NewLink(Control parent)
        {
            LinkLabel l = new LinkLabel
            {
                AutoSize = true,
                LinkBehavior = LinkBehavior.HoverUnderline,
                Font = Typography.Get(9.5f, Typography.Weight.Regular),
                UseMnemonic = false
            };
            parent.Controls.Add(l);
            return l;
        }

        static int WrapHeight(Control c, string text, int width)
        {
            return TextRenderer.MeasureText(text, c.Font, new Size(Math.Max(1, width), 0), TextFormatFlags.WordBreak).Height;
        }

        void InitModernTabs()
        {
            _modernTips = new ToolTip { InitialDelay = 400, ReshowDelay = 100, AutoPopDelay = 10000 };

            InitCleanerUi();
            InitFileHandlesUi();
            InitDiskActivityUi();
            InitDnsUi();
            InitPingerUi();
            InitHostsUi();
            InitAppsUi();
            InitIntegratorUi();
            InitRegistryUi();
            InitOptionsUi();
            RefreshModernTabStrings();
        }

        void RefreshModernTabStrings()
        {
            RefreshCleanerStrings();
            RefreshFileHandlesStrings();
            RefreshDiskActivityStrings();
            RefreshDnsStrings();
            RefreshPingerStrings();
            RefreshHostsStrings();
            RefreshAppsStrings();
            RefreshIntegratorStrings();
            RefreshRegistryStrings();
            RefreshOptionsStrings();
        }
    }
}
