﻿using System;
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


        public TorrentDownloader()
        {
            //The registry key is \HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Internet Settings\Zones\ - the keyname is 1400 and the value to disable it is 3, and to enable it is 0.
            RegistryKey enableJS = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Internet Settings\Zones\3", true);
            if ((int)enableJS.GetValue("1400") == 3)
            {
                enableJS.SetValue("1400", 0);
                enableJS.Close();
            }


            InitializeComponent();
            
            //this.Size = new Size(987, 140);

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
                    this.Size = new Size(987, 200);
                    this.Location = new Point((Screen.PrimaryScreen.Bounds.Width - this.Width) / 2,
                          (Screen.PrimaryScreen.Bounds.Height - this.Height) / 2);

                    this.richTextBoxFirstRun.Text = name_of_installer;
                    this.tableFirstRun.Visible = true;

                }
                else
                {
                    name_of_installer = "  Search for Apps";
                    this.SetPlaceHolder(tbSearch, name_of_installer);
                }
                //readKey.Close();


                Thread.Sleep(1000);
                var formSignUp = new SignUp();
                formSignUp.Show();
                formSignUp.Activate();

                Properties.Settings.Default.FirstRun = false;
                Properties.Settings.Default.Save();
            }
            else
            {
                this.SetPlaceHolder(tbSearch, "  Search for Apps");
                this.Show();
            }

        }

        private void ShowResults()
        {
            try
            {
                tableNothingResult.Visible = false;

                richTextBox1.Text = result[0].name;
                richTextBox2.Text = result[1].name;
                richTextBox3.Text = result[2].name;
                richTextBox4.Text = result[3].name;
                richTextBox5.Text = result[4].name;
                richTextBox6.Text = result[5].name;
                richTextBox7.Text = result[6].name;
                richTextBox8.Text = result[7].name;
                richTextBox9.Text = result[8].name;
                richTextBox10.Text = result[9].name;

                tableResult.Visible = true;
                this.Size = new Size(987, 650);
                this.Location = new Point((Screen.PrimaryScreen.Bounds.Width - this.Width) / 2,
                                          (Screen.PrimaryScreen.Bounds.Height - this.Height) / 2);
            }
            catch (Exception)
            {
                tableResult.Visible = false;
                tableNothingResult.Visible = true;
                this.Size = new Size(987, 200);
                this.Location = new Point((Screen.PrimaryScreen.Bounds.Width - this.Width) / 2,
                                          (Screen.PrimaryScreen.Bounds.Height - this.Height) / 2);
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

        private void btnSearch_Click(object sender, EventArgs e)
        {

            //webBrowser1.ScriptErrorsSuppressed = true;
            webBrowser1.Navigate("http://tsearch.me/global/");

            //webBrowser1PagePause();

            //Thread.Sleep(3000);



            //HtmlElementCollection elmInput, elmA;
            //elmInput = webBrowser1.Document.GetElementsByTagName("input");
            //foreach (HtmlElement elmBtn in elmInput)
            //{
            //    if (elmBtn.Name == "search")
            //    {
            //        elmBtn.InnerText = tbSearch.Text;
            //        break;
            //    }
            //}

            //webBrowser1PagePause();

            //foreach (HtmlElement elmBtn in elmInput)
            //{
            //    if (elmBtn.GetAttribute("value") == "Поиск")
            //    {
            //        elmBtn.InvokeMember("click");
            //        break;
            //    }
            //}

            //webBrowser1EventPause(3000);

            //string html = String.Empty;
            //result.Clear();
            //elmA = webBrowser1.Document.GetElementsByTagName("a");
            //foreach (HtmlElement elmBtn in elmA)
            //{
            //    if (elmBtn.GetAttribute("classname") == "gs-title" && elmBtn.InnerText != null)
            //    {
            //        one_result.name = elmBtn.InnerText;
            //        one_result.link = elmBtn.GetAttribute("href");
            //        if (!result.Contains(one_result))
            //        {
            //            result.Add(one_result);
            //        }
            //    }
            //}
            
            //ShowResults();
        }

        private void webBrowser1PagePause()
        {
            WebBrowserReadyState loadStatus = webBrowser1.ReadyState;
            while (webBrowser1.IsBusy || webBrowser1.ReadyState != WebBrowserReadyState.Complete)
            {
                Application.DoEvents();
            }

        }

        private void webBrowser1EventPause(int delay)
        {
            double time = DateTime.Now.TimeOfDay.TotalMilliseconds;
            while ((DateTime.Now.TimeOfDay.TotalMilliseconds - time) < delay)
            {
                Application.DoEvents();
            }
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
    }
}
