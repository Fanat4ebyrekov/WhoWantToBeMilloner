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
    /// Логика взаимодействия для ThirdWindow.xaml
    /// </summary>
    public partial class ThirdWindow : Window
    {
        public ThirdWindow()
        {
            InitializeComponent();
            Question.Text = "Самая дорогая система ножей в мясорубке";
            OptionA.Content = "A:Унгер";
            OptionB.Content = "B:1/2 унгер";
            OptionС.Content = "C:Ениерпрайс";
            OptionD.Content = "D:Червячная";
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
            FourthWindow fourthWindow = new FourthWindow();
            fourthWindow.ShowDialog();
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
            LONG.Visibility = Visibility.Hidden;
            LONG2.Visibility = Visibility.Hidden;
        }
    }
}
