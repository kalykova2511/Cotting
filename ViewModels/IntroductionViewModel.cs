using Cotting.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cotting.ViewModels
{
    internal class IntroductionWindowViewModel : ViewModel
    {

        private string _Introduction = "Привет. Это вводный урок.\n" +
            "Внимательно ознакомься с типами заданий и способом их выполнения." +
            "Для удобства каждый тип заданий обозначен своей иконкой:";

        public string Introduction
        {
            get => _Introduction;
            set => Set(ref _Introduction, value);
        }

        private string _GraduationCup = "Теоретические материалы, необходимые для прохождения уроков";

        public string GraduationCup
        {
            get => _GraduationCup;
            set => Set(ref _GraduationCup, value);
        }

        private string _List = "Тесты на проверку теоретических знаний";

        public string List
        {
            get => _List;
            set => Set(ref _List, value);
        }

        private string _Check = "Выбор верного ответа";

        public string Check
        {
            get => _Check;
            set => Set(ref _Check, value);
        }

        private string _Pen = "Вписать свой ответ, заполнить пропуски";

        public string Pen
        {
            get => _Pen;
            set => Set(ref _Pen, value);
        }

        private string _Search = "Поиск ошибок в коде";

        public string Search
        {
            get => _Search;
            set => Set(ref _Search, value);
        }
    }
}
