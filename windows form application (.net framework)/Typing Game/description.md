#Typing game

* írjuk át a Form címsorát : Typing Game
* katt a Form Properities Text-re és irjuk be oda
* állitsunk be a Form-nak 700x500 méretet
* Form Properities Size 700;500
* tegyünk a Form-ra 4 labelt
* katt a Form-ra Toolbox label
* Minta:
* 
* nevezzük át õket
* label Properities Text :
*  Correct : 0, Incorrect : 0, Word, Press Enter to check the text wodt word
* most nevezzük át a label-ek Design nevét
* katt label Properities Design Name
* rightLbl, wrongLbl, wordLbl
* huzzunk a Form-ra egy TextBox-ot
* jelöljük ki a TextBoxot és a Word labelt
* menjünk a Properities Font-ra (most egyszerre mindkettõ elemnek a tulajdonságát tudjuk módosjtani)
* állitsunk nagyobb betûméretet, betûstílust és betûtípust
* a TextBox Properities TextAlign Center
* TextBox Events KeyUp irjuk be a checkGame és Enter
* megjelenik a kódnézett, elõször huzzunk létre egy tö,bot
* string típusu tömb, ahol a szavakat fogjuk tárolni
* ezután kellenek nekünk random számok a szavak kiválasztására
* Random rnd = new Random();
* kell nekünk még egy helyes és nem helyes számláló változó
* int correct = 0; int incorrect = 0;
* irassuk ki a wordLbl-be a tömb random szavát
*  wordLbl.Text = words[rnd.Next(0, words.Length)];
*  ezzel a kóddal tehetjük meg
* a wordLbl-vel mehivjuk az elemet,
* a .Text ezzel hivatkozzunk a szövegre amit látunk  
* ez legyen egyenlõ 
* a words[...] tömbbel
* a rnd.Next(0, words.Lenght)
* az rnd.Next() kisorsol egy véletlen számot,
* az elsõ paraméter a 0 a kezdeti érték,vagyis a minimum szám ahonna kezdi
* a words.Lenght megszámolja hány elem van a tömbbe és visszatérési értéke esetünkben 4 lesz, ez a záróérték, tehát a maximum szám ami között lesznek a random számok
* még a wordLbl label-nek a szüvegét középre igazithatjuk
* ezután menjünkk a checkGame függvénybe
* vizsgáljuk meg hogyha Enter nyomunk,
* akkor a textBox1 Text-je pontosan egyezik-e
* a wordLbl Text-jével,
* tehát ha Enter nyomunk megvizsálja hogy a megjelenõ szöveg megegyezik azzal a szöveggel. amit beirtunk
* ha igen, akkor:
* növeli a correct változó értékét eggyel
* kisorsol random egy másik szót a label-be, amit kiir
* ha nem egyezik a beirt szöveg enter lenyomása után a megjelenitett szöveggel,akkor:
* az incorrect változóértékét növeli eggyel 
* és kisorsol egy új szót random a words tömbbõl
* 