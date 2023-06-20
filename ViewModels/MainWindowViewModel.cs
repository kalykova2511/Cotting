using Cotting.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cotting.ViewModels
{
    internal class MainWindowViewModel : ViewModel
    {
        private string _Title = "Coting";//Данные

        public string Title
        {
            get => _Title;
            set => Set(ref _Title, value);//Обновление при изменении
        }

        private string _Intro = "Добро пожаловать в приложение по обучению C#.\n " +
            $"Вам предстоит поработать настоящим программистом и помочь кошачьему приюту решить их проблемы.\n" +
            $"Чтобы начать обучение нажмите на кнопку ниже. Приятного путешествия в мир программирования.";//Данные

        public string Intro
        {
            get => _Intro;
            set => Set(ref _Intro, value);//Обновление при изменении
        }
    }
}

