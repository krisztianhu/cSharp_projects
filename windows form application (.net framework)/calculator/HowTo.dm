#l�p�sr�l-l�p�sre

	Form-ra jobbb click Properities
	Text tulajdons�gn�l �tirjuk a cimsort Calculatora

	Toolbox-ban keress�k meg a TextBox-ot �s tegy�k a Form-ra
	a nyilacsk�ra kattintva pip�ljuk be a Multiline-t �s igazitsuk

	Toolbox-b�l huzzunk a Form-ra egy button-t, m�retezz�k �s Text tulajdons�g�t irjuk �t 1-re
	A button-ra kattintva a Properities-ben keress�k meg a font tulajdons�got, majd katt a 3 p�tyre
	form�zzuk kedv�nkre, majd a TextBox-ot is

	Csin�ljuk meg ugyanigy a 2-t�l 9-ig a gombokat csak copy-paste-telj�nk.
	majd a C,(,),%,/,*,-,+,=,,,0-�t.

	A Form-on a Properities-ben irjuk �t a StartingPosition-t CenterScreen-re,
	hogy amikor fut a progi akkor k�z�pen jelenjen meg 

	Futtasuk a programot �s n�zz�k meg hogy nagy�b�l ar�nyosak e a m�retek egym�shoz k�pest

	A TextBox-ot nevezz�k �t txtDisplay-re
	A sz�m gombokat nevezz�k �t btn1, btn2 ... btn9 �s btn0-ra
	majd btnOsztas, btnTorles, ...

	Dupla klikk a 1-es gombra, megjelenik a Form-nak a k�dja.
	irjuk be a btn1_Click f�ggv�nybe a k�dott:

	            txtDisplay.Text = txtDisplay.Text + btn1.Text;

	Ez a sor a txtDisplay vagyis a TextBox tartalm�t egyenl�v� teszi
	a TextBox �s a btn1 Text tulajdons�g�val, ahov� 1-et irtunk.
	Vagy beirhathatjuk ezt is:

		txtDisplay.Text = txtDisplay.Text + "1";

	Futtassuk �s n�zz�k meg hogy beirja e az egyet?

	Ha m�k�dik csin�ljuk meg 0-t�l 9-ig mindegyik gombbal.

	Hozzunk l�tre n�h�ny v�ltoz�t, a k�vetkez� k�d ut�n:

	 public Form1()
        {
            InitializeComponent();
        }

        int num1; // a m�velet el�tti sz�mok
        int num2; // a m�velet ut�ni sz�mok
        string option; //a m�velet jele
        int result; //az eredm�ny

		private void btn1_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btn1.Text;
        }

		Ha beirtuk a k�dr�szletet, akkor haladjunk is tov�bb,
		k�zben magar�zom, hogy mi micsoda

		Kattintsunk 2x a + gombra a Form-on:
		�s irjuk be a k�v:

		private void btnPlusz_Click(object sender, EventArgs e)
        {
            option = "+";//1 l�p�s
            num1 = int.Parse(txtDisplay.Text);//2 l�p�s

            txtDisplay.Clear(); //3 l�p�s 
        }

		- 1 l�p�s: ha a fut� programban a +.jelre kattintunk akkor az option v�ltoz�ban elt�rol�dik a + jel
		- 2 l�p�s: �s az eddig beirt sz�m(okat),a TextBox-ban elt�roljuk a num1 v�ltoz�ba.
		- 3 l�p�s: Ezut�n t�rl�dik a Textbox tartalma

		Ugyanezt csin�ljuk meg a t�bbi aritmetikai jellel

		Mindig amikor beirjuk a sz�mot akkor �s r�kattintunk a m�veletre,
		akkor let�rol�dik a num1 v�ltoz�ba �s sz�vegk�nt t�roljuk a m�veletjelet is az option v�ltoz�ban
		�s t�r�lj�k a TextBox tartalm�t.

		Kattintsunk dupl�n a Form-on az egyenl�re, irjuk be a k�dott:
			
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
		
		Miut�n beirtuk az els� r�szt a sz�mokat, k�vetkezett a m�veletijel �s elt�nt a sz�veg,
		itt ugyanez a helyzet  beirjuk a sz�mokat csak m�r itt nem t�r�lj�k a TextBox tartalm�t,
		hanem fel�lirjuk az egyenl�re kattintva,
		ha +-ra kattintotunk akkor az els�nek megadott sz�mokat hozz�adjunk
		a m�sodj�ra megadott sz�mokhoz, amit elt�rolunk a result v�ltoz�ba,
		azt�n kiiratjuk a txtDisplay-be.

		M�g mind ezek ut�n sz�ks�g�nk lehet egy mindent t�rl�s gombra.
		Kattintsunk 2x a C-re �s irjuk be:

		private void btnTorles_Click(object sender, EventArgs e)
        {
            txtDisplay.Clear();
            result = (0);
            num1 = (0);
            num2 = (0);
        }
		
		Ez t�rli a TextBox tartalmat �s a v�ltoz�k tartalm�t.

		K�sz�n�m ha ezt v�gig olvastad, rem�lem segithettem a fejl�d�sedben ;)
			

