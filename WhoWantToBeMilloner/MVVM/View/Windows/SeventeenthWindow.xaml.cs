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
using System.Windows.Shapes;

namespace WhoWantToBeMilloner.MVVM.View.Windows
{
    /// <summary>
    /// Логика взаимодействия для SeventeenthWindow.xaml
    /// </summary>
    public partial class SeventeenthWindow : Window
    {
        public SeventeenthWindow()
        {
            InitializeComponent();
            Question.Text = "Если клиент просит ночную доставку, наши действия";
            OptionA.Content = "A:Откажем";
            OptionB.Content = "B:Сходим к Евгению Кургузоау и попросим лично съездить к клиенту";
            OptionС.Content = "C:Выставим счет на 4000,00 руб дополнительно";
            OptionD.Content = "D:Выставим счёт на 5500,00 руб дополнительно";
        }
        private void OptionA_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Это не правильный ответ");
            this.Hide();
            StartWindow startWindow = new StartWindow();
            startWindow.ShowDialog();
            this.Close();
        }

        private void OptionB_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Это не правильный ответ");
            this.Hide();
            StartWindow startWindow = new StartWindow();
            startWindow.ShowDialog();
            this.Close();
        }

        private void OptionС_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Это правильный ответ");
            this.Hide();
            EighteenthWindow eighteenthWindow = new EighteenthWindow();
            eighteenthWindow.ShowDialog();
            this.Close();
        }

        private void OptionD_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Это не правильный ответ");
            this.Hide();
            StartWindow startWindow = new StartWindow();
            startWindow.ShowDialog();
            this.Close();
        }

        private void Home_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            StartWindow startWindow = new StartWindow();
            startWindow.ShowDialog();
            this.Close();
        }

        private void Phone_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Друг сказал провильный ответ под буквой  C");
        }

        private void Group_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Большинство зрителей проголосовали за ответ под буквой C");
        }

        private void ELLipse_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Fifty_Click(object sender, RoutedEventArgs e)
        {
            OptionD.Visibility = Visibility.Hidden;
            OptionA.Visibility = Visibility.Hidden;
            LONG.Visibility = Visibility.Hidden;
            LONG2.Visibility = Visibility.Hidden;
        }
    }
}
