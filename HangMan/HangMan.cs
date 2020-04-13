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
        

        public HangMan()
        {
            InitializeComponent();
        }
        //form related events
        private void HangMan_Load(object sender, EventArgs e)
        {
            int xMod = ClientSize.Width - 600;
            int yMod = ClientSize.Height - 390;
            
            
            //titleLbl.Text = Convert.ToString(ClientSize.Width) + ", " + Convert.ToString(ClientSize.Height);
            
            prefBtn.Size = new System.Drawing.Size(125 + xMod / (600 / 125), 29 + yMod / (390 / 29));
            prefBtn.Location = new System.Drawing.Point((ClientSize.Width / 2-prefBtn.Width/2), (ClientSize.Height / 2-prefBtn.Height/2)+70);

            playBtn.Size = new System.Drawing.Size(125 + xMod / (600 / 125), 29 + yMod / (390 / 29));
            playBtn.Location = new System.Drawing.Point((ClientSize.Width / 2 - playBtn.Width / 2), (ClientSize.Height / 2 + playBtn.Height / 2) + 80);

            titleLbl.Font = new System.Drawing.Font("Unispace", (16 + xMod/(600/16)), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            titleLbl.Location = new System.Drawing.Point((ClientSize.Width / 2 - titleLbl.Width / 2), ClientSize.Height/10);

            prefPnl.Location = new System.Drawing.Point(0, ClientSize.Height / 5);
            prefPnl.Size = new System.Drawing.Size(ClientSize.Width, ClientSize.Height-prefPnl.Location.Y);
            
            gamePnl.Location = new System.Drawing.Point(0, 0);
            gamePnl.Size = new System.Drawing.Size(ClientSize.Width, ClientSize.Height);

            letterListbx.Size = new System.Drawing.Size(178+xMod/(600/178), 165+yMod/(390/165));
            letterListbx.Location = new System.Drawing.Point(ClientSize.Width - letterListbx.Width - 10, ClientSize.Height / 10);
           
            wordListbx.Location = new System.Drawing.Point(ClientSize.Width - (2 * letterListbx.Width) - 20, ClientSize.Height / 10);
           
            guessLetterLbl.Location = new System.Drawing.Point(ClientSize.Width - letterListbx.Width - 10, (ClientSize.Height / 10)-(guessLetterLbl.Height + 5));
            
            guessWordLbl.Location = new System.Drawing.Point(ClientSize.Width - 2 * letterListbx.Width - 20, (ClientSize.Height / 10) - (guessWordLbl.Height + 5));

            hangManPic.Size = new System.Drawing.Size(486+ xMod/(600/486), 298+ yMod/(390/298));
            hangManPic.Location = new System.Drawing.Point(ClientSize.Height/20, ClientSize.Height/20);

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
            
            prefMenuLbl.Font = prefMenuLbl.Font = new System.Drawing.Font("Unispace", (10 + xMod / (600 / 16)), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            prefPnl.Location = new System.Drawing.Point(0, ClientSize.Height / 5);
            prefPnl.Size = new System.Drawing.Size(ClientSize.Width, ClientSize.Height - prefPnl.Location.Y);
            gamePnl.Size = new System.Drawing.Size(ClientSize.Width, ClientSize.Height);
            
            letterListbx.Location = new System.Drawing.Point(ClientSize.Width - letterListbx.Width - 10, ClientSize.Height / 10);
            wordListbx.Location = new System.Drawing.Point(ClientSize.Width - (2*letterListbx.Width)-20, ClientSize.Height / 10);
            
            guessLetterLbl.Location = new System.Drawing.Point(ClientSize.Width - letterListbx.Width - 10, (ClientSize.Height / 10) - (guessLetterLbl.Height + 5));
            guessWordLbl.Location = new System.Drawing.Point(ClientSize.Width - 2*letterListbx.Width - 20, (ClientSize.Height / 10) - (guessWordLbl.Height + 5));
        }
        //menu events
        private void prefBtn_Click(object sender, EventArgs e)
        {
            prefPnl.Visible = true;
        }
        
        private void playBtn_Click(object sender, EventArgs e)
        {
            gamePnl.Visible = true;
            play = true;
        }

        private void prefMenuLbl_Click(object sender, EventArgs e)
        {
            prefPnl.Visible = false;
        }

        private void prefMenuLbl_MouseEnter(object sender, EventArgs e)
        {
            int xMod = ClientSize.Width - 600;
            prefMenuLbl.Font = new System.Drawing.Font("Unispace", (10 + xMod / (600 / 16)), System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        }

        private void prefMenuLbl_MouseLeave(object sender, EventArgs e)
        {
            int xMod = ClientSize.Width - 600;
            prefMenuLbl.Font = new System.Drawing.Font("Unispace", (10 + xMod / (600 / 16)), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        }
        //game events
        private void gameTmr_Tick(object sender, EventArgs e)
        {
           
        }
        //eventually will be a menu hub
        private void HangMan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (play)
            {
                if (e.KeyChar == 27)
                {
                    gamePnl.Visible = false;
                }
            }
            //will eventually prompt to exit program
            else
            {

            }
        }
    }
}
