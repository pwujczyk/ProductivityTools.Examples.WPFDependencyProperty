using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace ProductivityTools.Examples.WPFDependencyProperty
{
    public class MainWindowVM
    {
        public string CBText { get; set; }

        public ICommand ClickCommand { get; }

        public MainWindowVM()
        {
            this.ClickCommand = new CommandHandler(DoSomething);
        }

        public void DoSomething()
        {

        }
    }
}
