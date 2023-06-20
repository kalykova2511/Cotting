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
    /// Логика взаимодействия для Learning.xaml
    /// </summary>
    public partial class Learning : Page
    {
        int counter = 0;

        public Learning()
        {
            InitializeComponent();
            Counters.score = counter;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            line1.Opacity = 100;
            line2.Opacity = 100;
        }

        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            ClassesTabControl.SelectedItem = SecondTabItem;
        }

        private void Button_Click3(object sender, RoutedEventArgs e)
        {
            ClassesTabControl.SelectedItem = ThirdTabItem;
        }

        private void Button_Click4(object sender, RoutedEventArgs e)
        {
            ClassesTabControl.SelectedItem = ForthTabItem;
        }

        private void Button_Click5(object sender, RoutedEventArgs e)
        {
            ClassesTabControl.SelectedItem = FifthTabItem;
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

        private void AnswerChoice_Click(object sender, RoutedEventArgs e)
        {
            if (SelectedAnswer != null)
                if ((string)SelectedAnswer == (string)RightAnswer)
                {

                    Score1.Text = "1/1 балл!";
                    no1.Opacity = 0;
                    yes1.Opacity = 100;
                    counter++;
                }
                else
                {
                    yes1.Opacity = 0;
                    no1.Opacity = 100;
                }

        }
        string RightChoice = "Я молодец!У меня все получится";
        string SelectedChoice = "";

        private void MultiplyAnswerChoice_Click(object sender, RoutedEventArgs e)
        {
            int counter = 0;
            foreach (object obj in MPchoicePanel.Children)//Перебор CheckBox
            {
                if (obj is CheckBox)
                {
                    if (((CheckBox)obj).IsChecked == true)
                    {
                        counter += 1;
                        SelectedChoice += ((CheckBox)obj).Content;//Конкатенация правильных ответов
                    }
                }
            }
            if (counter != 0)//проверка выбрал ли пользователь ответ
            {
                if (RightChoice == SelectedChoice)//Сравнение привязанного ответа с выбранными
                {
                    //Интерфейсные изменения
                    Score2.Text = "1/1 балл!";
                    counter++;
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

        private void world_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                string right = "world";
                if (world.Text != right)
                {
                    world.Background = new SolidColorBrush(Colors.Red);
                    world.Text = "";
                }
                else
                {
                    world.Background = new SolidColorBrush(Colors.Green);
                    world.Text = "+1 балл";
                    counter++;
                }

            }
        }

        private void mir_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                string right = "миру";
                if (mir.Text != right)
                {
                    mir.Background = new SolidColorBrush(Colors.Red);
                    mir.Text = "";
                }
                else
                {
                    mir.Background = new SolidColorBrush(Colors.Green);
                    mir.Text = "+1 балл";
                    counter++;
                }

            }

        }

        private void copmputer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                string right = "компьютера";
                if (copmputer.Text != right)
                {
                    copmputer.Background = new SolidColorBrush(Colors.Red);
                    copmputer.Text = "";
                }
                else
                {
                    copmputer.Background = new SolidColorBrush(Colors.Green);
                    copmputer.Text = "+1 балл";
                    counter++;
                }

            }
        }

        private void Button_Click_Wrong(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Все верно! Правильно программировать");
            Score4.Text = "1/1 балл!";
            yes4.Opacity = 100;
            counter++;
        }
    }
}
