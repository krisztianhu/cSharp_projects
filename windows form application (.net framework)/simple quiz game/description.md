# Simple Quiz Game

- a Form-ot nevezz�k �t Simple Quiz Game, ezt a Form-ra kattintva Properities Text-n�l tehetj�k meg
- huzzunk a Form-ra egy label-t �s egy PictureBox-ot
- katt Form Toolbox ...
- �llitsuk be a m�reteket:
- Form Properities Size 500; 700
- PictureBox Properities Size 460; 200
- label Properities Size: AutoSize False �s Size 460; 100 tov�bb� Design name-je questionLbl tov�bb Text Question tov�bb TextAlign MiddleCenter v�g�l Font form�z�sokat is csin�ljunk
- sz�ks�g van n�gy darab Button-ra, latt a Form Toolbox �s keress�k meg a button-t
- a Size tulajdons�ga legyen 210; 100 
- n�zd meg a minta k�pet
- katt 1x jobbal a PictureBox-ra Choose Image ut�na Project Resource file ut�na Import
- �s egy l�trehozott Resources mapp�ba hozzunk l�tre k�peket 1-5-ig,
- m�soljuk be ide �s majd jel�lj�k ki egyszere az �sszeset �s Megnyit�s
- PictureBox SizeMode CenterScreen
- a button-nak a Tag tulajdons�gait �llitsuk be
- els� button-nak a Tag-je legyen 1, m�sodiknak 2, ...
- jel�lj�k ki egyszerre az �sszes button-t majd menj�nk az Event-re
- Click esem�ny, nevezz�k el checkAnswerEvent �s Enter
- megjelenik a k�d n�zett a l�trehozott f�ggv�ny block al� hozzunk l�tre 
- egy m�sik f�ggv�nyt
- private void askQuestion(int qnum)
        {
    
        }
- ha ez k�sz kell n�h�ny v�ltoz�- 
- int correctQuestion, score, questionNumber = 1, oercentage, totalQuestions;
- ezut�n menj�nk vissza az �ltalunk l�trehozott f�ggv�nyhez
- 
-  private void askQuestion(int qnum)
        {
            switch(qnum)
            {
                // els� eset
                case 1:
                    // a pictureboxunk k�pe legyen a tulajdons�g resourcesb�l a questionImg nev� k�p
                    pictureBox1.Image = Properties.Resources.questionImg; 

                    //a label szt�vege legyen az = ut�ni sz�veg
                    questionLbl.Text = "What is the colour of the sky?";

                    //gomb feliratok
                    button1.Text = "Blue";
                    button2.Text = "Yellow";
                    button3.Text = "Orange";
                    button4.Text = "Nincs";

                    //helyes v�lasz sz�ma
                    correctAnswer = 1;

                    //kil�p
                    break;
                // m�sodik eset
                case 2:

- ha v�gezt�nk a k�rd�sek l�trehoz�s�val menj�nk vissza a Form k�dj�hoz �s hivjuk meg a f�ggv�ny�nket
- sz�ks�ge lesz egy sz�m param�tere, ami a case ben leirt k�rd�seket fogja meghivni
-  public Form1()
        {
            InitializeComponent();

             //a megjelen� k�rd�s sz�ma, ez majd automatikusan n�vekv� lesz
             askQuestion(questionNumber);

            //�sszes k�rd�s darab sz�ma, ez att�l f�gg mennyi k�rd�st hoztunk l�tre a case-ban
            totalQuestions = 5;
        }
- tov�bb�
- private void checkAnswerEvent(object sender, EventArgs e)
        {
            //a r�kattintott gomb adatait menti
            var senderObject = (Button)sender;

            //let�roljuk a vizsg�lt gomb eg�sz sz�m tipusuv� konvert�lt gomb Tag tulajdons�g�t
            int buttonTag = Convert.ToInt32(senderObject.Tag);

            //ha a, gomb Tag tulajdons�g pontosan megegyezik a case-ban l�trehozott k�rd�s helyes v�lasz�nak a sz�m�val,
            //akkor, n�veli a helyes v�laszok sz�m�t 1-el �s 
            if(buttonTag == correctAnswer)
            {
                score++;
            }
             if(questionNumber == totalQuestions)
            {
                //%-k sz�mit�s

                /*
                 val�s sz�m� alakitjuk ideiglenesen a score v�ltoz�t �s * 100-al ut�na elosztjuk az �sszes k�rd�s darabsz�m�val
                ezut�n vissza konvert�ljuk eg�sz tipusu sz�m�
                amit a percentage v�ltoz�ba elt�rolunk el
                 */
                percentage = (int)Math.Round((double)(score * 100) / totalQuestions);

                //feldob egy megjelen� �zenetet, amikor el�ri a questionNumber �rt�ke a questionNumber �sszes k�rd�s darabsz�m�t
                MessageBox.Show(
                    //karakterl�c �sszef�z�sek 
                    //a Environment.NewLine �j sort nyit a megjelen� �zeneten
                    "Quiz Ended!" + Environment.NewLine + "\nYou have answered " + score + " question correctly." +
                    Environment.NewLine + "Your total percentage is " + percentage + "%" + Environment.NewLine +
                    "Click OK to play again"
                    );

                //ezeket lenull�zuk, hogy ha m�g egy k�rt karunk j�tszani, akkor ne folytassan az el�z� �rt�kekkel
                score = 0;
                questionNumber = 0;
                askQuestion(questionNumber);
            }

                questionNumber++;
                askQuestion(questionNumber);





