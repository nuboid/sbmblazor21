using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;
using MyBlazorServerSideApp.Model;

namespace MyBlazorServerSideApp.ViewModels
{
    public class MyViewModel
    {
        public MyModel Model { get; set; }
        public ICommand MyCommand { get; set; }
        public ICommand MyCommand2 { get; set; }

        public MyViewModel()
        {
            Model = new MyModel
            {
                Name = "Kurt",
                Age = 50
            };

            MyCommand = new Command(OnExecute);
            MyCommand2 = new Command(OnExecute2);
        }

        private void OnExecute2()
        {
            var tmp = Model.Name;
        }

        private void OnExecute()
        {
            Model.Name = "CCCCCCCCCC" + DateTime.Now.Ticks;
        }
    }
}
