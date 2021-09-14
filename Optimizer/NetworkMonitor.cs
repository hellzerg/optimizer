//using System.Collections;
//using System.Diagnostics;
//using System.Timers;

//namespace Optimizer
//{
//    public class NetworkMonitor
//    {
//        Timer _timer;
//        ArrayList _adapters;
//        ArrayList _monitoredAdapters;

//        public NetworkMonitor()
//        {
//            _adapters = new ArrayList();
//            _monitoredAdapters = new ArrayList();
//            EnumerateNetworkAdapters();

//            _timer = new Timer(1000);
//            _timer.Elapsed += new ElapsedEventHandler(timer_Elapsed);
//        }

//        private void EnumerateNetworkAdapters()
//        {
//            PerformanceCounterCategory category = new PerformanceCounterCategory("Network Interface");

//            foreach (string name in category.GetInstanceNames())
//            {
//                if (name == "MS TCP Loopback interface") continue;
//                if (name.ToLowerInvariant().Contains("virtual")) continue;
//                if (name.ToLowerInvariant().Contains("hyper-v")) continue;

//                NetworkAdapter adapter = new NetworkAdapter(name);
//                adapter.DownloadCounter = new PerformanceCounter("Network Interface", "Bytes Received/sec", name);
//                adapter.UploadCounter = new PerformanceCounter("Network Interface", "Bytes Sent/sec", name);
//                _adapters.Add(adapter);
//            }
//        }

//        private void timer_Elapsed(object sender, ElapsedEventArgs e)
//        {
//            foreach (NetworkAdapter adapter in this._monitoredAdapters)
//            {
//                adapter.Refresh();
//            }
//        }

//        public NetworkAdapter[] Adapters
//        {
//            get { return (NetworkAdapter[])_adapters.ToArray(typeof(NetworkAdapter)); }
//        }

//        public void StartMonitoring()
//        {
//            if (_adapters.Count > 0)
//            {
//                foreach (NetworkAdapter adapter in _adapters)
//                {
//                    if (!_monitoredAdapters.Contains(adapter))
//                    {
//                        _monitoredAdapters.Add(adapter);
//                        adapter.Initialize();
//                    }
//                }

//                _timer.Enabled = true;
//            }
//        }

//        public void StartMonitoring(NetworkAdapter adapter)
//        {
//            if (!_monitoredAdapters.Contains(adapter))
//            {
//                _monitoredAdapters.Add(adapter);
//                adapter.Initialize();
//            }

//            _timer.Enabled = true;
//        }

//        public void StopMonitoring()
//        {
//            _monitoredAdapters.Clear();
//            _timer.Enabled = false;
//        }

//        public void StopMonitoring(NetworkAdapter adapter)
//        {
//            if (_monitoredAdapters.Contains(adapter))
//            {
//                _monitoredAdapters.Remove(adapter);
//            }

//            if (_monitoredAdapters.Count == 0)
//            {
//                _timer.Enabled = false;
//            }
//        }
//    }
//}
