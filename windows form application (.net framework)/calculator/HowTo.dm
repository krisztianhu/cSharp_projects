#lépésrõl-lépésre

	Form-ra jobbb click Properities
	Text tulajdonságnál átirjuk a cimsort Calculatora

	Toolbox-ban keressük meg a TextBox-ot és tegyük a Form-ra
	a nyilacskára kattintva pipáljuk be a Multiline-t és igazitsuk

	Toolbox-ból huzzunk a Form-ra egy button-t, méretezzük és Text tulajdonságát irjuk át 1-re
	A button-ra kattintva a Properities-ben keressük meg a font tulajdonságot, majd katt a 3 pötyre
	formázzuk kedvünkre, majd a TextBox-ot is

	Csináljuk meg ugyanigy a 2-tõl 9-ig a gombokat csak copy-paste-teljünk.
	majd a C,(,),%,/,*,-,+,=,,,0-át.

	A Form-on a Properities-ben irjuk át a StartingPosition-t CenterScreen-re,
	hogy amikor fut a progi akkor középen jelenjen meg 

	Futtasuk a programot és nézzük meg hogy nagyából arányosak e a méretek egymáshoz képest

	A TextBox-ot nevezzük át txtDisplay-re
	A szám gombokat nevezzük át btn1, btn2 ... btn9 és btn0-ra
	majd btnOsztas, btnTorles, ...

	Dupla klikk a 1-es gombra, megjelenik a Form-nak a kódja.
	irjuk be a btn1_Click függvénybe a kódott:

	            txtDisplay.Text = txtDisplay.Text + btn1.Text;

	Ez a sor a txtDisplay vagyis a TextBox tartalmát egyenlõvé teszi
	a TextBox és a btn1 Text tulajdonságával, ahová 1-et irtunk.
	Vagy beirhathatjuk ezt is:

		txtDisplay.Text = txtDisplay.Text + "1";

	Futtassuk és nézzük meg hogy beirja e az egyet?

	Ha müködik csináljuk meg 0-tól 9-ig mindegyik gombbal.

	Hozzunk létre néhány változót, a következõ kód után:

	 public Form1()
        {
            InitializeComponent();
        }

        int num1; // a müvelet elõtti számok
        int num2; // a müvelet utáni számok
        string option; //a mûvelet jele
        int result; //az eredmény

		private void btn1_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btn1.Text;
        }

		Ha beirtuk a kódrészletet, akkor haladjunk is tovább,
		közben magarázom, hogy mi micsoda

		Kattintsunk 2x a + gombra a Form-on:
		és irjuk be a köv:

		private void btnPlusz_Click(object sender, EventArgs e)
        {
            option = "+";//1 lépés
            num1 = int.Parse(txtDisplay.Text);//2 lépés

            txtDisplay.Clear(); //3 lépés 
        }

		- 1 lépés: ha a futó programban a +.jelre kattintunk akkor az option változóban eltárolódik a + jel
		- 2 lépés: és az eddig beirt szám(okat),a TextBox-ban eltároljuk a num1 változóba.
		- 3 lépés: Ezután törlõdik a Textbox tartalma

		Ugyanezt csináljuk meg a többi aritmetikai jellel

		Mindig amikor beirjuk a számot akkor és rákattintunk a mûveletre,
		akkor letárolódik a num1 változóba és szövegként tároljuk a mûveletjelet is az option változóban
		és töröljök a TextBox tartalmát.

		Kattintsunk duplán a Form-on az egyenlõre, irjuk be a kódott:
			
			num2 = int.Parse(txtDisplay.Text); 

            if (option == ("+"))
                result = num1 + num2;

            if (option.Equals("-"))
                result = num1 - num2;

            if (option == ("*"))
                result = num1 * num2;

            if (option == ("/"))
                result = num1 / num2;

            if (option == ("%"))
                result = num1 % num2;

            txtDisplay.Text = result + "";
		
		Miután beirtuk az elsõ részt a számokat, következett a mûveletijel és eltünt a szöveg,
		itt ugyanez a helyzet  beirjuk a számokat csak már itt nem töröljük a TextBox tartalmát,
		hanem felülirjuk az egyenlõre kattintva,
		ha +-ra kattintotunk akkor az elsõnek megadott számokat hozzáadjunk
		a másodjára megadott számokhoz, amit eltárolunk a result változóba,
		aztán kiiratjuk a txtDisplay-be.

		Még mind ezek után szükségünk lehet egy mindent törlés gombra.
		Kattintsunk 2x a C-re és irjuk be:

		private void btnTorles_Click(object sender, EventArgs e)
        {
            txtDisplay.Clear();
            result = (0);
            num1 = (0);
            num2 = (0);
        }
		
		Ez törli a TextBox tartalmat és a változók tartalmát.

		Köszönöm ha ezt végig olvastad, remélem segithettem a fejlõdésedben ;)
			

