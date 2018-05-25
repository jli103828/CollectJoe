using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CollectJoe
{
    public partial class frmAdvancedOptions : Form
    {
        public frmAdvancedOptions()
        {
            InitializeComponent();
        }

        private void frmAdvancedOptions_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }
    }
}
