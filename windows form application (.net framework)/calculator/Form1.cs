using System;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int num1;       // a müvelet előtti számok
        int num2;       // a müvelet utáni számok
        string option;  //a művelet jele
        int result;     //az eredmény

        private void btn1_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btn2.Text;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btn8.Text;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btn7.Text;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btn6.Text;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btn5.Text;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btn4.Text;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btn3.Text;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btn9.Text;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btn0.Text;
        }

        private void btnPlusz_Click(object sender, EventArgs e)
        {
            num1 = int.Parse(txtDisplay.Text);// a müvelet előtti számok
            option = "+";

            txtDisplay.Clear();
        }

        private void btnMinusz_Click(object sender, EventArgs e)
        {
            num1 = int.Parse(txtDisplay.Text);// a müvelet előtti számok
            option = "-";

            txtDisplay.Clear();
        }

        private void btnSzorzas_Click(object sender, EventArgs e)
        {
           // num1 = int.Parse(txtDisplay.Text);// a müvelet előtti számok
            option = "*";

            txtDisplay.Clear();
        }

        private void btnOsztas_Click(object sender, EventArgs e)
        {
            num1 = int.Parse(txtDisplay.Text);// a müvelet előtti számok
            option = "/";

            txtDisplay.Clear();
        }

        private void btnMaradekosOsztas_Click(object sender, EventArgs e)
        {
            num1 = int.Parse(txtDisplay.Text); // a müvelet előtti számok
            option = "%";

            txtDisplay.Clear();
        }

        private void btnEgyenlo_Click(object sender, EventArgs e)
        {
            num2 = int.Parse(txtDisplay.Text); // a müvelet utáni számok 

            if (option == ("+")) // ha + volt akkor összead
                result = num1 + num2;

            if (option.Equals("-")) // ha - volt akkor összead
                result = num1 - num2;

            if (option == ("*")) // ha * volt akkor összead
                result = num1 * num2;

            if (option == ("/")) // ha / volt akkor összead
                result = num1 / num2;

            if (option == ("%")) // ha % volt akkor összead
                result = num1 % num2;

            // felülirja a TextBox tartalmár az eredményre
            txtDisplay.Text = result + ""; 
        }

        private void btnTorles_Click(object sender, EventArgs e)
        {
            txtDisplay.Clear(); //törli a TextBox tartalmát
            result = (0);   // törli a változó tartalmát
            num1 = (0);     // törli a változó tartalmát
            num2 = (0);     // törli a változó tartalmát
        }

        private void btnZarojelNyito_Click(object sender, EventArgs e)
        {
            //num1 = int.Parse(txtDisplay.Text);// a müvelet előtti számok
            option = "(";

            txtDisplay.Clear();
        }

        private void btnZarojelZaro_Click(object sender, EventArgs e)
        {
            num1 = int.Parse(txtDisplay.Text);// a müvelet előtti számok
            option = ")";

            txtDisplay.Clear();
        }
    }
}