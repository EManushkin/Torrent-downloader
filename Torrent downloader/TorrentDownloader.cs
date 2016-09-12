using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace Torrent_downloader
{

    public partial class TorrentDownloader : Form
    {
        public TorrentDownloader()
        {
            InitializeComponent();
            this.Show();
            this.Enabled = false;

            Thread.Sleep(2000);

            var formSignUp = new SignUp();
            formSignUp.Show();
            formSignUp.Activate();

        }

        private void btnContinue_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
