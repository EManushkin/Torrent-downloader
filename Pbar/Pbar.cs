using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pbar
{
    public partial class Pbar : UserControl
    {
        public Pbar()
        {
            InitializeComponent();
        }

        protected float percent = 0.0f;
        public float Value
        {
            get
            {
                return percent;
            }
            set
            {
                if (value < 0) value = 0;
                else if (value > 100) value = 100;
                percent = value;
                labelPercent.Text = value.ToString() + "%";
                this.Invalidate();
            }
        }
    }
}
