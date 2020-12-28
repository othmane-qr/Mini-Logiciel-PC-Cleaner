using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace Mini_Logiciel_PC_Cleaner
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {






        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_21(object sender, RoutedEventArgs e)
        {
            long b = 0;
            try
            {
                DirectoryInfo di = new DirectoryInfo("C:\\Users\\Administrateur\\Desktop\\Nouveau dossier (3)");
                FileInfo[] fiArr = di.GetFiles();
                foreach (var item in fiArr)
                {
                    item.Delete();
                    b += item.Length;
                    MessageBox.Show("fechier nttoyer");

                }
                using (System.IO.StreamWriter files =
         new System.IO.StreamWriter("C:\\Users\\Administrateur\\Desktop\\test.txt", true))
                {
                    files.WriteLine(b);

                }



            }
            catch (Exception)
            {

                throw new ArgumentNullException("try closing all apps");

            }
        }


        private void Button_Click_3(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {

        }

        private void btn_anul_Click(object sender, RoutedEventArgs e)
        {
            btn_analyse.Visibility = Visibility.Visible;
            bar_pro.Visibility = Visibility.Hidden;
            btn_annuler.Visibility = Visibility.Hidden;
            txt3.Visibility = Visibility.Visible;
            txt4.Visibility = Visibility.Visible;
            txt5.Visibility = Visibility.Visible;
            txt2.Content = "Analyse du PC nécessaire";
            btn_analyse.IsEnabled = true;
            btn_analysemenu.IsEnabled = true;
            btn_options.IsEnabled = true;
            btn_vue.IsEnabled = true;
            btn_histomenu.IsEnabled = true;
            canv_histo.Visibility = Visibility.Visible;
            Canv_net.Visibility = Visibility.Visible;
            canv_metter.Visibility = Visibility.Visible;
            txt_anlyse.Visibility = Visibility.Hidden;

        }

        private void bar_pro_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {

        }
        // btn analyse menu
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            btn_analyse.Visibility = Visibility.Hidden;
            bar_pro.Visibility = Visibility.Visible;
            btn_annuler.Visibility = Visibility.Visible;
            txt3.Visibility = Visibility.Hidden;
            txt4.Visibility = Visibility.Hidden;
            txt5.Visibility = Visibility.Hidden;
            txt2.Content = "Analyse en cours";
            btn_analyse.IsEnabled = false;
            btn_analysemenu.IsEnabled = false;
            btn_histomenu.IsEnabled = false;
            btn_options.IsEnabled = false;
            btn_vue.IsEnabled = false;
            canv_histo.Visibility = Visibility.Hidden;
            Canv_net.Visibility = Visibility.Hidden;
            canv_metter.Visibility = Visibility.Hidden;
            /*   Duration duration = new Duration(TimeSpan.FromSeconds(1));
               DoubleAnimation doubleAnimation = new DoubleAnimation(bar_pro.Value + 10, duration);
               bar_pro.BeginAnimation(ProgressBar.ValueProperty, doubleAnimation);*/

            Thread.Sleep(1000);
            bar_pro.Value = 0;

            Task.Run(() =>
            {
                for (int i = 0; i <= 100; i++)
                {
                    Thread.Sleep(50);
                    this.Dispatcher.Invoke(() => //Use Dispather to Update UI Immediately  
                    {
                        bar_pro.Value = i;
                        if (i == 100)
                        {
                            txt_anlyse.Visibility = Visibility.Visible;
                            Canv_net.Visibility = Visibility.Visible;

                        }
                        //lbl_CountDownTimer.Text = i.ToString();
                    });
                }
            });

            DirectoryInfo di = new DirectoryInfo("C:\\Windows\\Temp");
            FileInfo[] fiArr = di.GetFiles();
            long b = 0;
            foreach (var fi in fiArr)
            {
                b += fi.Length;
            }
            txt_anlyse.Visibility = Visibility.Hidden;
            txt_anlyse.Content = "The size of " + di.Name + " is " + b / 1000000 + " MB.\n";

            //Pass the file path and file name to the StreamReader constructor
            //StreamReader sr = new StreamReader("C:\\Users\\Administrateur\\Desktop\\sample.txt");
            String line = DateTime.UtcNow.ToString("f");
            using (System.IO.StreamWriter file =
          new System.IO.StreamWriter("C:\\Users\\Administrateur\\Desktop\\sample.txt", true))
            {
                file.WriteLine(line);

            }
            
        }

        private void Button_Click_28(object sender, RoutedEventArgs e)
        {
            txt5.Content = $"last analyse: {System.IO.File.ReadLines("C:\\Users\\Administrateur\\Desktop\\sample.txt").Last()}";
            txt4.Content = $"last cleaner: {System.IO.File.ReadLines("C:\\Users\\Administrateur\\Desktop\\test.txt").Last()}";
        }

        private void Button_Click_55(object sender, RoutedEventArgs e)
        {

            WebClient webClient = new WebClient();
            try
            {
                if (!webClient.DownloadString("https://pastebin.com/ahUnw4Cf").Contains("1.0.0"))
                {
                    if (MessageBox.Show("Looks like there is an update! Do you want to download it?", "Demo", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                        using (var client = new WebClient())
                        {
                            Process.Start(@"C:\Users\Administrateur\Desktop\Mini Logiciel PC Cleaner\MetterAjouR\bin\Release\MetterAjouR.exe");
                            this.Close();
                        }
                }

            }
            catch
            {

            }
        }
    }
}
