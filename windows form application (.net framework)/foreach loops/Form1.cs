using System.Drawing;
using System.Windows.Forms;

namespace foreach_loops
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //függvény hivás
            runLoop();
        }

        public void runLoop()
        {
            //végig megy a Controlsokon az x változóval
            foreach(Control x in this.Controls)
            {
                //x.BackColor = Color.Red;

                //ha x változó ami végig megy a Form-ra helyezett Controlsokon Button, akkor:
                if(x is Button) 
                {
                    //az x, vagyis az aktuálisan vizsgált Controls-nak a hátérszine legyen fekete
                    x.BackColor = Color.Black;
                    //az x, vagyis az aktuálisan vizsgált Controls-nak a betűszine legyen fehér
                    x.ForeColor = Color.White;
                }

                //ha x változó ami végig megy a Form-ra helyezett Controls-okon label, akkor:
                if (x is Label)
                {
                    //az x, vagyis az aktuálisan vizsgált Controls-nak a betűszine legyen lila
                    x.ForeColor = Color.Purple;
                }

                //ha x változó ami végig megy a Form-ra helyezett Controls-okon PictureBox, akkor:
                if (x is PictureBox)
                {
                    //az x, vagyis az aktuálisan vizsgált Controls-nak a hátérszine legyen szilva szinű
                    x.BackColor = Color.Plum;
                }

                //ha x változó ami végig megy a Form-ra helyezett Controls-okon PictureBox, és az Tag-ja szövege pontosan megegyezik a "group1"-el akkor:
                if (x is PictureBox && (string)x.Tag == "group1")
                {
                    //az x, vagyis az aktuálisan vizsgált Controls-nak a hátérszine legyen szilva szinű
                    x.BackColor = Color.Plum;
                }

                //ha x változó ami végig megy a Form-ra helyezett Controls-okon PictureBox, és az Tag-ja szövege pontosan megegyezik a "group2"-el akkor:
                if (x is PictureBox && (string)x.Tag == "group2")
                {
                    //az x, vagyis az aktuálisan vizsgált Controls-nak a hátérszine legyen gesztenyebarna szinű
                    x.BackColor = Color.Maroon;
                }


            }
        }

    }
}
