using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace ProductivityTools.Examples.WPFDependencyProperty
{
    public class CommandHandler : ICommand
    {
        public event EventHandler CanExecuteChanged;
        public Action Action;

        public CommandHandler(Action a)
        {
            this.Action = a;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            this.Action();
        }
    }
}
