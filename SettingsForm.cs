using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using Xabe.FFmpeg;
using System.Threading.Tasks;
using System.Windows.Forms;
using YoutubeDLSharp;

namespace Download_and_converter
{
    public partial class SettingsForm : Form
    {
        UserConfig userSettings = new UserConfig();
        string path;
        YoutubeDL ytdl = new YoutubeDL();

        public SettingsForm()
        {

            InitializeComponent();
            applyCfg();
            tBYtdlPth.Text = userSettings.Ytdlpath;
            tBFFmpegPth.Text = userSettings.FFmpegPath;

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

        private void DarkToggle_CheckedChanged(object sender, EventArgs e)
        {
            List<Label> labels = this.Controls.OfType<Label>().ToList();
            List<Button> buttons = this.Controls.OfType<Button>().ToList();
            List<TextBox> textboc = this.Controls.OfType<TextBox>().ToList();
            if (DarkToggle.Checked)
            {

                this.BackColor = Color.FromArgb(userSettings.backColorD[0], userSettings.backColorD[1], userSettings.backColorD[2]);
                this.ForeColor = Color.FromArgb(userSettings.textColorD[0], userSettings.textColorD[1], userSettings.textColorD[2]);
                foreach (Label label in labels)
                {
                    label.BackColor = Color.FromArgb(userSettings.backColorD[0], userSettings.backColorD[1], userSettings.backColorD[2]); ;
                    label.ForeColor = Color.FromArgb(userSettings.textColorD[0], userSettings.textColorD[1], userSettings.textColorD[2]);
                }
                foreach (Button button in buttons)
                {
                    button.BackColor = Color.FromArgb(userSettings.backColorD[0], userSettings.backColorD[1], userSettings.backColorD[2]);
                    button.ForeColor = Color.FromArgb(userSettings.textColorD[0], userSettings.textColorD[1], userSettings.textColorD[2]);

                }
                foreach (TextBox textbocs in textboc)
                {
                    textbocs.BackColor = Color.FromArgb(userSettings.backColorD[0], userSettings.backColorD[1], userSettings.backColorD[2]);
                    textbocs.ForeColor = Color.FromArgb(userSettings.textColorD[0], userSettings.textColorD[1], userSettings.textColorD[2]);
                }
                userSettings.darkMode = true;

            }
            if (!DarkToggle.Checked)
            {
                this.BackColor = userSettings.backColorL;
                this.ForeColor = Color.FromArgb(userSettings.textColorL[0], userSettings.textColorL[1], userSettings.textColorL[2]);
                foreach (Label label in labels)
                {
                    label.BackColor = userSettings.backColorL;
                    label.ForeColor = Color.FromArgb(userSettings.textColorL[0], userSettings.textColorL[1], userSettings.textColorL[2]);
                }
                foreach (Button button in buttons)
                {
                    button.BackColor = userSettings.backColorL;
                    button.ForeColor = Color.FromArgb(userSettings.textColorL[0], userSettings.textColorL[1], userSettings.textColorL[2]);

                }
                foreach (TextBox textbocs in textboc)
                {
                    textbocs.BackColor = userSettings.backColorL;
                    textbocs.ForeColor = Color.FromArgb(userSettings.textColorL[0], userSettings.textColorL[1], userSettings.textColorL[2]);
                }
                userSettings.darkMode = false;

            }
        }
        void saveSettings()
        {
            string configPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "DownloadConvertTools\\Config\\config.json");
            int jsonlen = File.ReadAllText(configPath).Length;
            string jsonified = JsonConvert.SerializeObject(userSettings);
            using (FileStream fs = File.Create(configPath))
            {
                byte[] bjsonified = new UTF8Encoding(true).GetBytes(jsonified);
                fs.Write(bjsonified, 0, bjsonified.Length);

            }

        }

        private void SaveCfgButton_Click(object sender, EventArgs e)
        {
            SaveNot.Visible = false;
            saveSettings();
            SaveNot.Visible = true;
        }
        void applyCfg()
        {
            string configPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "DownloadConvertTools\\Config\\config.json");
            DefaultConfig userConfig = JsonConvert.DeserializeObject<DefaultConfig>(File.ReadAllText(configPath));
            if (userConfig.darkMode)
            {
                DarkToggle.Checked = true;
                this.BackColor = Color.FromArgb(userConfig.backColorD[0], userConfig.backColorD[1], userConfig.backColorD[2]);
                this.ForeColor = Color.FromArgb(userConfig.textColorD[0], userConfig.textColorD[1], userConfig.textColorD[2]);
                List<Label> labels = this.Controls.OfType<Label>().ToList();
                List<Button> buttons = this.Controls.OfType<Button>().ToList();
                List<ProgressBar> bars = this.Controls.OfType<ProgressBar>().ToList();
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

            }
            else
            {
                this.BackColor = userSettings.backColorL;
                this.ForeColor = Color.FromArgb(userConfig.textColorL[0], userConfig.textColorL[1], userConfig.textColorL[2]);
            }
        }

        private void CloseApp_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void Form1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void SetYTDLpth_Click(object sender, EventArgs e)
        {
            path = tBYtdlPth.Text;
            userSettings.Ytdlpath = path;
            
            ytdl.YoutubeDLPath = Path.GetFullPath(path);
            MessageBox.Show(ytdl.YoutubeDLPath);
        }

        private void SetFFmpegPth_Click(object sender, EventArgs e)
        { 
            path = tBFFmpegPth.Text;
            userSettings.FFmpegPath = path;
            FFmpeg.SetExecutablesPath(path);
            
        }
    }

    class UserConfig
    {
        public bool darkMode = false;
        public int[] backColorD = { 30, 30, 30 };
        public Color backColorL = SystemColors.Control;
        public int[] textColorD = { 255, 255, 255 };
        public int[] textColorL = { 0, 0, 0 };
        public int[] progressBgD = { 40, 40, 40 };
        public string Ytdlpath = "./yt-dlp.exe";
        public string FFmpegPath;
    }
}
