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
            SetPlaceHolder(mtbCardNumber, "  Card Number");
            SetPlaceHolder(mtbCVV2, " CVV2");
            if (!cbMonth.Items.Contains("  Month"))
            {
                cbMonth.Items.Add("  Month");
            }
            cbMonth.Text = "  Month";
            if (!cbYear.Items.Contains("  Year"))
            {
                cbYear.Items.Add("  Year");
            }
            cbYear.Text = "  Year";
        }


        public void SetPlaceHolder(MaskedTextBox control, string PlaceHolderText)
        {
            control.Text = PlaceHolderText;
            control.GotFocus += delegate (object sender, EventArgs args) {
                if (control.Text == PlaceHolderText)
                {
                    control.Text = "";
                    control.ForeColor = System.Drawing.SystemColors.ControlText;
                    if (control.Name == "mtbCardNumber")
                    {
                        control.Mask = "0000-0000-0000-0000";
                    }
                    if (control.Name == "mtbCVV2")
                    {
                        control.Mask = "000";
                    }
                }
            };
            control.LostFocus += delegate (object sender, EventArgs args) {
                if (control.Mask != null && (control.Text == "    -    -    -" || control.Text == String.Empty))
                {
                    control.Mask = "";
                    control.Text = PlaceHolderText;
                    control.ForeColor = System.Drawing.SystemColors.ControlDark;
                }
            };
        }



        private void btnContinue_Click(object sender, EventArgs e)
        {
            if (mtbCardNumber.Text != String.Empty && mtbCardNumber.Text != "  Card Number" &&
                cbMonth.Text != "  Month" && cbYear.Text != "  Year" &&
                mtbCVV2.Text != String.Empty && mtbCVV2.Text != " CVV2") 
            {
                this.Close();
                Program.formTorrentDownloader.Enabled = true;
                Program.formTorrentDownloader.panelSearch.Enabled = true;
                Program.formTorrentDownloader.Activate();
                //Program.formTorrentDownloader.panel7.Visible = false;
                Program.formTorrentDownloader.btnSearch.PerformClick();
            }
        }

        private void cbMonth_DrawItem(object sender, DrawItemEventArgs e)
        {
            int index = e.Index >= 0 ? e.Index : 0;
            var brush = Brushes.Black;
            e.DrawBackground();
            e.Graphics.DrawString(cbMonth.Items[index].ToString(), e.Font, brush, e.Bounds, StringFormat.GenericDefault);
            e.DrawFocusRectangle();
        }

        private void cbMonth_DropDown(object sender, EventArgs e)
        {
            if (cbMonth.Items.Contains("  Month"))
                cbMonth.Items.Remove("  Month");
        }

        private void cbYear_DropDown(object sender, EventArgs e)
        {
            if (cbYear.Items.Contains("  Year"))
                cbYear.Items.Remove("  Year");
        }

        private void cbYear_DrawItem(object sender, DrawItemEventArgs e)
        {
            int index = e.Index >= 0 ? e.Index : 0;
            var brush = Brushes.Black;
            e.DrawBackground();
            e.Graphics.DrawString(cbYear.Items[index].ToString(), e.Font, brush, e.Bounds, StringFormat.GenericDefault);
            e.DrawFocusRectangle();
        }

        private void tbCCV2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void tbCardNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void mtbCardNumber_Enter(object sender, EventArgs e)
        {
            this.BeginInvoke((MethodInvoker)delegate ()
            {
                mtbCardNumber.Select(0, 0);
            });
        }

        private void mtbCCV2_Enter(object sender, EventArgs e)
        {
            this.BeginInvoke((MethodInvoker)delegate ()
            {
                mtbCVV2.Select(0, 0);
            });
        }

    }
}
