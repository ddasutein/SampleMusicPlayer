using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Globalization;

namespace SampleMusicPlayer
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // FOR DEBUGGING PURPOSES ONLY

            // FORCE APPLICATION TO DISPLAY IN JAPANESE ONLY. COMMENT TO DISABLE
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("ja-JP");

            // FORCE APPLICATION TO DISPLAY IN ENGLISH (US) ONLY. COMMENT TO DISABLE
            ///Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US");

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainWindow());
        }
    }
}
