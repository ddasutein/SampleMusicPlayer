using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage;
using Windows.Storage.Pickers;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.Media.Core;
using Windows.Media.Playback;
using System.Diagnostics;
using Windows.UI.Popups;
using MusicPlayerUWP.Core.audioplayback;


// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace MusicPlayerUWP
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        MediaPlayer player;
        MediaElement mediaElement;
        MediaSource mediaSource;
        MediaPlaybackItem mediaPlaybackItem;
        MediaItemDisplayProperties props;

        public MainPage()
        {
            this.InitializeComponent();
            audiofileplayback.play();
       

        }

        

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            audiofileplayback.openFileDialogAsync();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            audiofileplayback.stopPlayback();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            audiofileplayback.pausePlayback();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            audiofileplayback.resumePlayback();
        }

    }
}
