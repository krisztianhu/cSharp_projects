using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Typing_Game
{
    public partial class Form1 : Form
    {
        //szavak amelyek mközül választunk egyet és kisorsoljuk majd
        //string tipusu tomb, feltoltott ertekekkel
        string[] words = { "szia", "megint szia", "nézz körbe még", "gyakorolj" };

        //letrehoztunk egy rabdom valtotzoz
        Random rnd = new Random();

        //ket valtozott hoztunk letre aminek erteket adtunk
        int correct = 0; int incorrect = 0;


        public Form1()
        {
            InitializeComponent();
            
            //labelbe kisorsoltunk egy random szot a words tombbol
            wordLbl.Text = words[rnd.Next(0, words.Length)];
        }

        private void checkGame(object sender, KeyEventArgs e)
        {
            //ha entert nyomunk belep a feltetelbe
            if(e.KeyCode == Keys.Enter)
            {
                //ha beirt szoveg pontosan megegyezik a labelbe kisorsolt szoveggel akkor belep
                if(textBox1.Text == wordLbl.Text)
                {
                    correct++; //valtozo erteket noveljuk eggyel
                    textBox1.Text = null;//törli a textboc tartalmat
                    wordLbl.Text = words[rnd.Next(0, words.Length)];//labelbe kisorsoltunk egy random szot a words tombbol
                }
                else
                {
                    incorrect++;//valtozo erteket noveljuk eggyel
                    textBox1.Text = null; //törli a textboc tartalmat
                    wordLbl.Text = words[rnd.Next(0, words.Length)];//labelbe kisorsoltunk egy random szot a words tombbol
                }
                correctLbl.Text = "Correct : " + correct; //kiirjuk a labelbe a Correct szot és hozzáfűzzük a correct valtozo erteket
                incorrectLbl.Text = "Incorrect : " + incorrect;//kiirjuk a labelbe a Incorrect szot és hozzáfűzzük a incorrect valtozo erteket
            }
        }
    }
}
