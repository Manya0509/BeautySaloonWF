using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beauty.modals
{
    public class PayingInfo
    {
        public string MasterName { get; set; }
        public DateTime Time { get; set; }
        public Service Service { get; set; }

        public PayingInfo() { }
        public PayingInfo(string masterName, DateTime time, Service service) 
        {
            MasterName = masterName;
            Service = service;
            Time = time;   
        }


    }
}
