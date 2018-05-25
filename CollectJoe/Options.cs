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
    public partial class frmOptions : Form
    {
        public frmOptions()
        {
            InitializeComponent();
        }

        public int GetHorizontal() {
            try
            {
                Convert.ToInt16(nudHorizontal.Value);
            }
            catch
            {
                return Convert.ToInt16(nudHorizontal.Maximum);
            }
            if (nudHorizontal.Value > nudHorizontal.Maximum)
            {
                return Convert.ToInt16(nudHorizontal.Maximum);
            }
            if (nudHorizontal.Value < nudHorizontal.Minimum)
            {
                return Convert.ToInt16(nudHorizontal.Minimum);
            }


            return Convert.ToInt16(nudHorizontal.Value);
        }

        public int GetVertical() {
            try
            {
                Convert.ToInt16(nudVertical.Value);
            }
            catch
            {
                return Convert.ToInt16(nudVertical.Maximum);
            }
            if (nudVertical.Value > nudVertical.Maximum)
            {
                return Convert.ToInt16(nudVertical.Maximum);
            }
            if (nudVertical.Value < nudVertical.Minimum)
            {
                return Convert.ToInt16(nudVertical.Minimum);
            }


            return Convert.ToInt16(nudVertical.Value);
        }

        public int GetValue(string btnName) {
            Control[] controls = Controls.Find(btnName, true);
            if (controls.Length == 0) {
                return 1;
            }

            NumericUpDown nud = (NumericUpDown)controls[0];

            try
            {
                Convert.ToInt16(nud.Value);
            }
            catch
            {
                return 1;
            }

            return Convert.ToInt16(nud.Value);
        }

        public Color GetColor(string btnName) {
            Control[] controls = Controls.Find(btnName, true);

            Button btn = (Button)controls[0];

            return btn.BackColor;
        }

        private void BtnColor_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                (sender as Button).BackColor = colorDialog.Color;
            }
        }

        private void BtnUse_Click(object sender, EventArgs e)
        {
            if (AllUniqueColors())
            {
                Hide();
            }
            else {
                MessageBox.Show("Alle Farben müssen unterschiedlich sein!", "Keine gleichen Farben!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool AllUniqueColors() {
            Button[] buttons = gpxColors.Controls.OfType<Button>().ToArray();

            foreach (Button btn1 in buttons)
            {
                foreach (Button btn2 in buttons)
                {
                    if (btn1 != btn2) {
                        if (btn1.BackColor == btn2.BackColor)
                        {
                            return false;
                        }
                    }
                }
            }

            return true;
        }

        private void FrmOptions_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (AllUniqueColors())
            {
                Hide();
            }
            else
            {
                MessageBox.Show("Alle Farben müssen unterschiedlich sein!", "Keine gleichen Farben!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            e.Cancel = true;
        }

    }
}
