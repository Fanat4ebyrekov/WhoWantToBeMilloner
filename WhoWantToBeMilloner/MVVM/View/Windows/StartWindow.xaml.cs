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
    public partial class StartWindow : Window
    {
        public StartWindow()
        {
            InitializeComponent();

        }

        private void Start_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            SecondWindow secondWindow = new SecondWindow();
            secondWindow.ShowDialog();
            this.Close();
        }

        private void Rules_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            RulesWindow rulesWindow = new RulesWindow();
            rulesWindow.ShowDialog();
            this.Close();
        }
    }
}
