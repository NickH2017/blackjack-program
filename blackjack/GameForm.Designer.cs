
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
            this.btnPlay = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtDealerValue = new System.Windows.Forms.TextBox();
            this.lblDealerPlayer = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtPlayerValue = new System.Windows.Forms.TextBox();
            this.lblPlayerValue = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.panPot.SuspendLayout();
            this.panBet.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
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
            this.btnHit.Click += new System.EventHandler(this.btnHit_Click);
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
            this.btnStand.Click += new System.EventHandler(this.btnStand_Click);
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
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtDealerValue);
            this.panel1.Controls.Add(this.lblDealerPlayer);
            this.panel1.Location = new System.Drawing.Point(490, 109);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(165, 41);
            this.panel1.TabIndex = 22;
            // 
            // txtDealerValue
            // 
            this.txtDealerValue.BackColor = System.Drawing.Color.DarkSlateGray;
            this.txtDealerValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDealerValue.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDealerValue.ForeColor = System.Drawing.Color.LightGreen;
            this.txtDealerValue.Location = new System.Drawing.Point(57, 7);
            this.txtDealerValue.Name = "txtDealerValue";
            this.txtDealerValue.Size = new System.Drawing.Size(27, 26);
            this.txtDealerValue.TabIndex = 9;
            this.txtDealerValue.Text = "0";
            this.txtDealerValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblDealerPlayer
            // 
            this.lblDealerPlayer.AutoSize = true;
            this.lblDealerPlayer.BackColor = System.Drawing.Color.Transparent;
            this.lblDealerPlayer.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDealerPlayer.ForeColor = System.Drawing.Color.LightGreen;
            this.lblDealerPlayer.Location = new System.Drawing.Point(5, 9);
            this.lblDealerPlayer.Name = "lblDealerPlayer";
            this.lblDealerPlayer.Size = new System.Drawing.Size(50, 19);
            this.lblDealerPlayer.TabIndex = 7;
            this.lblDealerPlayer.Text = "Value";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.txtPlayerValue);
            this.panel2.Controls.Add(this.lblPlayerValue);
            this.panel2.Location = new System.Drawing.Point(490, 254);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(165, 41);
            this.panel2.TabIndex = 23;
            // 
            // txtPlayerValue
            // 
            this.txtPlayerValue.BackColor = System.Drawing.Color.DarkSlateGray;
            this.txtPlayerValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPlayerValue.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlayerValue.ForeColor = System.Drawing.Color.LightGreen;
            this.txtPlayerValue.Location = new System.Drawing.Point(57, 7);
            this.txtPlayerValue.Name = "txtPlayerValue";
            this.txtPlayerValue.Size = new System.Drawing.Size(27, 26);
            this.txtPlayerValue.TabIndex = 9;
            this.txtPlayerValue.Text = "0";
            this.txtPlayerValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblPlayerValue
            // 
            this.lblPlayerValue.AutoSize = true;
            this.lblPlayerValue.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayerValue.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerValue.ForeColor = System.Drawing.Color.LightGreen;
            this.lblPlayerValue.Location = new System.Drawing.Point(5, 9);
            this.lblPlayerValue.Name = "lblPlayerValue";
            this.lblPlayerValue.Size = new System.Drawing.Size(50, 19);
            this.lblPlayerValue.TabIndex = 7;
            this.lblPlayerValue.Text = "Value";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(32, 333);
            this.listBox1.Margin = new System.Windows.Forms.Padding(2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(56, 56);
            this.listBox1.TabIndex = 21;
            // 
            // BlackJack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.BackgroundImage = global::blackjack.Properties.Resources.blackjack_classic_background2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(702, 456);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnPlay);
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
            this.MaximumSize = new System.Drawing.Size(718, 534);
            this.MinimumSize = new System.Drawing.Size(718, 460);
            this.Name = "BlackJack";
            this.Text = "BlackJack Game";
            this.Load += new System.EventHandler(this.BlackJack_Load);
            this.panPot.ResumeLayout(false);
            this.panPot.PerformLayout();
            this.panBet.ResumeLayout(false);
            this.panBet.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
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
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtDealerValue;
        private System.Windows.Forms.Label lblDealerPlayer;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtPlayerValue;
        private System.Windows.Forms.Label lblPlayerValue;
        private System.Windows.Forms.ListBox listBox1;
    }
}

