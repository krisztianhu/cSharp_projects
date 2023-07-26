using System;
using System.Windows.Forms;

namespace flappy_bird
{
    public partial class Form1 : Form
    {
        int pipeSpeed = 8;
        int gravity = 3;
        int score = 0;

        public Form1()
        {
            InitializeComponent();
        }


        private void gameTimerEvent(object sender, EventArgs e)
        {
            flappyBird.Top += gravity;
            pipeBottom.Left -= pipeSpeed;
            pipeTop.Left -= pipeSpeed;
            scoreTxt.Text = score.ToString("Score: " + score);

            //ha a pipeBottom x koordinátájánál a -150 nagyobb akkor újra elhelyezi a képernyőn és növeli a score pontot 
            if (pipeBottom.Left < 0)
            {
                pipeBottom.Left = 439;
                score++;
            }

            //ha a pipeBottom x koordinátájánál a -180 nagyobb akkor újra elhelyezi a képernyőn és növeli a score pontot 
            if (pipeTop.Left < 0)
            {
                pipeTop.Left = 638;
                score++;
            }
            
            //ha hozzáér a pipe-khoz vag a földhöz gameover
            if (flappyBird.Bounds.IntersectsWith(pipeBottom.Bounds)
                || flappyBird.Bounds.IntersectsWith(pipeTop.Bounds)
                || flappyBird.Bounds.IntersectsWith(ground.Bounds))
            {
                endGame();
            }
            //ha a feltétel igeaz gyorsabb lesz
            if(score > 5)
            {
                pipeSpeed = 15;
            }
            //ha a tetejéhez ér gameover
            if(flappyBird.Top < - 25)
            {
                endGame();
            }
        }

        private void gameKeyIsDown(object sender, KeyEventArgs e)
        {
            /*
             * ha érzékeli a Form a Space gomb lenyomását akkor a flappyBird.Top += gravity;-hez képest, tehát az y koordinátán mozgatva 
               felfele fog mozogni mert levon -15-öt   
             */
            if (e.KeyCode == Keys.Space)
            {
                gravity = -15;
            }
        }
        /*
             * ha érzékeli a Form a Space gomb lenyomását akkor a flappyBird.Top += gravity;-hez képest, tehát az y koordinátán mozgatva 
               lefele fog mozogni mert hozzáad 15-öt   
             */
        private void gameKeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 15;
            }
        }
        //ha meghivjuk ezt akkor leáll a számláló(timer), eltünik a Score számláló és a kiirja a label ezt a szöveget
        private void endGame()
        {
            gameTimer.Stop();        
           scoreTxt.Text += $"\n GAME OVER!!!";
        }

    }  
}
