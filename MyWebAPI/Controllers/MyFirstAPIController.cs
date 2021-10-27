using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyRefitAPISpecification;

namespace MyWebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MyFirstAPIController : ControllerBase, IMyFirstAPI
    {

        [HttpPost("MyRoute")]
        public async Task<MyDto2> DoSometing(MyDto1 r)
        {
            //...
            return new MyDto2
            {
                Field1 = "dkjhskdjfhs",
                Field2 = 123
            };

        }
    }
}
