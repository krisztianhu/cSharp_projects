# Move PictureBox

* huzzunk a Form-ra egy PictureBox-ot
* adjunk neki egy h�tt�rszint
* a Form-nak �llitsunk be egy nevet
* a Form-ra a Toolbox-b�l huzzunk ki egy Timer-t
* a Timer-t nevezz�k el moveTimer-nek, Enabled True, hogy felkapcsoljuk
* Interval legyen 20, hogy 20 miliszekundumonk�nt ellen�rizze a Form-ot
* a Timer Events Tick-n�l hozzuk l�tre a moveTimer eventet (irjuk be �s Enter)
* a Form Events KeyDown �s KeyUp eventeket hozzuk l�tre 
* keyIsUp �s KeyIsDown-nak nevezz�k el �ket
* sz�ks�g�nk van n�gy v�ltoz�ra
* bool moveRight, moveLeft, moveUp, moveDown
* ezeket hozzuk l�tre, vel�k fogjuk eld�nteni, hogy mikor nyomtuk le a gombokat �s mikor hagytuk abba
* int speed = 12; ez segit nek�nk hogy 20 miliszekundomonk�nt mennyi koordin�t�t mozogjon a PictureBox
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
* a fenti k�dban vizsg�ljuk a billenty� �llapot�t, hogy mikor vannak lenyomva
* a k�vetkez� k�d pedig, hogy mikor engedt�k el a gombokat
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
* a k�vetkez� k�d vizsg�lja hogy ha a
* (moveLeft == true az igaz akkor lenyomva van a bal nyil
* a m�sodik r�sze
* pictureBox1.Left > 0
* ha a PictureBox m�g nagyobb 0-n�l akkor mozoghat tov�bb az x tengelyen
* �s ha ez a k�t felt�tel teljes�l, akkor
* akkor az x koordin�t�n mozoghat balra
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
            // itt mivel a pictureBox1.Top-ot adtuk meg automatikusan m�r az Y tengelyhez viszonyitja
            if(moveUp == true && pictureBox1.Top > 0)
            {
                pictureBox1.Top -= speed;
            }
            if (moveDown == true && pictureBox1.Top < 355)
            {
                pictureBox1.Top += speed;
            }
        }
* ugyanez t�rt�nik a t�bbin�l is
* figyelj�nk arra, hogy a koordin�t�k a Form m�ret�hez vannak igazitva X �s Y tengely�hez
a PictureBox h�tt�rk�pp�nek jusson esz�nkbe, hogy nem csak Windows-os el�r�si utat lehet adni
* hanem linket is
* majd kattintsunk a nyilacsk�ra �s StrechIgame, hogy a PictureBox-hoz igazitsa a m�ret�t