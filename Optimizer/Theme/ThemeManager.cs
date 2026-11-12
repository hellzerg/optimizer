using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace Optimizer {
    /// <summary>
    /// Implemented by controls that paint themselves from the active <see cref="Palette"/>.
    /// </summary>
    public interface IThemeable {
        void ApplyTheme(Palette palette);
    }

    /// <summary>
    /// A themeable control whose children should still be themed by the manager, on the given surface color.
    /// </summary>
    public interface IThemeContainer {
        Color ChildSurface { get; }
    }

    public enum TextRole {
        Primary,
        Secondary,
        Accent,
        Title,
        Danger
    }

    /// <summary>
    /// Central theme state. Walks control trees and maps every control to semantic palette tokens.
    /// </summary>
    public static class ThemeManager {
        static Palette _current = Palette.Create(ThemeMode.Dark, Palette.DefaultAccent);

        sealed class RoleBox { public TextRole Role; }

        static readonly ConditionalWeakTable<Control, RoleBox> _roles = new ConditionalWeakTable<Control, RoleBox>();
        static readonly ConditionalWeakTable<Control, object> _handleHooks = new ConditionalWeakTable<Control, object>();

        internal static event EventHandler ThemeChanged;

        internal static Palette Current { get { return _current; } }

        internal static void SetTheme(ThemeMode mode, Color accent)
        {
            Palette previous = _current;
            _current = Palette.Create(mode, accent);

            if (previous.Mode != _current.Mode || previous.Accent != _current.Accent)
            {
                ThemeChanged?.Invoke(null, EventArgs.Empty);
            }
        }

        /// <summary>
        /// Explicitly assigns a text role to a label-like control (overrides automatic classification).
        /// </summary>
        internal static void SetRole(Control c, TextRole role)
        {
            _roles.Remove(c);
            _roles.Add(c, new RoleBox { Role = role });
        }

        internal static void Apply(Control root)
        {
            if (root == null) return;

            Palette p = _current;
            Color surface = p.WindowBg;

            Form form = root as Form;
            if (form is TipBubble) return;
            if (form != null)
            {
                Typography.Modernize(form);
                EnableBuffering(form);
                form.BackColor = p.WindowBg;
                form.ForeColor = p.TextPrimary;
                WhenHandleCreated(form, () => WindowChrome.Apply(form, _current));
            }
            else if (root.Parent != null)
            {
                surface = root.Parent.BackColor;
            }

            root.SuspendLayout();
            try
            {
                if (form != null)
                {
                    foreach (Control child in root.Controls) ApplyRecursive(child, p, surface);
                }
                else
                {
                    ApplyRecursive(root, p, surface);
                }
            }
            finally
            {
                root.ResumeLayout(true);
            }

            root.Invalidate(true);
        }

        /// <summary>
        /// Text roles are derived from the designer colors, so they must be captured before any recoloring happens.
        /// </summary>
        static void ClassifyTree(Control c)
        {
            if (c is Label || c is ButtonBase) GetRole(c);
            foreach (Control child in c.Controls) ClassifyTree(child);
        }

        static readonly System.Reflection.MethodInfo _getStyle = typeof(Control).GetMethod("GetStyle", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic);
        static readonly System.Reflection.MethodInfo _setStyle = typeof(Control).GetMethod("SetStyle", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic);
        static readonly System.Reflection.PropertyInfo _doubleBuffered = typeof(Control).GetProperty("DoubleBuffered", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic);
        static readonly ConditionalWeakTable<Control, object> _buffered = new ConditionalWeakTable<Control, object>();
        const ControlStyles BufferStyles = ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint;

        /// <summary>
        /// Turns on double buffering for stock controls that WinForms paints itself (panels, tab pages, group boxes...)
        /// and for list/tree views, which support native buffering. Win32-painted controls such as text boxes are left alone.
        /// Runtime-added children are covered as well, so dynamically built lists don't flicker.
        /// </summary>
        internal static void EnableBuffering(Control c)
        {
            object marker;
            if (c == null || _buffered.TryGetValue(c, out marker)) return;
            _buffered.Add(c, null);

            try
            {
                if (c is ListView || c is TreeView || c is DataGridView)
                {
                    _doubleBuffered.SetValue(c, true, null);
                }
                else if ((bool)_getStyle.Invoke(c, new object[] { ControlStyles.UserPaint })
                    && !(bool)_getStyle.Invoke(c, new object[] { ControlStyles.OptimizedDoubleBuffer }))
                {
                    _setStyle.Invoke(c, new object[] { BufferStyles, true });
                }
            }
            catch { }

            c.ControlAdded += (s, e) => EnableBufferingTree(e.Control);
        }

        static void EnableBufferingTree(Control c)
        {
            EnableBuffering(c);
            foreach (Control child in c.Controls) EnableBufferingTree(child);
        }

        static void ApplyRecursive(Control c, Palette p, Color surface)
        {
            EnableBuffering(c);
            Typography.Modernize(c);
            ApplyControl(c, p, surface);

            Color childSurface = (c is TabControl) ? surface : c.BackColor;
            if (childSurface.A < 255) childSurface = surface;

            foreach (Control child in c.Controls)
            {
                ApplyRecursive(child, p, childSurface);
            }
        }

        static void ApplyControl(Control c, Palette p, Color surface)
        {
            IThemeable themeable = c as IThemeable;
            if (themeable != null)
            {
                themeable.ApplyTheme(p);
                return;
            }

            if (c is TabControl) return;

            if (c is LinkLabel)
            {
                LinkLabel link = (LinkLabel)c;
                link.BackColor = surface;
                link.ForeColor = RoleColor(GetRole(c), p);
                link.LinkColor = p.AccentText;
                link.VisitedLinkColor = p.AccentText;
                link.ActiveLinkColor = p.AccentPressed;
                link.LinkBehavior = LinkBehavior.HoverUnderline;
                return;
            }

            if (c is Label)
            {
                if (c.BackColor.A == 255 || c.BackColor != Color.Transparent) c.BackColor = surface;
                c.ForeColor = RoleColor(GetRole(c), p);
                return;
            }

            if (c is TextBoxBase)
            {
                c.BackColor = ((TextBoxBase)c).BorderStyle == BorderStyle.None ? surface : p.InputFill;
                TextBoxChrome.Attach((TextBoxBase)c);
                c.ForeColor = p.TextPrimary;
                if (((TextBoxBase)c).Multiline) ThemeScrollbars(c);
                return;
            }

            if (c is ListBox || c is ListView || c is TreeView)
            {
                c.BackColor = surface;
                c.ForeColor = p.TextPrimary;
                ThemeScrollbars(c);
                return;
            }

            if (c is ComboBox)
            {
                ComboBox box = (ComboBox)c;
                box.FlatStyle = FlatStyle.Flat;
                box.BackColor = p.InputFill;
                box.ForeColor = p.TextPrimary;
                return;
            }

            if (c is CheckBox || c is RadioButton)
            {
                c.BackColor = surface;
                c.ForeColor = RoleColor(GetRole(c), p);
                return;
            }

            if (c is Button)
            {
                Button b = (Button)c;
                b.FlatStyle = FlatStyle.Flat;
                b.BackColor = p.ControlFill;
                b.ForeColor = p.TextPrimary;
                b.FlatAppearance.BorderColor = p.Stroke;
                b.FlatAppearance.BorderSize = 1;
                b.FlatAppearance.MouseOverBackColor = p.ControlHover;
                b.FlatAppearance.MouseDownBackColor = p.ControlPressed;
                return;
            }

            if (c is GroupBox)
            {
                c.BackColor = surface;
                c.ForeColor = p.TextSecondary;
                return;
            }

            if (c is PictureBox)
            {
                c.BackColor = surface;
                GlyphTint.Apply((PictureBox)c, p);
                return;
            }

            if (c is ProgressBar) return;

            if (c is NumericUpDown || c is DateTimePicker)
            {
                c.BackColor = p.InputFill;
                c.ForeColor = p.TextPrimary;
                return;
            }

            // generic containers (Panel, TabPage, FlowLayoutPanel, TableLayoutPanel, UserControl, SplitContainer ...)
            c.BackColor = surface;
            c.ForeColor = p.TextPrimary;

            ScrollableControl scrollable = c as ScrollableControl;
            if (scrollable != null && scrollable.AutoScroll) ThemeScrollbars(c);
        }

        internal static TextRole GetRole(Control c)
        {
            RoleBox box;
            if (_roles.TryGetValue(c, out box)) return box.Role;

            TextRole role = Classify(c);
            _roles.Add(c, new RoleBox { Role = role });
            return role;
        }

        static TextRole Classify(Control c)
        {
            if ((c.Tag as string) == Constants.THEME_FLAG)
            {
                return c.Font.SizeInPoints >= 12f ? TextRole.Title : TextRole.Accent;
            }

            Color fc = c.ForeColor;

            if (fc.R > 170 && fc.G < 110 && fc.B < 110) return TextRole.Danger;

            bool greyish = Math.Abs(fc.R - fc.G) < 12 && Math.Abs(fc.G - fc.B) < 12;
            if (greyish && fc.R < 235 && fc.R > 60) return TextRole.Secondary;

            if (!greyish && fc != Color.Black) return TextRole.Accent;

            return TextRole.Primary;
        }

        internal static Color RoleColor(TextRole role, Palette p)
        {
            switch (role)
            {
                case TextRole.Secondary: return p.TextSecondary;
                case TextRole.Accent: return p.AccentText;
                case TextRole.Danger: return p.Danger;
                default: return p.TextPrimary;
            }
        }

        internal static void ThemeScrollbars(Control c)
        {
            WhenHandleCreated(c, () => WindowChrome.ApplyScrollbars(c, _current));
        }

        static void WhenHandleCreated(Control c, Action action)
        {
            if (c.IsHandleCreated) action();

            object hooked;
            if (!_handleHooks.TryGetValue(c, out hooked))
            {
                _handleHooks.Add(c, new object());
                c.HandleCreated += (s, e) => action();
            }
        }

        /// <summary>
        /// Applies the palette to context menus / tool strips (these are components, not part of the control tree).
        /// </summary>
        static readonly ConditionalWeakTable<Image, object> _menuGlyphImages = new ConditionalWeakTable<Image, object>();

        internal static void ApplyMenu(ToolStrip strip)
        {
            if (strip == null) return;

            strip.SuspendLayout();
            strip.RenderMode = ToolStripRenderMode.Professional;
            strip.Renderer = new MoonMenuRenderer();
            strip.BackColor = _current.Layer2;
            strip.ForeColor = _current.TextPrimary;
            strip.Font = Typography.Get(10f, Typography.Weight.Regular);
            strip.Padding = new Padding(Draw.SI(4), Draw.SI(6), Draw.SI(4), Draw.SI(6));
            strip.ImageScalingSize = new Size(Draw.SI(16), Draw.SI(16));
            foreach (ToolStripItem item in strip.Items) ApplyMenuItem(item);
            strip.ResumeLayout();

            ToolStripDropDown popup = strip as ToolStripDropDown;
            if (popup != null)
            {
                popup.Opened -= Popup_Opened;
                popup.Opened += Popup_Opened;
            }
        }

        static void Popup_Opened(object sender, EventArgs e)
        {
            WindowChrome.ApplyPopup((Control)sender, _current);
        }

        static void ApplyMenuItem(ToolStripItem item)
        {
            item.ForeColor = _current.TextPrimary;
            item.BackColor = _current.Layer2;

            if (item is ToolStripSeparator)
            {
                item.Margin = new Padding(0, Draw.SI(3), 0, Draw.SI(3));
                return;
            }

            if (item is ToolStripMenuItem)
            {
                item.Font = Typography.Get(10f, Typography.Weight.Regular);
                item.Padding = new Padding(Draw.SI(4), Draw.SI(6), Draw.SI(4), Draw.SI(6));
                item.ImageScaling = item.Tag is SidebarNav.Glyph ? ToolStripItemImageScaling.None : ToolStripItemImageScaling.SizeToFit;
            }
            else
            {
                Typography.Modernize(item);
            }

            if (item.Tag is SidebarNav.Glyph) SetMenuGlyph(item, (SidebarNav.Glyph)item.Tag);

            ToolStripDropDownItem dropDown = item as ToolStripDropDownItem;
            if (dropDown == null) return;

            dropDown.DropDown.BackColor = _current.Layer2;
            foreach (ToolStripItem child in dropDown.DropDownItems) ApplyMenuItem(child);
        }

        // Glyph items carry a blank placeholder that only reserves the icon column;
        // MoonMenuRenderer paints the vector glyph itself so it stays crisp at any DPI.
        static void SetMenuGlyph(ToolStripItem item, SidebarNav.Glyph glyph)
        {
            item.ImageScaling = ToolStripItemImageScaling.None;
            Size slot = MoonMenuRenderer.GlyphSlot;
            Image old = item.Image;
            if (old != null && old.Size == slot && _menuGlyphImages.TryGetValue(old, out _)) return;

            Bitmap placeholder = new Bitmap(slot.Width, slot.Height);
            _menuGlyphImages.Add(placeholder, null);
            item.Image = placeholder;
            if (old != null && _menuGlyphImages.TryGetValue(old, out _)) old.Dispose();
        }
    }

    public static class Draw {
        internal static GraphicsPath RoundedRect(RectangleF r, float radius)
        {
            GraphicsPath path = new GraphicsPath();
            float d = Math.Min(radius * 2, Math.Min(r.Width, r.Height));

            if (d <= 0.5f)
            {
                path.AddRectangle(r);
                return path;
            }

            path.AddArc(r.X, r.Y, d, d, 180, 90);
            path.AddArc(r.Right - d, r.Y, d, d, 270, 90);
            path.AddArc(r.Right - d, r.Bottom - d, d, d, 0, 90);
            path.AddArc(r.X, r.Bottom - d, d, d, 90, 90);
            path.CloseFigure();
            return path;
        }

        static float _dpiScale = -1f;

        /// <summary>
        /// The process is system-DPI aware, so a single scale factor applies to every window.
        /// </summary>
        internal static float DpiScale
        {
            get
            {
                if (_dpiScale < 0)
                {
                    try
                    {
                        using (Graphics g = Graphics.FromHwnd(IntPtr.Zero)) _dpiScale = g.DpiX / 96f;
                    }
                    catch
                    {
                        _dpiScale = 1f;
                    }
                }
                return _dpiScale;
            }
        }

        internal static float S(float value)
        {
            return value * DpiScale;
        }

        internal static int SI(int value)
        {
            return (int)Math.Round(value * DpiScale);
        }
    }
}
