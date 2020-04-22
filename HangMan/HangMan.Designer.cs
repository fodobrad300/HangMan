namespace HangMan
{
    partial class HangMan
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
            this.components = new System.ComponentModel.Container();
            this.titleLbl = new System.Windows.Forms.Label();
            this.prefBtn = new System.Windows.Forms.Button();
            this.playBtn = new System.Windows.Forms.Button();
            this.prefPnl = new System.Windows.Forms.Panel();
            this.gamePnl = new System.Windows.Forms.Panel();
            this.strikeLbl = new System.Windows.Forms.Label();
            this.gameWordLbl = new System.Windows.Forms.Label();
            this.wordLbl = new System.Windows.Forms.Label();
            this.guessTxt = new System.Windows.Forms.TextBox();
            this.guessLbl = new System.Windows.Forms.Label();
            this.timeLbl = new System.Windows.Forms.Label();
            this.guessLetterLbl = new System.Windows.Forms.Label();
            this.guessWordLbl = new System.Windows.Forms.Label();
            this.wordListbx = new System.Windows.Forms.ListBox();
            this.hangManPic = new System.Windows.Forms.PictureBox();
            this.letterListbx = new System.Windows.Forms.ListBox();
            this.gameTmr = new System.Windows.Forms.Timer(this.components);
            this.guessTmr = new System.Windows.Forms.Timer(this.components);
            this.difficulty = new System.Windows.Forms.TrackBar();
            this.difficultyLbl = new System.Windows.Forms.Label();
            this.prefMenuLbl = new System.Windows.Forms.Label();
            this.modeLbl = new System.Windows.Forms.Label();
            this.prefPnl.SuspendLayout();
            this.gamePnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hangManPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.difficulty)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLbl
            // 
            this.titleLbl.AutoSize = true;
            this.titleLbl.Font = new System.Drawing.Font("Unispace", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLbl.Location = new System.Drawing.Point(358, 52);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(337, 39);
            this.titleLbl.TabIndex = 0;
            this.titleLbl.Text = "Ultimate HangMan";
            // 
            // prefBtn
            // 
            this.prefBtn.Font = new System.Drawing.Font("Unispace", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prefBtn.Location = new System.Drawing.Point(348, 171);
            this.prefBtn.Name = "prefBtn";
            this.prefBtn.Size = new System.Drawing.Size(188, 45);
            this.prefBtn.TabIndex = 1;
            this.prefBtn.Text = "Preferences";
            this.prefBtn.UseVisualStyleBackColor = true;
            this.prefBtn.Click += new System.EventHandler(this.prefBtn_Click);
            // 
            // playBtn
            // 
            this.playBtn.Font = new System.Drawing.Font("Unispace", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playBtn.Location = new System.Drawing.Point(348, 222);
            this.playBtn.Name = "playBtn";
            this.playBtn.Size = new System.Drawing.Size(188, 45);
            this.playBtn.TabIndex = 2;
            this.playBtn.Text = "Play";
            this.playBtn.UseVisualStyleBackColor = true;
            this.playBtn.Click += new System.EventHandler(this.playBtn_Click);
            // 
            // prefPnl
            // 
            this.prefPnl.Controls.Add(this.modeLbl);
            this.prefPnl.Controls.Add(this.difficultyLbl);
            this.prefPnl.Controls.Add(this.difficulty);
            this.prefPnl.Controls.Add(this.prefMenuLbl);
            this.prefPnl.Location = new System.Drawing.Point(0, 100);
            this.prefPnl.Name = "prefPnl";
            this.prefPnl.Size = new System.Drawing.Size(900, 405);
            this.prefPnl.TabIndex = 3;
            this.prefPnl.Tag = "";
            this.prefPnl.Visible = false;
            // 
            // gamePnl
            // 
            this.gamePnl.Controls.Add(this.strikeLbl);
            this.gamePnl.Controls.Add(this.gameWordLbl);
            this.gamePnl.Controls.Add(this.wordLbl);
            this.gamePnl.Controls.Add(this.guessTxt);
            this.gamePnl.Controls.Add(this.guessLbl);
            this.gamePnl.Controls.Add(this.timeLbl);
            this.gamePnl.Controls.Add(this.guessLetterLbl);
            this.gamePnl.Controls.Add(this.guessWordLbl);
            this.gamePnl.Controls.Add(this.wordListbx);
            this.gamePnl.Controls.Add(this.hangManPic);
            this.gamePnl.Controls.Add(this.letterListbx);
            this.gamePnl.Font = new System.Drawing.Font("Unispace", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gamePnl.Location = new System.Drawing.Point(3, 1);
            this.gamePnl.Name = "gamePnl";
            this.gamePnl.Size = new System.Drawing.Size(900, 602);
            this.gamePnl.TabIndex = 4;
            this.gamePnl.Visible = false;
            // 
            // strikeLbl
            // 
            this.strikeLbl.AutoSize = true;
            this.strikeLbl.Font = new System.Drawing.Font("Unispace", 14F, System.Drawing.FontStyle.Bold);
            this.strikeLbl.Location = new System.Drawing.Point(514, 414);
            this.strikeLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.strikeLbl.Name = "strikeLbl";
            this.strikeLbl.Size = new System.Drawing.Size(151, 34);
            this.strikeLbl.TabIndex = 10;
            this.strikeLbl.Text = "Strikes:";
            // 
            // gameWordLbl
            // 
            this.gameWordLbl.AutoSize = true;
            this.gameWordLbl.Font = new System.Drawing.Font("Unispace", 18F, System.Drawing.FontStyle.Bold);
            this.gameWordLbl.Location = new System.Drawing.Point(21, 437);
            this.gameWordLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gameWordLbl.Name = "gameWordLbl";
            this.gameWordLbl.Size = new System.Drawing.Size(0, 43);
            this.gameWordLbl.TabIndex = 9;
            // 
            // wordLbl
            // 
            this.wordLbl.AutoSize = true;
            this.wordLbl.Font = new System.Drawing.Font("Unispace", 20F, System.Drawing.FontStyle.Bold);
            this.wordLbl.Location = new System.Drawing.Point(18, 358);
            this.wordLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.wordLbl.Name = "wordLbl";
            this.wordLbl.Size = new System.Drawing.Size(140, 48);
            this.wordLbl.TabIndex = 8;
            this.wordLbl.Text = "Word:";
            // 
            // guessTxt
            // 
            this.guessTxt.Font = new System.Drawing.Font("Unispace", 10F, System.Drawing.FontStyle.Bold);
            this.guessTxt.Location = new System.Drawing.Point(520, 363);
            this.guessTxt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.guessTxt.Name = "guessTxt";
            this.guessTxt.Size = new System.Drawing.Size(228, 31);
            this.guessTxt.TabIndex = 7;
            this.guessTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.guessTxt_KeyPress);
            // 
            // guessLbl
            // 
            this.guessLbl.AutoSize = true;
            this.guessLbl.Font = new System.Drawing.Font("Unispace", 14F, System.Drawing.FontStyle.Bold);
            this.guessLbl.Location = new System.Drawing.Point(514, 322);
            this.guessLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.guessLbl.Name = "guessLbl";
            this.guessLbl.Size = new System.Drawing.Size(117, 34);
            this.guessLbl.TabIndex = 6;
            this.guessLbl.Text = "Guess:";
            // 
            // timeLbl
            // 
            this.timeLbl.AutoSize = true;
            this.timeLbl.Font = new System.Drawing.Font("Unispace", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLbl.Location = new System.Drawing.Point(832, 552);
            this.timeLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.timeLbl.Name = "timeLbl";
            this.timeLbl.Size = new System.Drawing.Size(97, 39);
            this.timeLbl.TabIndex = 5;
            this.timeLbl.Text = "0:00";
            // 
            // guessLetterLbl
            // 
            this.guessLetterLbl.AutoSize = true;
            this.guessLetterLbl.Font = new System.Drawing.Font("Unispace", 9.75F, System.Drawing.FontStyle.Bold);
            this.guessLetterLbl.Location = new System.Drawing.Point(700, 22);
            this.guessLetterLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.guessLetterLbl.Name = "guessLetterLbl";
            this.guessLetterLbl.Size = new System.Drawing.Size(190, 24);
            this.guessLetterLbl.TabIndex = 4;
            this.guessLetterLbl.Text = "Letters Guessed";
            // 
            // guessWordLbl
            // 
            this.guessWordLbl.AutoSize = true;
            this.guessWordLbl.Location = new System.Drawing.Point(516, 22);
            this.guessWordLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.guessWordLbl.Name = "guessWordLbl";
            this.guessWordLbl.Size = new System.Drawing.Size(106, 24);
            this.guessWordLbl.TabIndex = 3;
            this.guessWordLbl.Text = "Guesses ";
            // 
            // wordListbx
            // 
            this.wordListbx.FormattingEnabled = true;
            this.wordListbx.ItemHeight = 23;
            this.wordListbx.Location = new System.Drawing.Point(516, 55);
            this.wordListbx.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.wordListbx.MultiColumn = true;
            this.wordListbx.Name = "wordListbx";
            this.wordListbx.Size = new System.Drawing.Size(178, 165);
            this.wordListbx.TabIndex = 2;
            // 
            // hangManPic
            // 
            this.hangManPic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.hangManPic.Image = global::HangMan.Properties.Resources.Wumpus;
            this.hangManPic.Location = new System.Drawing.Point(4, 14);
            this.hangManPic.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.hangManPic.Name = "hangManPic";
            this.hangManPic.Size = new System.Drawing.Size(486, 297);
            this.hangManPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.hangManPic.TabIndex = 1;
            this.hangManPic.TabStop = false;
            // 
            // letterListbx
            // 
            this.letterListbx.FormattingEnabled = true;
            this.letterListbx.ItemHeight = 23;
            this.letterListbx.Location = new System.Drawing.Point(705, 55);
            this.letterListbx.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.letterListbx.MultiColumn = true;
            this.letterListbx.Name = "letterListbx";
            this.letterListbx.Size = new System.Drawing.Size(178, 165);
            this.letterListbx.TabIndex = 0;
            // 
            // gameTmr
            // 
            this.gameTmr.Interval = 1000;
            this.gameTmr.Tick += new System.EventHandler(this.gameTmr_Tick);
            // 
            // guessTmr
            // 
            this.guessTmr.Interval = 1000;
            this.guessTmr.Tick += new System.EventHandler(this.guessTmr_Tick);
            // 
            // difficulty
            // 
            this.difficulty.Location = new System.Drawing.Point(3, 107);
            this.difficulty.Maximum = 2;
            this.difficulty.Name = "difficulty";
            this.difficulty.Size = new System.Drawing.Size(197, 69);
            this.difficulty.TabIndex = 5;
            // 
            // difficultyLbl
            // 
            this.difficultyLbl.AutoSize = true;
            this.difficultyLbl.Font = new System.Drawing.Font("Unispace", 12F, System.Drawing.FontStyle.Bold);
            this.difficultyLbl.Location = new System.Drawing.Point(9, 80);
            this.difficultyLbl.Name = "difficultyLbl";
            this.difficultyLbl.Size = new System.Drawing.Size(178, 29);
            this.difficultyLbl.TabIndex = 6;
            this.difficultyLbl.Text = "Difficulty:";
            // 
            // prefMenuLbl
            // 
            this.prefMenuLbl.AutoSize = true;
            this.prefMenuLbl.Font = new System.Drawing.Font("Unispace", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prefMenuLbl.Location = new System.Drawing.Point(9, 15);
            this.prefMenuLbl.Name = "prefMenuLbl";
            this.prefMenuLbl.Size = new System.Drawing.Size(238, 24);
            this.prefMenuLbl.TabIndex = 0;
            this.prefMenuLbl.Text = "Return to Main Menu";
            this.prefMenuLbl.Click += new System.EventHandler(this.prefMenuLbl_Click);
            this.prefMenuLbl.MouseEnter += new System.EventHandler(this.prefMenuLbl_MouseEnter);
            this.prefMenuLbl.MouseLeave += new System.EventHandler(this.prefMenuLbl_MouseLeave);
            // 
            // modeLbl
            // 
            this.modeLbl.AutoSize = true;
            this.modeLbl.Font = new System.Drawing.Font("Unispace", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modeLbl.Location = new System.Drawing.Point(12, 152);
            this.modeLbl.Name = "modeLbl";
            this.modeLbl.Size = new System.Drawing.Size(202, 24);
            this.modeLbl.TabIndex = 7;
            this.modeLbl.Text = "Easy Medium Hard";
            // 
            // HangMan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 598);
            this.Controls.Add(this.gamePnl);
            this.Controls.Add(this.prefPnl);
            this.Controls.Add(this.playBtn);
            this.Controls.Add(this.prefBtn);
            this.Controls.Add(this.titleLbl);
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(798, 591);
            this.Name = "HangMan";
            this.Text = "Ultimate Hangman";
            this.Load += new System.EventHandler(this.HangMan_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.HangMan_KeyPress);
            this.Resize += new System.EventHandler(this.HangMan_Resize);
            this.prefPnl.ResumeLayout(false);
            this.prefPnl.PerformLayout();
            this.gamePnl.ResumeLayout(false);
            this.gamePnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hangManPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.difficulty)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.Button prefBtn;
        private System.Windows.Forms.Button playBtn;
        private System.Windows.Forms.Panel prefPnl;
        private System.Windows.Forms.Panel gamePnl;
        private System.Windows.Forms.Timer gameTmr;
        private System.Windows.Forms.Label guessLetterLbl;
        private System.Windows.Forms.Label guessWordLbl;
        private System.Windows.Forms.ListBox wordListbx;
        private System.Windows.Forms.PictureBox hangManPic;
        private System.Windows.Forms.ListBox letterListbx;
        private System.Windows.Forms.Label timeLbl;
        private System.Windows.Forms.Label guessLbl;
        private System.Windows.Forms.Label wordLbl;
        private System.Windows.Forms.TextBox guessTxt;
        private System.Windows.Forms.Label gameWordLbl;
        private System.Windows.Forms.Label strikeLbl;
        private System.Windows.Forms.Timer guessTmr;
        private System.Windows.Forms.Label difficultyLbl;
        private System.Windows.Forms.TrackBar difficulty;
        private System.Windows.Forms.Label modeLbl;
        private System.Windows.Forms.Label prefMenuLbl;
    }
}

