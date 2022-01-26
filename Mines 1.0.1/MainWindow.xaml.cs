using System;
using System.Timers;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;


namespace Mines_1._0._1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Menu men = new Menu();

        SolidColorBrush _1b = new SolidColorBrush(Color.FromArgb(100, 0, 89, 255));
        SolidColorBrush _2b = new SolidColorBrush(Color.FromArgb(100, 0, 215, 0));
        SolidColorBrush _3b = new SolidColorBrush(Color.FromArgb(100, 255, 0, 0));
        SolidColorBrush _4b = new SolidColorBrush(Color.FromArgb(100, 0, 23, 151));
        SolidColorBrush _5b = new SolidColorBrush(Color.FromArgb(100, 97, 54, 16));
        SolidColorBrush _6b = new SolidColorBrush(Color.FromArgb(100, 44, 240, 212));
        SolidColorBrush _7b = new SolidColorBrush(Color.FromArgb(100, 255, 255, 255));
        SolidColorBrush _8b = new SolidColorBrush(Color.FromArgb(100, 255, 136, 32));

        SolidColorBrush _xb = new SolidColorBrush(Color.FromArgb(100, 255, 255, 255));

        int[,] Log = {
            {0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
            {0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
            {0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
            {0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
            {0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
            {0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
            {0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
            {0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
            {0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
            {0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }
            };
        int[,] minespos = new int [100, 2];


        Mines sou1 = new Mines(0, 0);
        Mines sou2 = new Mines(0, 1);
        Mines sou3 = new Mines(0, 2);
        Mines sou4 = new Mines(0, 3);
        Mines sou5 = new Mines(0, 4);
        Mines sou6 = new Mines(0, 5);
        Mines sou7 = new Mines(0, 6);
        Mines sou8 = new Mines(0, 7);
        Mines sou9 = new Mines(0, 8);
        Mines sou10 = new Mines(0, 9);

        Mines sou11 = new Mines(1, 0);
        Mines sou12 = new Mines(1, 1);
        Mines sou13 = new Mines(1, 2);
        Mines sou14 = new Mines(1, 3);
        Mines sou15 = new Mines(1, 4);
        Mines sou16 = new Mines(1, 5);
        Mines sou17 = new Mines(1, 6);
        Mines sou18 = new Mines(1, 7);
        Mines sou19 = new Mines(1, 8);
        Mines sou20 = new Mines(1, 9);

        Mines sou21 = new Mines(2, 0);
        Mines sou22 = new Mines(2, 1);
        Mines sou23 = new Mines(2, 2);
        Mines sou24 = new Mines(2, 3);
        Mines sou25 = new Mines(2, 4);
        Mines sou26 = new Mines(2, 5);
        Mines sou27 = new Mines(2, 6);
        Mines sou28 = new Mines(2, 7);
        Mines sou29 = new Mines(2, 8);
        Mines sou30 = new Mines(2, 9);

        Mines sou31 = new Mines(3, 0);
        Mines sou32 = new Mines(3, 1);
        Mines sou33 = new Mines(3, 2);
        Mines sou34 = new Mines(3, 3);
        Mines sou35 = new Mines(3, 4);
        Mines sou36 = new Mines(3, 5);
        Mines sou37 = new Mines(3, 6);
        Mines sou38 = new Mines(3, 7);
        Mines sou39 = new Mines(3, 8);
        Mines sou40 = new Mines(3, 9);

        Mines sou41 = new Mines(4, 0);
        Mines sou42 = new Mines(4, 1);
        Mines sou43 = new Mines(4, 2);
        Mines sou44 = new Mines(4, 3);
        Mines sou45 = new Mines(4, 4);
        Mines sou46 = new Mines(4, 5);
        Mines sou47 = new Mines(4, 6);
        Mines sou48 = new Mines(4, 7);
        Mines sou49 = new Mines(4, 8);
        Mines sou50 = new Mines(4, 9);

        Mines sou51 = new Mines(5, 0);
        Mines sou52 = new Mines(5, 1);
        Mines sou53 = new Mines(5, 2);
        Mines sou54 = new Mines(5, 3);
        Mines sou55 = new Mines(5, 4);
        Mines sou56 = new Mines(5, 5);
        Mines sou57 = new Mines(5, 6);
        Mines sou58 = new Mines(5, 7);
        Mines sou59 = new Mines(5, 8);
        Mines sou60 = new Mines(5, 9);

        Mines sou61 = new Mines(6, 0);
        Mines sou62 = new Mines(6, 1);
        Mines sou63 = new Mines(6, 2);
        Mines sou64 = new Mines(6, 3);
        Mines sou65 = new Mines(6, 4);
        Mines sou66 = new Mines(6, 5);
        Mines sou67 = new Mines(6, 6);
        Mines sou68 = new Mines(6, 7);
        Mines sou69 = new Mines(6, 8);
        Mines sou70 = new Mines(6, 9);

        Mines sou71 = new Mines(7, 0);
        Mines sou72 = new Mines(7, 1);
        Mines sou73 = new Mines(7, 2);
        Mines sou74 = new Mines(7, 3);
        Mines sou75 = new Mines(7, 4);
        Mines sou76 = new Mines(7, 5);
        Mines sou77 = new Mines(7, 6);
        Mines sou78 = new Mines(7, 7);
        Mines sou79 = new Mines(7, 8);
        Mines sou80 = new Mines(7, 9);

        Mines sou81 = new Mines(8, 0);
        Mines sou82 = new Mines(8, 1);
        Mines sou83 = new Mines(8, 2);
        Mines sou84 = new Mines(8, 3);
        Mines sou85 = new Mines(8, 4);
        Mines sou86 = new Mines(8, 5);
        Mines sou87 = new Mines(8, 6);
        Mines sou88 = new Mines(8, 7);
        Mines sou89 = new Mines(8, 8);
        Mines sou90 = new Mines(8, 9);

        Mines sou91 = new Mines(9, 0);
        Mines sou92 = new Mines(9, 1);
        Mines sou93 = new Mines(9, 2);
        Mines sou94 = new Mines(9, 3);
        Mines sou95 = new Mines(9, 4);
        Mines sou96 = new Mines(9, 5);
        Mines sou97 = new Mines(9, 6);
        Mines sou98 = new Mines(9, 7);
        Mines sou99 = new Mines(9, 8);
        Mines sou100 = new Mines(9, 9);

        int ticked = 10;
        int click_s1 = 0;
        int click_s2 = 0;

        public MainWindow()
        {

            InitializeComponent();
            men.Show();
            Hide();

            tagall();

        }
        public void tagall()
        {
            _1_1.Tag = sou1;
            _1_2.Tag = sou2;
            _1_3.Tag = sou3;
            _1_4.Tag = sou4;
            _1_5.Tag = sou5;
            _1_6.Tag = sou6;
            _1_7.Tag = sou7;
            _1_8.Tag = sou8;
            _1_9.Tag = sou9;
            _1_10.Tag = sou10;

            _2_1.Tag = sou11;
            _2_2.Tag = sou12;
            _2_3.Tag = sou13;
            _2_4.Tag = sou14;
            _2_5.Tag = sou15;
            _2_6.Tag = sou16;
            _2_7.Tag = sou17;
            _2_8.Tag = sou18;
            _2_9.Tag = sou19;
            _2_10.Tag = sou20;

            _3_1.Tag = sou21;
            _3_2.Tag = sou22;
            _3_3.Tag = sou23;
            _3_4.Tag = sou24;
            _3_5.Tag = sou25;
            _3_6.Tag = sou26;
            _3_7.Tag = sou27;
            _3_8.Tag = sou28;
            _3_9.Tag = sou29;
            _3_10.Tag = sou30;

            _4_1.Tag = sou31;
            _4_2.Tag = sou32;
            _4_3.Tag = sou33;
            _4_4.Tag = sou34;
            _4_5.Tag = sou35;
            _4_6.Tag = sou36;
            _4_7.Tag = sou37;
            _4_8.Tag = sou38;
            _4_9.Tag = sou39;
            _4_10.Tag = sou40;

            _5_1.Tag = sou41;
            _5_2.Tag = sou42;
            _5_3.Tag = sou43;
            _5_4.Tag = sou44;
            _5_5.Tag = sou45;
            _5_6.Tag = sou46;
            _5_7.Tag = sou47;
            _5_8.Tag = sou48;
            _5_9.Tag = sou49;
            _5_10.Tag = sou50;

            _6_1.Tag = sou51;
            _6_2.Tag = sou52;
            _6_3.Tag = sou53;
            _6_4.Tag = sou54;
            _6_5.Tag = sou55;
            _6_6.Tag = sou56;
            _6_7.Tag = sou57;
            _6_8.Tag = sou58;
            _6_9.Tag = sou59;
            _6_10.Tag = sou60;

            _7_1.Tag = sou61;
            _7_2.Tag = sou62;
            _7_3.Tag = sou63;
            _7_4.Tag = sou64;
            _7_5.Tag = sou65;
            _7_6.Tag = sou66;
            _7_7.Tag = sou67;
            _7_8.Tag = sou68;
            _7_9.Tag = sou69;
            _7_10.Tag = sou70;

            _8_1.Tag = sou71;
            _8_2.Tag = sou72;
            _8_3.Tag = sou73;
            _8_4.Tag = sou74;
            _8_5.Tag = sou75;
            _8_6.Tag = sou76;
            _8_7.Tag = sou77;
            _8_8.Tag = sou78;
            _8_9.Tag = sou79;
            _8_10.Tag = sou80;

            _9_1.Tag = sou81;
            _9_2.Tag = sou82;
            _9_3.Tag = sou83;
            _9_4.Tag = sou84;
            _9_5.Tag = sou85;
            _9_6.Tag = sou86;
            _9_7.Tag = sou87;
            _9_8.Tag = sou88;
            _9_9.Tag = sou89;
            _9_10.Tag = sou90;

            _10_1.Tag = sou91;
            _10_2.Tag = sou92;
            _10_3.Tag = sou93;
            _10_4.Tag = sou94;
            _10_5.Tag = sou95;
            _10_6.Tag = sou96;
            _10_7.Tag = sou97;
            _10_8.Tag = sou98;
            _10_9.Tag = sou99;
            _10_10.Tag = sou100;

        }
        int first_click = 0;
        public void main_Click(object sender, RoutedEventArgs e)
        {
            Button bt = (Button)sender;
            first_click++;

            if(first_click == 1)
            {
                click_s1 = ((Mines)bt.Tag).up;
                click_s2 = ((Mines)bt.Tag).side;
                AutoGeneratio();
                tagall();               
            }
            
           
            Countit(((Mines)bt.Tag).up, ((Mines)bt.Tag).side);
        }
        public void Ended()
        {
            tl.IsEnabled = false;
            lose l = new lose();
            l.Show();
            Close();
        }

        public void Countit(int h, int w)
        {
            if (((Button)(FindName("_" + (h + 1) + "_" + (w + 1)))).Content != "!")
            {
                if (Log[h, w] == 0)
                {
                    Log[h, w] = -2;
                    ((Button)(FindName("_" + (h + 1) + "_" + (w + 1)))).Content = 0;
                    try
                    {
                        if (Log[h + 1, w] != -2)
                        { Countit(h + 1, w); }
                    }
                    catch { };
                    try
                    {
                        if (Log[h + 1, w + 1] != -2)
                        { Countit(h + 1, w + 1); }
                    }
                    catch { };
                    try
                    {
                        if (Log[h, w + 1] != -2)
                        { Countit(h, w + 1); }
                    }
                    catch { };
                    try
                    {
                        if (Log[h - 1, w] != -2)
                        { Countit(h - 1, w); }
                    }
                    catch { };
                    try
                    {
                        if (Log[h - 1, w - 1] != -2)
                        {
                            Countit(h - 1, w - 1);
                        }
                    }
                    catch { };
                    try
                    {
                        if (Log[h, w - 1] != -2)
                        { Countit(h, w - 1); }
                    }
                    catch { };
                    try
                    {
                        if (Log[h + 1, w - 1] != -2)
                        { Countit(h + 1, w - 1); }
                    }
                    catch { };
                    try
                    {
                        if (Log[h - 1, w + 1] != -2)
                            Countit(h - 1, w + 1);
                    }
                    catch { };

                    try
                    {

                        if (Log[h + 1, w] == 0)
                        {
                            Countit(h + 1, w);
                        }
                        if (Log[h - 1, w] == 0)
                        {
                            Countit(h - 1, w);
                        }
                        if (Log[h, w + 1] == 0)
                        {
                            Countit(h, w + 1);
                        }
                        if (Log[h, w - 1] == 0)
                        {
                            Countit(h, w - 1);
                        }
                    }
                    catch { };
                }
                else if (Log[h, w] == 1)
                {
                    try
                    {
                        ((Button)(FindName("_" + (h + 1) + "_" + (w + 1)))).Content = 1;
                        ((Button)(FindName("_" + (h + 1) + "_" + (w + 1)))).Background = _1b;
                    }
                    catch { MessageBox.Show("unexpected error!!"); };
                }
                else if (Log[h, w] == 2)
                {
                    try
                    {
                        ((Button)(FindName("_" + (h + 1) + "_" + (w + 1)))).Content = 2;
                        ((Button)(FindName("_" + (h + 1) + "_" + (w + 1)))).Background = _2b;
                    }
                    catch { MessageBox.Show("unexpected error!"); };
                }
                else if (Log[h, w] == 3)
                {
                    try
                    {
                        ((Button)(FindName("_" + (h + 1) + "_" + (w + 1)))).Content = 3;
                        ((Button)(FindName("_" + (h + 1) + "_" + (w + 1)))).Background = _3b;
                    }
                    catch { MessageBox.Show("unexpected error!"); };
                }
                else if (Log[h, w] == 4)
                {
                    try
                    {
                        ((Button)(FindName("_" + (h + 1) + "_" + (w + 1)))).Content = 4;
                        ((Button)(FindName("_" + (h + 1) + "_" + (w + 1)))).Background = _4b;
                    }
                    catch { MessageBox.Show("unexpected error!"); };
                }
                else if (Log[h, w] == 5)
                {
                    try
                    {
                        ((Button)(FindName("_" + (h + 1) + "_" + (w + 1)))).Content = 5;
                        ((Button)(FindName("_" + (h + 1) + "_" + (w + 1)))).Background = _5b;
                    }
                    catch { MessageBox.Show("unexpected error!"); };
                }
                else if (Log[h, w] == 6)
                {
                    try
                    {
                        ((Button)(FindName("_" + (h + 1) + "_" + (w + 1)))).Content = 6;
                        ((Button)(FindName("_" + (h + 1) + "_" + (w + 1)))).Background = _6b;
                    }
                    catch { MessageBox.Show("unexpected error!"); };
                }
                else if (Log[h, w] == 7)
                {
                    try
                    {
                        ((Button)(FindName("_" + (h + 1) + "_" + (w + 1)))).Content = 7;
                        ((Button)(FindName("_" + (h + 1) + "_" + (w + 1)))).Background = _7b;
                    }
                    catch { MessageBox.Show("unexpected error!"); };
                }
                else if (Log[h, w] == 8)
                {
                    try
                    {
                        ((Button)(FindName("_" + (h + 1) + "_" + (w + 1)))).Content = 8;
                        ((Button)(FindName("_" + (h + 1) + "_" + (w + 1)))).Background = _8b;
                    }
                    catch { MessageBox.Show("unexpected error!"); };
                }
                else if (Log[h, w] == -1)
                {
                    try
                    {
                        ((Button)(FindName("_" + (h + 1) + "_" + (w + 1)))).Content = "x";
                        ((Button)(FindName("_" + (h + 1) + "_" + (w + 1)))).Background = _xb;
                    }
                    catch { MessageBox.Show("unexpected error!"); };
                    Ended();

                }
            }
        }

        private void secondaryclick(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            Button now = sender as Button;
            if (now.Content != "!")
            {
                if (ticked != 0)
                {
                    if (Log[((Mines)now.Tag).up, ((Mines)now.Tag).side] == -1)
                    {
                        Log[((Mines)now.Tag).up, ((Mines)now.Tag).side] = -3;
                    }




                    now.Content = "!";
                    now.Background = new SolidColorBrush(Color.FromArgb(255, 242, 239, 6));
                    ticked--;
                    mine_input.Text = ticked.ToString();
                }
                if (ticked == 0)
                {

                    MessageBoxResult res = MessageBox.Show("Check mines?", "", MessageBoxButton.YesNo);
                    if (res == MessageBoxResult.Yes)
                    {
                        for (int i = ticked; i > 0; i--)
                        {
                            if (Log[minespos[i - 1, 0], minespos[i - 1, 1]] == -3)
                            {
                            ticked--;
                            }
                        }
                        if (ticked == 0)
                        {
                            win w = new win();
                            w.Show();
                        }
                        else
                        {
                            Ended();
                        }
                    }
                }
            }
            else if (now.Content == "!")
            {
                if (Log[((Mines)now.Tag).up, ((Mines)now.Tag).side] == -3)
                {
                    Log[((Mines)now.Tag).up, ((Mines)now.Tag).side] = -1;
                }
                now.Content = "";
                now.Background = new SolidColorBrush(Color.FromRgb(112, 112, 112));
                ticked++;
                mine_input.Text = ticked.ToString();
            }
        }
        int stp = 0;
        private void start_Click(object sender, RoutedEventArgs e)
        {
            
            

            if (stp == 0)
            {
                stp = 1;
                start.Content = "End";
                tl.IsEnabled = true;
                Timer myTimer = new Timer();
                myTimer.Elapsed += new ElapsedEventHandler(DisplayTimeEvent);
                myTimer.Interval = 1000;
                myTimer.Start();
                mine_input.IsEnabled = false;


            }
            else if (stp == 1)
            {
                stp = 0;
                start.Content = "Start";
                tl.IsEnabled = false;
                Hide();
                MainWindow main = new MainWindow();
                main.Show();
            }
        }

        int sec = 0;
        int min = 0;
        public void DisplayTimeEvent(object source, ElapsedEventArgs e)
        {
            sec++;
            if (sec > 59)
            {
                sec = 0;
                min++;
            }
            write(min, sec);
        }
        public void write(int _1, int _2)
        {
            this.Dispatcher.Invoke(() =>
            {
                if (sec < 10)
                {
                    if (min < 10)
                    {
                        tmr1.Content = ("0" + _1 + ":" + "0" + _2);
                    }
                    else
                    { tmr1.Content = (_1 + ":" + "0" + _2); }

                }
                else if (min < 10)
                {
                    tmr1.Content = ("0" + _1 + ":" + _2);
                }
                else
                { tmr1.Content = (_1 + ":" + _2); }
            });

        }

        private void Window_Activated(object sender, System.EventArgs e)
        {
            men.Hide();
        }


        
        public void AutoGeneratio()
        {
            for (int i = ticked; i != 0; i--)
            {
                Random rm1 = new Random();
                Random rm2 = new Random();

                int p1 = rm1.Next(0, 9);
                int p2 = rm2.Next(0, 9);

                if (Log[p1, p2] == -1 || (p1 == click_s1! & p2 == click_s2) || (p1 +1 == click_s1! & p2 == click_s2) || (p1 == click_s1! & p2 +1 == click_s2) || (p1 +1 == click_s1! & p2 +1 == click_s2) || (p1 -1 == click_s1! & p2 == click_s2) || (p1 == click_s1! & p2 -1 == click_s2) || (p1-1 == click_s1! & p2-1 == click_s2) || (p1 -1 == click_s1! & p2 +1 == click_s2) || (p1 +1 == click_s1! & p2 -1 == click_s2))
                {
                    do
                    {
                        p2 = rm2.Next(0, 9);
                    }
                    while (Log[p1, p2] == -1 || (p1 == click_s1! & p2 == click_s2) || (p1 + 1 == click_s1! & p2 == click_s2) || (p1 == click_s1! & p2 + 1 == click_s2) || (p1 + 1 == click_s1! & p2 + 1 == click_s2) || (p1 - 1 == click_s1! & p2 == click_s2) || (p1 == click_s1! & p2 - 1 == click_s2) || (p1 - 1 == click_s1! & p2 - 1 == click_s2) || (p1 - 1 == click_s1! & p2 + 1 == click_s2) || (p1 + 1 == click_s1! & p2 - 1 == click_s2));
                }
                

                Log[p1, p2] = -1;


                minespos[(i - 1) , 0] = p1;
                minespos[(i - 1) , 1] = p2;
            }

            int m1 = 9;
            int m2 = 9;
            int near = 0;

            for (int i = Log.Length; i > 0; i--)
            {
                if (Log[m1, m2] != -1)
                {
                    try
                    {
                        if (Log[m1 - 1, m2] == -1)
                        {
                            near++;
                        }
                    }
                    catch { }
                    try
                    {

                        if (Log[m1 - 1, m2 - 1] == -1)
                        {
                            near++;
                        }
                    }
                    catch { }
                    try
                    {
                        if (Log[m1, m2 - 1] == -1)
                        {
                            near++;
                        }
                    }
                    catch { }
                    try
                    {
                        if (Log[m1 + 1, m2] == -1)
                        {
                            near++;
                        }
                    }
                    catch { }
                    try
                    {
                        if (Log[m1 + 1, m2 + 1] == -1)
                        {
                            near++;
                        }
                    }
                    catch { }
                    try
                    {
                        if (Log[m1, m2 + 1] == -1)
                        {
                            near++;
                        }
                    }
                    catch { }
                    try
                    {
                        if (Log[m1 - 1, m2 + 1] == -1)
                        {
                            near++;
                        }
                    }
                    catch { }
                    try
                    {
                        if (Log[m1 + 1, m2 - 1] == -1)
                        {
                            near++;
                        }
                    }
                    catch { }


                    Log[m1, m2] = near;

                    near = 0;

                }
                else
                {

                }
                m2--;
                if (m2 < 0)
                {
                    m2 = 9;
                    m1--;
                }
            }
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            try 
            {
            ticked = int.Parse(mine_input.Text);
            }
            catch
            {
                MessageBox.Show("Input a valid number!");
            }
        }
    }


}
