using Microsoft.VisualBasic.ApplicationServices;
using Newtonsoft.Json;
using System.Diagnostics;
using System.Security.Policy;
using System.Text;
using System.Threading;
using Xabe.FFmpeg;
using Xabe.FFmpeg.Downloader;
using YoutubeDLSharp;

namespace Download_and_converter
{

    public partial class MainForm : Form
    {
        DefaultConfig userConfig;
        string downloadPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "DownloadConvertTools\\Downloads");
        string ConvertPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "DownloadConvertTools\\ConvertedFiles");
        public string configPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "DownloadConvertTools\\Config");

        public YoutubeDL ytdl = new YoutubeDL();
        string dlUrl;
        string convPth;
        string convCodec;
        string output;
        Label oldLbl;


        public MainForm()
        {
            //updater code here
            InitializeComponent();
            DeleteFileBtn.Enabled = false;
            if (!Directory.Exists(downloadPath) || !Directory.Exists(ConvertPath))
            {
                // triggers antivirus for some reason
                FFmpegDownloader.GetLatestVersion(FFmpegVersion.Official);
                Directory.CreateDirectory(downloadPath);
                Directory.CreateDirectory(ConvertPath);
            }
            ytdl.OutputFolder = downloadPath;
            getDownloadedFiles();
            getConvertedFiles();
            convertButton.Enabled = false;
            errorLbl.Visible = false;
            errIcon.Visible = false;
            if (!Directory.Exists(configPath))
            {
                DefaultConfig shippedConfig = new DefaultConfig();
                string jsonified = JsonConvert.SerializeObject(shippedConfig);
                Directory.CreateDirectory(configPath);
                using (FileStream fs = File.Create(Path.Combine(configPath, "config.json")))
                {
                    byte[] bjsonified = new UTF8Encoding(true).GetBytes(jsonified);
                    fs.Write(bjsonified, 0, bjsonified.Length);
                }
            }
            userConfig = JsonConvert.DeserializeObject<DefaultConfig>(File.ReadAllText(Path.Combine(configPath, "config.json")));
            applyConfig();


        }
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case 0x84:
                    base.WndProc(ref m);
                    if ((int)m.Result == 0x1)
                        m.Result = (IntPtr)0x2;
                    return;
            }

            base.WndProc(ref m);
        }




        private void removeLabels()
        {

            DirectoryInfo downloaded = new DirectoryInfo(downloadPath);
            FileInfo[] Files = downloaded.GetFiles();
            List<Label> labels = downloadedFiles.Controls.OfType<Label>().ToList();
            foreach (Label label in labels)
            {
                downloadedFiles.Controls.Remove(label);
            }
        }
        private void removeLabelsConv()
        {

            DirectoryInfo Cnv = new DirectoryInfo(ConvertPath);
            FileInfo[] Files = Cnv.GetFiles();
            List<Label> labels = convertedFiles.Controls.OfType<Label>().ToList();
            foreach (Label label in labels)
            {
                convertedFiles.Controls.Remove(label);
            }
        }
        private void getDownloadedFiles()
        {
            int offsetX = 10;
            int offsetY = 10;
            DirectoryInfo downloaded = new DirectoryInfo(downloadPath);
            FileInfo[] Files = downloaded.GetFiles();
            foreach (FileInfo File in Files)
            {
                Label fileLabel = new Label();
                fileLabel.Name = $"{File.Name}Lbl";
                fileLabel.Text = File.Name;
                fileLabel.Left = offsetX;
                fileLabel.Location = new Point(offsetX, offsetY);
                fileLabel.Width = 370;
                fileLabel.Parent = downloadedFiles;
                fileLabel.Click += (sender, e) => fileTextClick(sender, e, File.FullName, fileLabel);
                offsetY += (fileLabel.Height);



            }
        }
        private void getConvertedFiles()
        {
            int offsetX = 10;
            int offsetY = 10;
            DirectoryInfo convertedFilesPth = new DirectoryInfo(ConvertPath);
            FileInfo[] Files = convertedFilesPth.GetFiles();
            foreach (FileInfo File in Files)
            {
                Label fileLabel = new Label();
                fileLabel.Name = $"{File.Name}Lbl";
                fileLabel.Text = File.Name;
                fileLabel.Left = offsetX;
                fileLabel.Location = new Point(offsetX, offsetY);
                fileLabel.Width = 370;
                fileLabel.Parent = convertedFiles;
                fileLabel.Click += (sender, e) => fileTextClick(sender, e, File.FullName, fileLabel);
                offsetY += (fileLabel.Height);



            }
        }
        string clickedfile;
        private void fileTextClick(object sender, EventArgs e, string fileName, Label triggerLbl)
        {
            DeleteFileBtn.Enabled = true;
            if (oldLbl != null)
            {
                if (userConfig.darkMode)
                {
                    oldLbl.BackColor = Color.FromArgb(userConfig.backColorD[0], userConfig.backColorD[1], userConfig.backColorD[2]);
                    oldLbl.ForeColor = Color.FromArgb(userConfig.textColorD[0], userConfig.textColorD[1], userConfig.textColorD[2]);
                }
                else
                {
                    oldLbl.BackColor = userConfig.backColorL;
                    oldLbl.ForeColor = Color.FromArgb(userConfig.textColorL[0], userConfig.textColorL[1], userConfig.textColorL[2]);
                }

            }

            triggerLbl.BackColor = SystemColors.Highlight;
            convertFilePath.Text = fileName;
            clickedfile = fileName;
            output = Path.Combine(ConvertPath, triggerLbl.Text.Split(".")[0]);
            oldLbl = triggerLbl;
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            SettingsForm settingsWindow = new SettingsForm();
            settingsWindow.Show();

        }

        private async void downloadButton_Click(object sender, EventArgs e)
        {
            //cache the URL
            downloadProgress.Minimum = 1;
            downloadProgress.Maximum = 100;
            downloadProgress.Value = 1;
            downloadProgress.Step = 50;
            dlUrl = downloadUrl.Text;
            downloadProgress.PerformStep();
            var dl = await ytdl.RunVideoDownload(dlUrl);
            downloadProgress.PerformStep();
            removeLabels();
            getDownloadedFiles();




        }

        private async void convertButton_Click(object sender, EventArgs e)
        {
            errorLbl.Visible = false;
            errIcon.Visible = false;
            convPth = convertFilePath.Text;
            convCodec = codecCombo.Text;
            convertProgress.Minimum = 1;
            convertProgress.Maximum = 100;
            convertProgress.Value = 1;
            convertProgress.Step = 50;
            convertProgress.PerformStep();
            if (convCodec.Equals("MP4"))
            {
                var conversion = await FFmpeg.Conversions.FromSnippet.ToMp4(convPth, $"{output}.mp4");
                conversion.Start();
                convertProgress.PerformStep();
            }
            else if (convCodec.Equals("WEBM"))
            {
                var conversion = await FFmpeg.Conversions.FromSnippet.ToWebM(convPth, $"{output}.webm");
                conversion.Start();
                convertProgress.PerformStep();
            }
            else if (convCodec.Equals("MOV"))
            {
                var conversion = await FFmpeg.Conversions.FromSnippet.Convert(convPth, $"{output}.mov");
                conversion.Start();
                convertProgress.PerformStep();
            }
            else if (convCodec.Equals("AVI"))
            {
                var conversion = await FFmpeg.Conversions.FromSnippet.Convert(convPth, $"{output}.avi");
                conversion.Start();
                convertProgress.PerformStep();
            }
            else if (convCodec.Equals("MP3"))
            {
                var conversion = await FFmpeg.Conversions.FromSnippet.Convert(convPth, $"{output}.mp3");
                conversion.Start();
                convertProgress.PerformStep();
            }
            else
            {
                errorLbl.Visible = true;
                errIcon.Visible = true;
            }


            Thread.Sleep(1000);
            removeLabelsConv();
            getConvertedFiles();

        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            removeLabelsConv();
            removeLabels();
            getDownloadedFiles();
            getConvertedFiles();
        }

        private void codecCombo_SelectedValueChanged(object sender, EventArgs e)
        {
            convertButton.Enabled = true;
        }
        public void applyConfig()
        {

            if (userConfig.FFmpegPath != null)
            {
                FFmpeg.SetExecutablesPath(userConfig.FFmpegPath);
            }
            if (userConfig.Ytdlpath != null)
            {
                ytdl.YoutubeDLPath = userConfig.Ytdlpath;
            }

            if (userConfig.darkMode)
            {
                this.BackColor = Color.FromArgb(userConfig.backColorD[0], userConfig.backColorD[1], userConfig.backColorD[2]);
                this.ForeColor = Color.FromArgb(userConfig.textColorD[0], userConfig.textColorD[1], userConfig.textColorD[2]);
                List<Label> labels = this.Controls.OfType<Label>().ToList();
                List<Button> buttons = this.Controls.OfType<Button>().ToList();
                List<ProgressBar> bars = this.Controls.OfType<ProgressBar>().ToList();
                List<TextBox> textboc = this.Controls.OfType<TextBox>().ToList();
                List<ComboBox> combox = this.Controls.OfType<ComboBox>().ToList();
                foreach (Label label in labels)
                {
                    label.BackColor = Color.FromArgb(userConfig.backColorD[0], userConfig.backColorD[1], userConfig.backColorD[2]); ;
                    label.ForeColor = Color.FromArgb(userConfig.textColorD[0], userConfig.textColorD[1], userConfig.textColorD[2]);
                }
                foreach (Button button in buttons)
                {
                    button.BackColor = Color.FromArgb(userConfig.backColorD[0], userConfig.backColorD[1], userConfig.backColorD[2]);
                    button.ForeColor = Color.FromArgb(userConfig.textColorD[0], userConfig.textColorD[1], userConfig.textColorD[2]);
                }
                foreach (ProgressBar bar in bars)
                {
                    bar.BackColor = Color.FromArgb(userConfig.progressBgD[0], userConfig.progressBgD[1], userConfig.progressBgD[2]);
                }
                foreach (TextBox textbocs in textboc)
                {
                    textbocs.BackColor = Color.FromArgb(userConfig.backColorD[0], userConfig.backColorD[1], userConfig.backColorD[2]);
                    textbocs.ForeColor = Color.FromArgb(userConfig.textColorD[0], userConfig.textColorD[1], userConfig.textColorD[2]);
                }
                foreach (ComboBox comb in combox)
                {
                    comb.BackColor = Color.FromArgb(userConfig.backColorD[0], userConfig.backColorD[1], userConfig.backColorD[2]);
                    comb.ForeColor = Color.FromArgb(userConfig.textColorD[0], userConfig.textColorD[1], userConfig.textColorD[2]);
                }

            }
            else
            {
                this.BackColor = userConfig.backColorL;
                this.ForeColor = Color.FromArgb(userConfig.textColorL[0], userConfig.textColorL[1], userConfig.textColorL[2]);
            }
        }

        private void CloseApp_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void explorerOpen_Click(object sender, EventArgs e)
        {

            Process.Start("explorer.exe", @downloadPath);
        }

        private void convertedFilesFolder_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", @ConvertPath);
        }

        private void DeleteFileBtn_Click(object sender, EventArgs e)
        {
            File.Delete(clickedfile);
            removeLabelsConv();
            removeLabels();
            getDownloadedFiles();
            getConvertedFiles();
        }
    }
    class DefaultConfig
    {
        public bool darkMode = false;
        public  int[] backColorD = { 30, 30, 30 };
        public Color backColorL = SystemColors.Control;
        public int[] textColorD = { 255, 255, 255 };
        public int[] textColorL = { 0, 0, 0 };
        public int[] progressBgD = { 40, 40, 40 };
        public string Ytdlpath = "./yt-dlp.exe";
        public string FFmpegPath;
    }
}
