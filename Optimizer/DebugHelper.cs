using Newtonsoft.Json.Linq;
using System;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Optimizer {
    // Collection of useful debugging methods and utilities
    internal sealed class DebugHelper {
        // For comparing and detecting missing keys between two translation JSON files
        internal static void FindDifferenceInTwoJsons() {
            JObject file1 = JObject.Parse(Properties.Resources.EN);
            JObject file2 = JObject.Parse(Properties.Resources.RU);

            var p1 = file1.Properties().ToList();
            var p2 = file2.Properties().ToList();

            var missingProps = p1.Where(expected => !p2.Where(actual => actual.Name == expected.Name).Any());

            StringBuilder sb = new StringBuilder();
            foreach (var x in missingProps) {
                sb.Append(x.Name + Environment.NewLine);
            }
            MessageBox.Show(sb.ToString());
        }
    }
}
