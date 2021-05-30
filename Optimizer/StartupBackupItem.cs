using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optimizer
{
    [Serializable]
    public class StartupBackupItem
    {
        public string Name { get; set; }
        public string FileLocation { get; set; }
        public string RegistryLocation { get; set; }
        public string StartupType { get; set; }

        public StartupBackupItem(string n, string fl, string rl, string st)
        {
            Name = n;
            FileLocation = fl;
            RegistryLocation = rl;
            StartupType = st;
        }
    }
}
