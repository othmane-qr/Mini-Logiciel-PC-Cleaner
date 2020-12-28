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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Net;
using System.IO;
using System.Diagnostics;
using System.IO.Compression;
using System.Threading;

namespace MetterAjouR
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
            btn_start.Visibility = Visibility.Hidden;
            pro_bar2.Visibility = Visibility.Visible;
            txt.Visibility = Visibility.Visible;


            Thread.Sleep(1000);
            pro_bar2.Value = 0;

            Task.Run(() =>
            {
                for (int i = 0; i <= 100; i++)
                {
                    Thread.Sleep(50);
                    this.Dispatcher.Invoke(() => //Use Dispather to Update UI Immediately  
                    {
                        pro_bar2.Value = i;
                          var client = new WebClient();

                            if (i == 100)
                        {
                            WebClient webClient = new WebClient();
                          string[] files = Directory.GetFiles(@"C:\Users\Administrateur\Desktop\Mini Logiciel PC Cleaner\Mini Logiciel PC Cleaner\bin\Release");

                            foreach (string file in files)
                            {
                                File.Delete(file);
                            }
                            client.DownloadFile("http://localhost/Nouveau%20dossier/Release.zip", @"C:\Users\Administrateur\Desktop\Mini Logiciel PC Cleaner\Mini Logiciel PC Cleaner\bin\Release\Release.zip");
                            string zipPath = @"C:\Users\Administrateur\Desktop\Mini Logiciel PC Cleaner\Mini Logiciel PC Cleaner\bin\Release\Release.zip";
                            //. pour racourcir 
                            string extractPath = @"C:\Users\Administrateur\Desktop\Mini Logiciel PC Cleaner\Mini Logiciel PC Cleaner\bin\Release";
                            ZipFile.ExtractToDirectory(zipPath, extractPath);
                            File.Delete(@"C:\Users\Administrateur\Desktop\Mini Logiciel PC Cleaner\Mini Logiciel PC Cleaner\bin\Release\Release.zip");
                            Process.Start(@"C:\Users\Administrateur\Desktop\Mini Logiciel PC Cleaner\Mini Logiciel PC Cleaner\bin\Release\mini logiciel.exe");
                            this.Close();

                            btn_quiter.Visibility = Visibility.Visible;
                            txt.Text = "La mise à jour à été effectuée avec succès !";

                        }
                        //lbl_CountDownTimer.Text = i.ToString();
                    });
                }
            });
        }

        private void pro_bar2_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {

        }

        private void btn_quiter_Click(object sender, RoutedEventArgs e)
        {
            Close();
            Process.Start(@"C:\Users\Administrateur\Desktop\Mini Logiciel PC Cleaner\Mini Logiciel PC Cleaner\bin\Release\mini logiciel.exe");
        }
    }
}
