
namespace blackjack
{
    partial class BlackJack
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BlackJack));
            this.lblPayout = new System.Windows.Forms.Label();
            this.btnHit = new System.Windows.Forms.Button();
            this.btnStand = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblPot = new System.Windows.Forms.Label();
            this.panPot = new System.Windows.Forms.Panel();
            this.txtPot = new System.Windows.Forms.TextBox();
            this.panBet = new System.Windows.Forms.Panel();
            this.txtBet = new System.Windows.Forms.TextBox();
            this.lblBet = new System.Windows.Forms.Label();
            this.picPlayerCard5 = new System.Windows.Forms.PictureBox();
            this.picPlayerCard4 = new System.Windows.Forms.PictureBox();
            this.picPlayerCard3 = new System.Windows.Forms.PictureBox();
            this.picPlayerCard2 = new System.Windows.Forms.PictureBox();
            this.picPlayerCard1 = new System.Windows.Forms.PictureBox();
            this.picDealerCard1 = new System.Windows.Forms.PictureBox();
            this.picDealerCard2 = new System.Windows.Forms.PictureBox();
            this.picDealerCard3 = new System.Windows.Forms.PictureBox();
            this.picDealerCard4 = new System.Windows.Forms.PictureBox();
            this.picDealerCard5 = new System.Windows.Forms.PictureBox();
            this.btnPlay = new System.Windows.Forms.Button();
            this.panPot.SuspendLayout();
            this.panBet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayerCard5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayerCard4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayerCard3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayerCard2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayerCard1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDealerCard1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDealerCard2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDealerCard3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDealerCard4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDealerCard5)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPayout
            // 
            this.lblPayout.AutoSize = true;
            this.lblPayout.BackColor = System.Drawing.Color.Transparent;
            this.lblPayout.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPayout.ForeColor = System.Drawing.Color.LightGreen;
            this.lblPayout.Location = new System.Drawing.Point(253, 429);
            this.lblPayout.Name = "lblPayout";
            this.lblPayout.Size = new System.Drawing.Size(227, 28);
            this.lblPayout.TabIndex = 1;
            this.lblPayout.Text = "BlackJack pays 3 to 2";
            // 
            // btnHit
            // 
            this.btnHit.BackColor = System.Drawing.Color.Green;
            this.btnHit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHit.FlatAppearance.BorderColor = System.Drawing.Color.Gold;
            this.btnHit.FlatAppearance.BorderSize = 2;
            this.btnHit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHit.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHit.ForeColor = System.Drawing.Color.White;
            this.btnHit.Location = new System.Drawing.Point(275, 361);
            this.btnHit.Name = "btnHit";
            this.btnHit.Size = new System.Drawing.Size(73, 48);
            this.btnHit.TabIndex = 4;
            this.btnHit.Text = "Hit";
            this.btnHit.UseVisualStyleBackColor = false;
            // 
            // btnStand
            // 
            this.btnStand.BackColor = System.Drawing.Color.DarkRed;
            this.btnStand.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStand.FlatAppearance.BorderColor = System.Drawing.Color.Gold;
            this.btnStand.FlatAppearance.BorderSize = 2;
            this.btnStand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStand.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStand.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnStand.Location = new System.Drawing.Point(391, 361);
            this.btnStand.Name = "btnStand";
            this.btnStand.Size = new System.Drawing.Size(68, 48);
            this.btnStand.TabIndex = 5;
            this.btnStand.Text = "Stand";
            this.btnStand.UseVisualStyleBackColor = false;
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Cornsilk;
            this.btnReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.btnReset.Location = new System.Drawing.Point(50, 123);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(105, 27);
            this.btnReset.TabIndex = 6;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblPot
            // 
            this.lblPot.AutoSize = true;
            this.lblPot.BackColor = System.Drawing.Color.Transparent;
            this.lblPot.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPot.ForeColor = System.Drawing.Color.LightGreen;
            this.lblPot.Location = new System.Drawing.Point(5, 9);
            this.lblPot.Name = "lblPot";
            this.lblPot.Size = new System.Drawing.Size(89, 19);
            this.lblPot.TabIndex = 7;
            this.lblPot.Text = "Available $";
            // 
            // panPot
            // 
            this.panPot.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panPot.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panPot.Controls.Add(this.txtPot);
            this.panPot.Controls.Add(this.lblPot);
            this.panPot.Location = new System.Drawing.Point(3, 3);
            this.panPot.Name = "panPot";
            this.panPot.Size = new System.Drawing.Size(165, 41);
            this.panPot.TabIndex = 8;
            // 
            // txtPot
            // 
            this.txtPot.BackColor = System.Drawing.Color.DarkSlateGray;
            this.txtPot.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPot.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPot.ForeColor = System.Drawing.Color.LightGreen;
            this.txtPot.Location = new System.Drawing.Point(100, 7);
            this.txtPot.Name = "txtPot";
            this.txtPot.Size = new System.Drawing.Size(42, 26);
            this.txtPot.TabIndex = 9;
            this.txtPot.Text = "100";
            this.txtPot.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panBet
            // 
            this.panBet.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panBet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panBet.Controls.Add(this.txtBet);
            this.panBet.Controls.Add(this.lblBet);
            this.panBet.Location = new System.Drawing.Point(3, 43);
            this.panBet.Name = "panBet";
            this.panBet.Size = new System.Drawing.Size(165, 41);
            this.panBet.TabIndex = 9;
            // 
            // txtBet
            // 
            this.txtBet.BackColor = System.Drawing.Color.DarkSlateGray;
            this.txtBet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBet.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBet.ForeColor = System.Drawing.Color.LightGreen;
            this.txtBet.Location = new System.Drawing.Point(57, 7);
            this.txtBet.Name = "txtBet";
            this.txtBet.Size = new System.Drawing.Size(27, 26);
            this.txtBet.TabIndex = 9;
            this.txtBet.Text = "5";
            this.txtBet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblBet
            // 
            this.lblBet.AutoSize = true;
            this.lblBet.BackColor = System.Drawing.Color.Transparent;
            this.lblBet.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBet.ForeColor = System.Drawing.Color.LightGreen;
            this.lblBet.Location = new System.Drawing.Point(5, 9);
            this.lblBet.Name = "lblBet";
            this.lblBet.Size = new System.Drawing.Size(46, 19);
            this.lblBet.TabIndex = 7;
            this.lblBet.Text = "Bet $";
            // 
            // picPlayerCard5
            // 
            this.picPlayerCard5.BackColor = System.Drawing.Color.Transparent;
            this.picPlayerCard5.Location = new System.Drawing.Point(275, 217);
            this.picPlayerCard5.Name = "picPlayerCard5";
            this.picPlayerCard5.Size = new System.Drawing.Size(83, 126);
            this.picPlayerCard5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPlayerCard5.TabIndex = 10;
            this.picPlayerCard5.TabStop = false;
            // 
            // picPlayerCard4
            // 
            this.picPlayerCard4.BackColor = System.Drawing.Color.Transparent;
            this.picPlayerCard4.Location = new System.Drawing.Point(300, 217);
            this.picPlayerCard4.Name = "picPlayerCard4";
            this.picPlayerCard4.Size = new System.Drawing.Size(83, 126);
            this.picPlayerCard4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPlayerCard4.TabIndex = 11;
            this.picPlayerCard4.TabStop = false;
            // 
            // picPlayerCard3
            // 
            this.picPlayerCard3.BackColor = System.Drawing.Color.Transparent;
            this.picPlayerCard3.Location = new System.Drawing.Point(326, 217);
            this.picPlayerCard3.Name = "picPlayerCard3";
            this.picPlayerCard3.Size = new System.Drawing.Size(83, 126);
            this.picPlayerCard3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPlayerCard3.TabIndex = 12;
            this.picPlayerCard3.TabStop = false;
            // 
            // picPlayerCard2
            // 
            this.picPlayerCard2.BackColor = System.Drawing.Color.Transparent;
            this.picPlayerCard2.Location = new System.Drawing.Point(351, 217);
            this.picPlayerCard2.Name = "picPlayerCard2";
            this.picPlayerCard2.Size = new System.Drawing.Size(83, 126);
            this.picPlayerCard2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPlayerCard2.TabIndex = 13;
            this.picPlayerCard2.TabStop = false;
            // 
            // picPlayerCard1
            // 
            this.picPlayerCard1.BackColor = System.Drawing.Color.Transparent;
            this.picPlayerCard1.Image = global::blackjack.Properties.Resources.green_back;
            this.picPlayerCard1.Location = new System.Drawing.Point(376, 217);
            this.picPlayerCard1.Name = "picPlayerCard1";
            this.picPlayerCard1.Size = new System.Drawing.Size(83, 126);
            this.picPlayerCard1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPlayerCard1.TabIndex = 14;
            this.picPlayerCard1.TabStop = false;
            // 
            // picDealerCard1
            // 
            this.picDealerCard1.BackColor = System.Drawing.Color.Transparent;
            this.picDealerCard1.Image = global::blackjack.Properties.Resources.gray_back;
            this.picDealerCard1.Location = new System.Drawing.Point(376, 65);
            this.picDealerCard1.Name = "picDealerCard1";
            this.picDealerCard1.Size = new System.Drawing.Size(83, 126);
            this.picDealerCard1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picDealerCard1.TabIndex = 19;
            this.picDealerCard1.TabStop = false;
            // 
            // picDealerCard2
            // 
            this.picDealerCard2.BackColor = System.Drawing.Color.Transparent;
            this.picDealerCard2.Location = new System.Drawing.Point(351, 65);
            this.picDealerCard2.Name = "picDealerCard2";
            this.picDealerCard2.Size = new System.Drawing.Size(83, 126);
            this.picDealerCard2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picDealerCard2.TabIndex = 18;
            this.picDealerCard2.TabStop = false;
            // 
            // picDealerCard3
            // 
            this.picDealerCard3.BackColor = System.Drawing.Color.Transparent;
            this.picDealerCard3.Location = new System.Drawing.Point(326, 65);
            this.picDealerCard3.Name = "picDealerCard3";
            this.picDealerCard3.Size = new System.Drawing.Size(83, 126);
            this.picDealerCard3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picDealerCard3.TabIndex = 17;
            this.picDealerCard3.TabStop = false;
            // 
            // picDealerCard4
            // 
            this.picDealerCard4.BackColor = System.Drawing.Color.Transparent;
            this.picDealerCard4.Location = new System.Drawing.Point(300, 65);
            this.picDealerCard4.Name = "picDealerCard4";
            this.picDealerCard4.Size = new System.Drawing.Size(83, 126);
            this.picDealerCard4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picDealerCard4.TabIndex = 16;
            this.picDealerCard4.TabStop = false;
            // 
            // picDealerCard5
            // 
            this.picDealerCard5.BackColor = System.Drawing.Color.Transparent;
            this.picDealerCard5.Location = new System.Drawing.Point(275, 65);
            this.picDealerCard5.Name = "picDealerCard5";
            this.picDealerCard5.Size = new System.Drawing.Size(83, 126);
            this.picDealerCard5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picDealerCard5.TabIndex = 15;
            this.picDealerCard5.TabStop = false;
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.Cornsilk;
            this.btnPlay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlay.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.btnPlay.Location = new System.Drawing.Point(50, 164);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(105, 27);
            this.btnPlay.TabIndex = 20;
            this.btnPlay.Text = "Play!";
            this.btnPlay.UseVisualStyleBackColor = false;
            // 
            // BlackJack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.BackgroundImage = global::blackjack.Properties.Resources.blackjack_classic_background2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(704, 501);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.picPlayerCard1);
            this.Controls.Add(this.picDealerCard1);
            this.Controls.Add(this.picDealerCard2);
            this.Controls.Add(this.picDealerCard3);
            this.Controls.Add(this.picDealerCard4);
            this.Controls.Add(this.picDealerCard5);
            this.Controls.Add(this.picPlayerCard2);
            this.Controls.Add(this.picPlayerCard3);
            this.Controls.Add(this.picPlayerCard4);
            this.Controls.Add(this.picPlayerCard5);
            this.Controls.Add(this.panBet);
            this.Controls.Add(this.panPot);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnStand);
            this.Controls.Add(this.btnHit);
            this.Controls.Add(this.lblPayout);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(720, 540);
            this.MinimumSize = new System.Drawing.Size(720, 540);
            this.Name = "BlackJack";
            this.Text = "BlackJack Game";
            this.panPot.ResumeLayout(false);
            this.panPot.PerformLayout();
            this.panBet.ResumeLayout(false);
            this.panBet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayerCard5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayerCard4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayerCard3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayerCard2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayerCard1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDealerCard1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDealerCard2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDealerCard3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDealerCard4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDealerCard5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPayout;
        private System.Windows.Forms.Button btnHit;
        private System.Windows.Forms.Button btnStand;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblPot;
        private System.Windows.Forms.Panel panPot;
        private System.Windows.Forms.TextBox txtPot;
        private System.Windows.Forms.Panel panBet;
        private System.Windows.Forms.TextBox txtBet;
        private System.Windows.Forms.Label lblBet;
        private System.Windows.Forms.PictureBox picPlayerCard5;
        private System.Windows.Forms.PictureBox picPlayerCard4;
        private System.Windows.Forms.PictureBox picPlayerCard3;
        private System.Windows.Forms.PictureBox picPlayerCard2;
        private System.Windows.Forms.PictureBox picPlayerCard1;
        private System.Windows.Forms.PictureBox picDealerCard1;
        private System.Windows.Forms.PictureBox picDealerCard2;
        private System.Windows.Forms.PictureBox picDealerCard3;
        private System.Windows.Forms.PictureBox picDealerCard4;
        private System.Windows.Forms.PictureBox picDealerCard5;
        private System.Windows.Forms.Button btnPlay;
    }
}

