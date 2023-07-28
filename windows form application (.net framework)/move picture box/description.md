# Move PictureBox

* huzzunk a Form-ra egy PictureBox-ot
* adjunk neki egy háttérszint
* a Form-nak állitsunk be egy nevet
* a Form-ra a Toolbox-ból huzzunk ki egy Timer-t
* a Timer-t nevezzük el moveTimer-nek, Enabled True, hogy felkapcsoljuk
* Interval legyen 20, hogy 20 miliszekundumonként ellenõrizze a Form-ot
* a Timer Events Tick-nél hozzuk létre a moveTimer eventet (irjuk be és Enter)
* a Form Events KeyDown és KeyUp eventeket hozzuk létre 
* keyIsUp és KeyIsDown-nak nevezzük el õket
* szükségünk van négy változóra
* bool moveRight, moveLeft, moveUp, moveDown
* ezeket hozzuk létre, velük fogjuk eldönteni, hogy mikor nyomtuk le a gombokat és mikor hagytuk abba
* int speed = 12; ez segit nekünk hogy 20 miliszekundomonként mennyi koordinátát mozogjon a PictureBox
*  private void keyIsDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Left)
            {
                moveLeft = true;
            }
            if(e.KeyCode == Keys.Right)
            {
                moveRight = true;
            }
            if(e.KeyCode == Keys.Down)
            {
                moveDown = true;
            }
            if(e.KeyCode == Keys.Up)
            {
                moveUp = true;
            }
        }
* a fenti kódban vizsgáljuk a billentyû állapotát, hogy mikor vannak lenyomva
* a következõ kód pedig, hogy mikor engedtük el a gombokat
*if (e.KeyCode == Keys.Left)
            {
                moveLeft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                moveRight = false;
            }
            if (e.KeyCode == Keys.Down)
            {
                moveDown = false;
            }
            if (e.KeyCode == Keys.Up)
            {
                moveUp = false;
            }
* a következõ kód vizsgálja hogy ha a
* (moveLeft == true az igaz akkor lenyomva van a bal nyil
* a második része
* pictureBox1.Left > 0
* ha a PictureBox még nagyobb 0-nál akkor mozoghat tovább az x tengelyen
* és ha ez a két feltétel teljesül, akkor
* akkor az x koordinátán mozoghat balra
* private void moveTimerEnter(object sender, EventArgs e)
        {
            if(moveLeft == true && pictureBox1.Left > 0)
            {
                pictureBox1.Left -= speed; 
            }
            if(moveRight == true && pictureBox1.Left < 700)
            {
                pictureBox1.Left += speed;
            }
            // itt mivel a pictureBox1.Top-ot adtuk meg automatikusan már az Y tengelyhez viszonyitja
            if(moveUp == true && pictureBox1.Top > 0)
            {
                pictureBox1.Top -= speed;
            }
            if (moveDown == true && pictureBox1.Top < 355)
            {
                pictureBox1.Top += speed;
            }
        }
* ugyanez történik a többinél is
* figyeljünk arra, hogy a koordináták a Form méretéhez vannak igazitva X és Y tengelyéhez
a PictureBox háttérképpének jusson eszünkbe, hogy nem csak Windows-os elérési utat lehet adni
* hanem linket is
* majd kattintsunk a nyilacskára és StrechIgame, hogy a PictureBox-hoz igazitsa a méretét