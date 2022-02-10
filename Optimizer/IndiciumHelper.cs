using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Management;

namespace Optimizer
{
    public static class IndiciumHelper
    {
        public static List<Volume> Volumes = new List<Volume>();
        public static List<Volume> Opticals = new List<Volume>();
        public static List<Volume> Removables = new List<Volume>();

        public static List<NetworkDevice> PhysicalAdapters = new List<NetworkDevice>();
        public static List<NetworkDevice> VirtualAdapters = new List<NetworkDevice>();

        public static List<Keyboard> Keyboards = new List<Keyboard>();
        public static List<PointingDevice> PointingDevices = new List<PointingDevice>();

        public static List<CPU> GetCPUs()
        {
            List<CPU> CPUs = new List<CPU>();
            CPU cpu;

            try
            {
                ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_Processor");
                foreach (ManagementObject mo in searcher.Get())
                {
                    cpu = new CPU();

                    cpu.Name = Convert.ToString(mo.Properties["Name"].Value);
                    cpu.L2CacheSize = ByteSize.FromKiloBytes(Convert.ToDouble(mo.Properties["L2CacheSize"].Value));
                    cpu.L3CacheSize = ByteSize.FromKiloBytes(Convert.ToDouble(mo.Properties["L3CacheSize"].Value));
                    cpu.Cores = Convert.ToUInt32(mo.Properties["NumberOfCores"].Value);

                    // ThreadCount is for Windows 10+
                    //cpu.Threads = Convert.ToUInt32(mo.Properties["ThreadCount"].Value);

                    cpu.LogicalCpus = Convert.ToUInt32(mo.Properties["NumberOfLogicalProcessors"].Value);

                    if (Utilities.CurrentWindowsVersion != WindowsVersion.Windows7)
                    {
                        bool temp = Convert.ToBoolean(mo.Properties["VirtualizationFirmwareEnabled"].Value);
                        cpu.Virtualization = (temp) ? "Yes" : "No";
                    }
                    else
                    {
                        cpu.Virtualization = "-";
                    }

                    cpu.Stepping = Convert.ToString(mo.Properties["Description"].Value);
                    cpu.Revision = Convert.ToString(mo.Properties["Revision"].Value);

                    try
                    {
                        ManagementObjectSearcher searcher2 = new ManagementObjectSearcher("SELECT * FROM Win32_OperatingSystem");
                        foreach (ManagementObject mo2 in searcher2.Get())
                        {
                            bool temp2 = Convert.ToBoolean(mo2.Properties["DataExecutionPrevention_Available"].Value);
                            cpu.DataExecutionPrevention = (temp2) ? "Yes" : "No";
                        }
                    }
                    catch
                    {
                        cpu.DataExecutionPrevention = "-";
                    }

                    if (string.IsNullOrEmpty(cpu.Name)) cpu.Name = GetCPUNameAlternative();

                    CPUs.Add(cpu);
                }
            }
            catch (Exception ex)
            {
                ErrorLogger.LogError("IndiciumHelper.GetCPUs", ex.Message, ex.StackTrace);
            }

            return CPUs;
        }

        private static string GetCPUNameAlternative()
        {
            using (RegistryKey key = Registry.LocalMachine.OpenSubKey(@"HARDWARE\DESCRIPTION\System\CentralProcessor\0", false))
            {
                return key.GetValue("ProcessorNameString").ToString();
            }
        }

        public static VirtualMemory GetVM()
        {
            VirtualMemory vm = new VirtualMemory();

            try
            {
                ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_OperatingSystem");
                foreach (ManagementObject mo in searcher.Get())
                {
                    vm.TotalVirtualMemory = ByteSize.FromKiloBytes(Convert.ToUInt64(mo.Properties["TotalVirtualMemorySize"].Value));
                    vm.AvailableVirtualMemory = ByteSize.FromKiloBytes(Convert.ToUInt64(mo.Properties["FreeVirtualMemory"].Value));
                    vm.UsedVirtualMemory = vm.TotalVirtualMemory.Subtract(vm.AvailableVirtualMemory);
                }
            }
            catch (Exception ex)
            {
                ErrorLogger.LogError("IndiciumHelper.GetVM", ex.Message, ex.StackTrace);
            }

            return vm;
        }

        public static List<RAM> GetRAM()
        {
            List<RAM> modules = new List<RAM>();
            RAM module;

            try
            {
                ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_PhysicalMemory");
                foreach (ManagementObject mo in searcher.Get())
                {
                    module = new RAM();

                    module.BankLabel = Convert.ToString(mo.Properties["BankLabel"].Value);
                    module.Capacity = ByteSize.FromBytes(Convert.ToDouble(mo.Properties["Capacity"].Value));
                    module.Manufacturer = Convert.ToString(mo.Properties["Manufacturer"].Value);
                    module.Speed = Convert.ToUInt32(mo.Properties["Speed"].Value);
                    UInt16 memorytype = Convert.ToUInt16(mo.Properties["MemoryType"].Value);
                    UInt16 formfactor = Convert.ToUInt16(mo.Properties["FormFactor"].Value);
                    module.MemoryType = SanitizeMemoryType(memorytype);
                    module.FormFactor = SanitizeFormFactor(formfactor);

                    modules.Add(module);
                }
            }
            catch (Exception ex)
            {
                ErrorLogger.LogError("IndiciumHelper.GetRAM", ex.Message, ex.StackTrace);
            }

            return modules;
        }

        public static List<Motherboard> GetMotherboards()
        {
            List<Motherboard> mobos = new List<Motherboard>();

            try
            {
                ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_BaseBoard");
                foreach (ManagementObject mo in searcher.Get())
                {
                    Motherboard mobo = new Motherboard();

                    mobo.Model = Convert.ToString(mo.Properties["Model"].Value);
                    mobo.Manufacturer = Convert.ToString(mo.Properties["Manufacturer"].Value);
                    mobo.Product = Convert.ToString(mo.Properties["Product"].Value);
                    mobo.Version = Convert.ToString(mo.Properties["Version"].Value);

                    try
                    {
                        ManagementObjectSearcher searcher2 = new ManagementObjectSearcher("SELECT * FROM Win32_IDEController");
                        foreach (ManagementObject mo2 in searcher2.Get())
                        {
                            mobo.Chipset = Convert.ToString(mo2.Properties["Description"].Value);
                        }
                    }
                    catch { }

                    try
                    {
                        ManagementObjectSearcher searcher3 = new ManagementObjectSearcher("SELECT * FROM Win32_IDEController");
                        foreach (ManagementObject mo3 in searcher3.Get())
                        {
                            mobo.Revision = Convert.ToString(mo3.Properties["RevisionNumber"].Value);
                        }
                    }
                    catch { }

                    try
                    {
                        ManagementObjectSearcher searcher4 = new ManagementObjectSearcher("SELECT * FROM Win32_ComputerSystem");
                        foreach (ManagementObject mo4 in searcher4.Get())
                        {
                            mobo.SystemModel = Convert.ToString(mo4.Properties["Model"].Value);
                        }
                    }
                    catch { }

                    ManagementObjectSearcher searcher5 = new ManagementObjectSearcher("SELECT * FROM Win32_BIOS");
                    foreach (ManagementObject mo5 in searcher5.Get())
                    {
                        mobo.BIOSName = Convert.ToString(mo5.Properties["Name"].Value);
                        mobo.BIOSManufacturer = Convert.ToString(mo5.Properties["Manufacturer"].Value);
                        mobo.BIOSVersion = Convert.ToString(mo5.Properties["Version"].Value);
                        mobo.BIOSBuildNumber = Convert.ToString(mo5.Properties["BuildNumber"].Value);
                        //ReleaseDate = DateTime.Parse(mo.Properties["ReleaseDate"].Value.ToString());
                    }

                    mobos.Add(mobo);
                }
            }
            catch (Exception ex)
            {
                ErrorLogger.LogError("IndiciumHelper.GetMotherboards", ex.Message, ex.StackTrace);
            }

            return mobos;
        }

        public static List<Disk> GetDisks()
        {
            List<Disk> disks = new List<Disk>();

            try
            {
                ManagementObjectSearcher searcher2 = new ManagementObjectSearcher("SELECT * FROM Win32_DiskDrive");
                foreach (ManagementObject mo2 in searcher2.Get())
                {
                    Disk disk = new Disk();

                    disk.Model = Convert.ToString(mo2.Properties["Model"].Value);
                    disk.BytesPerSector = Convert.ToUInt32(mo2.Properties["BytesPerSector"].Value);
                    disk.FirmwareRevision = Convert.ToString(mo2.Properties["FirmwareRevision"].Value);
                    disk.MediaType = Convert.ToString(mo2.Properties["MediaType"].Value);
                    disk.Capacity = ByteSize.FromBytes(Convert.ToDouble(mo2.Properties["Size"].Value));

                    disks.Add(disk);
                }
            }
            catch (Exception ex)
            {
                ErrorLogger.LogError("IndiciumHelper.GetDisks", ex.Message, ex.StackTrace);
            }

            return disks;
        }

        public static void GetVolumes()
        {
            try
            {
                ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_Volume");
                foreach (ManagementObject mo in searcher.Get())
                {
                    Volume volume = new Volume();

                    volume.BlockSize = Convert.ToUInt64(mo.Properties["BlockSize"].Value);
                    volume.Capacity = ByteSize.FromBytes(Convert.ToDouble(mo.Properties["Capacity"].Value));
                    bool temp = Convert.ToBoolean(mo.Properties["Compressed"].Value);
                    volume.Compressed = (temp) ? "Yes" : "No";
                    volume.DriveLetter = Convert.ToString(mo.Properties["DriveLetter"].Value);
                    UInt32 i = Convert.ToUInt32(mo.Properties["DriveType"].Value);
                    volume.DriveType = SanitizeDriveType(i);
                    volume.FileSystem = Convert.ToString(mo.Properties["FileSystem"].Value);
                    volume.FreeSpace = ByteSize.FromBytes(Convert.ToDouble(mo.Properties["FreeSpace"].Value));
                    volume.UsedSpace = volume.Capacity.Subtract(volume.FreeSpace);
                    bool temp2 = Convert.ToBoolean(mo.Properties["IndexingEnabled"].Value);
                    volume.Indexing = (temp2) ? "Yes" : "No";
                    volume.Label = Convert.ToString(mo.Properties["Label"].Value);

                    if (i == 2)
                    {
                        Removables.Add(volume);
                    }
                    else if (i == 5)
                    {
                        Opticals.Add(volume);
                    }
                    else
                    {
                        Volumes.Add(volume);
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorLogger.LogError("IndiciumHelper.GetVolumes", ex.Message, ex.StackTrace);
            }
        }

        public static void GetPeripherals()
        {
            try
            {
                ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_Keyboard");
                foreach (ManagementObject mo in searcher.Get())
                {
                    Keyboard keyboard = new Keyboard();

                    keyboard.Name = Convert.ToString(mo.Properties["Description"].Value);
                    keyboard.Layout = Convert.ToString(mo.Properties["Layout"].Value);
                    keyboard.Status = Convert.ToString(mo.Properties["Status"].Value);
                    keyboard.FunctionKeys = Convert.ToUInt16(mo.Properties["NumberOfFunctionKeys"].Value);
                    bool temp = Convert.ToBoolean(mo.Properties["IsLocked"].Value);
                    keyboard.Locked = (temp) ? "Yes" : "No";

                    Keyboards.Add(keyboard);
                }
            }
            catch (Exception ex)
            {
                ErrorLogger.LogError("IndiciumHelper.GetKeyboards", ex.Message, ex.StackTrace);
            }

            try
            {
                ManagementObjectSearcher searcher2 = new ManagementObjectSearcher("SELECT * FROM Win32_PointingDevice");
                foreach (ManagementObject mo2 in searcher2.Get())
                {
                    PointingDevice pointingDevice = new PointingDevice();

                    pointingDevice.Name = Convert.ToString(mo2.Properties["Description"].Value);
                    pointingDevice.Manufacturer = Convert.ToString(mo2.Properties["Manufacturer"].Value);
                    pointingDevice.Status = Convert.ToString(mo2.Properties["Status"].Value);
                    pointingDevice.Buttons = Convert.ToUInt16(mo2.Properties["NumberOfButtons"].Value);
                    bool temp = Convert.ToBoolean(mo2.Properties["IsLocked"].Value);
                    pointingDevice.Locked = (temp) ? "Yes" : "No";
                    pointingDevice.HardwareType = Convert.ToString(mo2.Properties["HardwareType"].Value);
                    UInt16 i = Convert.ToUInt16(mo2.Properties["PointingType"].Value);
                    pointingDevice.PointingType = SanitizePointingType(i);
                    UInt16 i2 = Convert.ToUInt16(mo2.Properties["DeviceInterface"].Value);
                    pointingDevice.DeviceInterface = SanitizeDeviceInterface(i2);

                    PointingDevices.Add(pointingDevice);
                }
            }
            catch (Exception ex)
            {
                ErrorLogger.LogError("IndiciumHelper.GetPointingDevices", ex.Message, ex.StackTrace);
            }
        }

        public static List<GPU> GetGPUs()
        {
            List<GPU> GPUs = new List<GPU>();

            try
            {
                ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_VideoController");
                foreach (ManagementObject mo in searcher.Get())
                {
                    GPU gpu = new GPU();

                    gpu.Name = Convert.ToString(mo.Properties["Name"].Value);
                    gpu.Memory = ByteSize.FromBytes(Convert.ToDouble(mo.Properties["AdapterRAM"].Value));
                    gpu.ResolutionX = Convert.ToUInt32(mo.Properties["CurrentHorizontalResolution"].Value);
                    gpu.ResolutionY = Convert.ToUInt32(mo.Properties["CurrentVerticalResolution"].Value);
                    gpu.RefreshRate = Convert.ToUInt32(mo.Properties["CurrentRefreshRate"].Value);
                    gpu.DACType = Convert.ToString(mo.Properties["AdapterDACType"].Value);
                    UInt16 vtype = Convert.ToUInt16(mo.Properties["VideoMemoryType"].Value);
                    gpu.VideoMemoryType = SanitizeVideoMemoryType(vtype);

                    GPUs.Add(gpu);
                }
            }
            catch (Exception ex)
            {
                ErrorLogger.LogError("IndiciumHelper.GetGPUs", ex.Message, ex.StackTrace);
            }

            return GPUs;
        }

        public static void GetNetworkAdapters()
        {
            try
            {
                ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_NetworkAdapter");
                foreach (ManagementObject mo in searcher.Get())
                {
                    NetworkDevice adapter = new NetworkDevice();

                    adapter.AdapterType = Convert.ToString(mo.Properties["AdapterType"].Value);
                    adapter.Manufacturer = Convert.ToString(mo.Properties["Manufacturer"].Value);
                    adapter.ProductName = Convert.ToString(mo.Properties["ProductName"].Value);
                    bool temp = Convert.ToBoolean(mo.Properties["PhysicalAdapter"].Value);
                    adapter.PhysicalAdapter = (temp) ? "Yes" : "No";
                    adapter.MacAddress = Convert.ToString(mo.Properties["MacAddress"].Value);
                    adapter.ServiceName = Convert.ToString(mo.Properties["ServiceName"].Value);

                    if (temp)
                    {
                        PhysicalAdapters.Add(adapter);
                    }
                    else
                    {
                        VirtualAdapters.Add(adapter);
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorLogger.LogError("IndiciumHelper.GetNetworkAdapters", ex.Message, ex.StackTrace);
            }
        }

        public static List<AudioDevice> GetAudioDevices()
        {
            List<AudioDevice> audioDevices = new List<AudioDevice>();

            try
            {
                ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_SoundDevice");
                foreach (ManagementObject mo in searcher.Get())
                {
                    AudioDevice device = new AudioDevice();

                    device.ProductName = Convert.ToString(mo.Properties["ProductName"].Value);
                    device.Manufacturer = Convert.ToString(mo.Properties["Manufacturer"].Value);
                    device.Status = Convert.ToString(mo.Properties["Status"].Value);

                    audioDevices.Add(device);
                }
            }
            catch (Exception ex)
            {
                ErrorLogger.LogError("IndiciumHelper.GetAudioDevices", ex.Message, ex.StackTrace);
            }

            return audioDevices;
        }

        private static string SanitizeDriveType(UInt32 i)
        {
            string result = string.Empty;

            switch (i)
            {
                case 0:
                    result = "Unknown";
                    break;
                case 1:
                    result = "No Root Directory";
                    break;
                case 2:
                    result = "Removable Disk";
                    break;
                case 3:
                    result = "Local Disk";
                    break;
                case 4:
                    result = "Network Drive";
                    break;
                case 5:
                    result = "Compact Disk";
                    break;
                case 6:
                    result = "RAM Disk";
                    break;
            }

            return result;
        }

        private static string SanitizeVideoMemoryType(UInt16 i)
        {
            string result = string.Empty;

            switch (i)
            {
                case 1:
                    result = "Other";
                    break;
                case 2:
                    result = "Unknown";
                    break;
                case 3:
                    result = "VRAM";
                    break;
                case 4:
                    result = "DRAM";
                    break;
                case 5:
                    result = "SRAM";
                    break;
                case 6:
                    result = "WRAM";
                    break;
                case 7:
                    result = "EDO RAM";
                    break;
                case 8:
                    result = "Burst Synchronous DRAM";
                    break;
                case 9:
                    result = "Pipelined Burst SRAM";
                    break;
                case 10:
                    result = "CDRAM";
                    break;
                case 11:
                    result = "3DRAM";
                    break;
                case 12:
                    result = "SDRAM";
                    break;
                case 13:
                    result = "SGRAM";
                    break;
            }

            return result;
        }

        private static string SanitizeFormFactor(UInt16 i)
        {
            string result = string.Empty;

            switch (i)
            {
                case 0:
                    result = "Unknown";
                    break;
                case 1:
                    result = "Other";
                    break;
                case 2:
                    result = "SIP";
                    break;
                case 3:
                    result = "DIP";
                    break;
                case 4:
                    result = "ZIP";
                    break;
                case 5:
                    result = "SOJ";
                    break;
                case 6:
                    result = "Proprietary";
                    break;
                case 7:
                    result = "SIMM";
                    break;
                case 8:
                    result = "DIMM";
                    break;
                case 9:
                    result = "TSOP";
                    break;
                case 10:
                    result = "PGA";
                    break;
                case 11:
                    result = "RIMM";
                    break;
                case 12:
                    result = "SODIMM";
                    break;
                case 13:
                    result = "SRIMM";
                    break;
                case 14:
                    result = "SMD";
                    break;
                case 15:
                    result = "SSMP";
                    break;
                case 16:
                    result = "QFP";
                    break;
                case 17:
                    result = "TQFP";
                    break;
                case 18:
                    result = "SOIC";
                    break;
                case 19:
                    result = "LCC";
                    break;
                case 20:
                    result = "PLCC";
                    break;
                case 21:
                    result = "BGA";
                    break;
                case 22:
                    result = "FPBGA";
                    break;
                case 23:
                    result = "LGA";
                    break;
            }

            return result;
        }

        private static string SanitizeMemoryType(UInt16 i)
        {
            string result = string.Empty;

            switch (i)
            {
                case 0:
                    result = "Unknown";
                    break;
                case 1:
                    result = "Other";
                    break;
                case 2:
                    result = "DRAM";
                    break;
                case 3:
                    result = "Synchonous DRAM";
                    break;
                case 4:
                    result = "Cache DRAM";
                    break;
                case 5:
                    result = "EDO";
                    break;
                case 6:
                    result = "EDRAM";
                    break;
                case 7:
                    result = "VRAM";
                    break;
                case 8:
                    result = "SRAM";
                    break;
                case 9:
                    result = "RAM";
                    break;
                case 10:
                    result = "ROM";
                    break;
                case 11:
                    result = "Flash";
                    break;
                case 12:
                    result = "EEPROM";
                    break;
                case 13:
                    result = "FEPROM";
                    break;
                case 14:
                    result = "EPROM";
                    break;
                case 15:
                    result = "CDRAM";
                    break;
                case 16:
                    result = "3DRAM";
                    break;
                case 17:
                    result = "SDRAM";
                    break;
                case 18:
                    result = "SGRAM";
                    break;
                case 19:
                    result = "RDRAM";
                    break;
                case 20:
                    result = "DDR";
                    break;
                case 21:
                    result = "DDR2";
                    break;
                case 22:
                    result = "DDR2 FB-DIMM";
                    break;
                case 24:
                    result = "DDR3";
                    break;
                case 25:
                    result = "FBD2";
                    break;
            }

            return result;
        }

        private static string SanitizeDeviceInterface(UInt16 i)
        {
            string result = string.Empty;

            switch (i)
            {
                case 1:
                    result = "Other";
                    break;
                case 2:
                    result = "Unknown";
                    break;
                case 3:
                    result = "Serial";
                    break;
                case 4:
                    result = "PS/2";
                    break;
                case 5:
                    result = "Infrared";
                    break;
                case 6:
                    result = "HP-HIL";
                    break;
                case 7:
                    result = "Bus mouse";
                    break;
                case 8:
                    result = "ADB (Apple Desktop Bus)";
                    break;
                case 160:
                    result = "Bus mouse DB-9";
                    break;
                case 161:
                    result = "Bus mouse micro-DIN";
                    break;
                case 162:
                    result = "USB";
                    break;
            }

            return result;
        }

        private static string SanitizePointingType(UInt16 i)
        {
            string result = string.Empty;

            switch (i)
            {
                case 1:
                    result = "Other";
                    break;
                case 2:
                    result = "Unknown";
                    break;
                case 3:
                    result = "Mouse";
                    break;
                case 4:
                    result = "Track Ball";
                    break;
                case 5:
                    result = "Track Point";
                    break;
                case 6:
                    result = "Glide Point";
                    break;
                case 7:
                    result = "Touch Pad";
                    break;
                case 8:
                    result = "Touch Screen";
                    break;
                case 9:
                    result = "Mouse - Optical Sensor";
                    break;
            }

            return result;
        }
    }
}
