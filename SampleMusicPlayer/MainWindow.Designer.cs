namespace SampleMusicPlayer
{
    partial class MainWindow
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playFromFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preferencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.languageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.englishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.japaneseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelSongTitle = new System.Windows.Forms.Label();
            this.labelArtistName = new System.Windows.Forms.Label();
            this.labelAlbumName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelSongLength = new System.Windows.Forms.Label();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.VolumeSlider = new System.Windows.Forms.TrackBar();
            this.SongDuration = new System.Windows.Forms.Timer(this.components);
            this.VolumeIcons = new System.Windows.Forms.ImageList(this.components);
            this.labelVolumeStatus = new System.Windows.Forms.Label();
            this.buttonStop = new System.Windows.Forms.Button();
            this.buttonImportFile = new System.Windows.Forms.Button();
            this.buttonPlayPause = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VolumeSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.preferencesToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Name = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            resources.ApplyResources(this.fileToolStripMenuItem, "fileToolStripMenuItem");
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.playFromFileToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            // 
            // playFromFileToolStripMenuItem
            // 
            resources.ApplyResources(this.playFromFileToolStripMenuItem, "playFromFileToolStripMenuItem");
            this.playFromFileToolStripMenuItem.Image = global::SampleMusicPlayer.Properties.Resources.glyphicons_504_cd;
            this.playFromFileToolStripMenuItem.Name = "playFromFileToolStripMenuItem";
            this.playFromFileToolStripMenuItem.Click += new System.EventHandler(this.playFromFileToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            resources.ApplyResources(this.exitToolStripMenuItem, "exitToolStripMenuItem");
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // preferencesToolStripMenuItem
            // 
            resources.ApplyResources(this.preferencesToolStripMenuItem, "preferencesToolStripMenuItem");
            this.preferencesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.languageToolStripMenuItem});
            this.preferencesToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.preferencesToolStripMenuItem.Name = "preferencesToolStripMenuItem";
            // 
            // languageToolStripMenuItem
            // 
            resources.ApplyResources(this.languageToolStripMenuItem, "languageToolStripMenuItem");
            this.languageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.englishToolStripMenuItem,
            this.japaneseToolStripMenuItem});
            this.languageToolStripMenuItem.Name = "languageToolStripMenuItem";
            // 
            // englishToolStripMenuItem
            // 
            resources.ApplyResources(this.englishToolStripMenuItem, "englishToolStripMenuItem");
            this.englishToolStripMenuItem.Name = "englishToolStripMenuItem";
            // 
            // japaneseToolStripMenuItem
            // 
            resources.ApplyResources(this.japaneseToolStripMenuItem, "japaneseToolStripMenuItem");
            this.japaneseToolStripMenuItem.Name = "japaneseToolStripMenuItem";
            // 
            // helpToolStripMenuItem
            // 
            resources.ApplyResources(this.helpToolStripMenuItem, "helpToolStripMenuItem");
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            // 
            // aboutToolStripMenuItem
            // 
            resources.ApplyResources(this.aboutToolStripMenuItem, "aboutToolStripMenuItem");
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // labelSongTitle
            // 
            resources.ApplyResources(this.labelSongTitle, "labelSongTitle");
            this.labelSongTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelSongTitle.ForeColor = System.Drawing.Color.White;
            this.labelSongTitle.Name = "labelSongTitle";
            this.labelSongTitle.UseCompatibleTextRendering = true;
            // 
            // labelArtistName
            // 
            resources.ApplyResources(this.labelArtistName, "labelArtistName");
            this.labelArtistName.BackColor = System.Drawing.Color.Transparent;
            this.labelArtistName.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.labelArtistName.Name = "labelArtistName";
            // 
            // labelAlbumName
            // 
            resources.ApplyResources(this.labelAlbumName, "labelAlbumName");
            this.labelAlbumName.BackColor = System.Drawing.Color.Transparent;
            this.labelAlbumName.ForeColor = System.Drawing.Color.DimGray;
            this.labelAlbumName.Name = "labelAlbumName";
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.VolumeSlider);
            this.panel1.Controls.Add(this.labelSongLength);
            this.panel1.Controls.Add(this.labelVolumeStatus);
            this.panel1.Controls.Add(this.trackBar2);
            this.panel1.Controls.Add(this.buttonImportFile);
            this.panel1.Controls.Add(this.buttonPlayPause);
            this.panel1.Controls.Add(this.buttonStop);
            this.panel1.Name = "panel1";
            // 
            // labelSongLength
            // 
            resources.ApplyResources(this.labelSongLength, "labelSongLength");
            this.labelSongLength.ForeColor = System.Drawing.Color.Black;
            this.labelSongLength.Name = "labelSongLength";
            // 
            // trackBar2
            // 
            resources.ApplyResources(this.trackBar2, "trackBar2");
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // VolumeSlider
            // 
            resources.ApplyResources(this.VolumeSlider, "VolumeSlider");
            this.VolumeSlider.BackColor = System.Drawing.Color.White;
            this.VolumeSlider.LargeChange = 1;
            this.VolumeSlider.Name = "VolumeSlider";
            this.VolumeSlider.Value = 10;
            this.VolumeSlider.Scroll += new System.EventHandler(this.VolumeSlider_Scroll);
            // 
            // SongDuration
            // 
            this.SongDuration.Tick += new System.EventHandler(this.SongDuration_Tick);
            // 
            // VolumeIcons
            // 
            this.VolumeIcons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("VolumeIcons.ImageStream")));
            this.VolumeIcons.TransparentColor = System.Drawing.Color.Transparent;
            this.VolumeIcons.Images.SetKeyName(0, "glyphicons-183-mute.png");
            this.VolumeIcons.Images.SetKeyName(1, "glyphicons-184-volume-down.png");
            this.VolumeIcons.Images.SetKeyName(2, "glyphicons-185-volume-up.png");
            // 
            // labelVolumeStatus
            // 
            resources.ApplyResources(this.labelVolumeStatus, "labelVolumeStatus");
            this.labelVolumeStatus.BackColor = System.Drawing.Color.Transparent;
            this.labelVolumeStatus.ForeColor = System.Drawing.Color.White;
            this.labelVolumeStatus.ImageList = this.VolumeIcons;
            this.labelVolumeStatus.Name = "labelVolumeStatus";
            // 
            // buttonStop
            // 
            resources.ApplyResources(this.buttonStop, "buttonStop");
            this.buttonStop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.buttonStop.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.buttonStop.Image = global::SampleMusicPlayer.Properties.Resources.glyphicons_176_stop;
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.UseVisualStyleBackColor = false;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // buttonImportFile
            // 
            resources.ApplyResources(this.buttonImportFile, "buttonImportFile");
            this.buttonImportFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.buttonImportFile.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.buttonImportFile.Image = global::SampleMusicPlayer.Properties.Resources.glyphicons_182_download_alt;
            this.buttonImportFile.Name = "buttonImportFile";
            this.buttonImportFile.UseVisualStyleBackColor = false;
            this.buttonImportFile.Click += new System.EventHandler(this.buttonImportFile_Click);
            // 
            // buttonPlayPause
            // 
            resources.ApplyResources(this.buttonPlayPause, "buttonPlayPause");
            this.buttonPlayPause.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.buttonPlayPause.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.buttonPlayPause.Image = global::SampleMusicPlayer.Properties.Resources.glyphicons_174_play;
            this.buttonPlayPause.Name = "buttonPlayPause";
            this.buttonPlayPause.UseVisualStyleBackColor = false;
            this.buttonPlayPause.Click += new System.EventHandler(this.buttonPlayPause_Click);
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // MainWindow
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelAlbumName);
            this.Controls.Add(this.labelArtistName);
            this.Controls.Add(this.labelSongTitle);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainWindow";
            this.TransparencyKey = System.Drawing.Color.DarkRed;
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VolumeSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playFromFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelSongLength;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.TrackBar VolumeSlider;
        public System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Label labelSongTitle;
        public System.Windows.Forms.Label labelArtistName;
        public System.Windows.Forms.Label labelAlbumName;
        public System.Windows.Forms.Button buttonPlayPause;
        public System.Windows.Forms.Button buttonImportFile;
        public System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Timer SongDuration;
        private System.Windows.Forms.ToolStripMenuItem preferencesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem languageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem englishToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem japaneseToolStripMenuItem;
        private System.Windows.Forms.ImageList VolumeIcons;
        public System.Windows.Forms.Label labelVolumeStatus;
    }
}

