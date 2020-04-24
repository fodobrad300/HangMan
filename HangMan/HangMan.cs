using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HangMan
{
    public partial class HangMan : Form
    {
        //declare all variables + create all lists
        bool play = false;
        bool hold = false;
        int time = 0;
        int cycle = 1;
        int minute = 0;
        int strike = 0;
        string word;
        List<string> wordsEasy = new List<string>() { "APPLE", "BEE", "CAR", "SKY", "RED", "BLUE", "TRUCK", "PAPER", "WOOD", "SMALL", "BIG", "BREAD", "OVEN", "FERN", "PLANT" };
        List<string> wordsMedium = new List<string>() { "BRADY", "COMPUTER", "ALDWORTH", "INDIGO", "COTTON", "LARGE","MOUND", "HEAP", "FORGE", "WIELD", "BAKERY", "INTEREST", "COUNT"};
        List<string> wordsHard = new List<string>() { "ZEYPHR", "PHILOSOPHER", "CHEMISTRY","PEROXIDE", "ATMOSPHERE", "SYNCHRONIZE", "OXIDIZER", "DERIVATIVE" , "REFERENCE", "STRATEGY"};
        List<string> guessedWords = new List<string>();
        List<string> guessedLetters = new List<string>();
        List<string> letters = new List<string>();
        Random generator = new Random();



        public HangMan()
        {
            InitializeComponent();
        }
        //form related events
        private void HangMan_Load(object sender, EventArgs e)
        {
            letterListbx.DataSource = guessedLetters;

            int xMod = ClientSize.Width - 600;
            int yMod = ClientSize.Height - 390;


            //titleLbl.Text = Convert.ToString(ClientSize.Width) + ", " + Convert.ToString(ClientSize.Height);

            prefBtn.Size = new System.Drawing.Size(125 + xMod / (600 / 125), 29 + yMod / (390 / 29));
            prefBtn.Location = new System.Drawing.Point((ClientSize.Width / 2 - prefBtn.Width / 2), (ClientSize.Height / 2 - prefBtn.Height / 2) + 70);

            playBtn.Size = new System.Drawing.Size(125 + xMod / (600 / 125), 29 + yMod / (390 / 29));
            playBtn.Location = new System.Drawing.Point((ClientSize.Width / 2 - playBtn.Width / 2), (ClientSize.Height / 2 + playBtn.Height / 2) + 80);

            titleLbl.Font = new System.Drawing.Font("Unispace", (16 + xMod / (600 / 16)), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            titleLbl.Location = new System.Drawing.Point((ClientSize.Width / 2 - titleLbl.Width / 2), ClientSize.Height / 10);

            prefPnl.Location = new System.Drawing.Point(0, ClientSize.Height / 5);
            prefPnl.Size = new System.Drawing.Size(ClientSize.Width, ClientSize.Height - prefPnl.Location.Y);

            gamePnl.Location = new System.Drawing.Point(0, 0);
            gamePnl.Size = new System.Drawing.Size(ClientSize.Width, ClientSize.Height);

            letterListbx.Size = new System.Drawing.Size(120 + xMod / (600 / 120), 150 + yMod / (390 / 150));
            letterListbx.Location = new System.Drawing.Point(ClientSize.Width - letterListbx.Width - 10, ClientSize.Height / 10);

            wordListbx.Size = new System.Drawing.Size(120 + xMod / (600 / 120), 150 + yMod / (390 / 150));
            wordListbx.Location = new System.Drawing.Point(ClientSize.Width - (2 * letterListbx.Width) - 20, ClientSize.Height / 10);

            guessLetterLbl.Font = new System.Drawing.Font("Unispace", (9 + xMod / (600 / 9)), System.Drawing.FontStyle.Bold);
            guessLetterLbl.Location = new System.Drawing.Point(ClientSize.Width - letterListbx.Width - 10, (ClientSize.Height / 10) - (guessLetterLbl.Height + 5));

            guessWordLbl.Font = new System.Drawing.Font("Unispace", (9 + xMod / (600 / 9)), System.Drawing.FontStyle.Bold);
            guessWordLbl.Location = new System.Drawing.Point(ClientSize.Width - 2 * letterListbx.Width - 20, (ClientSize.Height / 10) - (guessWordLbl.Height + 5));

            hangManPic.Size = new System.Drawing.Size(300 + xMod / (600 / 300), 200 + yMod / (390 / 200));
            hangManPic.Location = new System.Drawing.Point(10, 10);

            timeLbl.Font = new System.Drawing.Font("Unispace", (16 + xMod / (600 / 16)), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            timeLbl.Location = new System.Drawing.Point(ClientSize.Width - (timeLbl.Width + 10), ClientSize.Height - (timeLbl.Height + 10));

            guessLbl.Font = new System.Drawing.Font("Unispace", (14 + xMod / (600 / 14)), System.Drawing.FontStyle.Bold);
            guessLbl.Location = new System.Drawing.Point(ClientSize.Width - 2 * letterListbx.Width - 20, hangManPic.Height + 10);

            guessTxt.Size = new System.Drawing.Size(153 + xMod / (600 / 153), 23 + yMod / (390 / 23));
            guessTxt.Font = new System.Drawing.Font("Unispace", (10 + xMod / (600 / 16)), System.Drawing.FontStyle.Bold);
            guessTxt.Location = new System.Drawing.Point(guessLbl.Location.X, guessLbl.Location.Y + guessLbl.Height + 10);

            wordLbl.Font = new System.Drawing.Font("Unispace", (20 + xMod / (600 / 20)), System.Drawing.FontStyle.Bold);
            wordLbl.Location = new System.Drawing.Point(50, hangManPic.Height + 50);

            gameWordLbl.Font = new System.Drawing.Font("Unispace", (18 + xMod / (600 / 18)), System.Drawing.FontStyle.Bold);
            gameWordLbl.Location = new System.Drawing.Point(wordLbl.Location.X, wordLbl.Location.Y + 30);

            strikeLbl.Font = new System.Drawing.Font("Unispace", (14 + xMod / (600 / 14)), System.Drawing.FontStyle.Bold);
            strikeLbl.Location = new System.Drawing.Point(guessLbl.Location.X, guessTxt.Location.Y + guessTxt.Height + 20);

            difficulty.Size = new System.Drawing.Size(197 + xMod / (600 / 197), 69 + yMod / (390 / 23));
            difficulty.Location = new System.Drawing.Point(ClientSize.Width / 2, ClientSize.Height / 3);

            modeLbl.Font = new System.Drawing.Font("Unispace", (10 + xMod / (600 / 10)), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            modeLbl.Location = new System.Drawing.Point(difficulty.Location.X, difficulty.Location.Y + (11 * difficulty.Height / 10));

            difficultyLbl.Font = new System.Drawing.Font("Unispace", (12 + xMod / (600 / 12)), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            difficultyLbl.Location = new System.Drawing.Point(difficulty.Location.X, difficulty.Location.Y - (15 * difficultyLbl.Height / 10));
        }

        private void HangMan_Resize(object sender, EventArgs e)
        {
            int xMod = ClientSize.Width - 600;
            int yMod = ClientSize.Height - 390;

            //titleLbl.Text = Convert.ToString(ClientSize.Width) + ", " + Convert.ToString(ClientSize.Height);

            prefBtn.Size = new System.Drawing.Size(125 + xMod / (600 / 125), 29 + yMod / (390 / 29));
            prefBtn.Location = new System.Drawing.Point((ClientSize.Width / 2 - prefBtn.Width / 2), (ClientSize.Height / 2 - prefBtn.Height / 2) + 70);

            playBtn.Size = new System.Drawing.Size(125 + xMod / (600 / 125), 29 + yMod / (390 / 29));
            playBtn.Location = new System.Drawing.Point((ClientSize.Width / 2 - playBtn.Width / 2), (ClientSize.Height / 2 + playBtn.Height / 2) + 80);

            titleLbl.Font = new System.Drawing.Font("Unispace", (16 + xMod / (600 / 16)), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            titleLbl.Location = new System.Drawing.Point((ClientSize.Width / 2 - titleLbl.Width / 2), ClientSize.Height / 10);

            prefMenuLbl.Font = prefMenuLbl.Font = new System.Drawing.Font("Unispace", (10 + xMod / (600 / 10)), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            prefPnl.Location = new System.Drawing.Point(0, ClientSize.Height / 5);
            prefPnl.Size = new System.Drawing.Size(ClientSize.Width, ClientSize.Height - prefPnl.Location.Y);
            gamePnl.Size = new System.Drawing.Size(ClientSize.Width, ClientSize.Height);

            letterListbx.Size = new System.Drawing.Size(120 + xMod / (600 / 120), 150 + yMod / (390 / 150));
            letterListbx.Location = new System.Drawing.Point(ClientSize.Width - letterListbx.Width - 10, ClientSize.Height / 10);

            wordListbx.Size = new System.Drawing.Size(120 + xMod / (600 / 120), 150 + yMod / (390 / 150));
            wordListbx.Location = new System.Drawing.Point(ClientSize.Width - (2 * letterListbx.Width) - 20, ClientSize.Height / 10);

            guessLetterLbl.Font = new System.Drawing.Font("Unispace", (9 + xMod / (600 / 9)), System.Drawing.FontStyle.Bold);
            guessLetterLbl.Location = new System.Drawing.Point(ClientSize.Width - letterListbx.Width - 10, (ClientSize.Height / 10) - (guessLetterLbl.Height + 5));

            guessWordLbl.Font = new System.Drawing.Font("Unispace", (9 + xMod / (600 / 9)), System.Drawing.FontStyle.Bold);
            guessWordLbl.Location = new System.Drawing.Point(ClientSize.Width - 2 * letterListbx.Width - 20, (ClientSize.Height / 10) - (guessWordLbl.Height + 5));

            hangManPic.Size = new System.Drawing.Size(300 + xMod / (600 / 300), 200 + yMod / (390 / 200));
            hangManPic.Location = new System.Drawing.Point(10, 10);

            timeLbl.Font = new System.Drawing.Font("Unispace", (16 + xMod / (600 / 16)), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            timeLbl.Location = new System.Drawing.Point(ClientSize.Width - (timeLbl.Width + 10), ClientSize.Height - (timeLbl.Height + 10));

            guessLbl.Font = new System.Drawing.Font("Unispace", (14 + xMod / (600 / 16)), System.Drawing.FontStyle.Bold);
            guessLbl.Location = new System.Drawing.Point(ClientSize.Width - 2 * letterListbx.Width - 20, hangManPic.Height + 10);

            guessTxt.Size = new System.Drawing.Size(153 + xMod / (600 / 153), 23 + yMod / (390 / 23));
            guessTxt.Font = new System.Drawing.Font("Unispace", (10 + xMod / (600 / 10)), System.Drawing.FontStyle.Bold);
            guessTxt.Location = new System.Drawing.Point(guessLbl.Location.X, guessLbl.Location.Y + guessLbl.Height + 10);

            wordLbl.Font = new System.Drawing.Font("Unispace", (20 + xMod / (600 / 20)), System.Drawing.FontStyle.Bold);
            wordLbl.Location = new System.Drawing.Point(50, hangManPic.Height + 50);

            gameWordLbl.Font = new System.Drawing.Font("Unispace", (18 + xMod / (600 / 18)), System.Drawing.FontStyle.Bold);
            gameWordLbl.Location = new System.Drawing.Point(wordLbl.Location.X, wordLbl.Location.Y + 50);

            strikeLbl.Font = new System.Drawing.Font("Unispace", (14 + xMod / (600 / 14)), System.Drawing.FontStyle.Bold);
            strikeLbl.Location = new System.Drawing.Point(guessLbl.Location.X, guessTxt.Location.Y + guessTxt.Height + 20);

            difficulty.Size = new System.Drawing.Size(197 + xMod / (600 / 197), 69 + yMod / (390 / 23));
            difficulty.Location = new System.Drawing.Point(ClientSize.Width / 2, ClientSize.Height / 3);

            modeLbl.Font = new System.Drawing.Font("Unispace", (10 + xMod / (600 / 10)), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            modeLbl.Location = new System.Drawing.Point(difficulty.Location.X, difficulty.Location.Y + (11 * difficulty.Height / 10));

            difficultyLbl.Font = new System.Drawing.Font("Unispace", (12 + xMod / (600 / 12)), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            difficultyLbl.Location = new System.Drawing.Point(difficulty.Location.X, difficulty.Location.Y - (15 * difficultyLbl.Height / 10));
        }
        //menu events
        private void prefBtn_Click(object sender, EventArgs e)
        {
            prefPnl.Visible = true;
        }

        private void playBtn_Click(object sender, EventArgs e)
        {
            //reset game text
            gameWordLbl.Text = "";
            //generate words and set all play elements to visible
            if (difficulty.Value == 0)
            {
                word = wordsEasy[generator.Next(0, wordsEasy.Count)];
            }
            else if (difficulty.Value == 1)
            {
                word = wordsMedium[generator.Next(0, wordsMedium.Count)];
            }
            else
            {
                word = wordsHard[generator.Next(0, wordsHard.Count)];
            }

            for (int i = 0; i < word.Length; i++)
            {
                gameWordLbl.Text += "_ ";
                letters.Add(" ");
            }
            strike = 0;
            strikeLbl.Text = "Strikes:" + strike;
            gamePnl.Visible = true;
            gameTmr.Start();
            time = 0;
            play = true;
        }

        private void prefMenuLbl_Click(object sender, EventArgs e)
        {
            prefPnl.Visible = false;
        }

        private void prefMenuLbl_MouseEnter(object sender, EventArgs e)
        {
            int xMod = ClientSize.Width - 600;
            prefMenuLbl.Font = new System.Drawing.Font("Unispace", (10 + xMod / (600 / 10)), System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        }

        private void prefMenuLbl_MouseLeave(object sender, EventArgs e)
        {
            int xMod = ClientSize.Width - 600;
            prefMenuLbl.Font = new System.Drawing.Font("Unispace", (10 + xMod / (600 / 10)), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        }
        //game events
        private void gameTmr_Tick(object sender, EventArgs e)
        {
            time += 1;
            if (play == false)
            {
                if (time == 5)
                {
                    gamePnl.Visible = false;
                    letters.Clear();
                    time = 0;
                    imageTmr.Stop();
                    cycle = 1;
                    hangManPic.Image = global::HangMan.Properties.Resources.Strike0;
                    guessTxt.Text = null;
                    strike = 0;
                    guessedLetters.Clear();
                    guessedWords.Clear();
                    letterListbx.DataSource = null;
                    wordListbx.DataSource = null;
                    gameTmr.Stop();
                }
            }
            else
            {
                if (time == 60)
                {
                    minute += 1;
                    time = 0;
                }
                if (time < 10)
                {
                    timeLbl.Text = Convert.ToString(minute) + ":0" + Convert.ToString(time);
                }

                else
                {
                    timeLbl.Text = Convert.ToString(minute) + ":" + Convert.ToString(time);
                }
                timeLbl.Location = new System.Drawing.Point(ClientSize.Width - (timeLbl.Width + 10), ClientSize.Height - (timeLbl.Height + 10));
            }
        }
        //eventually will be a menu hub
        private void HangMan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (play)
            {
                if (e.KeyChar == 27)
                {
                    gamePnl.Visible = false;
                    gameTmr.Stop();
                }
            }
            //Will eventually prompt to exit program
            else
            {

            }
        }

        private void guessTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (!hold)
                {
                    int complete = 0;
                    int count;
                    string guess = guessTxt.Text.Trim().ToUpper();

                    if (guess.Length == 1)
                    {
                        if (guessedLetters.Contains(guess))
                        {
                            hold = true;
                            guessTxt.Text = "Guessed Already";
                            guessTmr.Start();
                        }
                        else
                        {
                            if (word.Contains(guess))
                            {
                                letters.Add(guess);
                                count = word.Length;
                                gameWordLbl.Text = "";
                                for (int i = 0; i < count; i++)
                                {
                                    if (guess == Convert.ToString(word[i]))
                                    {
                                        letters[i] = guess;
                                    }
                                    if (letters[i] == Convert.ToString(word[i]))
                                    {
                                        gameWordLbl.Text += letters[i] + " ";
                                        complete += 1;
                                    }
                                    else
                                    {
                                        gameWordLbl.Text += "_ ";
                                    }
                                }
                                if (complete == word.Length)
                                {
                                    guessTxt.Text = "Finished";
                                    time = 0;
                                    play = false;
                                }
                                //refresh listbx
                                guessedLetters.Add(guess);
                                letterListbx.DataSource = null;
                                letterListbx.DataSource = guessedLetters;
                                guessTxt.Text = null;
                            }
                            else
                            {
                                guessedLetters.Add(guess);
                                letterListbx.DataSource = null;
                                letterListbx.DataSource = guessedLetters;
                                guessTxt.Text = null;
                                strike += 1;
                                imageTmr.Start();
                                strikeLbl.Text = "Strikes:" + strike;
                            }
                        }
                    }
                    else
                    {
                        if (guessedWords.Contains(guess))
                        {
                            hold = true;
                            guessTxt.Text = "Guessed Already";
                            guessTmr.Start();
                        }
                        else
                        {
                            if (guess == word)
                            {
                                gameWordLbl.Text = "";
                                count = word.Length;
                                for (int i = 0; i < count; i++)
                                {
                                    gameWordLbl.Text += word[i] + " ";
                                }
                                guessTxt.Text = "Finished";
                                time = 0;
                                play = false;
                            }
                            else
                            {
                                guessedWords.Add(guess);
                                wordListbx.DataSource = null;
                                wordListbx.DataSource = guessedWords;
                                guessTxt.Text = null;
                                strike += 1;
                                imageTmr.Start();
                                strikeLbl.Text = "Strikes:" + strike;
                            }
                        }
                    }
                    if (strike == 3)
                    {
                        guessTxt.Text = "Failure";
                        time = 0;
                        play = false;
                    }
                }
            }
        }

        private void guessTmr_Tick(object sender, EventArgs e)
        {
            hold = false;
            guessTxt.Text = null;
            guessTmr.Stop();
        }

        private void imageTmr_Tick(object sender, EventArgs e)
        {

            if (strike == 1)
            {
                switch (cycle)
                {
                    case 1:
                        hangManPic.Image = global::HangMan.Properties.Resources.Hangman_Strike1_Seq0001;
                        break;
                    case 2:
                        hangManPic.Image = global::HangMan.Properties.Resources.Hangman_Strike1_Seq0002;
                        break;
                    case 3:
                        hangManPic.Image = global::HangMan.Properties.Resources.Hangman_Strike1_Seq0003;
                        break;
                    case 4:
                        hangManPic.Image = global::HangMan.Properties.Resources.Hangman_Strike1_Seq0004;
                        break;
                    case 5:
                        hangManPic.Image = global::HangMan.Properties.Resources.Hangman_Strike1_Seq0005;
                        break;
                    case 6:
                        hangManPic.Image = global::HangMan.Properties.Resources.Hangman_Strike1_Seq0006;
                        break;
                    case 7:
                        hangManPic.Image = global::HangMan.Properties.Resources.Hangman_Strike1_Seq0007;
                        break;
                    case 8:
                        hangManPic.Image = global::HangMan.Properties.Resources.Hangman_Strike1_Seq0008;
                        break;
                    case 9:
                        hangManPic.Image = global::HangMan.Properties.Resources.Hangman_Strike1_Seq0009;
                        break;
                    case 10:
                        hangManPic.Image = global::HangMan.Properties.Resources.Hangman_Strike1_Seq0010;
                        break;
                    case 11:
                        hangManPic.Image = global::HangMan.Properties.Resources.Hangman_Strike1_Seq0011;
                        break;
                    case 12:
                        hangManPic.Image = global::HangMan.Properties.Resources.Hangman_Strike1_Seq0012;
                        break;
                    case 13:
                        hangManPic.Image = global::HangMan.Properties.Resources.Hangman_Strike1_Seq0013;
                        break;
                    case 14:
                        hangManPic.Image = global::HangMan.Properties.Resources.Hangman_Strike1_Seq0014;
                        cycle = 0;
                        break;

                }
            }
            else if (strike == 2)
            {
                switch (cycle)
                {
                    case 1:
                        hangManPic.Image = global::HangMan.Properties.Resources.Strike_20001;
                        break;
                    case 2:
                        hangManPic.Image = global::HangMan.Properties.Resources.Strike_20002;
                        break;
                    case 3:
                        hangManPic.Image = global::HangMan.Properties.Resources.Strike_20003;
                        break;
                    case 4:
                        hangManPic.Image = global::HangMan.Properties.Resources.Strike_20004;
                        break;
                    case 5:
                        hangManPic.Image = global::HangMan.Properties.Resources.Strike_20005;
                        break;
                    case 6:
                        hangManPic.Image = global::HangMan.Properties.Resources.Strike_20006;
                        break;
                    case 7:
                        hangManPic.Image = global::HangMan.Properties.Resources.Strike_20007;
                        break;
                    case 8:
                        hangManPic.Image = global::HangMan.Properties.Resources.Strike_20008;
                        break;
                    case 9:
                        hangManPic.Image = global::HangMan.Properties.Resources.Strike_20009;
                        break;
                    case 10:
                        hangManPic.Image = global::HangMan.Properties.Resources.Strike_20010;
                        break;
                    case 11:
                        hangManPic.Image = global::HangMan.Properties.Resources.Strike_20011;
                        break;
                    case 12:
                        hangManPic.Image = global::HangMan.Properties.Resources.Strike_20012;
                        break;
                    case 13:
                        hangManPic.Image = global::HangMan.Properties.Resources.Strike_20013;
                        break;
                    case 14:
                        hangManPic.Image = global::HangMan.Properties.Resources.Strike_20014;
                        cycle = 0;
                        break;
                }

            }
            else if (strike == 3)
            {
                switch (cycle)
                {
                    case 1:
                        hangManPic.Image = global::HangMan.Properties.Resources.Strike_30001;
                        break;
                    case 2:
                        hangManPic.Image = global::HangMan.Properties.Resources.Strike_30002;
                        break;
                    case 3:
                        hangManPic.Image = global::HangMan.Properties.Resources.Strike_30003;
                        break;
                    case 4:
                        hangManPic.Image = global::HangMan.Properties.Resources.Strike_30004;
                        break;
                    case 5:
                        hangManPic.Image = global::HangMan.Properties.Resources.Strike_30005;
                        break;
                    case 6:
                        hangManPic.Image = global::HangMan.Properties.Resources.Strike_30006;
                        break;
                    case 7:
                        hangManPic.Image = global::HangMan.Properties.Resources.Strike_30007;
                        break;
                    case 8:
                        hangManPic.Image = global::HangMan.Properties.Resources.Strike_30008;
                        break;
                    case 9:
                        hangManPic.Image = global::HangMan.Properties.Resources.Strike_30009;
                        break;
                    case 10:
                        hangManPic.Image = global::HangMan.Properties.Resources.Strike_30010;
                        break;
                    case 11:
                        hangManPic.Image = global::HangMan.Properties.Resources.Strike_30011;
                        break;
                    case 12:
                        hangManPic.Image = global::HangMan.Properties.Resources.Strike_30012;
                        break;
                    case 13:
                        hangManPic.Image = global::HangMan.Properties.Resources.Strike_30013;
                        break;
                    case 14:
                        hangManPic.Image = global::HangMan.Properties.Resources.Strike_30014;
                        cycle = 0;
                        break;
                }
            }
            cycle += 1;
        }
    }
}
