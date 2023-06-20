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
    class VarPageViewModel : ViewModel
    {
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

        private string _Motivation = "Доброе утро, сегодня нам обещают привезти новорожденного котенка, " +
            "нам нужно рассчитать диаметр миски для нового жильца нашего приюта. Поэтому нам нужна программа, " +
            "которая будет спрашивать кличку котенка, его вес(дробное число - P), ширину головы(целое число - S) и окрас. " +
            "На выходе мы  должны получить кличку, окрас и вес в одной строке, а в следующей диаметр его миски.\r\n" +
            "Диаметр миски считается по такой формуле:\r\nD = P * 13.09 / S % 20 + 4\r\nДля того чтобы выполнить задание, " +
            "вы сегодня узнаете\r\n - какие есть типы данных\r\n - какие есть требования к переменным\r\n" +
            " - как вводить и выводить данные\r\n - как пользоваться математическими операциями\r\n";

        public string Motivaton
        {
            get => _Motivation;
            set => Set(ref _Motivation, value);
        }

        private string _Text1 = "Переменные напоминают контейнеры для переработки мусора, но нужны они не для сортировки отходов, " +
            "а для хранения данных в программе. Мы можем менять значение переменной сколько угодно, но должны следить, чтобы тип данных, " +
            "который мы помещаем в переменную совпадал с типом переменной.\r\nОсновные тип переменных, которые мы будем использовать\r\n";

        public string Text1
        {
            get => _Text1;
            set => Set(ref _Text1, value);
        }

        private string _Text2 = "Чтобы пользоваться переменной, сначала нужно ее объявить. Первое слово - это тип переменной, " +
            "а второе - это ее имя, также мы можем сразу же задать значение к переменной, как на первом скриншоте. " +
            "В дальнейшем с помощью имени мы сможем обращаться к переменной.\r\n";

        public string Text2
        {
            get => _Text2;
            set => Set(ref _Text2, value);
        }

        private string _Text3 = "В качестве имени переменной лучше выбирать слова,которые отражают ее назначение и " +
            "удовлетворяют следующим требованиям:" +
            "\r\n1 - имя может содержать любые цифры,латинские буквы и символ подчеркивания, при этом первый символ в имени не может быть цифрой" +
            "\r\n2 - в имени не должно быть знаков пунктуации и пробелов\r\n" +
            "3 -имя не может быть ключевым словом языка C#. Таких слов не так много, и при работе в Visual Studio среда разработки подсвечивает ключевые слова синим цветом.\r\n";

        public string Text3
        {
            get => _Text3;
            set => Set(ref _Text3, value);
        }

        private string _Text4 = "!!! Имена, которые отличаются только регистрами, будут считаться разными именами !!!";

        public string Text4
        {
            get => _Text4;
            set => Set(ref _Text4, value);
        }

    }
}
