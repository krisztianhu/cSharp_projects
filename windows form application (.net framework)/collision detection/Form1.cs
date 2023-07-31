using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace collision_detection
{
    public partial class Form1 : Form
    {

        bool moveLeft, moveRight, moveUp, moveDown;
        int speed = 7;

        public Form1()
        {
            InitializeComponent();
        }

        private void mainTimerEvent(object sender, EventArgs e)
        {
            if (moveLeft == true && player.Left > 0)
            {
                player.Left -= speed;
            }
            if (moveRight == true && player.Left < 700)
            {
                player.Left += speed;
            }
            if (moveUp == true && player.Top > 0)
            {
                player.Top -= speed;
            }
            if (moveDown == true && player.Top < 351)
            {
                player.Top += speed;
            }

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "objects")
                {
                    if (player.Bounds.IntersectsWith(x.Bounds))
                    {
                        x.BackColor = Color.Red;
                        label1.Text = "You Hit With\n" + x.Name;
                    }
                    else
                    {
                        x.BackColor = Color.DarkBlue;
                        label1.Text = "You Hit With";
                    }
                }
            }
        }

        private void keyIsDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Left)
            {
                moveLeft = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                moveRight = true;
            }
            if (e.KeyCode == Keys.Up)
            {
                moveUp = true;
            }
            if (e.KeyCode == Keys.Down)
            {
                moveDown = true;
            }
        }

        private void keyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                moveLeft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                moveRight = false;
            }
            if (e.KeyCode == Keys.Up)
            {
                moveUp = false;
            }
            if (e.KeyCode == Keys.Down)
            {
                moveDown = false;
            }
        }
    }
}
