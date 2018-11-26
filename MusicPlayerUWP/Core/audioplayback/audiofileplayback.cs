using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Media.Core;
using Windows.Media.Playback;
using Windows.Storage;
using Windows.Storage.Pickers;
using Windows.UI.Popups;

namespace MusicPlayerUWP.Core.audioplayback
{
    public class audiofileplayback
    {

        public static void play()
        {
            player = new MediaPlayer();
        }

        static MediaPlayer player;
        public MediaPlaybackSession PlaybackSession { get; }
        public MediaPlaybackState PlaybackState { get; }

        public static async void openFileDialogAsync()
        {

            FileOpenPicker openPicker = new FileOpenPicker();
            openPicker.FileTypeFilter.Add(".mp3");
            openPicker.FileTypeFilter.Add(".m4a");
            openPicker.FileTypeFilter.Add(".flac");
            StorageFile file = await openPicker.PickSingleFileAsync();

            if (file != null)
            {
                player.Source = MediaSource.CreateFromStorageFile(file);
                player.Play();

            }
            else
            {

            }

        }

        public static void pausePlayback()
        {
            player.Pause();
        }

        public static void stopPlayback()
        {
            player.Dispose();
        }

        public static void resumePlayback()
        {
            player.Play();
        }

        public static float volumeValue;

        public static void changeVolume()
        {

            player.Volume = volumeValue;


        }
    }
}

