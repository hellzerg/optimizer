//using System.Diagnostics;

//namespace Optimizer
//{
//    public class NetworkAdapter
//    {
//        long _downloadSpeed, _uploadSpeed;
//        long _downloadValue, _uploadValue;
//        long _downloadValueOld, _uploadValueOld;

//        string _name;

//        internal PerformanceCounter DownloadCounter, UploadCounter;

//        internal NetworkAdapter(string name)
//        {
//            _name = name;
//        }

//        internal void Initialize()
//        {
//            _downloadValueOld = DownloadCounter.NextSample().RawValue;
//            _uploadValueOld = UploadCounter.NextSample().RawValue;
//        }

//        internal void Refresh()
//        {
//            _downloadValue = DownloadCounter.NextSample().RawValue;
//            _uploadValue = UploadCounter.NextSample().RawValue;

//            _downloadSpeed = _downloadValue - _downloadValueOld;
//            _uploadSpeed = _uploadValue - _uploadValueOld;

//            _downloadValueOld = _downloadValue;
//            _uploadValueOld = _uploadValue;
//        }

//        public override string ToString()
//        {
//            return _name;
//        }

//        public string Name
//        {
//            get { return _name; }
//        }

//        public long DownloadSpeed
//        {
//            get { return _downloadSpeed; }
//        }

//        public long UploadSpeed
//        {
//            get { return _uploadSpeed; }
//        }

//        public double DownloadSpeedKbps
//        {
//            get { return this._downloadSpeed / 1024.0; }
//        }

//        public double UploadSpeedKbps
//        {
//            get { return this._uploadSpeed / 1024.0; }
//        }

//        public double DownloadSpeedMbps
//        {
//            get { return this._downloadSpeed / 1024.0 / 1024.0; }
//        }

//        public double UploadSpeedMbps
//        {
//            get { return this._uploadSpeed / 1024.0 / 1024.0; }
//        }
//    }
//}
