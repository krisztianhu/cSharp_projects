# For Each loops 

* nevezzük át a Form-ot, For each loops project-re
* Form Properities Text és neve
* helyezzünk el a Form-ra 6 darab PcitureBox-ot
* Toolbox PictureBox és huzzuk ki a Form-ra
* A PictureBox-ok mérete legyen 100x100
* katt a PictureBox-ra Properities Size 100;100
* szükségünk van még további kettõ label és Button-ra
* katt a Form-ra és Toolbox, innen huzzuk a Form-ra az elemeket
* formázzuk a label-eket: betûtípus, betûstílus, betûméretet változtassuk meg
* a Button-ok méretét állitsuk 100;100-ra
* katt a Form-ra és jobb click View Code vagy F7
*   public void runLoop()
*        { ... }
* hozzuk létre a runLoop függvényt
* irjunk egy foreach ciklust ami végig megy a Form-ra kihelyzett Controls elemeken
* foreach (Controls x in this.Controls)
* a foreach egy ciklus ami egy változó segitségével mindent megvizsgál amit paraméterként megadunk
* Controls x, létrehozzunk egy Controls tipus x nevû váltoozót
* in -> ami végig megy a..
* this.Controls -> a Form-ra helyezett a Controls elemeken
* if(x is Button)
* ha x mint változó ami vizsgálja a Ciontrols elemeket
* Button -> hha x Button akkor teljesül a feltétel
* x.BackColor = Color.Black;
* belép a feltételbe és az aktuális gomb BackColor háttérszíne
* Color.Black szine fekete lesz
* ez ugyanigy a többivel