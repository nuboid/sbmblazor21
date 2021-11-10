using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ServicesLifetimes.Services;

namespace ServicesLifetimes.Controllers
{
    [ApiController]
    [Route("api/v1/mydemo")]
    public class MyDemoController : ControllerBase
    {
        private readonly MyRealtimeLogger _myRealtimeLogger;

        public MyDemoController(MyRealtimeLogger myRealtimeLogger)
        {
            _myRealtimeLogger = myRealtimeLogger;
        }
        [HttpGet]
        [Route("Set")]
        public async Task<string> GetSomething(string param)
        {
            _myRealtimeLogger.StoreSomething(param);
            return await Task.FromResult("test");
        }

        [HttpGet]
        [Route("Retrieve")]
        public async Task<string> RetrieveSomething()
        {
            return await Task.FromResult(_myRealtimeLogger.GetSomething());
        }
    }
}
