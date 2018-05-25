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
    public partial class frmField : Form
    {
        private frmOptions _options = new frmOptions();
        private frmScoreList _scoreList;
        private frmEditScore _editScore;
        private Random _rnd = new Random();
        private int _playTime = 20; //no idea why you would put 39999 here (doesn't make sense in any time unit)
        private int _timePlayed;
        private string _highScoreFilePath;
        private int _numberBoxesHorizontal;
        private int _numberBoxesVertical;
        private int _boxWidth;
        private int _boxHeight;
        private Color _boxColor;
        private List<Button> _boxList = new List<Button>();
        private int _indexLastOpened = 0;
        private Dictionary<Color, int> _dctColorAndValue = new Dictionary<Color, int>();
        private int[] _marginBoxInPanel = new int[] { 10, 10 };

        private int _counter = 0;
        private char[] _charsToRemove = { ' ', 'P', '.' };
        private int _dummyForRnd;


        public frmField()
        {
            InitializeComponent();

            _highScoreFilePath = Path.Combine(Environment.CurrentDirectory, "highscore.txt");
            if (!File.Exists(_highScoreFilePath)) {
                File.AppendAllText(_highScoreFilePath, "");
            }

            _scoreList = new frmScoreList(_highScoreFilePath);
            _editScore = new frmEditScore(_highScoreFilePath);

            SetOptions();
            BuildButtonField();

            _options.VisibleChanged += new System.EventHandler(BtnHideOptions_Click); 
        }
        public void SetOptions() {
            //set backgroundcolor
            pnlField.BackColor = _options.GetColor("btnColorField");

            //set numbers of boxes in both directions
            _numberBoxesHorizontal = _options.GetHorizontal();
            _numberBoxesVertical = _options.GetVertical();

            //set boxwidth and boxheight
            _boxWidth = (pnlField.Width - _marginBoxInPanel[1] * 2) / _numberBoxesHorizontal;
            _boxHeight = (pnlField.Height - _marginBoxInPanel[0] * 2) / _numberBoxesVertical;

            //set boxcolor
            _boxColor = _options.GetColor("btnColorBox");

            //Clear then fill dictionary
            _dctColorAndValue.Clear();
            for (int i = 1; i <= 3; i++)
            {
                _dctColorAndValue.Add(_options.GetColor("btnColorBoxType" + i), _options.GetValue("nudBoxType" + i));
            }
        }

        public void StopGame() {
            tmrGame.Stop();
            ResetField();

            if (Convert.ToInt32(lblPoints.Text.TrimEnd(_charsToRemove)) == 284 && _numberBoxesHorizontal == 20 && _numberBoxesVertical == 10)
            {
                Eastereggs.Celia(this);
            }
            else if (Convert.ToInt32(lblPoints.Text.TrimEnd(_charsToRemove)) > 9000)
            {
                Eastereggs.Over9000();
            }

            if (Convert.ToInt32(lblPoints.Text.TrimEnd(_charsToRemove)) < 0)
            {
                MessageBox.Show("GAME OVER!", "GAME OVER!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else
            {
                _editScore.SetScore(lblPoints.Text.TrimEnd(_charsToRemove));
                _editScore.ShowDialog();
            }

            btnStart.Text = "Spiel starten";

            btnOptions.Enabled = true;
            btnScoreList.Enabled = true;
        }

        private void BtnBox_Click(object sender, EventArgs e) {
            if (tmrGame.Enabled)
            {

                if (_dctColorAndValue.ContainsKey((sender as Button).BackColor))
                {
                    lblPoints.Text = Convert.ToString(Convert.ToInt32(lblPoints.Text.TrimEnd(_charsToRemove)) + _dctColorAndValue[(sender as Button).BackColor]) + " P.";
                }
                if (Convert.ToInt32(lblPoints.Text.TrimEnd(_charsToRemove)) < 0)
                {
                    StopGame();
                }
            }
        }

        private Point CalcLocation(int i, int j)
        {
            return new Point((j-1) * _boxWidth + _marginBoxInPanel[0], i * _boxHeight + _marginBoxInPanel[1]);
        }
        private string CreateName(int i, int j, int maxJ)
        {
            int number;
            if (i == 0){
                number = j;
            }
            else {
                number = i * maxJ +j;
            }

            return "btn_" + Convert.ToString(number);
        }
        public void BuildButtonField() {
            pnlField.Controls.Clear();
            _boxList.Clear();

            for (int i = 0; i < _numberBoxesVertical; i++)
            {
                for (int j = 1; j <= _numberBoxesHorizontal; j++)
                {

                    Button btn = new Button();
                    btn.Name = CreateName(i, j, _numberBoxesHorizontal);
                    btn.Height = _boxHeight;
                    btn.Width = _boxWidth;
                    btn.Location = CalcLocation(i, j);
                    btn.Text = "";
                    btn.BackColor = _boxColor;
                    btn.Click += new System.EventHandler(BtnBox_Click);

                    pnlField.Controls.Add(btn);
                    _boxList.Add(btn);
                }
            }
        }

        public void DrawOnField(int[] indexlist) {
            ResetField();
            foreach (int index in indexlist)
            {
                _boxList[index].BackColor = _dctColorAndValue.ElementAt(_rnd.Next(0, _dctColorAndValue.Count)).Key;
                //_boxList[index].BackColor = Color.Black;
            }
        }

        public void ResetField() {
            foreach (Button btn in _boxList)
            {
                if (btn.BackColor != _boxColor) { btn.BackColor = _boxColor; };
            }
            foreach (Button btn in pnlField.Controls.OfType<Button>().ToArray())
            {
                if (btn.BackColor != _boxColor) { btn.BackColor = _boxColor; };
            }
        }

        private void BtnHideOptions_Click(object sender, EventArgs e)
        {
            if (!(sender as frmOptions).Visible) {
                SetOptions();
                BuildButtonField();
            }
        }

        private void BtnOptions_Click(object sender, EventArgs e)
        {
            _options.ShowDialog();
        }

        private void BtnScoreList_Click(object sender, EventArgs e)
        {
            _scoreList.RefreshScore();
            _scoreList.Show();
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            btnOptions.Enabled = false;
            btnScoreList.Enabled = false;

            _timePlayed = 0;
            _indexLastOpened = 0;
            lblPoints.Text = "0 P.";
            lblTime.Text = _playTime + " Sek.";
            _editScore.ReSetNameAndScore();

            ResetField();

            btnStart.Text = "Spiel neustarten";

            tmrGame.Start();
        }

        private void tmrGame_Tick(object sender, EventArgs e)
        {
            if (_counter < 1000F/tmrGame.Interval){
                _counter++;
            }
            else {
                _timePlayed++;
                _counter = 1;
                lblTime.Text = (_playTime - _timePlayed) + " Sek.";

                if (_playTime - _timePlayed == 0) {
                    StopGame();
                }

            }

            _boxList[_indexLastOpened].BackColor = _boxColor;

            _dummyForRnd = _rnd.Next(0, _boxList.Count);
            _boxList[_dummyForRnd].BackColor = _dctColorAndValue.ElementAt(_rnd.Next(0, _dctColorAndValue.Count)).Key;
            _indexLastOpened = _boxList.IndexOf(_boxList[_dummyForRnd]);
        }
    }
}
