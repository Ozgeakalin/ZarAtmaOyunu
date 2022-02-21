namespace ZarAtmaOyunu
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblScore = new System.Windows.Forms.Label();
            this.txtScore = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pBDice1 = new System.Windows.Forms.PictureBox();
            this.pBDice2 = new System.Windows.Forms.PictureBox();
            this.btnFirstPlayer = new System.Windows.Forms.Button();
            this.btnSecondPlayer = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblFirstPlayerScore = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblSecondPlayerScore = new System.Windows.Forms.Label();
            this.btnRestart = new System.Windows.Forms.Button();
            this.lblWinner = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pBDice1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBDice2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Location = new System.Drawing.Point(95, 15);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(97, 13);
            this.lblScore.TabIndex = 0;
            this.lblScore.Text = "Oyun Kaçta Bitsin?";
            // 
            // txtScore
            // 
            this.txtScore.Location = new System.Drawing.Point(213, 12);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(71, 20);
            this.txtScore.TabIndex = 1;
            this.txtScore.TextChanged += new System.EventHandler(this.txtScore_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(160, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "ATILAN ZARLAR";
            // 
            // pBDice1
            // 
            this.pBDice1.Location = new System.Drawing.Point(67, 99);
            this.pBDice1.Name = "pBDice1";
            this.pBDice1.Size = new System.Drawing.Size(111, 100);
            this.pBDice1.TabIndex = 3;
            this.pBDice1.TabStop = false;
            // 
            // pBDice2
            // 
            this.pBDice2.Location = new System.Drawing.Point(242, 99);
            this.pBDice2.Name = "pBDice2";
            this.pBDice2.Size = new System.Drawing.Size(108, 100);
            this.pBDice2.TabIndex = 4;
            this.pBDice2.TabStop = false;
            // 
            // btnFirstPlayer
            // 
            this.btnFirstPlayer.Location = new System.Drawing.Point(46, 230);
            this.btnFirstPlayer.Name = "btnFirstPlayer";
            this.btnFirstPlayer.Size = new System.Drawing.Size(132, 38);
            this.btnFirstPlayer.TabIndex = 5;
            this.btnFirstPlayer.Text = "1. Oyuncu Zar Atsın";
            this.btnFirstPlayer.UseVisualStyleBackColor = true;
            this.btnFirstPlayer.Click += new System.EventHandler(this.btnFirstPlayer_Click);
            // 
            // btnSecondPlayer
            // 
            this.btnSecondPlayer.Location = new System.Drawing.Point(242, 230);
            this.btnSecondPlayer.Name = "btnSecondPlayer";
            this.btnSecondPlayer.Size = new System.Drawing.Size(129, 38);
            this.btnSecondPlayer.TabIndex = 6;
            this.btnSecondPlayer.Text = "2. Oyuncu Zar Atsın";
            this.btnSecondPlayer.UseVisualStyleBackColor = true;
            this.btnSecondPlayer.Click += new System.EventHandler(this.btnSecondPlayer_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 297);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Toplam Puan :";
            // 
            // lblFirstPlayerScore
            // 
            this.lblFirstPlayerScore.AutoSize = true;
            this.lblFirstPlayerScore.Location = new System.Drawing.Point(134, 297);
            this.lblFirstPlayerScore.Name = "lblFirstPlayerScore";
            this.lblFirstPlayerScore.Size = new System.Drawing.Size(13, 13);
            this.lblFirstPlayerScore.TabIndex = 8;
            this.lblFirstPlayerScore.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(242, 297);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Toplam Puan :";
            // 
            // lblSecondPlayerScore
            // 
            this.lblSecondPlayerScore.AutoSize = true;
            this.lblSecondPlayerScore.Location = new System.Drawing.Point(337, 297);
            this.lblSecondPlayerScore.Name = "lblSecondPlayerScore";
            this.lblSecondPlayerScore.Size = new System.Drawing.Size(13, 13);
            this.lblSecondPlayerScore.TabIndex = 10;
            this.lblSecondPlayerScore.Text = "0";
            // 
            // btnRestart
            // 
            this.btnRestart.Location = new System.Drawing.Point(137, 391);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(147, 41);
            this.btnRestart.TabIndex = 11;
            this.btnRestart.Text = "Yeniden Başla";
            this.btnRestart.UseVisualStyleBackColor = true;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // lblWinner
            // 
            this.lblWinner.AutoSize = true;
            this.lblWinner.Location = new System.Drawing.Point(160, 346);
            this.lblWinner.Name = "lblWinner";
            this.lblWinner.Size = new System.Drawing.Size(0, 13);
            this.lblWinner.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 450);
            this.Controls.Add(this.lblWinner);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.lblSecondPlayerScore);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblFirstPlayerScore);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSecondPlayer);
            this.Controls.Add(this.btnFirstPlayer);
            this.Controls.Add(this.pBDice2);
            this.Controls.Add(this.pBDice1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.lblScore);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pBDice1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBDice2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.TextBox txtScore;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pBDice1;
        private System.Windows.Forms.PictureBox pBDice2;
        private System.Windows.Forms.Button btnFirstPlayer;
        private System.Windows.Forms.Button btnSecondPlayer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblFirstPlayerScore;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblSecondPlayerScore;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.Label lblWinner;
    }
}

