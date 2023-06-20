using Cotting.Infrustructure.Commands;
using Cotting.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Cotting.ViewModels
{
    internal class LearningWindowViewModel : ViewModel
    {
        //_______________________________________________________________//

        private string _IntroText = "В данном типе заданий нет ничего сложного! " +
            "Читай много интересного и наслаждайся. " +
            "Давай потренеруемся с другими типами. Для этого перейди в следующую вкладку, " +
            "нажав на верхнее меню или на стрелочку снизу";

        public string IntroText
        {
            get => _IntroText;
            set => Set(ref _IntroText, value);
        }

        private string _ChooseOneText = "Выбери единственый верный ответ:";

        public string ChooseOneText
        {
            get => _ChooseOneText;
            set => Set(ref _ChooseOneText, value);
        }


        #region Commands
        //_______________________________________________________________//

        private ICommand _radioCommand;

        public ICommand RadioCommand
        {
            get
            {
                if (_radioCommand == null)
                    _radioCommand = new RadioCommand((param) => { RadioMethod(param); });
                return _radioCommand;
            }
        }

        private void RadioMethod(object parametr)
        {
            string answer = (string)parametr;
        }
        //_______________________________________________________________//
        #endregion
    }
}
