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
    class VSPageViewModel : ViewModel
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

        private string _Motivation = "Доброе утро, мы очень рады, что вы отозвались на наше объявление о наборе штатных C# программистов. Сегодня ваш первый рабочий день в нашем кошачьем приюте “Лапка помощи”.\n Вот ваши задания на сегодня:\r\n1 - Загрузить среду разработки Visual Studio на ваш рабочий компьютер\r\n2 - Вкусно пообедать\r\n3 - Создать первый проект\r\n4 - Объяснить коту загрузку\r\n";

        public string Motivaton
        {
            get => _Motivation;
            set => Set(ref _Motivation, value);
        }

        private string _Install = "Для начала необходимо проверить, что ваш компьютер соответствует требованиям к системе\r\n\r\nhttps://learn.microsoft.com/ru-ru/visualstudio/releases/2022/system-requirements\r\n\r\nПосле этого, необходимо загрузить visual Studio из официального источника\r\n\r\nhttps://visualstudio.microsoft.com/ru/ \r\n";

        public string Install
        {
            get => _Install;
            set => Set(ref _Install, value);
        }

        private string _Install2 = "Для начала обучения рекомендуем скачать версию Community, в нее не входят некоторые функции, что есть в других платных версиях, но для начала они не понадобятся.\r\nПосле окончания загрузки в папке Загрузки дважды щелкните VisualStudioSetup.exe начального загрузчика, чтобы начать установку.\r\n";

        public string Install2
        {
            get => _Install2;
            set => Set(ref _Install2, value);
        }

        private string _Install3 = "После скачивания и распаковки, выйдет такое окно.\r\n";
        public string Install3
        {
            get => _Install3;
            set => Set(ref _Install3, value);
        }
        private string _Install4 = "После окончания загрузки предлагается выбрать компоненты для скачивания, в этом курсе, мы рекомендуем скачать только Разработку классических приложений .Net.\r\n";

        public string Install4
        {
            get => _Install4;
            set => Set(ref _Install4, value);
        }

        private string _Install5 = "Когда установка Visual Studio завершится, нажмите кнопку Запустить, чтобы приступить к разработке в Visual Studio. На начальном экране выберите Создать проект.Далее выбираем консольное приложение(.NET Framework), после перехода на следующую страницу выбрать платформу .NET Framework 4.8";

        public string Install5
        {
            get => _Install5;
            set => Set(ref _Install5, value);
        }
    }
}
