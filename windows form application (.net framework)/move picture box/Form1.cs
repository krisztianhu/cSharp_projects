using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace move_picture_box
{
    public partial class Form1 : Form
    {

        bool moveRight, moveLeft, moveUp, moveDown;

        int speed = 12;

        public Form1()
        {
            InitializeComponent();
        }

        private void moveTimerEnter(object sender, EventArgs e)
        {
            if(moveLeft == true && pictureBox1.Left > 0)
            {
                pictureBox1.Left -= speed; 
            }
            if(moveRight == true && pictureBox1.Left < 700)
            {
                pictureBox1.Left += speed;
            }
            if(moveUp == true && pictureBox1.Top > 0)
            {
                pictureBox1.Top -= speed;
            }
            if (moveDown == true && pictureBox1.Top < 355)
            {
                pictureBox1.Top += speed;
            }
        }

        private void keyIsDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Left)
            {
                moveLeft = true;
            }
            if(e.KeyCode == Keys.Right)
            {
                moveRight = true;
            }
            if(e.KeyCode == Keys.Down)
            {
                moveDown = true;
            }
            if(e.KeyCode == Keys.Up)
            {
                moveUp = true;
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
            if (e.KeyCode == Keys.Down)
            {
                moveDown = false;
            }
            if (e.KeyCode == Keys.Up)
            {
                moveUp = false;
            }
        }
    }
}
