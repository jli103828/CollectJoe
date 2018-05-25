using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CollectJoe
{
    public partial class frmEditScore : Form
    {
        private string _highScoreFilePath;
        public frmEditScore(string scorePath)
        {
            InitializeComponent();
            _highScoreFilePath = scorePath;
        }

        public void SetScore(string score) {
            lblPoints.Text = score;
        }

        public void ReSetNameAndScore() {
            txtName.Text = "";
            lblPoints.Text = "";
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (txtName.Text == ""){
                MessageBox.Show("Bitte geben Sie Ihren Namen ein.", "Keinen Namen eingegeben!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtName.Focus();
            }
            else{
                File.WriteAllText(_highScoreFilePath, txtName.Text + ";" + lblPoints.Text + Environment.NewLine + File.ReadAllText(_highScoreFilePath));
                txtName.Focus();
                Hide();
            }
            
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            txtName.Focus();
            Hide();
        }

        private void FrmEditScore_FormClosing(object sender, FormClosingEventArgs e)
        {
            txtName.Focus();
            Hide();
            e.Cancel = true;
        }
    }
}
