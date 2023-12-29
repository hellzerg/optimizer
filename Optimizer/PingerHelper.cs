using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;

namespace Optimizer {
    internal static class PingerHelper {
        internal static string[] DNSOptions =
        {
            "Automatic",
            "Cloudflare",
            "OpenDNS",
            "Quad9",
            "Google",
            "AlternateDNS",
            "Adguard",
            "CleanBrowsing",
            "CleanBrowsing (adult filter)"
        };

        internal static string[] GoogleDNSv4 = { "8.8.8.8", "8.8.4.4" };
        internal static string[] GoogleDNSv6 = { "2001:4860:4860::8888", "2001:4860:4860::8844" };

        internal static string[] OpenDNSv4 = { "208.67.222.222", "208.67.220.220" };
        internal static string[] OpenDNSv6 = { "2620:0:ccc::2", "2620:0:ccd::2" };

        internal static string[] CloudflareDNSv4 = { "1.1.1.1", "1.0.0.1" };
        internal static string[] CloudflareDNSv6 = { "2606:4700:4700::1111", "2606:4700:4700::1001" };

        internal static string[] Quad9DNSv4 = { "9.9.9.9", "149.112.112.112" };
        internal static string[] Quad9DNSv6 = { "2620:fe::fe", string.Empty };

        internal static string[] CleanBrowsingDNSv4 = { "185.228.168.168", "185.228.168.169" };
        internal static string[] CleanBrowsingDNSv6 = { "2a0d:2a00:1::", "2a0d:2a00:2::" };

        internal static string[] CleanBrowsingAdultDNSv4 = { "185.228.168.10", "185.228.168.11" };
        internal static string[] CleanBrowsingAdultDNSv6 = { "2a0d:2a00:1::1", "2a0d:2a00:2::1" };

        internal static string[] AlternateDNSv4 = { "76.76.19.19", "76.223.122.150" };
        internal static string[] AlternateDNSv6 = { "2602:fcbc::ad", "2602:fcbc:2::ad" };

        internal static string[] AdguardDNSv4 = { "94.140.14.14", "94.140.15.15" };
        internal static string[] AdguardDNSv6 = { "2a10:50c0::ad1:ff", "2a10:50c0::ad2:ff" };

        internal static Ping pinger = new Ping();

        internal static bool ShowHiddenAdapters = false;
        internal static NetworkInterface[] NetworkAdapters = GetActiveNetworkAdapters();

        static IPAddress addressToPing;

        internal static NetworkInterface[] GetActiveNetworkAdapters() {
            try {
                if (ShowHiddenAdapters) NetworkAdapters = NetworkInterface.GetAllNetworkInterfaces();

                if (!ShowHiddenAdapters) NetworkAdapters = NetworkInterface.GetAllNetworkInterfaces().Where(
                    a => a.OperationalStatus == OperationalStatus.Up &&
                    (a.NetworkInterfaceType == NetworkInterfaceType.Wireless80211 || a.NetworkInterfaceType == NetworkInterfaceType.Ethernet) &&
                    a.GetIPProperties().GatewayAddresses.Any(g => g.Address.AddressFamily.ToString() == "InterNetwork")).ToArray();
            }
            catch (Exception ex) {
                Logger.LogError("PingerHelper.GetActiveNetworkAdapters", ex.Message, ex.StackTrace);
                return null;
            }

            return NetworkAdapters;
        }

        internal static IEnumerable<string> GetDNSFromNetworkAdapter(NetworkInterface nic) {
            try {
                return nic.GetIPProperties().DnsAddresses.Select(z => z.ToString());
            }
            catch (Exception ex) {
                Logger.LogError("PingerHelper.GetDNSFromNetworkAdapter", ex.Message, ex.StackTrace);
                return null;
            }
        }

        internal static void SetDNS(string nic, string[] dnsv4, string[] dnsv6) {
            string cmdv4Alternate = string.Empty;
            string cmdv6Alternate = string.Empty;

            string cmdv4Primary = $"netsh interface ipv4 set dnsservers {nic} static {dnsv4[0]} primary";
            if (dnsv4.Length == 2) {
                cmdv4Alternate = $"netsh interface ipv4 add dnsservers {nic} {dnsv4[1]} index=2";
            }

            string cmdv6Primary = $"netsh interface ipv6 set dnsservers {nic} static {dnsv6[0]} primary";
            if (dnsv6.Length == 2) {
                cmdv6Alternate = $"netsh interface ipv6 add dnsservers {nic} {dnsv6[1]} index=2";
            }


            Utilities.RunCommand(cmdv4Primary);
            Utilities.RunCommand(cmdv4Alternate);
            Utilities.RunCommand(cmdv6Primary);
            Utilities.RunCommand(cmdv6Alternate);
        }

        internal static void ResetDefaultDNS(string nic) {
            string cmdv4 = $"netsh interface ipv4 set dnsservers {nic} dhcp";
            string cmdv6 = $"netsh interface ipv6 set dnsservers {nic} dhcp";

            Utilities.RunCommand(cmdv4);
            Utilities.RunCommand(cmdv6);
        }

        internal static void ResetDefaultDNSForAllNICs() {
            foreach (string nic in NetworkAdapters.Select(x => x.Name)) {
                ResetDefaultDNS(nic);
            }
        }

        internal static void SetDNSForAllNICs(string[] dnsv4, string[] dnsv6) {
            foreach (string nic in NetworkAdapters.Select(x => x.Name)) {
                SetDNS(nic, dnsv4, dnsv6);
            }
        }

        internal static PingReply PingHost(string nameOrAddress) {
            PingReply reply;
            try {
                addressToPing = Dns.GetHostAddresses(nameOrAddress).First(address => address.AddressFamily == AddressFamily.InterNetwork);

                reply = pinger.Send(addressToPing);
                return reply;
            }
            catch {
                return null;
            }
        }

        // It uses the InternalDNS setting for this
        internal static bool IsInternetAvailable() {
            const int timeout = 1000;
            string host = OptionsHelper.CurrentOptions.InternalDNS ?? Constants.INTERNAL_DNS;

            var ping = new Ping();
            var buffer = new byte[32];
            var pingOptions = new PingOptions();

            try {
                var reply = ping.Send(host, timeout, buffer, pingOptions);
                return (reply != null && reply.Status == IPStatus.Success);
            }
            catch (Exception) {
                return false;
            }
        }

        internal static void FlushDNSCache() {
            Utilities.RunCommand("ipconfig /flushdns");
        }

        //internal static string PortScan(string IP, int port)
        //{
        //    IPAddress ipAddress = IPAddress.Parse(IP);
        //    IPEndPoint endPoint = new IPEndPoint(ipAddress, port);
        //    Socket sock = null;

        //    try
        //    {
        //        sock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        //        IAsyncResult result = sock.BeginConnect(endPoint, null, null);
        //        bool success = result.AsyncWaitHandle.WaitOne(100, true);
        //        if (sock.Connected)
        //        {
        //            sock.EndConnect(result);
        //            return $"{port} - [✓]";
        //        }
        //        else
        //        {
        //            return $"{port} - [×]";
        //        }


        //    }
        //    catch
        //    {
        //        return $"{port} - [×]";
        //    }
        //    finally
        //    {
        //        if (sock != null) sock.Close();
        //    }
        //}
    }
}
