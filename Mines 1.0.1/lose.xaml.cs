using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Mines_1._0._1
{
    /// <summary>
    /// Interaction logic for lose.xaml
    /// </summary>
    public partial class lose : Window
    {
        public lose()
        {
            InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Menu man = new Menu();
            man.Show();
            Close();
        }
    }
}
