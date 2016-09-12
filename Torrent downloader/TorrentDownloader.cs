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
        public bool maximized = false;

        public TorrentDownloader()
        {
            InitializeComponent();

            this.SetPlaceHolder(tbSearch, "  Search for Apps");
            this.Show();
            this.Enabled = false;

            Thread.Sleep(1000);

            var formSignUp = new SignUp();
            formSignUp.Show();
            formSignUp.Activate();



        }

        public void SetPlaceHolder(Control control, string PlaceHolderText)
        {
            control.Text = PlaceHolderText;
            control.GotFocus += delegate (object sender, EventArgs args) {
                if (control.Text == PlaceHolderText)
                {
                    control.Text = "";
                    control.ForeColor = System.Drawing.SystemColors.ControlText;
                }
            };
            control.LostFocus += delegate (object sender, EventArgs args) {
                if (control.Text.Length == 0)
                {
                    control.Text = PlaceHolderText;
                    control.ForeColor = System.Drawing.SystemColors.ControlDark;
                }
            };
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void btnTurn_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnExpand_Click(object sender, EventArgs e)
        {
            if (!maximized)
            {
                WindowState = FormWindowState.Maximized;
                maximized = !maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
                maximized = !maximized;
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }
    }
}
