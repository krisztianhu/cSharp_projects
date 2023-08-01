# Simple Quiz Game

- a Form-ot nevezzük át Simple Quiz Game, ezt a Form-ra kattintva Properities Text-nél tehetjük meg
- huzzunk a Form-ra egy label-t és egy PictureBox-ot
- katt Form Toolbox ...
- állitsuk be a méreteket:
- Form Properities Size 500; 700
- PictureBox Properities Size 460; 200
- label Properities Size: AutoSize False és Size 460; 100 továbbá Design name-je questionLbl tovább Text Question tovább TextAlign MiddleCenter végül Font formázásokat is csináljunk
- szükség van négy darab Button-ra, latt a Form Toolbox és keressük meg a button-t
- a Size tulajdonsága legyen 210; 100 
- nézd meg a minta képet
- katt 1x jobbal a PictureBox-ra Choose Image utána Project Resource file utána Import
- és egy létrehozott Resources mappába hozzunk létre képeket 1-5-ig,
- másoljuk be ide és majd jelöljük ki egyszere az összeset és Megnyitás
- PictureBox SizeMode CenterScreen
- a button-nak a Tag tulajdonságait állitsuk be
- elsõ button-nak a Tag-je legyen 1, másodiknak 2, ...
- jelöljük ki egyszerre az összes button-t majd menjünk az Event-re
- Click esemény, nevezzük el checkAnswerEvent és Enter
- megjelenik a kód nézett a létrehozott függvény block alá hozzunk létre 
- egy másik függvényt
- private void askQuestion(int qnum)
        {
    
        }
- ha ez kész kell néhány változó- 
- int correctQuestion, score, questionNumber = 1, oercentage, totalQuestions;
- ezután menjünk vissza az általunk létrehozott függvényhez
- 
-  private void askQuestion(int qnum)
        {
            switch(qnum)
            {
                // elsõ eset
                case 1:
                    // a pictureboxunk képe legyen a tulajdonság resourcesbõl a questionImg nevû kép
                    pictureBox1.Image = Properties.Resources.questionImg; 

                    //a label sztövege legyen az = utáni szöveg
                    questionLbl.Text = "What is the colour of the sky?";

                    //gomb feliratok
                    button1.Text = "Blue";
                    button2.Text = "Yellow";
                    button3.Text = "Orange";
                    button4.Text = "Nincs";

                    //helyes válasz száma
                    correctAnswer = 1;

                    //kilép
                    break;
                // második eset
                case 2:

- ha végeztünk a kérdések létrehozásával menjünk vissza a Form kódjához és hivjuk meg a függvényünket
- szóksége lesz egy szám paramétere, ami a case ben leirt kérdéseket fogja meghivni
-  public Form1()
        {
            InitializeComponent();

             //a megjelenõ kérdés száma, ez majd automatikusan növekvõ lesz
             askQuestion(questionNumber);

            //összes kérdés darab száma, ez attól függ mennyi kérdést hoztunk létre a case-ban
            totalQuestions = 5;
        }
- továbbá
- private void checkAnswerEvent(object sender, EventArgs e)
        {
            //a rákattintott gomb adatait menti
            var senderObject = (Button)sender;

            //letároljuk a vizsgált gomb egész szám tipusuvá konvertált gomb Tag tulajdonságát
            int buttonTag = Convert.ToInt32(senderObject.Tag);

            //ha a, gomb Tag tulajdonság pontosan megegyezik a case-ban létrehozott kérdés helyes válaszának a számával,
            //akkor, növeli a helyes válaszok számát 1-el és 
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

                //feldob egy megjelenõ üzenetet, amikor eléri a questionNumber értéke a questionNumber összes kérdés darabszámát
                MessageBox.Show(
                    //karakterlác összefüzések 
                    //a Environment.NewLine új sort nyit a megjelenõ üzeneten
                    "Quiz Ended!" + Environment.NewLine + "\nYou have answered " + score + " question correctly." +
                    Environment.NewLine + "Your total percentage is " + percentage + "%" + Environment.NewLine +
                    "Click OK to play again"
                    );

                //ezeket lenullázuk, hogy ha még egy kört karunk játszani, akkor ne folytassan az elõzõ értékekkel
                score = 0;
                questionNumber = 0;
                askQuestion(questionNumber);
            }

                questionNumber++;
                askQuestion(questionNumber);





