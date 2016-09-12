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
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
            SetPlaceHolder(tbEmail, "   Email");
            SetPlaceHolder(tbPassword, "   Password (+6 Characters)");

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

        private void btnContinue_Click(object sender, EventArgs e)
        {
            this.Close();
            var formValidateAccount = new ValidateAccount();
            formValidateAccount.Show();
        }
    }
}
