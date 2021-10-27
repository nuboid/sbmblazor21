using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using Refit;

namespace MyRefitAPISpecification
{

    public interface IMyFirstAPI
    {
        [Post("/MyFirstAPI/MyRoute")]
        Task<MyDto2> DoSometing(MyDto1 r);
    }

    public class MyDto1
    {
        public string Field1 { get; set; }
        public int Field2 { get; set; }
    }

    public class MyDto2
    {
        public string Field1 { get; set; }
        public int Field2 { get; set; }
    }
}
