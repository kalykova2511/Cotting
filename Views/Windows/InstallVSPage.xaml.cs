using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Cotting.Views.Windows
{
    /// <summary>
    /// Логика взаимодействия для InstallVSPage.xaml
    /// </summary>
    public partial class InstallVSPage : Page
    {
        static int counter = 0;

        public InstallVSPage()
        {
            InitializeComponent();
            counter = Counters.Score;
        }

        private void Button_Click_NextPage1(object sender, RoutedEventArgs e)
        {
            ClassesTabControl.SelectedItem = SecondTabItem;
        }

        private void Button_Click_NextPage2(object sender, RoutedEventArgs e)
        {
            ClassesTabControl.SelectedItem = ThirdTabItem;
        }

        private void Button_Click_NextPage3(object sender, RoutedEventArgs e)
        {
            ClassesTabControl.SelectedItem = ForthTabItem;
        }

        private void Button_Click_NextPage4(object sender, RoutedEventArgs e)
        {
            ClassesTabControl.SelectedItem = FifthTabItem;
        }

        private void Button_Click_NextPage5(object sender, RoutedEventArgs e)
        {
            ClassesTabControl.SelectedItem = SixthTabItem;
        }

        private void Button_Click_NextPage6(object sender, RoutedEventArgs e)
        {
            ClassesTabControl.SelectedItem = SeventhTabItem;
        }

        private void MultiplyAnswerChoice_Click1(object sender, RoutedEventArgs e)
        {
            string RightChoice = "EnterpriseProfessional";
            string SelectedChoice = "";
            foreach (object obj in MPchoicePanel.Children)
            {
                if (obj is CheckBox)
                {
                    if (((CheckBox)obj).IsChecked == true)
                    {
                        counter += 1;
                        SelectedChoice += ((CheckBox)obj).Content;
                    }
                }
            }
            if (counter != 0)
            {
                if (RightChoice == SelectedChoice)
                {
                    Score1.Text = "1/1 балл!";
                    no1.Opacity = 0;
                    yes1.Opacity = 100;
                    Counters.score1++;
                }
                else
                {
                    yes1.Opacity = 0;
                    no1.Opacity = 100;
                }
            }
        }

        public object SelectedAnswer { get; private set; }
        public object RightAnswer { get; private set; }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            if (sender is RadioButton item)
            {
                SelectedAnswer = item.Content;
                RightAnswer = item.CommandParameter;
            }
        }

        private void AnswerChoice_Click1(object sender, RoutedEventArgs e)
        {
            if (SelectedAnswer != null) //Проверка выбрал ли пользователь ответ
                if ((string)SelectedAnswer == (string)RightAnswer)//Сравнение данных в кнопке с привязанными данными
                {
                    //Интерфейсные изменения
                    Score2.Text = "1/1 балл!";
                    counter += 1;
                    no2.Opacity = 0;
                    yes2.Opacity = 100;
                }
                else
                {
                    //Интерфейсные изменения
                    yes2.Opacity = 0;
                    no2.Opacity = 100;
                }
        }
    }
}
