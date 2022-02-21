using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace ZarAtmaOyunu
{
    public partial class Form1 : Form
    {
        Random _rnd;
        Player _player1, _player2;
        int _finishScore;

        public Form1()
        {
            InitializeComponent();
            if (_rnd == null)
            {
                _rnd = new Random();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _player1 = new Player { PlayerId = 1, TotalScore = 0 };
            _player2 = new Player { PlayerId = 2, TotalScore = 0 };

            btnFirstPlayer.Enabled = false;
            btnSecondPlayer.Enabled = false;

        }

        private void btnFirstPlayer_Click(object sender, EventArgs e)
        {
            _player1.TotalScore += GetResourceImagesAndValue();
            lblFirstPlayerScore.Text = (_player1.TotalScore).ToString();

            btnFirstPlayer.Enabled = false;
            btnSecondPlayer.Enabled = true;

            WinnerControl(_player1.TotalScore, _player1);

        }
        private void btnSecondPlayer_Click(object sender, EventArgs e)
        {
            _player2.TotalScore += GetResourceImagesAndValue();
            lblSecondPlayerScore.Text = (_player2.TotalScore).ToString();

            btnFirstPlayer.Enabled = true;
            btnSecondPlayer.Enabled = false;
            WinnerControl(_player2.TotalScore, _player2);

        }

        private void txtScore_TextChanged(object sender, EventArgs e)
        {
            if (txtScore.Text == "")
            {
                btnFirstPlayer.Enabled = false;
                btnSecondPlayer.Enabled = false;
            }
            else
            {
                if (IsNumeric(txtScore.Text))
                {
                    _finishScore = Convert.ToInt32(txtScore.Text);
                    btnFirstPlayer.Enabled = true;
                    btnSecondPlayer.Enabled = false;
                }
                else
                {
                    txtScore.Text = "";
                    MessageBox.Show("Sadece sayı girişi yapınız;");
                }

            }


        }


        private bool IsNumeric(string text)
        {
            bool result = true;
            foreach (char item in text)
            {
                if (!Char.IsNumber(item))
                {
                    result = false;
                    break;
                }
            }
            return result;
        }


        private void btnRestart_Click(object sender, EventArgs e)
        {
            Form1_Load(new object(), new EventArgs());
            lblFirstPlayerScore.Text = "0";
            lblSecondPlayerScore.Text = "0";
            txtScore.Text = "";
            if (pBDice1.Image != null && pBDice2.Image != null)
            {
                pBDice1.Image.Dispose();
                pBDice1.Image = null;
                pBDice2.Image.Dispose();
                pBDice2.Image = null;
            }



        }

        public void WinnerControl(int score, Player player)
        {
            if (score >= _finishScore)
            {
                DialogResult dialogResult = MessageBox.Show("Tebrikler " + player.PlayerId.ToString() + ". Oyuncu Kazandı", "Tebrikler", MessageBoxButtons.RetryCancel);
                if (dialogResult == DialogResult.Cancel)
                    Form.ActiveForm.Close();
                else
                    btnRestart_Click(new object(), new EventArgs());

                btnFirstPlayer.Enabled = false;
                btnSecondPlayer.Enabled = false;
            }
        }


        private int GetResourceImagesAndValue()
        {
            PropertyInfo[] props = typeof(Properties.Resources).GetProperties(BindingFlags.NonPublic | BindingFlags.Static);
            var images = props.Where(prop => prop.PropertyType == typeof(Bitmap)).Select(prop => prop.GetValue(null, null) as Bitmap).ToArray();

            if (images == null || images.Length == 0)
                return 0;

            int id = _rnd.Next(images.Length);
            int id2 = _rnd.Next(images.Length);
            pBDice1.Image = images[id];
            pBDice2.Image = images[id2];

            return id + id2 + 2;
        }


    }
}
