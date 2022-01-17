using System.Windows;
using System.Windows.Controls;
using System.Reflection;
using System.IO;
using System.Timers;


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

            _1_1.Tag =  _1_1a;
            _1_2.Tag =  _1_2a;
            _1_3.Tag =  _1_3a;
            _1_4.Tag =  _1_4a;
            _1_5.Tag =  _1_5a;
            _1_6.Tag =  _1_6a;
            _1_7.Tag =  _1_7a;
            _1_8.Tag =  _1_8a;
            _1_9.Tag =  _1_9a;
            _1_10.Tag = _1_10a;

            _2_1.Tag = _2_1a;
            _2_2.Tag = _2_2a;
            _2_3.Tag = _2_3a;
            _2_4.Tag = _2_4a;
            _2_5.Tag = _2_5a;
            _2_6.Tag = _2_6a;
            _2_7.Tag = _2_7a;
            _2_8.Tag = _2_8a;
            _2_9.Tag = _2_9a;
            _2_10.Tag = _2_10a;

            _3_1.Tag = _3_1a;
            _3_2.Tag = _3_2a;
            _3_3.Tag = _3_3a;
            _3_4.Tag = _3_4a;
            _3_5.Tag = _3_5a;
            _3_6.Tag = _3_6a;
            _3_7.Tag = _3_7a;
            _3_8.Tag = _3_8a;
            _3_9.Tag = _3_9a;
            _3_10.Tag = _3_10a;

            _4_1.Tag = _4_1a;
            _4_2.Tag = _4_2a;
            _4_3.Tag = _4_3a;
            _4_4.Tag = _4_4a;
            _4_5.Tag = _4_5a;
            _4_6.Tag = _4_6a;
            _4_7.Tag = _4_7a;
            _4_8.Tag = _4_8a;
            _4_9.Tag = _4_9a;
            _4_10.Tag = _4_10a;

            _5_1.Tag = _5_1a;
            _5_2.Tag = _5_2a;
            _5_3.Tag = _5_3a;
            _5_4.Tag = _5_4a;
            _5_5.Tag = _5_5a;
            _5_6.Tag = _5_6a;
            _5_7.Tag = _5_7a;
            _5_8.Tag = _5_8a;
            _5_9.Tag = _5_9a;
            _5_10.Tag = _5_10a;

            _6_1.Tag = _6_1a;
            _6_2.Tag = _6_2a;
            _6_3.Tag = _6_3a;
            _6_4.Tag = _6_4a;
            _6_5.Tag = _6_5a;
            _6_6.Tag = _6_6a;
            _6_7.Tag = _6_7a;
            _6_8.Tag = _6_8a;
            _6_9.Tag = _6_9a;
            _6_10.Tag = _6_10a;

            _7_1.Tag = _7_1a;
            _7_2.Tag = _7_2a;
            _7_3.Tag = _7_3a;
            _7_4.Tag = _7_4a;
            _7_5.Tag = _7_5a;
            _7_6.Tag = _7_6a;
            _7_7.Tag = _7_7a;
            _7_8.Tag = _7_8a;
            _7_9.Tag = _7_9a;
            _7_10.Tag = _7_10a;

            _8_1.Tag = _8_1a;
            _8_2.Tag = _8_2a;
            _8_3.Tag = _8_3a;
            _8_4.Tag = _8_4a;
            _8_5.Tag = _8_5a;
            _8_6.Tag = _8_6a;
            _8_7.Tag = _8_7a;
            _8_8.Tag = _8_8a;
            _8_9.Tag = _8_9a;
            _8_10.Tag = _8_10a;

            _9_1.Tag = _9_1a;
            _9_2.Tag = _9_2a;
            _9_3.Tag = _9_3a;
            _9_4.Tag = _9_4a;
            _9_5.Tag = _9_5a;
            _9_6.Tag = _9_6a;
            _9_7.Tag = _9_7a;
            _9_8.Tag = _9_8a;
            _9_9.Tag = _9_9a;
            _9_10.Tag = _9_10a;

            _10_1.Tag = _10_1a;
            _10_2.Tag = _10_2a;
            _10_3.Tag = _10_3a;
            _10_4.Tag = _10_4a;
            _10_5.Tag = _10_5a;
            _10_6.Tag = _10_6a;
            _10_7.Tag = _10_7a;
            _10_8.Tag = _10_8a;
            _10_9.Tag = _10_9a;
            _10_10.Tag = _10_10a;

            tmr1();

        }

        public void main_Click(object sender, RoutedEventArgs e)
        {
            

            Button bt = (Button)sender;
            
            Mines actual = bt.Tag as Mines;



            bt.Content = actual.MinesNear;
            if(actual.IsaMine == true)
            {
                bt.Content = "X";
                Ended();
            }

        }
        public void Ended()
        {
            MessageBox.Show("Game over!");
        }

        public void tmr1()
        {
            Timer timw = new Timer();
            timw.Start();

            tmr.Content = timw.ToString();
        }


    }


}
