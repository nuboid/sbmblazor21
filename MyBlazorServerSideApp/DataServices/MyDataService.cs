using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyBlazorServerSideApp.DataServices
{
    public class MyDataService
    {
        public List<MyDataStructure> GetData()
        {
            return new List<MyDataStructure>
            {
                new MyDataStructure
                {
                    Id = "1",
                    FirstName = "Kurt",
                    LastName = "Claeys"
                },
                new MyDataStructure
                {
                    Id = "2",
                    FirstName = "Elon",
                    LastName = "Musk"
                }
            };
        }

        public void UpdateData(MyDataStructure myDataStructure)
        {
            
        }
    }

    public class MyDataStructure
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string FullName => FirstName + " " + LastName;
    }
}
