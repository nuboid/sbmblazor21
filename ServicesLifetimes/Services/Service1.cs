using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServicesLifetimes.Services
{
    public class Service1
    {
        private string _data;

        public void StoreSomething(string data)
        {
            _data = data;
        }

        public string GetSomething()
        {
            return _data;
        }
    }
}
