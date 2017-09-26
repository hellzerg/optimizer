using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.IO;
using Newtonsoft.Json;

namespace Optimizer
{
    public class SettingsJson
    {
        public Theme Color { get; set; }
    }

    public static class Options
    {
        readonly static string flag = "themeable";
        internal readonly static string SettingsFile = Required.CoreFolder + "\\Optimizer.json";

        internal static SettingsJson CurrentOptions = new SettingsJson();

        // use this to determine if changes have been made
        private static SettingsJson Flag = new SettingsJson();

        internal static IEnumerable<Control> GetSelfAndChildrenRecursive(Control parent)
        {
            List<Control> controls = new List<Control>();

            foreach (Control child in parent.Controls)
            {
                controls.AddRange(GetSelfAndChildrenRecursive(child));
            }

            controls.Add(parent);
            return controls;
        }

        internal static void ApplyTheme(Form f)
        {
            switch (CurrentOptions.Color)
            {
                case Theme.Caramel:
                    SetTheme(f, Color.DarkOrange, Color.Chocolate);
                    break;
                case Theme.Lime:
                    SetTheme(f, Color.LimeGreen, Color.ForestGreen);
                    break;
                case Theme.Magma:
                    SetTheme(f, Color.Tomato, Color.Red);
                    break;
                case Theme.Minimal:
                    SetTheme(f, Color.Gray, Color.DimGray);
                    break;
                case Theme.Ocean:
                    SetTheme(f, Color.DodgerBlue, Color.RoyalBlue);
                    break;
                case Theme.Zerg:
                    SetTheme(f, Color.MediumOrchid, Color.DarkOrchid);
                    break;
            }
        }

        private static void SetTheme(Form f, Color c1, Color c2)
        {
            GetSelfAndChildrenRecursive(f).OfType<Button>().ToList().ForEach(b => b.BackColor = c1);
            GetSelfAndChildrenRecursive(f).OfType<Button>().ToList().ForEach(b => b.FlatAppearance.BorderColor = c1);
            GetSelfAndChildrenRecursive(f).OfType<Button>().ToList().ForEach(b => b.FlatAppearance.MouseDownBackColor = c2);
            GetSelfAndChildrenRecursive(f).OfType<Button>().ToList().ForEach(b => b.FlatAppearance.MouseOverBackColor = c2);

            foreach (Label tmp in GetSelfAndChildrenRecursive(f).OfType<Label>().ToList())
            {
                if ((string)tmp.Tag == flag)
                {
                    tmp.ForeColor = c1;
                }
            }
            foreach (LinkLabel tmp in GetSelfAndChildrenRecursive(f).OfType<LinkLabel>().ToList())
            {
                if ((string)tmp.Tag == flag)
                {
                    tmp.LinkColor = c1;
                    tmp.VisitedLinkColor = c1;
                    tmp.ActiveLinkColor = c2;
                }
            }
            foreach (CheckBox tmp in GetSelfAndChildrenRecursive(f).OfType<CheckBox>().ToList())
            {
                if ((string)tmp.Tag == flag)
                {
                    tmp.ForeColor = c1;
                }
            }
        }

        internal static void SaveSettings()
        {
            if (File.Exists(SettingsFile))
            {
                if (Flag.Color != CurrentOptions.Color)
                {
                    using (FileStream fs = File.Open(SettingsFile, FileMode.OpenOrCreate))
                    using (StreamWriter sw = new StreamWriter(fs))
                    using (JsonWriter jw = new JsonTextWriter(sw))
                    {
                        jw.Formatting = Formatting.Indented;

                        JsonSerializer serializer = new JsonSerializer();
                        serializer.Serialize(jw, CurrentOptions);
                    }
                }
                else
                {
                    // no changes have been made, no need to save
                }
            }
        }

        internal static void LoadSettings()
        {
            if (!File.Exists(SettingsFile))
            {
                CurrentOptions.Color = Theme.Zerg;

                using (FileStream fs = File.Open(SettingsFile, FileMode.CreateNew))
                using (StreamWriter sw = new StreamWriter(fs))
                using (JsonWriter jw = new JsonTextWriter(sw))
                {
                    jw.Formatting = Formatting.Indented;

                    JsonSerializer serializer = new JsonSerializer();
                    serializer.Serialize(jw, CurrentOptions);
                }
            }
            else
            {
                CurrentOptions = JsonConvert.DeserializeObject<SettingsJson>(File.ReadAllText(SettingsFile));

                // initialize flag
                Flag.Color = CurrentOptions.Color;
            }
        }
    }
}
