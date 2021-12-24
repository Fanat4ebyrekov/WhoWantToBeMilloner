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
    /// Логика взаимодействия для TwelfthWindow.xaml
    /// </summary>
    public partial class TwelfthWindow : Window
    {
        public TwelfthWindow()
        {
            InitializeComponent();
            Question.Text = "Клиент хочет купить ДЕЗАР 7 а количестве 100 штук, просит оформить счёт с ндс";
            OptionA.Content = "A:Выставим счёт,что бы быстрее оплатил";
            OptionB.Content = "B:Запросим потент на покупку дезаров в таком количестве";
            OptionС.Content = "C:Выставим счет без НДС, объясним клиенту,что это медицинское оборудование,продается без ндс";
            OptionD.Content = "D:Проигнорируем запрос,не наш ассортимент";
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
            MessageBox.Show("Это  правильный ответ");
            this.Hide();
            ThirteenthWindow thirteenthWindow = new ThirteenthWindow();
            thirteenthWindow.ShowDialog();
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
            OptionA.Visibility = Visibility.Hidden;
            OptionD.Visibility = Visibility.Hidden;
            LONG.Visibility = Visibility.Hidden;
            LONG2.Visibility = Visibility.Hidden;
        }
    }
}
