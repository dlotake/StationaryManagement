using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Store
{
    public class RelayCommand : System.Windows.Input.ICommand
    {
        #region Members
        Func<object, bool> canExecute;
        bool execute;
        Action<object> executeAction;
        #endregion

        public RelayCommand(Action<object> executeAction,Func<object,bool> canExecute,bool execute)
        {
            this.executeAction = executeAction;
            this.canExecute = canExecute;
            this.execute = execute;
        }



        #region ICommand Members
        public event EventHandler CanExecuteChanged
        {
            add
            {

                if (execute != null)
                {
                    CommandManager.RequerySuggested += value;
                }
            }
            remove
            {

                if (execute != null)
                {
                    CommandManager.RequerySuggested -= value;
                }
            }
        }

        [DebuggerStepThrough]
        public Boolean CanExecute(Object parameter)
        {
            return execute == null ? true : execute;
        }

        public void Execute(Object parameter)
        {
            executeAction(parameter);
        }
        #endregion
    }
}
