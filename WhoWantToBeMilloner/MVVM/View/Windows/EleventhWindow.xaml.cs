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
    /// Логика взаимодействия для EleventhWindow.xaml
    /// </summary>
    public partial class EleventhWindow : Window
    {
        public EleventhWindow()
        {
            InitializeComponent();
            Question.Text = "Когда мы привезем оборудование клиенту,который оплатил заказ в понедельник с утра, если товара нет на нашем складе";
            OptionA.Content = "A:Во вторник";
            OptionB.Content = "B:В среду";
            OptionС.Content = "C:Проф.кухонные ножи";
            OptionD.Content = "D:Жидкие моющие средства rational";
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
            MessageBox.Show("Это  правильный ответ");
            this.Hide();
            TwelfthWindow twelfthWindow = new TwelfthWindow();
            twelfthWindow.ShowDialog();
            this.Close();
        }

        private void OptionС_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Это не правильный ответ");
            this.Hide();
            StartWindow startWindow = new StartWindow();
            startWindow.ShowDialog();
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
            MessageBox.Show("Друг сказал провильный ответ под буквой  B");
        }

        private void Group_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Большинство зрителей проголосовали за ответ под буквой B");
        }

        private void ELLipse_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Fifty_Click(object sender, RoutedEventArgs e)
        {
            OptionA.Visibility = Visibility.Hidden;
            OptionD.Visibility = Visibility.Hidden;
            LONG.Visibility = Visibility.Hidden;
            LONG2.Visibility = Visibility.Hidden;
        }
    }
}
