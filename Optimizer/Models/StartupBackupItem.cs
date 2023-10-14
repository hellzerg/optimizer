using System;

namespace Optimizer
{
    [Serializable]
    public sealed class BackupStartupItem
    {
        public string Name { get; set; }
        public string FileLocation { get; set; }
        public string RegistryLocation { get; set; }
        public string StartupType { get; set; }

        public BackupStartupItem(string name, string fileLocation, string registryLocation, string startupType)
        {
            Name = name;
            FileLocation = fileLocation;
            RegistryLocation = registryLocation;
            StartupType = startupType;
        }
    }
}
