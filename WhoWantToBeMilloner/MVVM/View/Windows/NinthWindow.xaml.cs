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
    /// Логика взаимодействия для NinthWindow.xaml
    /// </summary>
    public partial class NinthWindow : Window
    {
        public NinthWindow()
        {
            InitializeComponent();
            Question.Text = "Какое оборудование не влезет в газельку высотой 160см";
            OptionA.Content = "A:Тестомест хуракан hkn 30m";
            OptionB.Content = "B:Ларь моррзильный млк 700";
            OptionС.Content = "C:Шкаф холодильный polair CB 110 S";
            OptionD.Content = "D:Печь для пиццы itpizza ml 44";
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
            TenthWindow tenthWindow = new TenthWindow();
            tenthWindow.ShowDialog();
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
            MessageBox.Show("Друг сказал провильный ответ под буквой  С");
        }

        private void Group_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Большинство зрителей проголосовали за ответ под буквой С");
        }

        private void ELLipse_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Fifty_Click(object sender, RoutedEventArgs e)
        {
            OptionA.Visibility = Visibility.Hidden;
            OptionB.Visibility = Visibility.Hidden;
            LONG.Visibility = Visibility.Hidden;
            LONG2.Visibility = Visibility.Hidden;
        }
    }
}
