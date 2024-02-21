namespace Download_and_converter
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            downloadedFiles = new GroupBox();
            convertedFiles = new GroupBox();
            settingsButton = new Button();
            downloadProgress = new ProgressBar();
            convertProgress = new ProgressBar();
            downloadButton = new Button();
            convertButton = new Button();
            downloadUrl = new TextBox();
            convertFilePath = new TextBox();
            codecCombo = new ComboBox();
            label1 = new Label();
            refreshBtn = new Button();
            errorLbl = new Label();
            errIcon = new Label();
            CloseApp = new Button();
            explorerOpen = new Button();
            convertedFilesFolder = new Button();
            label2 = new Label();
            progressBar1 = new ProgressBar();
            DeleteFileBtn = new Button();
            SuspendLayout();
            // 
            // downloadedFiles
            // 
            downloadedFiles.FlatStyle = FlatStyle.Flat;
            downloadedFiles.Location = new Point(12, 144);
            downloadedFiles.Name = "downloadedFiles";
            downloadedFiles.Size = new Size(385, 265);
            downloadedFiles.TabIndex = 0;
            downloadedFiles.TabStop = false;
            // 
            // convertedFiles
            // 
            convertedFiles.FlatStyle = FlatStyle.Flat;
            convertedFiles.Location = new Point(403, 144);
            convertedFiles.Name = "convertedFiles";
            convertedFiles.Size = new Size(385, 265);
            convertedFiles.TabIndex = 1;
            convertedFiles.TabStop = false;
            // 
            // settingsButton
            // 
            settingsButton.BackColor = Color.Transparent;
            settingsButton.BackgroundImageLayout = ImageLayout.Center;
            settingsButton.FlatAppearance.BorderSize = 0;
            settingsButton.FlatStyle = FlatStyle.Flat;
            settingsButton.Image = (Image)resources.GetObject("settingsButton.Image");
            settingsButton.Location = new Point(12, 9);
            settingsButton.Margin = new Padding(0);
            settingsButton.Name = "settingsButton";
            settingsButton.Size = new Size(42, 41);
            settingsButton.TabIndex = 2;
            settingsButton.UseVisualStyleBackColor = false;
            settingsButton.Click += settingsButton_Click;
            // 
            // downloadProgress
            // 
            downloadProgress.Location = new Point(12, 415);
            downloadProgress.Name = "downloadProgress";
            downloadProgress.Size = new Size(385, 23);
            downloadProgress.Style = ProgressBarStyle.Continuous;
            downloadProgress.TabIndex = 3;
            // 
            // convertProgress
            // 
            convertProgress.BackColor = SystemColors.ActiveCaptionText;
            convertProgress.Location = new Point(403, 415);
            convertProgress.Name = "convertProgress";
            convertProgress.Size = new Size(385, 23);
            convertProgress.Style = ProgressBarStyle.Continuous;
            convertProgress.TabIndex = 4;
            // 
            // downloadButton
            // 
            downloadButton.FlatStyle = FlatStyle.Flat;
            downloadButton.Location = new Point(322, 115);
            downloadButton.Name = "downloadButton";
            downloadButton.Size = new Size(75, 24);
            downloadButton.TabIndex = 5;
            downloadButton.Text = "Download";
            downloadButton.UseVisualStyleBackColor = true;
            downloadButton.Click += downloadButton_Click;
            // 
            // convertButton
            // 
            convertButton.FlatStyle = FlatStyle.Flat;
            convertButton.Location = new Point(713, 115);
            convertButton.Name = "convertButton";
            convertButton.Size = new Size(75, 24);
            convertButton.TabIndex = 6;
            convertButton.Text = "Convert";
            convertButton.UseVisualStyleBackColor = true;
            convertButton.Click += convertButton_Click;
            // 
            // downloadUrl
            // 
            downloadUrl.Location = new Point(12, 114);
            downloadUrl.Name = "downloadUrl";
            downloadUrl.Size = new Size(304, 23);
            downloadUrl.TabIndex = 7;
            // 
            // convertFilePath
            // 
            convertFilePath.Location = new Point(403, 115);
            convertFilePath.Name = "convertFilePath";
            convertFilePath.Size = new Size(304, 23);
            convertFilePath.TabIndex = 8;
            // 
            // codecCombo
            // 
            codecCombo.FlatStyle = FlatStyle.Flat;
            codecCombo.FormattingEnabled = true;
            codecCombo.Items.AddRange(new object[] { "MP4", "MOV", "AVI", "MP3", "WEBM" });
            codecCombo.Location = new Point(667, 86);
            codecCombo.Name = "codecCombo";
            codecCombo.Size = new Size(121, 23);
            codecCombo.TabIndex = 9;
            codecCombo.SelectedValueChanged += codecCombo_SelectedValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(570, 86);
            label1.Name = "label1";
            label1.Size = new Size(91, 21);
            label1.TabIndex = 10;
            label1.Text = "Convert To: ";
            // 
            // refreshBtn
            // 
            refreshBtn.BackColor = Color.Transparent;
            refreshBtn.FlatAppearance.BorderSize = 0;
            refreshBtn.FlatStyle = FlatStyle.Flat;
            refreshBtn.Image = (Image)resources.GetObject("refreshBtn.Image");
            refreshBtn.Location = new Point(15, 54);
            refreshBtn.Name = "refreshBtn";
            refreshBtn.Size = new Size(39, 41);
            refreshBtn.TabIndex = 11;
            refreshBtn.UseVisualStyleBackColor = false;
            refreshBtn.Click += refreshBtn_Click;
            // 
            // errorLbl
            // 
            errorLbl.AutoSize = true;
            errorLbl.BackColor = SystemColors.Control;
            errorLbl.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            errorLbl.ForeColor = Color.Red;
            errorLbl.Location = new Point(655, 62);
            errorLbl.Name = "errorLbl";
            errorLbl.Size = new Size(133, 21);
            errorLbl.TabIndex = 12;
            errorLbl.Text = "Please Pick Codec";
            // 
            // errIcon
            // 
            errIcon.AutoSize = true;
            errIcon.BackColor = Color.Transparent;
            errIcon.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            errIcon.Image = (Image)resources.GetObject("errIcon.Image");
            errIcon.Location = new Point(699, 37);
            errIcon.Name = "errIcon";
            errIcon.Size = new Size(47, 25);
            errIcon.TabIndex = 13;
            errIcon.Text = "       ";
            // 
            // CloseApp
            // 
            CloseApp.BackColor = Color.Transparent;
            CloseApp.FlatAppearance.BorderSize = 0;
            CloseApp.FlatStyle = FlatStyle.Flat;
            CloseApp.Image = (Image)resources.GetObject("CloseApp.Image");
            CloseApp.Location = new Point(761, 1);
            CloseApp.Name = "CloseApp";
            CloseApp.Size = new Size(42, 41);
            CloseApp.TabIndex = 14;
            CloseApp.UseVisualStyleBackColor = false;
            CloseApp.Click += CloseApp_Click;
            // 
            // explorerOpen
            // 
            explorerOpen.BackColor = Color.Transparent;
            explorerOpen.BackgroundImageLayout = ImageLayout.Center;
            explorerOpen.FlatAppearance.BorderSize = 0;
            explorerOpen.FlatStyle = FlatStyle.Flat;
            explorerOpen.Image = (Image)resources.GetObject("explorerOpen.Image");
            explorerOpen.Location = new Point(378, 71);
            explorerOpen.Margin = new Padding(0);
            explorerOpen.Name = "explorerOpen";
            explorerOpen.Size = new Size(42, 41);
            explorerOpen.TabIndex = 15;
            explorerOpen.UseVisualStyleBackColor = false;
            explorerOpen.Click += explorerOpen_Click;
            // 
            // convertedFilesFolder
            // 
            convertedFilesFolder.BackColor = Color.Transparent;
            convertedFilesFolder.BackgroundImageLayout = ImageLayout.Center;
            convertedFilesFolder.FlatAppearance.BorderSize = 0;
            convertedFilesFolder.FlatStyle = FlatStyle.Flat;
            convertedFilesFolder.Image = (Image)resources.GetObject("convertedFilesFolder.Image");
            convertedFilesFolder.Location = new Point(415, 71);
            convertedFilesFolder.Margin = new Padding(0);
            convertedFilesFolder.Name = "convertedFilesFolder";
            convertedFilesFolder.Size = new Size(42, 41);
            convertedFilesFolder.TabIndex = 16;
            convertedFilesFolder.UseVisualStyleBackColor = false;
            convertedFilesFolder.Click += convertedFilesFolder_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(354, 62);
            label2.Name = "label2";
            label2.Size = new Size(95, 15);
            label2.TabIndex = 17;
            label2.Text = "Open in Explorer";
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(-15, -20);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(838, 23);
            progressBar1.TabIndex = 18;
            // 
            // DeleteFileBtn
            // 
            DeleteFileBtn.FlatAppearance.BorderSize = 0;
            DeleteFileBtn.FlatStyle = FlatStyle.Flat;
            DeleteFileBtn.Image = (Image)resources.GetObject("DeleteFileBtn.Image");
            DeleteFileBtn.Location = new Point(344, 71);
            DeleteFileBtn.Name = "DeleteFileBtn";
            DeleteFileBtn.Size = new Size(42, 41);
            DeleteFileBtn.TabIndex = 19;
            DeleteFileBtn.UseVisualStyleBackColor = true;
            DeleteFileBtn.Click += DeleteFileBtn_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(804, 449);
            Controls.Add(label2);
            Controls.Add(DeleteFileBtn);
            Controls.Add(progressBar1);
            Controls.Add(convertedFilesFolder);
            Controls.Add(explorerOpen);
            Controls.Add(CloseApp);
            Controls.Add(errorLbl);
            Controls.Add(errIcon);
            Controls.Add(refreshBtn);
            Controls.Add(label1);
            Controls.Add(codecCombo);
            Controls.Add(convertFilePath);
            Controls.Add(downloadUrl);
            Controls.Add(convertButton);
            Controls.Add(downloadButton);
            Controls.Add(convertProgress);
            Controls.Add(downloadProgress);
            Controls.Add(settingsButton);
            Controls.Add(convertedFiles);
            Controls.Add(downloadedFiles);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(804, 449);
            Name = "MainForm";
            Text = "VidConv";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox downloadedFiles;
        private GroupBox convertedFiles;
        private Button settingsButton;
        private ProgressBar downloadProgress;
        private ProgressBar convertProgress;
        private Button downloadButton;
        private Button convertButton;
        private TextBox downloadUrl;
        private TextBox convertFilePath;
        private ComboBox codecCombo;
        private Label label1;
        private Button refreshBtn;
        private Label errorLbl;
        private Label errIcon;
        private Button CloseApp;
        private Button explorerOpen;
        private Button convertedFilesFolder;
        private Label label2;
        private ProgressBar progressBar1;
        private Button DeleteFileBtn;
    }
}
