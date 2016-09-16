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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            webBrowser1.ScriptErrorsSuppressed = true;
            webBrowser1.Navigate("http://tsearch.me/global/");

            webBrowser1Pause();


            HtmlElementCollection elmInput, elmA;
            elmInput = webBrowser1.Document.GetElementsByTagName("input");
            foreach (HtmlElement elmBtn in elmInput)
            {
                if (elmBtn.Name == "search")
                {
                    elmBtn.InnerText = tbSearch.Text;
                    break;
                }
            }

            foreach (HtmlElement elmBtn in elmInput)
            {
                if (elmBtn.GetAttribute("value") == "Поиск")
                {
                    elmBtn.InvokeMember("click");
                    break;
                }
            }

            webBrowser1Pause();


            //string html = webBrowser1.Document.Body.InnerHtml;

            object[] codeString = { "search", "1", new object[] { "language:", "ru"} };
            webBrowser1.Document.InvokeScript("google.load", codeString);
            string html = webBrowser1.DocumentText;
            File.WriteAllText(@"D:\FreeLance\Torrent downloader\Project\Torrent downloader\bin\Debug\test.html", html);



            //webBrowser1.Navigate("http://tsearch.me/global/", "_self", data, "Content-Type: application/x-www-form-urlencoded");
        }

        private void webBrowser1Pause()
        {
            while (webBrowser1.IsBusy || webBrowser1.ReadyState != WebBrowserReadyState.Complete)
            {
                Application.DoEvents();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HtmlElementCollection elmInput, elmA;
            string html = String.Empty;


            elmA = webBrowser1.Document.GetElementsByTagName("a");
            foreach (HtmlElement elmBtn in elmA)
            {
                if (elmBtn.GetAttribute("class") == "gs-title")
                {
                    html += elmBtn.OuterText;
                }
            }

            File.WriteAllText(@"D:\FreeLance\Torrent downloader\Project\Torrent downloader\bin\Debug\test.html", html);
        }

    }
}
