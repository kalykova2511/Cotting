using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
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
using static System.Formats.Asn1.AsnWriter;

namespace Cotting.Views.Windows
{
    /// <summary>
    /// Логика взаимодействия для OperatorsPage.xaml
    /// </summary>
    public partial class OperatorsPage : Page
    {
        public OperatorsPage()
        {
            InitializeComponent();
            counter = Counters.Score;
        }

        static int counter = 0;

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
            ClassesTabControl.SelectedItem = SevenTabItem;
        }

        private void Button_Click_NextPage7(object sender, RoutedEventArgs e)
        {
            ClassesTabControl.SelectedItem = EightTabItem;
        }

        private void Button_Click_NextPage8(object sender, RoutedEventArgs e)
        {
            ClassesTabControl.SelectedItem = NinthTabItem;
        }

        private void Button_Click_NextPage9(object sender, RoutedEventArgs e)
        {
            ClassesTabControl.SelectedItem = TenTabItem;
        }

        private void MultiplyAnswerChoice_Click1(object sender, RoutedEventArgs e)
        {
            string RightChoice = "!||";
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
            if (SelectedAnswer != null)
                if ((string)SelectedAnswer == (string)RightAnswer)
                {
                    Score2.Text = "1/1 балл!";
                    counter += 1;
                    no2.Opacity = 0;
                    yes2.Opacity = 100;
                }
                else
                {
                    yes2.Opacity = 0;
                    no2.Opacity = 100;
                }
        }

        private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                string right = "4";
                if (TextBox.Text != right)
                {
                    TextBox.Background = new SolidColorBrush(Colors.Red);
                }
                else
                {
                    TextBox.Background = new SolidColorBrush(Colors.Green);
                    TextBox.Text = "+1 балл";
                    counter++;
                }

            }
        }
    }
}
