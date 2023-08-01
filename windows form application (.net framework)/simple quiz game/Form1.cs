using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace simple_quiz_game
{
    public partial class Form1 : Form
    {

        int correctAnswer, score, questionNumber = 1, percentage, totalQuestions;

        public Form1()
        {
            InitializeComponent();

            askQuestion(questionNumber);

            totalQuestions = 5;
        }

        private void checkAnswerEvent(object sender, EventArgs e)
        {

            var senderObject = (Button)sender;

            int buttonTag = Convert.ToInt32(senderObject.Tag);

            if(buttonTag == correctAnswer)
            {
                score++;
            }

            if(questionNumber == totalQuestions)
            {
                //%-k számitás

                /*
                 valós számá alakitjuk ideiglenesen a score változót és * 100-al utána elosztjuk az összes kérdés darabszámával
                ezután vissza konvertáljuk egész tipusu számá
                amit a percentage változóba eltárolunk el
                 */
                percentage = (int)Math.Round((double)(score * 100) / totalQuestions);

                //feldob egy megjelenő üzenetet, amikor eléri a questionNumber értéke a questionNumber összes kérdés darabszámát
                MessageBox.Show(
                    //karakterlác összefüzések 
                    //a Environment.NewLine új sort nyit a megjelenő üzeneten
                    "Quiz Ended!" + Environment.NewLine + "\nYou have answered " + score + " question correctly." +
                    Environment.NewLine + "Your total percentage is " + percentage + "%" + Environment.NewLine +
                    "Click OK to play again"
                    );

                //ezeket lenullázuk, hogy ha még egy kört karunk játszani, akkor ne folytassan az előző értékekkel
                score = 0;
                questionNumber = 0;
                askQuestion(questionNumber);
            }

                questionNumber++;
                askQuestion(questionNumber);
        }

        private void askQuestion(int qnum)
        {
            switch(qnum)
            {
                case 1:
                    pictureBox1.Image = Properties.Resources.questionImg;

                    questionLbl.Text = "What is the colour of the sky?";

                    button1.Text = "Blue";
                    button2.Text = "Yellow";
                    button3.Text = "Orange";
                    button4.Text = "Nincs";

                    correctAnswer = 1;

                    break;

                case 2:
                    pictureBox1.Image = Properties.Resources._3;

                    questionLbl.Text = "What is the number of the Image?";

                    button1.Text = "Egy";
                    button2.Text = "два";
                    button3.Text = "ثلاثة";
                    button4.Text = "quattro";

                    correctAnswer = 3;

                    break;

                case 3:
                    pictureBox1.Image = Properties.Resources._2;

                    questionLbl.Text = "What number do you see?";

                    button1.Text = "1";
                    button2.Text = "2";
                    button3.Text = "3";
                    button4.Text = "4";

                    correctAnswer = 2;

                    break;

                case 4:
                    pictureBox1.Image = Properties.Resources._4;

                    questionLbl.Text = "mi ez a Szyyám?";

                    button1.Text = "1";
                    button2.Text = "2";
                    button3.Text = "3";
                    button4.Text = "4";

                    correctAnswer = 4;

                    break;

                case 5:
                    pictureBox1.Image = Properties.Resources._5;

                    questionLbl.Text = "mi ez a Szyyám?";

                    button1.Text = "1";
                    button2.Text = "5";
                    button3.Text = "3";
                    button4.Text = "4";

                    correctAnswer = 2;

                    break;
            }
        }
    }
}
