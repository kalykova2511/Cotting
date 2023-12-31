﻿using Cotting.Infrustructure.Commands;
using Cotting.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Cotting.ViewModels
{
    internal class CyclesViewModel: ViewModel
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

        private string _Motivation = "Ой-ой-ой! Два наших ветеринара жутко поспорили, " +
            "через сколько дней родится малыш котенок. Их предположения абсолютно секретны, " +
            "поэтому для программы нужна авторизация. Напишите, пожалуйста, программу, " +
            "которая должна считать дни до рождения котенка и проверять: совпадает ли их прогноз с реальностью." +
            "\nДля этого вы должны узнать что такое:" +
            "\n- Цикл while" +
            "\n- Цикл for" +
            "\n- Цикл do..while" +
            "\nХорошего вам дня!!";

        public string Motivaton
        {
            get => _Motivation;
            set => Set(ref _Motivation, value);
        }

        private string _Text1 = "Циклы - это конструкция, которая позволяет выполнять какую-либо часть кода множество раз, " +
            "пока не выполнится условие. Существует три основных вида цикла, которые различаются тем, когда и как проверяется условие. " +
            "/nСейчас разберем цикл While. Цикл While - это самый простой вид цикла. Он смотрит на выполнение условия и если условие выполняется, " +
            "он начинает действовать. Потом, когда условие перестает выполняться, он завершает работу." +
            "/nВот так выглядит синтаксис цикла While.В круглых скобках находится условие, которое должно выполняться, а в фигурных - действие.\n";

        public string Text1
        {
            get => _Text1;
            set => Set(ref _Text1, value);
        }

        private string _Text2 = "Также помимо цикла While, который сначала проверяет условие, " +
            "а потом действие, существует цикл Do…While, который сначала выполняет действие, а потом проверяет условие." +
            "Например, такой цикл используется при вводе пароля, вы вводите пароль и уже потом программа проверяет насколько он верный.\n";

        public string Text2
        {
            get => _Text2;
            set => Set(ref _Text2, value);
        }

        private string _Text3 = "Объявление цикла for состоит из трех частей. " +
            "\nПервая часть объявления цикла - это объявление переменных, которые будут использоваться в цикле." +
            "\nВторая часть - условие, при котором будет выполняться цикл.Пока условие истинно, будет выполняться цикл." +
            "\nИ третья часть - некоторые действия, которые выполняются в конце каждого действия цикла." +
            "\nПосле объявления цикла, в фигурных скобках помещаются сами действия цикла.\n";

        public string Text3
        {
            get => _Text3;
            set => Set(ref _Text3, value);
        }

        private string _Text4 = "Также этот цикл с одним действием можно сократить и убрать фигурные скобки.\n";

        public string Text4
        {
            get => _Text4;
            set => Set(ref _Text4, value);
        }

        private string _Text5 = "Обычно такие циклы используются, когда счетчик (i) " +
            "должен принять конкретное значение, вместо них также можно использовать " +
            "классические циклы while, но эти сильно упрощают программу.\n";

        public string Text5
        {
            get => _Text5;
            set => Set(ref _Text5, value);
        }

        private string _Text6 = "Теперь в каждом уроке будет раздел теории с советами по код-стайлу. Это поможет писать красивый  читабельный код для других." +
            "\n1. Имена переменных должны описывать их назначение и каждое слово в их названии должно начинаться с большой буквы, " +
            "кроме первого, также не нужно использовать слово of.Русские слова, записанные английскими буквами тоже лучше избегать." +
            "\n2. Для отступов используйте 4 пробела вместо табуляции." +
            "\n3.Избегайте использования аббревиатур в именах переменных\n";

        public string Text6
        {
            get => _Text6;
            set => Set(ref _Text6, value);
        }

        private string _Text7 = "В данном случае конструкция switch последовательно сравнивает значение переменной name с набором значений, " +
            "которые указаны после операторов case. Поскольку здесь значение переменной name - строка Мявка, " +
            "то будет выполняться первый блок. Каждый case необходимо заканчивать словом break. " +
            "Также можно учесть случай, при котором никакое значение case не подходит. Тогда можно добавить case под названием default.";

        public string Text7
        {
            get => _Text7;
            set => Set(ref _Text7, value);
        }

        private string _Text8 = "Какие логические операции нужны для перевода этого предложения в выражение:\n Мурзик или Муся не сидели на трубе.";

        public string Text8
        {
            get => _Text8;
            set => Set(ref _Text8, value);
        }

        private string _Text9 = "Нам необходимо подобрать подушки семи кошкам: " +
           "\n-Марусе - нужна яркая и твердая подушка" +
           "\n-Рыжику - нужна мягкая, но не зеленая подушка" +
           "\n-Алисе - нужна подушка с натуральными наполнителями" +
           "\n-Мусе - нужна круглая или овальная подушка" +
           "\n-Соне - нужна декоративная подушка" +
           "\n-Васе - нужна дакимакура любая, но без изображения жирафов" +
           "\n-Кузе - нужна ортопедическая соломенная подушка\n" +
           "\nПрограмма должна спрашивать пользователя, для какой именно кошки нужно подобрать подушку, и потом задавать вопросы, чтобы определить, подходит эта подушка или нет";

        public string Text9
        {
            get => _Text9;
            set => Set(ref _Text9, value);
        }
    }
}
