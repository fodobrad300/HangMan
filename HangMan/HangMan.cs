﻿using System;
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
        int minute = 0;
        int strike = 0;
        string word;
        List<string> words = new List<string>() { "BRADY", "COMPUTER", "ALDWORTH"};
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

            guessLbl.Font = new System.Drawing.Font("Unispace", (14 + xMod / (600 / 16)), System.Drawing.FontStyle.Bold);
            guessLbl.Location = new System.Drawing.Point(ClientSize.Width - 2 * letterListbx.Width - 20, hangManPic.Height + 10);

            guessTxt.Size = new System.Drawing.Size(153 + xMod / (600 / 153), 23 + yMod / (390 / 23));
            guessTxt.Font = new System.Drawing.Font("Unispace", (10 + xMod / (600 / 16)), System.Drawing.FontStyle.Bold);
            guessTxt.Location = new System.Drawing.Point(guessLbl.Location.X, guessLbl.Location.Y + guessLbl.Height + 10);

            wordLbl.Font = new System.Drawing.Font("Unispace", (20 + xMod / (600 / 16)), System.Drawing.FontStyle.Bold);
            wordLbl.Location = new System.Drawing.Point(50, hangManPic.Height + 50);

            gameWordLbl.Font = new System.Drawing.Font("Unispace", (18 + xMod / (600 / 16)), System.Drawing.FontStyle.Bold);
            gameWordLbl.Location = new System.Drawing.Point(wordLbl.Location.X, wordLbl.Location.Y + 30);

            strikeLbl.Font = new System.Drawing.Font("Unispace", (14 + xMod / (600 / 16)), System.Drawing.FontStyle.Bold);
            strikeLbl.Location = new System.Drawing.Point(guessLbl.Location.X, guessTxt.Location.Y + guessTxt.Height + 20);
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
            guessTxt.Font = new System.Drawing.Font("Unispace", (10 + xMod / (600 / 16)), System.Drawing.FontStyle.Bold);
            guessTxt.Location = new System.Drawing.Point(guessLbl.Location.X, guessLbl.Location.Y + guessLbl.Height + 10);

            wordLbl.Font = new System.Drawing.Font("Unispace", (20 + xMod / (600 / 16)), System.Drawing.FontStyle.Bold);
            wordLbl.Location = new System.Drawing.Point(50, hangManPic.Height + 50);

            gameWordLbl.Font = new System.Drawing.Font("Unispace", (18 + xMod / (600 / 16)), System.Drawing.FontStyle.Bold);
            gameWordLbl.Location = new System.Drawing.Point(wordLbl.Location.X, wordLbl.Location.Y + 50);

            strikeLbl.Font = new System.Drawing.Font("Unispace", (14 + xMod / (600 / 16)), System.Drawing.FontStyle.Bold);
            strikeLbl.Location = new System.Drawing.Point(guessLbl.Location.X, guessTxt.Location.Y + guessTxt.Height + 20);
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
            word = words[generator.Next(0, 3)];
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
    }
}
