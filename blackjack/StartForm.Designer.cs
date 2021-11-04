
namespace blackjack
{
    partial class StartForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartForm));
            this.btnStart = new System.Windows.Forms.Button();
            this.panPot = new System.Windows.Forms.Panel();
            this.lblSeed = new System.Windows.Forms.Label();
            this.txtSeed = new System.Windows.Forms.TextBox();
            this.lblDecks = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.cboDecks = new System.Windows.Forms.ComboBox();
            this.panPot.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.Cornsilk;
            this.btnStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.btnStart.Location = new System.Drawing.Point(291, 350);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(144, 56);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Play!";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // panPot
            // 
            this.panPot.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panPot.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panPot.Controls.Add(this.cboDecks);
            this.panPot.Controls.Add(this.checkBox1);
            this.panPot.Controls.Add(this.lblDecks);
            this.panPot.Controls.Add(this.txtSeed);
            this.panPot.Controls.Add(this.lblSeed);
            this.panPot.ForeColor = System.Drawing.Color.DarkGreen;
            this.panPot.Location = new System.Drawing.Point(232, 124);
            this.panPot.Name = "panPot";
            this.panPot.Size = new System.Drawing.Size(253, 209);
            this.panPot.TabIndex = 9;
            // 
            // lblSeed
            // 
            this.lblSeed.AutoSize = true;
            this.lblSeed.BackColor = System.Drawing.Color.Transparent;
            this.lblSeed.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeed.ForeColor = System.Drawing.Color.LightGreen;
            this.lblSeed.Location = new System.Drawing.Point(53, 36);
            this.lblSeed.Name = "lblSeed";
            this.lblSeed.Size = new System.Drawing.Size(47, 19);
            this.lblSeed.TabIndex = 3;
            this.lblSeed.Text = "Seed:";
            // 
            // txtSeed
            // 
            this.txtSeed.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSeed.ForeColor = System.Drawing.Color.DarkGreen;
            this.txtSeed.Location = new System.Drawing.Point(106, 33);
            this.txtSeed.Name = "txtSeed";
            this.txtSeed.Size = new System.Drawing.Size(84, 26);
            this.txtSeed.TabIndex = 4;
            this.txtSeed.Text = "999";
            // 
            // lblDecks
            // 
            this.lblDecks.AutoSize = true;
            this.lblDecks.BackColor = System.Drawing.Color.Transparent;
            this.lblDecks.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDecks.ForeColor = System.Drawing.Color.LightGreen;
            this.lblDecks.Location = new System.Drawing.Point(53, 90);
            this.lblDecks.Name = "lblDecks";
            this.lblDecks.Size = new System.Drawing.Size(88, 19);
            this.lblDecks.TabIndex = 5;
            this.lblDecks.Text = "# of Decks:";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.ForeColor = System.Drawing.Color.LightGreen;
            this.checkBox1.Location = new System.Drawing.Point(57, 148);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(78, 23);
            this.checkBox1.TabIndex = 7;
            this.checkBox1.Text = "Soft 17";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.BackColor = System.Drawing.Color.Transparent;
            this.lblWelcome.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.ForeColor = System.Drawing.Color.LightGreen;
            this.lblWelcome.Location = new System.Drawing.Point(238, 81);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(247, 28);
            this.lblWelcome.TabIndex = 10;
            this.lblWelcome.Text = "Welcome to BlackJack!";
            // 
            // cboDecks
            // 
            this.cboDecks.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboDecks.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDecks.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDecks.ForeColor = System.Drawing.Color.DarkGreen;
            this.cboDecks.FormattingEnabled = true;
            this.cboDecks.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.cboDecks.Location = new System.Drawing.Point(147, 87);
            this.cboDecks.Name = "cboDecks";
            this.cboDecks.Size = new System.Drawing.Size(43, 27);
            this.cboDecks.TabIndex = 11;
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::blackjack.Properties.Resources.blackjack_classic_background2;
            this.ClientSize = new System.Drawing.Size(704, 501);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.panPot);
            this.Controls.Add(this.btnStart);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(720, 540);
            this.MinimumSize = new System.Drawing.Size(720, 540);
            this.Name = "StartForm";
            this.Text = "Welcome to BlackJack!";
            this.panPot.ResumeLayout(false);
            this.panPot.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Panel panPot;
        private System.Windows.Forms.Label lblSeed;
        private System.Windows.Forms.TextBox txtSeed;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label lblDecks;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.ComboBox cboDecks;
    }
}