# For Each loops 

* nevezz�k �t a Form-ot, For each loops project-re
* Form Properities Text �s neve
* helyezz�nk el a Form-ra 6 darab PcitureBox-ot
* Toolbox PictureBox �s huzzuk ki a Form-ra
* A PictureBox-ok m�rete legyen 100x100
* katt a PictureBox-ra Properities Size 100;100
* sz�ks�g�nk van m�g tov�bbi kett� label �s Button-ra
* katt a Form-ra �s Toolbox, innen huzzuk a Form-ra az elemeket
* form�zzuk a label-eket: bet�t�pus, bet�st�lus, bet�m�retet v�ltoztassuk meg
* a Button-ok m�ret�t �llitsuk 100;100-ra
* katt a Form-ra �s jobb click View Code vagy F7
*   public void runLoop()
*        { ... }
* hozzuk l�tre a runLoop f�ggv�nyt
* irjunk egy foreach ciklust ami v�gig megy a Form-ra kihelyzett Controls elemeken
* foreach (Controls x in this.Controls)
* a foreach egy ciklus ami egy v�ltoz� segits�g�vel mindent megvizsg�l amit param�terk�nt megadunk
* Controls x, l�trehozzunk egy Controls tipus x nev� v�ltooz�t
* in -> ami v�gig megy a..
* this.Controls -> a Form-ra helyezett a Controls elemeken
* if(x is Button)
* ha x mint v�ltoz� ami vizsg�lja a Ciontrols elemeket
* Button -> hha x Button akkor teljes�l a felt�tel
* x.BackColor = Color.Black;
* bel�p a felt�telbe �s az aktu�lis gomb BackColor h�tt�rsz�ne
* Color.Black szine fekete lesz
* ez ugyanigy a t�bbivel