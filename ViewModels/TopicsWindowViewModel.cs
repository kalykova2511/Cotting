using Cotting.Infrustructure.Commands;
using Cotting.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;

namespace Cotting.ViewModels
{
    class TopicsWindowViewModel : ViewModel
    {
        private ICommand? _radioCommand; //Создание команды в контексте окна
        public ICommand RadioCommand
        {
            get
            {
                if (_radioCommand == null)
                    _radioCommand = new RadioCommand((param) => { RadioMethod(param); });//Использование модели команды
                return _radioCommand;
            }
        }

        private void RadioMethod(object parametr)
        {
            string pageUri = (string)parametr;//Привязка ссылки на страницу к объекту
        }

        private ICommand? _checkAnswer; //Создание команды в контексте окна
        public ICommand CheckAnswer
        {
            get
            {
                if (_checkAnswer == null)
                    _checkAnswer = new CheckAnswer((param) => { CheckMethod(param); });//Использование модели команды
                return _radioCommand;
            }
        }

        private void CheckMethod(object parametr)
        {
            string answer = (string)parametr;//Привязка верного ответа
        }

        private ICommand? _checkMultiplyAnswer;//Создание команды в контексте окна
        public ICommand CheckMultiplyAnswer
        {
            get
            {
                if (_checkMultiplyAnswer == null)
                    _checkMultiplyAnswer = new CheckAnswer((param) => { CheckMethod(param); });// Использование модели команды
                return _radioCommand;
            }
        }

        private void CheckMultiplyMethod(object parametr)
        {
            string answer = (string)parametr;//Привязка конкатенированных верных ответов
        }
    }
}
