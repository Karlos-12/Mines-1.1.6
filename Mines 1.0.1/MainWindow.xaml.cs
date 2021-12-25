using System.Windows;

namespace Mines_1._0._1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Mines _1_1a = new Mines(false, 0);
        Mines _1_2a =new Mines(false, 0);
        Mines _1_3a = new Mines(false, 0);
        Mines _1_4a = new Mines(false, 0);
        Mines _1_5a = new Mines(false, 0);
        Mines _1_6a = new Mines(false, 0);
        Mines _1_7a = new Mines(false, 0);
        Mines _1_8a = new Mines(false, 0);
        Mines _1_9a = new Mines(false, 0);
        Mines _1_10a = new Mines(false, 0);

        Mines _2_1a = new Mines(false, 0);
        Mines _2_2a = new Mines(false, 0);
        Mines _2_3a = new Mines(false, 0);
        Mines _2_4a = new Mines(false, 0);
        Mines _2_5a = new Mines(false, 0);
        Mines _2_6a = new Mines(false, 0);
        Mines _2_7a = new Mines(false, 0);
        Mines _2_8a = new Mines(false, 1);
        Mines _2_9a = new Mines(false, 1);
        Mines _2_10a = new Mines(false, 1);

        Mines _3_1a = new Mines(false, 1);
        Mines _3_2a = new Mines(false, 1);
        Mines _3_3a = new Mines(false, 1);
        Mines _3_4a = new Mines(false, 0);
        Mines _3_5a = new Mines(false, 0);
        Mines _3_6a = new Mines(false, 0);
        Mines _3_7a = new Mines(false, 0);
        Mines _3_8a = new Mines(false, 1);
        Mines _3_9a = new Mines(true, 0);
        Mines _3_10a = new Mines(false, 1);
            


        public MainWindow()
        {
            InitializeComponent();


           
            
            
            
            
           
            
            
           
            
        }

        public void _1_1_Click(object sender, RoutedEventArgs e)
        {
            _1_1.Content = _1_1a.MinesNear;

        }

        private void _1_2_Click(object sender, RoutedEventArgs e)
        {

        }
    }


}
