//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;

//namespace Optimizer.Models {
//    public sealed class WorkEventArgs {
//        string _fileName;
//        string _eventType;
//        ListViewItem _currentItem;

//        public WorkEventArgs(string fileName, string eventType, ListViewItem currentItem) {
//            _fileName = fileName;
//            _eventType = eventType;

//            if (currentItem != null) {
//                _currentItem = currentItem;
//            }
//        }

//        public string FileName {
//            get {
//                return _fileName;
//            }
//        }

//        public string EventType {
//            get {
//                return _eventType;
//            }
//        }

//        public ListViewItem CurrentItem {
//            get {
//                if (_currentItem != null) {
//                    return _currentItem;
//                }
//                else {
//                    return null;
//                }
//            }
//        }
//    }
//}
