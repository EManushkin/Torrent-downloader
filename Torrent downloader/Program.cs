using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Torrent_downloader
{
    static class Program
    {
        static public TorrentDownloader formTorrentDownloader;
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            formTorrentDownloader = new TorrentDownloader();
            Application.Run(formTorrentDownloader);
        }
    }
}
