using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MyBlazorServerSideApp
{
    public class Command : ICommand
    {
        private Action _execute;
        public Command(Action execute)
        {
            _execute = execute;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute()
        {
            _execute?.Invoke();
        }

        public void Execute(object parameter)
        {
            _execute?.Invoke();
        }
    }
}
