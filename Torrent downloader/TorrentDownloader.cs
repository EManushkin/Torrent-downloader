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
using System.IO;
using Microsoft.Win32;
using System.Net;
using System.Text.RegularExpressions;

namespace Torrent_downloader
{

    public partial class TorrentDownloader : Form
    {
        public bool maximized = false;
        private struct Result
        {
            public string name;
            public string link;
        }
        private Result one_result; 
        private List<Result> result = new List<Result>();
        private int percent = 0;


        public TorrentDownloader()
        {

            InitializeComponent();

            menuStrip1.Renderer = new MyRenderer();
            this.Size = new Size(987, 650);
            this.panelSearchResults.Size = new Size(988, 483);

            //Config in this path
            //C:\Users\[User]\AppData\Local\[ProgramName]\[ExeName]_Url_[some_hash]\[Version]\user.config
            if (Properties.Settings.Default.FirstRun == true)
            {
                this.Show();

                this.Enabled = false;

                string name_of_installer;

                RegistryKey readKey = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Torrent Downloader");
                if (readKey != null)
                {
                    name_of_installer = (string)readKey.GetValue("OriginalDatabase");
                    name_of_installer = name_of_installer.Substring(name_of_installer.LastIndexOf("\\") + 1, name_of_installer.IndexOf(".msi") - name_of_installer.LastIndexOf("\\") - 1);

                    tbSearch.ForeColor = System.Drawing.SystemColors.ControlText;
                    tbSearch.Text = name_of_installer;
                    //this.Size = new Size(987, 650);
                    //this.Location = new Point((Screen.PrimaryScreen.Bounds.Width - this.Width) / 2, (Screen.PrimaryScreen.Bounds.Height - this.Height) / 2);

                    this.richTextBoxFirstRun.Text = name_of_installer;

                }
                else
                {
                    name_of_installer = "  Search file ...";
                    this.SetPlaceHolder(tbSearch, name_of_installer);
                }

                //Thread.Sleep(1000);
                Properties.Settings.Default.FirstRun = false;
                Properties.Settings.Default.Save();

                pbar1.Location = new System.Drawing.Point(434, 200);
                pbar1.Visible = true;
                timerFirstRun.Enabled = true;
            }
            else
            {
                this.SetPlaceHolder(tbSearch, "  Search file ...");
                this.Show();
            }

        }

        private class MyRenderer : ToolStripProfessionalRenderer
        {
            public MyRenderer() : base(new MyColors()) { }
        }

        private class MyColors : ProfessionalColorTable
        {
            public override Color MenuItemSelected
            {
                get { return Color.MediumSeaGreen; }
            }
            public override Color MenuItemSelectedGradientBegin
            {
                get { return Color.MediumSeaGreen; }
            }
            public override Color MenuItemSelectedGradientEnd
            {
                get { return Color.MediumSeaGreen; }
            }
            public override Color MenuItemBorder
            {
                get { return Color.MediumSeaGreen; }
            }
            //public override Color ToolStripBorder
            //{
            //    get { return Color.MediumSeaGreen; }
            //}
            //public override Color ToolStripForeColor
            //{
            //    get { return Color.MediumSeaGreen; }
            //}
            //public override Color ToolStripDropDownBackground
            //{
            //    get { return Color.SeaGreen; }
            //}
            //public override Color ToolStripGradientBegin
            //{
            //    get { return Color.MediumSeaGreen; }
            //}
            //public override Color ToolStripGradientMiddle
            //{
            //    get { return Color.MediumSeaGreen; }
            //}
            //public override Color ToolStripGradientEnd
            //{
            //    get { return Color.MediumSeaGreen; }
            //}
        }


        private void ShowResults()
        {
            try
            {
                panelNothing.Visible = false;
                

                richTextBox1.Text = result[0].name;
                richTextBox2.Text = result[1].name;
                richTextBox3.Text = result[2].name;
                richTextBox4.Text = result[3].name;
                richTextBox5.Text = result[4].name;
                richTextBox6.Text = result[5].name;
                richTextBox7.Text = result[6].name;
                richTextBox8.Text = result[7].name;
                richTextBox9.Text = result[8].name;

                panelSearchResults.Visible = true;

                //panelResult1.Visible = true;
                //panelResult2.Visible = true;
                //panelResult3.Visible = true;
                //panelResult4.Visible = true;
                //panelResult5.Visible = true;
                //panelResult6.Visible = true;
                //panelResult7.Visible = true;
                //panelResult8.Visible = true;
                //panelResult9.Visible = true;
                //panelSearchResults.Visible = true;
                //this.Size = new Size(987, 650);
                //this.Location = new Point((Screen.PrimaryScreen.Bounds.Width - this.Width) / 2, (Screen.PrimaryScreen.Bounds.Height - this.Height) / 2);
            }
            catch (Exception)
            {
                panelSearchResults.Visible = false;
                panelNothing.Visible = true;
                //richTextBoxNothing.Visible = true;
                //this.Size = new Size(987, 650);
                //this.Location = new Point((Screen.PrimaryScreen.Bounds.Width - this.Width) / 2, (Screen.PrimaryScreen.Bounds.Height - this.Height) / 2);
            }



        }

        private void OpenLink(string link)
        {
            System.Diagnostics.Process.Start(link);
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

        private void Torrent_Search()
        {
            string url = "http://www.torrentdownloads.me/search/?search=" + tbSearch.Text.Replace(" ", "+");

            WebClient client = new WebClient();
            client.Encoding = System.Text.Encoding.UTF8;
            client.Headers.Add("user-agent", "Mozilla/5.0 (Windows NT 10.0; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/49.0.2623.110 Safari/537.36");
            string page = client.DownloadString(url);

            MatchCollection tags_results = Regex.Matches(page, @"(<a href=""/torrent.*?>)", RegexOptions.IgnoreCase | RegexOptions.Singleline | RegexOptions.Multiline);

            result.Clear();

            foreach (var tag in tags_results)
            {
                try
                {
                    one_result.name = tag.ToString().Substring(tag.ToString().IndexOf(": ") + 2, tag.ToString().IndexOf("\">") - tag.ToString().IndexOf(": ") - 2);
                    one_result.link = "http://www.torrentdownloads.me" + tag.ToString().Substring(tag.ToString().IndexOf("/"), tag.ToString().IndexOf("\" title") - tag.ToString().IndexOf("/"));

                    if (!result.Contains(one_result))
                    {
                        result.Add(one_result);
                    }
                }
                catch
                {
                }

            }

            ShowResults();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            panelSearchResults.Visible = false;
            pbar1.Location = new System.Drawing.Point(434, 200);
            pbar1.Visible = true;
            timerSearch.Enabled = true;
        }

        private void btnDownload1_Click(object sender, EventArgs e)
        {
            OpenLink(result[0].link);
        }

        private void btnDownload2_Click(object sender, EventArgs e)
        {
            OpenLink(result[1].link);
        }

        private void btnDownload3_Click(object sender, EventArgs e)
        {
            OpenLink(result[2].link);
        }

        private void btnDownload4_Click(object sender, EventArgs e)
        {
            OpenLink(result[3].link);
        }

        private void btnDownload5_Click(object sender, EventArgs e)
        {
            OpenLink(result[4].link);
        }

        private void btnDownload6_Click(object sender, EventArgs e)
        {
            OpenLink(result[5].link);
        }

        private void btnDownload7_Click(object sender, EventArgs e)
        {
            OpenLink(result[6].link);
        }

        private void btnDownload8_Click(object sender, EventArgs e)
        {
            OpenLink(result[7].link);
        }

        private void btnDownload9_Click(object sender, EventArgs e)
        {
            OpenLink(result[8].link);
        }

        private void btnDownload10_Click(object sender, EventArgs e)
        {
            OpenLink(result[9].link);
        }

        private Point MouseHook;
        private void menuStrip1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) MouseHook = e.Location;
            Location = new Point((Size)Location - (Size)MouseHook + (Size)e.Location);
        }

        private void btnFirstRun_Click(object sender, EventArgs e)
        {

        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pbar1.Value == 100)
            {
                timerSearch.Stop();
                pbar1.Visible = false;
                pbar1.Value = 0;
                Torrent_Search();
            }
            else
            {
                pbar1.Value ++;
            }
        }

        private void timerFirstRun_Tick(object sender, EventArgs e)
        {
            if (pbar1.Value == 100)
            {
                timerFirstRun.Stop();
                pbar1.Visible = false;
                pbar1.Value = 0;

                panelFirstRun.Visible = true;
                var formSignUp = new SignUp();
                formSignUp.Show();
                formSignUp.Activate();
            }
            else
            {
                pbar1.Value++;
            }
        }

        private void howToDownloadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //var formSignUp = new SignUp();
            //formSignUp.Show();
            //formSignUp.Activate();
        }

        private void fileToolStripMenuItem_DropDownOpened(object sender, EventArgs e)
        {
            fileToolStripMenuItem.ForeColor = Color.SeaGreen;
        }

        private void fileToolStripMenuItem_DropDownClosed(object sender, EventArgs e)
        {
            fileToolStripMenuItem.ForeColor = Color.White;
        }
    }
}
