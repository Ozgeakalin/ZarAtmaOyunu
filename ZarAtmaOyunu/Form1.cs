using System;
using System.Collections;
using System.Collections.Generic;
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
        Business _business;

        public Form1()
        {
            InitializeComponent();
           _rnd= _rnd == null ? new Random() : _rnd;
            _business = new Business();
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
            int dice1, dice2;
            dice1 = _rnd.Next(_business.GetResourceImagesLength());
            dice2 = _rnd.Next(_business.GetResourceImagesLength());
            pBDice1.Image = _business.GetResourceImages(dice1);
            pBDice2.Image= _business.GetResourceImages(dice2);

            
            _player1.TotalScore += _business.GetResourceImageValue(dice1)+ _business.GetResourceImageValue(dice2);
            lblFirstPlayerScore.Text = (_player1.TotalScore).ToString();

            btnFirstPlayer.Enabled = false;
            btnSecondPlayer.Enabled = true;
            if (_business.WinnerControl(_player1.TotalScore, _player1, Convert.ToInt32(txtScore.Text)))
            {
                btnRestart_Click(new object(), new EventArgs());

            }
        }
        private void btnSecondPlayer_Click(object sender, EventArgs e)
        {
            int dice1, dice2;
            dice1 = _rnd.Next(_business.GetResourceImagesLength());
            dice2 = _rnd.Next(_business.GetResourceImagesLength());
            pBDice1.Image = _business.GetResourceImages(dice1);
            pBDice2.Image = _business.GetResourceImages(dice2);


            _player2.TotalScore += _business.GetResourceImageValue(dice1) + _business.GetResourceImageValue(dice2);
            lblSecondPlayerScore.Text = (_player2.TotalScore).ToString();

            btnFirstPlayer.Enabled = true;
            btnSecondPlayer.Enabled = false;
            if (_business.WinnerControl(_player2.TotalScore, _player2, Convert.ToInt32(txtScore.Text))) 
            {
                btnRestart_Click(new object(), new EventArgs());
            }

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
                if (_business.IsNumeric(txtScore.Text))
                {
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




    }
}
