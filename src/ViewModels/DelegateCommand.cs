using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ViewModels
{
    // RelayCommand
    public class DelegateCommand : ICommand
    {
        public event EventHandler? CanExecuteChanged;

        private readonly Action execute;
        private readonly Func<object, bool> canExecute;

        public DelegateCommand(Action execute, Func<object, bool> canExecute = null)
        {
            this.execute = execute;
            this.canExecute = canExecute;
        }

        public bool CanExecute(object? parameter)
        {
            return canExecute == null || canExecute.Invoke(parameter);
        }

        public void Execute(object? parameter)
        {
            //if (execute != null)
            //    execute.Invoke();
            //    
            execute?.Invoke();
        }
    }
}
