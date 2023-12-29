//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Optimizer.Models {
//    public sealed class WorkEvent : List<WorkEventArgs> {
//        static object _lockObject = new object();
//        static object _syncRoot = new object();
//        static volatile WorkEvent _instance;

//        private WorkEvent() { }

//        public static WorkEvent Instance {
//            get {
//                if (_instance == null) {
//                    lock (_syncRoot) {
//                        if (_instance == null) {
//                            _instance = new WorkEvent();
//                        }
//                    }
//                }

//                return _instance;
//            }
//        }

//        public new void Add(WorkEventArgs wea) {
//            lock (_lockObject) {
//                base.Add(wea);
//            }
//        }

//        public new void Remove(WorkEventArgs wea) {
//            lock (_lockObject) {
//                base.Remove(wea);
//            }
//        }

//        public WorkEventArgs GetEventObject() {
//            if (this.Count > 0) {
//                if (this[0] != null) {
//                    WorkEventArgs dwoTemp = this[0];
//                    Remove(this[0]);
//                    return dwoTemp;

//                }
//                else {
//                    return null;
//                }
//            }
//            else {
//                return null;
//            }
//        }
//    }
//}
