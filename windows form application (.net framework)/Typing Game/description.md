#Typing game

* �rjuk �t a Form c�msor�t : Typing Game
* katt a Form Properities Text-re �s irjuk be oda
* �llitsunk be a Form-nak 700x500 m�retet
* Form Properities Size 700;500
* tegy�nk a Form-ra 4 labelt
* katt a Form-ra Toolbox label
* Minta:
* 
* nevezz�k �t �ket
* label Properities Text :
*  Correct : 0, Incorrect : 0, Word, Press Enter to check the text wodt word
* most nevezz�k �t a label-ek Design nev�t
* katt label Properities Design Name
* rightLbl, wrongLbl, wordLbl
* huzzunk a Form-ra egy TextBox-ot
* jel�lj�k ki a TextBoxot �s a Word labelt
* menj�nk a Properities Font-ra (most egyszerre mindkett� elemnek a tulajdons�g�t tudjuk m�dosjtani)
* �llitsunk nagyobb bet�m�retet, bet�st�lust �s bet�t�pust
* a TextBox Properities TextAlign Center
* TextBox Events KeyUp irjuk be a checkGame �s Enter
* megjelenik a k�dn�zett, el�sz�r huzzunk l�tre egy t�,bot
* string t�pusu t�mb, ahol a szavakat fogjuk t�rolni
* ezut�n kellenek nek�nk random sz�mok a szavak kiv�laszt�s�ra
* Random rnd = new Random();
* kell nek�nk m�g egy helyes �s nem helyes sz�ml�l� v�ltoz�
* int correct = 0; int incorrect = 0;
* irassuk ki a wordLbl-be a t�mb random szav�t
*  wordLbl.Text = words[rnd.Next(0, words.Length)];
*  ezzel a k�ddal tehetj�k meg
* a wordLbl-vel mehivjuk az elemet,
* a .Text ezzel hivatkozzunk a sz�vegre amit l�tunk  
* ez legyen egyenl� 
* a words[...] t�mbbel
* a rnd.Next(0, words.Lenght)
* az rnd.Next() kisorsol egy v�letlen sz�mot,
* az els� param�ter a 0 a kezdeti �rt�k,vagyis a minimum sz�m ahonna kezdi
* a words.Lenght megsz�molja h�ny elem van a t�mbbe �s visszat�r�si �rt�ke eset�nkben 4 lesz, ez a z�r��rt�k, teh�t a maximum sz�m ami k�z�tt lesznek a random sz�mok
* m�g a wordLbl label-nek a sz�veg�t k�z�pre igazithatjuk
* ezut�n menj�nkk a checkGame f�ggv�nybe
* vizsg�ljuk meg hogyha Enter nyomunk,
* akkor a textBox1 Text-je pontosan egyezik-e
* a wordLbl Text-j�vel,
* teh�t ha Enter nyomunk megvizs�lja hogy a megjelen� sz�veg megegyezik azzal a sz�veggel. amit beirtunk
* ha igen, akkor:
* n�veli a correct v�ltoz� �rt�k�t eggyel
* kisorsol random egy m�sik sz�t a label-be, amit kiir
* ha nem egyezik a beirt sz�veg enter lenyom�sa ut�n a megjelenitett sz�veggel,akkor:
* az incorrect v�ltoz��rt�k�t n�veli eggyel 
* �s kisorsol egy �j sz�t random a words t�mbb�l
* 