using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net;
using System.IO;

namespace Optimizer
{
    public class AppLinks
    {
      

        public List<AppInfo> Apps = new List<AppInfo>();

        public AppLinks()
        {
            string feed = @"feed.json";
            Apps = JsonConvert.DeserializeObject<List<AppInfo>>(File.ReadAllText(feed));

            
        }
    }
}
