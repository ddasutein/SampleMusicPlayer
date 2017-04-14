using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using NAudio;
using NAudio.Wave;
using TagLib;

namespace SampleMusicPlayer
{
    public partial class MainWindow : Form
    {

        private TagLibGetID3Tag tabLibGetID3Tag;

        public MainWindow()
        {
            InitializeComponent();
        }



        AudioFileReader audioFileReader;
        WaveOutEvent output = new WaveOutEvent();
        TimeSpan duration;

        private void MainWindow_Load(object sender, EventArgs e)
        {

        }


        private void buttonImportFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog audioFile = new OpenFileDialog())
            {
                audioFile.Title = "Direct Play - Please select an audio file";
                audioFile.Filter = "All Audio Types|*.mp3;*.m4a;*.flac;*.ogg|MP3 (MPEG-3 Audio)|*.mp3|M4A (MPEG-4 Audio)|*.m4a|FLAC (Free Lossless Audio Codec)|*.flac";
                string fileLocation = audioFile.ToString();

                if (audioFile.ShowDialog() == DialogResult.OK)
                {
                    if (output.PlaybackState == PlaybackState.Stopped)
                    {
                        audioFileReader = new AudioFileReader(audioFile.FileName);
                        output.Init(audioFileReader);
                        output.Play();
                        SongDuration.Start();
                        duration = audioFileReader.TotalTime;

                        /// TAGLIB#
                        fileLocation = audioFile.FileName;
                        TagLib.File file = TagLib.File.Create(fileLocation);

                        foreach (string artist in file.Tag.Artists)
                        {
                            labelArtistName.Text = artist.ToString();                          
                        }

                        labelSongTitle.Text = file.Tag.Title;
                        this.Text = "SampleMusicPlayer - " + file.Tag.Title;
                        labelAlbumName.Text = file.Tag.Album;

                        if (file.Tag.Pictures.Length >= 1)
                        {
                            var bin = (byte[])(file.Tag.Pictures[0].Data.Data);
                            pictureBox1.Image = Image.FromStream(new MemoryStream(bin)).GetThumbnailImage(1000, 1000, null, IntPtr.Zero);

                        }

                    }
                    else if (output.PlaybackState == PlaybackState.Playing)
                    {
                        output.Dispose();
                        audioFileReader = new AudioFileReader(audioFile.FileName);
                        output.Init(audioFileReader);
                        output.Play();

                        fileLocation = audioFile.FileName;
                        TagLib.File file = TagLib.File.Create(fileLocation);

                        foreach (string artist in file.Tag.Artists)
                        {
                            labelArtistName.Text = artist.ToString();
                        }

                        labelSongTitle.Text = file.Tag.Title;
                        this.Text = "SampleMusicPlayer - " + file.Tag.Title;
                        labelAlbumName.Text = file.Tag.Album;

                        if (file.Tag.Pictures.Length >= 1)
                        {
                            var bin = (byte[])(file.Tag.Pictures[0].Data.Data);
                            pictureBox1.Image = Image.FromStream(new MemoryStream(bin)).GetThumbnailImage(1000, 1000, null, IntPtr.Zero);

                        }
                        else if (file.Tag.Pictures.Length >= 0)
                        {
                            pictureBox1.Image = Properties.Resources.AlbumArtDefault;
                        }
                    }
                }

            }

        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            output.Dispose();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutProgram about = new AboutProgram();
            about.ShowDialog();
        }

        private void SongDuration_Tick(object sender, EventArgs e)
        {
            if (output.PlaybackState == PlaybackState.Playing)
            {
                TimeSpan currentTime = audioFileReader.CurrentTime;
                trackBar2.Value = (int)currentTime.TotalSeconds;
                trackBar2.Maximum = (int)audioFileReader.TotalTime.TotalSeconds;
                labelSongLength.Text = String.Format("{0:00}:{1:00} / " + duration.ToString("mm\\:ss"), (int)currentTime.TotalMinutes,
                currentTime.Seconds);
            }

            else
            {

            }

            }
        }
    }

