using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace simple_image_gallery
{
    public partial class Form1 : Form
    {

        int i = 1;

        public Form1()
        {
            InitializeComponent();
            changeImage(3);
        }

        private void goNext(object sender, EventArgs e)
        {
            i++;
            if(i>5)
            {
                i = 1;
            }
            changeImage(i);
        }

        private void goBack(object sender, EventArgs e)
        {
            i--;
            if (i < 1)
            {
                i = 5;
            }
            changeImage(i);

        }
        private void changeImage(int num)
        {
            switch(num)
            {
                case 1:
                    pictureBox1.Image = Properties.Resources._1;
                    break;
                case 2:
                    pictureBox1.Image = Properties.Resources._2;
                    break;
                case 3:
                    pictureBox1.Image = Properties.Resources._3;
                    break;
                case 4:
                    pictureBox1.Image = Properties.Resources._4;
                    break;
                case 5:
                    pictureBox1.Image = Properties.Resources._5;
                    break;

            }

        }

    }
}
