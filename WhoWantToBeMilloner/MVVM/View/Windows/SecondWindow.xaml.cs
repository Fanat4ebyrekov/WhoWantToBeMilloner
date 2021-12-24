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
    /// Логика взаимодействия для SecondWindow.xaml
    /// </summary>
    public partial class SecondWindow : Window
    {
        public SecondWindow()
        {
            InitializeComponent();

            

            Question.Text = "Как нельзя использовать льдогенератор с воздушным исполнением";
            OptionA.Content = "A:Нельзя вставлять в мебель";
            OptionB.Content = "B:Нельзя ставить под кондиционером";
            OptionС.Content = "C:Нельзя продавать дуракам";
            OptionD.Content = "D:Нельзя ставить в холодном помещении";

        }

        private void Home_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            StartWindow startWindow = new StartWindow();
            startWindow.ShowDialog();
            this.Close();
        }

        private void OptionA_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Это правильный ответ");
            this.Hide();
            ThirdWindow thirdWindow = new ThirdWindow();
            thirdWindow.ShowDialog();
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

        private void OptionB_Click(object sender, RoutedEventArgs e)
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

        private void Phone_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Друг сказал провильный ответ под буквой  A");
        }

        private void Group_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Большинство зрителей проголосовали за ответ под буквой А");
        }

        private void ELLipse_Click(object sender, RoutedEventArgs e)
        {
           
        }

        private void Fifty_Click(object sender, RoutedEventArgs e)
        {
            OptionB.Visibility = Visibility.Hidden;
            OptionС.Visibility = Visibility.Hidden;
            LONG.Visibility=Visibility.Hidden;
            LONG2.Visibility=Visibility.Hidden;
        }
    }
}
