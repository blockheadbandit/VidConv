namespace Download_and_converter
{
    partial class SettingsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            DarkToggle = new CheckBox();
            SaveCfgButton = new Button();
            label1 = new Label();
            CloseApp = new Button();
            SaveNot = new Label();
            progressBar1 = new ProgressBar();
            YtdlLocationLbl = new Label();
            FFmpegLocationLbl = new Label();
            SetYTDLpth = new Button();
            tBYtdlPth = new TextBox();
            tBFFmpegPth = new TextBox();
            SetFFmpegPth = new Button();
            SuspendLayout();
            // 
            // DarkToggle
            // 
            DarkToggle.AutoSize = true;
            DarkToggle.FlatStyle = FlatStyle.Flat;
            DarkToggle.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            DarkToggle.Location = new Point(14, 36);
            DarkToggle.Name = "DarkToggle";
            DarkToggle.Size = new Size(126, 32);
            DarkToggle.TabIndex = 1;
            DarkToggle.Text = "Dark Mode";
            DarkToggle.UseVisualStyleBackColor = true;
            DarkToggle.CheckedChanged += DarkToggle_CheckedChanged;
            // 
            // SaveCfgButton
            // 
            SaveCfgButton.FlatStyle = FlatStyle.Flat;
            SaveCfgButton.Location = new Point(12, 221);
            SaveCfgButton.Name = "SaveCfgButton";
            SaveCfgButton.Size = new Size(138, 41);
            SaveCfgButton.TabIndex = 2;
            SaveCfgButton.Text = "Save";
            SaveCfgButton.UseVisualStyleBackColor = true;
            SaveCfgButton.Click += SaveCfgButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 190);
            label1.Name = "label1";
            label1.Size = new Size(315, 28);
            label1.TabIndex = 3;
            label1.Text = "Relaunch for changes to take effect";
            // 
            // CloseApp
            // 
            CloseApp.BackColor = Color.Transparent;
            CloseApp.FlatAppearance.BorderSize = 0;
            CloseApp.FlatStyle = FlatStyle.Flat;
            CloseApp.Image = (Image)resources.GetObject("CloseApp.Image");
            CloseApp.Location = new Point(332, 2);
            CloseApp.Name = "CloseApp";
            CloseApp.Size = new Size(42, 41);
            CloseApp.TabIndex = 15;
            CloseApp.UseVisualStyleBackColor = false;
            CloseApp.Click += CloseApp_Click;
            // 
            // SaveNot
            // 
            SaveNot.AutoSize = true;
            SaveNot.Location = new Point(156, 234);
            SaveNot.Name = "SaveNot";
            SaveNot.Size = new Size(83, 15);
            SaveNot.TabIndex = 16;
            SaveNot.Text = "Settings Saved";
            SaveNot.Visible = false;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(-4, -20);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(385, 23);
            progressBar1.TabIndex = 17;
            // 
            // YtdlLocationLbl
            // 
            YtdlLocationLbl.AutoSize = true;
            YtdlLocationLbl.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            YtdlLocationLbl.Location = new Point(11, 67);
            YtdlLocationLbl.Name = "YtdlLocationLbl";
            YtdlLocationLbl.Size = new Size(136, 28);
            YtdlLocationLbl.TabIndex = 18;
            YtdlLocationLbl.Text = "YTDL Location";
            // 
            // FFmpegLocationLbl
            // 
            FFmpegLocationLbl.AutoSize = true;
            FFmpegLocationLbl.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            FFmpegLocationLbl.Location = new Point(10, 124);
            FFmpegLocationLbl.Name = "FFmpegLocationLbl";
            FFmpegLocationLbl.Size = new Size(163, 28);
            FFmpegLocationLbl.TabIndex = 19;
            FFmpegLocationLbl.Text = "FFmpeg Location";
            // 
            // SetYTDLpth
            // 
            SetYTDLpth.Location = new Point(289, 93);
            SetYTDLpth.Name = "SetYTDLpth";
            SetYTDLpth.Size = new Size(75, 23);
            SetYTDLpth.TabIndex = 20;
            SetYTDLpth.Text = "Set";
            SetYTDLpth.UseVisualStyleBackColor = true;
            SetYTDLpth.Click += SetYTDLpth_Click;
            // 
            // tBYtdlPth
            // 
            tBYtdlPth.Location = new Point(12, 93);
            tBYtdlPth.Name = "tBYtdlPth";
            tBYtdlPth.Size = new Size(281, 23);
            tBYtdlPth.TabIndex = 21;
            // 
            // tBFFmpegPth
            // 
            tBFFmpegPth.Location = new Point(12, 154);
            tBFFmpegPth.Name = "tBFFmpegPth";
            tBFFmpegPth.Size = new Size(281, 23);
            tBFFmpegPth.TabIndex = 22;
            // 
            // SetFFmpegPth
            // 
            SetFFmpegPth.Location = new Point(289, 154);
            SetFFmpegPth.Name = "SetFFmpegPth";
            SetFFmpegPth.Size = new Size(75, 23);
            SetFFmpegPth.TabIndex = 23;
            SetFFmpegPth.Text = "Set";
            SetFFmpegPth.UseVisualStyleBackColor = true;
            SetFFmpegPth.Click += SetFFmpegPth_Click;
            // 
            // SettingsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(376, 273);
            Controls.Add(SetYTDLpth);
            Controls.Add(SetFFmpegPth);
            Controls.Add(tBFFmpegPth);
            Controls.Add(tBYtdlPth);
            Controls.Add(FFmpegLocationLbl);
            Controls.Add(YtdlLocationLbl);
            Controls.Add(progressBar1);
            Controls.Add(SaveNot);
            Controls.Add(CloseApp);
            Controls.Add(label1);
            Controls.Add(SaveCfgButton);
            Controls.Add(DarkToggle);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MaximumSize = new Size(376, 310);
            MinimizeBox = false;
            MinimumSize = new Size(376, 273);
            Name = "SettingsForm";
            Text = "SettingsForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox DarkToggle;
        private Button SaveCfgButton;
        private Label label1;
        private Button CloseApp;
        private Label SaveNot;
        private ProgressBar progressBar1;
        private Label YtdlLocationLbl;
        private Label FFmpegLocationLbl;
        private Button SetYTDLpth;
        private TextBox tBYtdlPth;
        private TextBox tBFFmpegPth;
        private Button SetFFmpegPth;
    }
}