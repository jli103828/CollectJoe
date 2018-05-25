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
    public partial class frmScoreList : Form
    {
        private string _highScoreFilePath;
        public frmScoreList(string scorePath)
        {
            InitializeComponent();
            _highScoreFilePath = scorePath;
        }

        public void RefreshScore() {
            if (_highScoreFilePath == "" || _highScoreFilePath == null || !File.Exists(_highScoreFilePath)){
                txtScore.Text = "Rangliste nicht verfügbar.";
            }
            else{
                
                txtScore.Text = File.ReadAllText(_highScoreFilePath);
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void FrmScoreList_Closing(object sender, FormClosingEventArgs e)
        {
            Hide();
            e.Cancel = true;
        }
    }
}
