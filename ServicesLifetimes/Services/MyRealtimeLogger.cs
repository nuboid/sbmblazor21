using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServicesLifetimes.Services
{
    public class MyRealtimeLogger
    {
        private string _data;


        public void StoreSomething(string data)
        {
            _data = data;
            if (ReportLog != null)
            {
                ReportLog(data);
            }
            
        }

        public string GetSomething()
        {
            return _data;
        }

        public Action<string> ReportLog;
    }
}
