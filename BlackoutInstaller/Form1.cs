using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Diagnostics;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;


namespace BlackoutInstaller
{

    public partial class Form1 : Form
    {

        private bool dragging = false;
        private Point lastLocation;

        Timer fadeinTimer = new Timer();
        Timer fadeoutTimer = new Timer();

        public Form1()
        {
            InitializeComponent();
            string defaultDirectory = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), ".minecraft");
            DirectoryText.Text = defaultDirectory;
        }

        void fadeIn(object sender, EventArgs e)
        {
            if (Opacity >= 1)
            {
                fadeinTimer.Stop();
            }
            else
                Opacity += 0.05;
        }

        void fadeOut(object sender, EventArgs e)
        {
            if (Opacity <= 0)
            {
                fadeoutTimer.Stop();
                Close();
            }
            else
                Opacity -= 0.05;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Opacity = 0;

            fadeinTimer.Interval = 30;
            fadeinTimer.Tick += new EventHandler(fadeIn);
            fadeinTimer.Start();
        }

        private void XButton_MouseClick(object sender, MouseEventArgs e)
        {
            fadeoutTimer.Interval = 30;
            fadeoutTimer.Tick += new EventHandler(fadeOut);
            fadeoutTimer.Start();
        }

        private void Top_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            lastLocation = e.Location;
        }

        private void Top_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging && e.Y < 30)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X,
                    (this.Location.Y - lastLocation.Y) + e.Y);
                this.Update();
            }

        }
        private void Top_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }


        private void DirButton_Click(object sender, EventArgs e)
        {
            using (var dialog = new FolderBrowserDialog())
            {
                dialog.SelectedPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData));
                DialogResult result = dialog.ShowDialog();
                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(dialog.SelectedPath))
                {
                    DirectoryText.Text = dialog.SelectedPath;
                }
            }
        }

        private void InstallButton_MouseClick(object sender, MouseEventArgs e) {
            string apiUrl = $"https://api.github.com/repos/chell-dev/Blackout-3.0/releases/latest";
            string fabricInstallerUrl = "https://maven.fabricmc.net/net/fabricmc/fabric-installer/0.11.1/fabric-installer-0.11.1.jar";
            string fabricInstallTo = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Downloads";

            using (WebClient client = new WebClient()) 
            {
                client.Headers.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64)");
                string releaseJson = client.DownloadString(apiUrl);

                dynamic release = JsonConvert.DeserializeObject(releaseJson);
                string downloadUrl = release.assets[0].browser_download_url;

                using (WebClient downloadClient = new WebClient()) 
                {
                    string filename = downloadUrl.Split('/').Last();
                    string installto = DirectoryText.Text;
                    string downloadPath = Path.Combine(installto, filename);

                    DialogResult fabricresult = MessageBox.Show("Do you have fabric 1.19.3 installed?", "Blackout 3.0", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (fabricresult == DialogResult.No)
                    {
                        downloadClient.DownloadFile(fabricInstallerUrl, fabricInstallTo);

                        ProcessStartInfo fabricJar = new ProcessStartInfo();
                        fabricJar.FileName = "java";
                        fabricJar.Arguments = "-jar \"" + fabricInstallTo + "\"";
                        Process fabricProcess = Process.Start(fabricJar);
                        fabricProcess.WaitForExit();

                    }

                    if (File.Exists(Path.Combine(installto, "mods", filename)))
                    {
                        DialogResult result = MessageBox.Show("Blackout is already installed. Do you want to update it?", "Blackout 3.0" , MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.No) 
                        {
                            return;
                        }
                        else {
                            File.Delete(Path.Combine(installto, "mods", filename)); 
                        }
                    }
                    downloadClient.DownloadFile(downloadUrl, downloadPath);

                        string modsPath = Path.Combine(installto, "mods");
                        Directory.CreateDirectory(modsPath);

                        string destinationPath = Path.Combine(modsPath, filename);
                        File.Move(downloadPath, destinationPath);

                    install_label.Text = "Installation successfull!";
                }
            }
        }
    }
}
