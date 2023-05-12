using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
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
using System.Windows.Threading;

namespace RedM_Launcher
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //Create Timers
        System.Windows.Threading.DispatcherTimer StartCheckingRedM = new System.Windows.Threading.DispatcherTimer();
        System.Windows.Threading.DispatcherTimer ClearRedMCache = new System.Windows.Threading.DispatcherTimer();
        System.Windows.Threading.DispatcherTimer UpdateStatus = new System.Windows.Threading.DispatcherTimer();
        System.Windows.Threading.DispatcherTimer StartRedM = new System.Windows.Threading.DispatcherTimer();
        System.Windows.Threading.DispatcherTimer FinishingUpTimer = new System.Windows.Threading.DispatcherTimer();

        public MainWindow()
        {
            InitializeComponent();
            StatusText.Text = "Initializing";
            DetailText.Text = "Checking for RedM...";
            progress.Value = 10;

            StartCheckingRedM.Tick += StartCheckingRedM_Tick;
            StartCheckingRedM.Interval = new TimeSpan(0, 0, 3);
            StartCheckingRedM.Start();
        }

        private void StartCheckingRedM_Tick(object? sender, EventArgs e)
        {
            StartCheckingRedM.Stop();
            //Define Location of RedM and RedM App Data
            string LocalAppData = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            string RedMAppData = LocalAppData + @"\RedM\RedM.app\data";
            string RedM = LocalAppData + @"\RedM\RedM.exe";

            //If RedM.Exe Exists
            if(File.Exists(RedM))
            {
                //Check that RedM Application Data Directory Exists
                if(Directory.Exists(RedMAppData))
                {
                    //RedM and Application Data Directory Exist
                    StatusText.Text = "Validating Files";
                    DetailText.Text = "RedM.exe/RedM Application Data found!";
                    progress.Value = 50;

                    //Clear Cache
                    ClearRedMCache.Tick += ClearRedMCache_Tick;
                    ClearRedMCache.Interval = new TimeSpan(0, 0, 3);
                    ClearRedMCache.Start();
                }
                else if (!Directory.Exists(RedMAppData))
                {
                    //RedM and Application Data Directory Exist
                    StatusText.Text = "Validating Files";
                    DetailText.Text = "RedM.exe found with missing Application Data";
                    progress.Value = 30;

                    //Clear Cache
                    ClearRedMCache.Tick += ClearRedMCache_Tick;
                    ClearRedMCache.Interval = new TimeSpan(0, 0, 3);
                    ClearRedMCache.Start();
                }
            }
            else if (!File.Exists(RedM))
            {
                //RedM.exe not found
                string RedMBundled = @"C:\Program Files (x86)\RWE Labs\RedM Launcher\RedM.exe";
                progress.Value = 18;

                //If RedM Directory in Local App Data does not exist...
                if(!Directory.Exists(LocalAppData + @"\RedM\"))
                {
                    //Create the directory
                    Directory.CreateDirectory(LocalAppData + @"\RedM\");
                }

                try
                {
                    StatusText.Text = "Replacing Files";
                    DetailText.Text = "Adding RedM.exe to RedM Local App Data";

                    //Copy the bundled RedM copy to the AppData Folder
                    File.Copy(RedMBundled, RedM);

                    progress.Value = 30;

                    //Clear Cache
                    ClearRedMCache.Tick += ClearRedMCache_Tick;
                    ClearRedMCache.Interval = new TimeSpan(0, 0, 3);
                    ClearRedMCache.Start();
                }
                catch
                {
                    StatusText.Text = "Cancelling";
                    DetailText.Text = "We couldn't find or install RedM.";
                    progress.Value = 0;
                    MessageBox.Show("Error 591 - We weren't able to install a copy of RedM to your LocalApplicationData folder. Consider downloading and installing RedM to your LocalApplicationData folder before running RedM Launcher.");
                    this.Close();
                }
            }
        }

        private void ClearRedMCache_Tick(object? sender, EventArgs e)
        {
            ClearRedMCache.Stop();

            string LocalAppData = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            string RedMAppData = LocalAppData + @"\RedM\RedM.app\data";

            StatusText.Text = "Clearing Cache";
            progress.Value = 75;

            //Cache File Locations
            string servercache = RedMAppData + @"\server-cache\";
            string cache = RedMAppData + @"\cache\";
            string servercachepriv = RedMAppData + @"\server-cache-priv\";

            //Delete Cache
            if (Directory.Exists(servercache))
            {
                DetailText.Text = @"data\server-cache";
                Directory.Delete(servercache, true);
                progress.Value = 85;
            }
            if (Directory.Exists(servercachepriv))
            {
                DetailText.Text = @"data\server-cache-priv";
                Directory.Delete(servercachepriv, true);
                progress.Value = 93;
            }
            if (Directory.Exists(cache))
            {
                DetailText.Text = @"data\cache";
                Directory.Delete(cache, true);
                progress.Value = 98;
            }

            //Start RedM
            StatusText.Text = "Clearing Cache";
            DetailText.Text = "Finshing up...";
            UpdateStatus.Tick += UpdateStatus_Tick;
            UpdateStatus.Interval = new TimeSpan(0, 0, 3);
            UpdateStatus.Start();
        }

        private void UpdateStatus_Tick(object? sender, EventArgs e)
        {
            UpdateStatus.Stop();
            progress.Value = 96;
            StatusText.Text = "Launching Game";
            DetailText.Text = @"Starting 'RedM\RedM.exe'";
            StartRedM.Tick += StartRedM_Tick;
            StartRedM.Interval = new TimeSpan(0, 0, 3);
            StartRedM.Start();
        }

        private void StartRedM_Tick(object? sender, EventArgs e)
        {
            StartRedM.Stop();
            progress.Value = 98;
            LaunchRedM();
        }

        private void LaunchRedM()
        {
            //Define Location of RedM and RedM App Data
            string LocalAppData = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            string RedM = LocalAppData + @"\RedM\RedM.exe";

            try
            {
                Process.Start(RedM);
                progress.Value = 100;
                StatusText.Text = "Finishing up";
                DetailText.Text = @"Please wait...";
                FinishingUpTimer.Tick += FinishUp;
                FinishingUpTimer.Interval = new TimeSpan(0, 0, 7);
                FinishingUpTimer.Start();
            }
            catch
            {
                //
                this.Close();
            }
        }

        private void FinishUp(object? sender, EventArgs e)
        {
            //Close application
            this.Close();
        }
    }
}
