using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Torrent_downloader
{
    public partial class ValidateAccount : Form
    {
        public ValidateAccount()
        {
            InitializeComponent();
            Program.formTorrentDownloader.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.formTorrentDownloader.Enabled = true;
            this.Close();
        }
    }
}
