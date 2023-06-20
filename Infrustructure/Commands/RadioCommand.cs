using Cotting.Infrustructure.Commands.Base;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Cotting.Infrustructure.Commands
{
    internal class RadioCommand : Command
    {
        private readonly Predicate<object> _canExecute;
        private readonly Action<object> _execute;

        public RadioCommand(Action<object> execute) : this(execute, null)
        {
        }

        public RadioCommand(Action<object> execute, Predicate<object> canExecute)
        {
            if (execute == null) throw new ArgumentNullException("execute");

            _execute = execute;
            _canExecute = canExecute;
        }

        [DebuggerStepThrough]
        public override bool CanExecute(object parameter)
        {
            return _canExecute == null ? true : _canExecute(parameter);
        }

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public override void Execute(object parameter)
        {
            _execute(parameter);
        }
    }
}
