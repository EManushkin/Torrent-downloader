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
    public partial class HowToDownload : Form
    {
        public HowToDownload()
        {
            InitializeComponent();
        }

        private void HowToDownload_Deactivate(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
