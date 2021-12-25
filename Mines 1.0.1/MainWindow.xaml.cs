using System.Windows;
using System.Windows.Controls;

namespace Mines_1._0._1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Mines _1_1a = new Mines(false, 0);
        Mines _1_2a = new Mines(false, 0);
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
        Mines _2_7a = new Mines(false, 1);
        Mines _2_8a = new Mines(false, 1);
        Mines _2_9a = new Mines(false, 1);
        Mines _2_10a = new Mines(false, 0);

        Mines _3_1a = new Mines(false, 1);
        Mines _3_2a = new Mines(false, 1);
        Mines _3_3a = new Mines(false, 1);
        Mines _3_4a = new Mines(false, 0);
        Mines _3_5a = new Mines(false, 0);
        Mines _3_6a = new Mines(false, 0);
        Mines _3_7a = new Mines(false, 1);
        Mines _3_8a = new Mines(true, 0);
        Mines _3_9a = new Mines(false, 1);
        Mines _3_10a = new Mines(false, 0);

        Mines _4_1a = new Mines(false, 2);
        Mines _4_2a = new Mines(true, 0);
        Mines _4_3a = new Mines(false, 3);
        Mines _4_4a = new Mines(false, 1);
        Mines _4_5a = new Mines(false, 0);
        Mines _4_6a = new Mines(false, 0);
        Mines _4_7a = new Mines(false, 1);
        Mines _4_8a = new Mines(false, 1);
        Mines _4_9a = new Mines(false, 1);
        Mines _4_10a = new Mines(false, 0);

        Mines _5_1a = new Mines(false, 3);
        Mines _5_2a = new Mines(true, 0);
        Mines _5_3a = new Mines(true, 0);
        Mines _5_4a = new Mines(false, 1);
        Mines _5_5a = new Mines(false, 0);
        Mines _5_6a = new Mines(false, 0);
        Mines _5_7a = new Mines(false, 0);
        Mines _5_8a = new Mines(false, 1);
        Mines _5_9a = new Mines(false, 1);
        Mines _5_10a = new Mines(false, 1);

        Mines _6_1a = new Mines(false, 2);
        Mines _6_2a = new Mines(true, 0);
        Mines _6_3a = new Mines(false, 3);
        Mines _6_4a = new Mines(false, 1);
        Mines _6_5a = new Mines(false, 0);
        Mines _6_6a = new Mines(false, 0);
        Mines _6_7a = new Mines(false, 0);
        Mines _6_8a = new Mines(false, 1);
        Mines _6_9a = new Mines(true, 0);
        Mines _6_10a = new Mines(false, 1);

        Mines _7_1a = new Mines(false, 1);
        Mines _7_2a = new Mines(false, 1);
        Mines _7_3a = new Mines(false, 1);
        Mines _7_4a = new Mines(false, 0);
        Mines _7_5a = new Mines(false, 1);
        Mines _7_6a = new Mines(false, 1);
        Mines _7_7a = new Mines(false, 1);
        Mines _7_8a = new Mines(false, 1);
        Mines _7_9a = new Mines(false, 1);
        Mines _7_10a = new Mines(false, 1);

        Mines _8_1a = new Mines(false, 0);
        Mines _8_2a = new Mines(false, 1);
        Mines _8_3a = new Mines(false, 1);
        Mines _8_4a = new Mines(false, 1);
        Mines _8_5a = new Mines(false, 1);
        Mines _8_6a = new Mines(true, 0);
        Mines _8_7a = new Mines(false, 3);
        Mines _8_8a = new Mines(false, 2);
        Mines _8_9a = new Mines(false, 1);
        Mines _8_10a = new Mines(false, 0);

        Mines _9_1a = new Mines(false, 0);
        Mines _9_2a = new Mines(false, 1);
        Mines _9_3a = new Mines(true, 0);
        Mines _9_4a = new Mines(false, 1);
        Mines _9_5a = new Mines(false, 1);
        Mines _9_6a = new Mines(false, 2);
        Mines _9_7a = new Mines(true, 0);
        Mines _9_8a = new Mines(true, 0);
        Mines _9_9a = new Mines(false, 1);
        Mines _9_10a = new Mines(false, 0);

        Mines _10_1a = new Mines(false, 0);
        Mines _10_2a = new Mines(false, 1);
        Mines _10_3a = new Mines(false, 1);
        Mines _10_4a = new Mines(false, 1);
        Mines _10_5a = new Mines(false, 0);
        Mines _10_6a = new Mines(false, 1);
        Mines _10_7a = new Mines(false, 2);
        Mines _10_8a = new Mines(false, 2);
        Mines _10_9a = new Mines(false, 1);
        Mines _10_10a = new Mines(false, 0);



        public MainWindow()
        {
            InitializeComponent();












        }

        public void main_Click(object sender, RoutedEventArgs e)
        {
            

            Button bt = (Button)sender;

            

            bt.Content = [sender.ToString + "a"].MinesNear ;  

        }


    }


}
