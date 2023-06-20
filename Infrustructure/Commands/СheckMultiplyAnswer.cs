using Cotting.Infrustructure.Commands.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Cotting.Infrustructure.Commands
{
    internal class СheckMultiplyAnswer: Command
    {
        private readonly Action<object> _Execute;
        private readonly Func<object, bool> _CanExecute;

        public СheckMultiplyAnswer(Action<object> Execute, Func<object, bool> CanExecute = null)
        {
            _Execute = Execute;
            _CanExecute = CanExecute;
        }

        public override bool CanExecute(object parameter) => _CanExecute?.Invoke(parameter) ?? true;//Настройка доступа
        public override void Execute(object parameter) => _Execute(parameter);//Привязка поведения

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }//Добавление в менеджер команд
            remove { CommandManager.RequerySuggested -= value; }//Удаление из менеджера команд
        }
    }
}

