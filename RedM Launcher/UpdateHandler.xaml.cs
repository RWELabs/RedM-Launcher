using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
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

namespace RedM_Launcher
{
    /// <summary>
    /// Interaction logic for UpdateHandler.xaml
    /// </summary>
    public partial class UpdateHandler : Window
    {
        System.Windows.Threading.DispatcherTimer NoUpdate = new System.Windows.Threading.DispatcherTimer();
        System.Windows.Threading.DispatcherTimer Update = new System.Windows.Threading.DispatcherTimer();
        System.Windows.Threading.DispatcherTimer ApplyUpdate = new System.Windows.Threading.DispatcherTimer();

        public UpdateHandler()
        {
            InitializeComponent();

            StatusText.Text = "Checking for Updates";
            DetailText.Text = @"Connecting to labs.ryanwalpole.com...";
            progress.Value = 10;

            string CurrentUpdateVersion = "https://raw.githubusercontent.com/RWELabs/RedM-Launcher/main/WebAssets/CVER.txt";

            try
            {
                //View current stable version number
                WebClient client = new WebClient();
                client.Proxy = null;
                Stream stream = client.OpenRead(CurrentUpdateVersion);
                StreamReader reader = new StreamReader(stream);
                String CVER = reader.ReadToEnd();
                progress.Value = 40;

                if (!CVER.Contains(redmLauncher.Default.Version))
                {
                    //Updates Available
                    StatusText.Text = "Checking for Updates";
                    DetailText.Text = @"(1) new at /labs.ryanwalpole.com:7872/udc.cver";
                    progress.Value = 52;
                    Update.Tick += Update_Tick;
                    Update.Interval = new TimeSpan(0, 0, 5);
                    Update.Start();
                }
                else
                {
                    StatusText.Text = "Checking for Updates";
                    DetailText.Text = @"Application up to date";
                    progress.Value = 73;
                    NoUpdate.Tick += NoUpdate_Tick;
                    NoUpdate.Interval = new TimeSpan(0, 0, 3);
                    NoUpdate.Start();
                }
            }
            catch
            {
                StatusText.Text = "Finishing Up";
                DetailText.Text = @"Closing application...";
                //Close application
                this.Close();
            }
        }

        private void Update_Tick(object? sender, EventArgs e)
        {
            Update.Stop();
            progress.Value = 99;

            StatusText.Text = "Downloading Update";
            DetailText.Text = @"Retrieving information...";
            try
            {
                using (WebClient wc = new WebClient())
                {
                    string dataPath = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData);
                    string updatelocation = System.IO.Path.Combine(dataPath, "redmlauncherupdate.exe");

                    wc.DownloadProgressChanged += wc_DownloadProgressChanged2;
                    wc.DownloadFileAsync(
                        // Param1 = Link of file
                        new System.Uri("https://github.com/RWELabs/RedM-Launcher/raw/main/Installer/redmlauncher.exe"),
                        // Param2 = Path to save
                        updatelocation
                    );
                }

            }
            catch
            {

            }
        }

        void wc_DownloadProgressChanged2(object sender, DownloadProgressChangedEventArgs e)
        {
            StatusText.Text = "Downloading Update";
            progress.Value = e.ProgressPercentage;
            long FileSize = e.TotalBytesToReceive / 1024;
            DetailText.Text = e.ProgressPercentage.ToString() + "% of " + FileSize.ToString() + " kb";

            if(progress.Value == 100)
            {
                ApplyUpdate.Tick += ApplyUpdate_Tick;
                ApplyUpdate.Interval = new TimeSpan(0, 0, 5);
                ApplyUpdate.Start();
            }
        }

        private void ApplyUpdate_Tick(object? sender, EventArgs e)
        {
            ApplyUpdate.Stop();

            string dataPath = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData);
            string updatePath = System.IO.Path.Combine(dataPath, "redmlauncherupdate.exe");

            string Params = @"/silent";

            Process updateprocess = new Process();
            updateprocess.StartInfo.FileName = "cmd.exe";
            updateprocess.StartInfo.Arguments = "/k " + updatePath + " " + Params;
            updateprocess.StartInfo.UseShellExecute = false;
            updateprocess.StartInfo.CreateNoWindow = true;
            updateprocess.Start();

            this.Close();
        }

        private void NoUpdate_Tick(object? sender, EventArgs e)
        {
            NoUpdate.Stop();
            progress.Value = 100;
            this.Close();
        }
    }
}
