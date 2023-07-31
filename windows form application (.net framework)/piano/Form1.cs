using System;
using System.Windows.Forms;
using System.Media;

namespace piano
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void musicNoteC_Click(object sender, EventArgs e)
        {
            SoundPlayer sp = new SoundPlayer(@"C:\Users\READY\source\repos\c#_projects\windows form application (.net framework)\piano\Properties\Music_Notes\C.wav");
            sp.Play();
        }

        private void musicNoteD_Click(object sender, EventArgs e)
        {
            SoundPlayer sp = new SoundPlayer(@"C:\Users\READY\source\repos\c#_projects\windows form application (.net framework)\piano\Properties\Music_Notes\D.wav");
            sp.Play();
        }

        private void musicNoteFS_Click(object sender, EventArgs e)
        {
            SoundPlayer sp = new SoundPlayer(@"C:\Users\READY\source\repos\c#_projects\windows form application (.net framework)\piano\Properties\Music_Notes\F_s.wav");
            sp.Play();
        }

        private void musicNoteDS1_Click(object sender, EventArgs e)
        {
            SoundPlayer sp = new SoundPlayer(@"C:\Users\READY\source\repos\c#_projects\windows form application (.net framework)\piano\Properties\Music_Notes\D_s1.wav");
            sp.Play();
        }

        private void musicNoteCS1_Click(object sender, EventArgs e)
        {
            SoundPlayer sp = new SoundPlayer(@"C:\Users\READY\source\repos\c#_projects\windows form application (.net framework)\piano\Properties\Music_Notes\C_s1.wav");
            sp.Play();
        }

        private void musicNoteBB_Click(object sender, EventArgs e)
        {
            SoundPlayer sp = new SoundPlayer(@"C:\Users\READY\source\repos\c#_projects\windows form application (.net framework)\piano\Properties\Music_Notes\Bb.wav");
            sp.Play();
        }

        private void musicNoteGS_Click(object sender, EventArgs e)
        {
            SoundPlayer sp = new SoundPlayer(@"C:\Users\READY\source\repos\c#_projects\windows form application (.net framework)\piano\Properties\Music_Notes\G_s.wav");
            sp.Play();
        }

        private void musicNoteDS_Click(object sender, EventArgs e)
        {
            SoundPlayer sp = new SoundPlayer(@"C:\Users\READY\source\repos\c#_projects\windows form application (.net framework)\piano\Properties\Music_Notes\D_s.wav");
            sp.Play();
        }

        private void musicNoteCS_Click(object sender, EventArgs e)
        {
            SoundPlayer sp = new SoundPlayer(@"C:\Users\READY\source\repos\c#_projects\windows form application (.net framework)\piano\Properties\Music_Notes\C_s.wav");
            sp.Play();
        }

        private void musicNoteF1_Click(object sender, EventArgs e)
        {
            SoundPlayer sp = new SoundPlayer(@"C:\Users\READY\source\repos\c#_projects\windows form application (.net framework)\piano\Properties\Music_Notes\F1.wav");
            sp.Play();
        }

        private void musicNoteE1_Click(object sender, EventArgs e)
        {
            SoundPlayer sp = new SoundPlayer(@"C:\Users\READY\source\repos\c#_projects\windows form application (.net framework)\piano\Properties\Music_Notes\E1.wav");
            sp.Play();
        }

        private void musicNoteD1_Click(object sender, EventArgs e)
        {
            SoundPlayer sp = new SoundPlayer(@"C:\Users\READY\source\repos\c#_projects\windows form application (.net framework)\piano\Properties\Music_Notes\D1.wav");
            sp.Play();
        }

        private void musicNoteC1_Click(object sender, EventArgs e)
        {
            SoundPlayer sp = new SoundPlayer(@"C:\Users\READY\source\repos\c#_projects\windows form application (.net framework)\piano\Properties\Music_Notes\C1.wav");
            sp.Play();
        }

        private void musicNoteB_Click(object sender, EventArgs e)
        {
            SoundPlayer sp = new SoundPlayer(@"C:\Users\READY\source\repos\c#_projects\windows form application (.net framework)\piano\Properties\Music_Notes\B.wav");
            sp.Play();
        }

        private void musicNoteA_Click(object sender, EventArgs e)
        {
            SoundPlayer sp = new SoundPlayer(@"C:\Users\READY\source\repos\c#_projects\windows form application (.net framework)\piano\Properties\Music_Notes\A.wav");
            sp.Play();
        }

        private void musicNoteG_Click(object sender, EventArgs e)
        {
            SoundPlayer sp = new SoundPlayer(@"C:\Users\READY\source\repos\c#_projects\windows form application (.net framework)\piano\Properties\Music_Notes\G.wav");
            sp.Play();
        }

        private void musicNoteF_Click(object sender, EventArgs e)
        {
            SoundPlayer sp = new SoundPlayer(@"C:\Users\READY\source\repos\c#_projects\windows form application (.net framework)\piano\Properties\Music_Notes\F.wav");
            sp.Play();
        }

        private void musicNoteE_Click(object sender, EventArgs e)
        {
            SoundPlayer sp = new SoundPlayer(@"C:\Users\READY\source\repos\c#_projects\windows form application (.net framework)\piano\Properties\Music_Notes\E.wav");
            sp.Play();
        }
    }
}
