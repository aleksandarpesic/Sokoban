using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Sokoban
{
    public partial class Form1 : Form
    {
        private bool textBox_uputstvoVisable=false;
        private Bitmap bm;
        private Graphics g;
        private Mapa mapa=new Mapa();
        private Mapa mapaBack = new Mapa();
        private InicializacijaNivoa inicializacijaNivoa=new InicializacijaNivoa();
        private int nivo;
        int w, h; //width, height full screen ekrana
        int brojVrsta = 15;
        int brojKolona = 20;
        Baza baza=new Baza();
        Label lbl_lista_Rangiranjapomocna1 = new Label();
        Label lbl_lista_Rangiranjapomocna2 = new Label();
        Label[] lbl_lista_Rangiranja = new Label[10];
        int stanje = 0;
        int krajnjiNivo = 12;
        List<String> rez;
        SoundPlayer player = new SoundPlayer("Resource/music.wav");
        bool peva;
        NivoKodirajPamti pamtiCirajFail = new NivoKodirajPamti();
        public Form1()
        {
            InitializeComponent();     
            w=Screen.PrimaryScreen.Bounds.Width;
            h = Screen.PrimaryScreen.Bounds.Height;
           
           // baza.conect();
            MakeMeni();
            muzika(); 
            
           /* for (int i = 0; i < 10;i++ )
                baza.Insert(1, "Beta Tester ");*/
            
           

        }
        private void MakeMeni()
        {
            //Pozicioniranje na ekranu menija
            this.lbl_play.Location = new System.Drawing.Point(w / 5, h / 4 );
            this.lbl_play.BackColor = Color.Transparent;

            this.lbl_userManual.Location = new System.Drawing.Point(w / 5, h / 4 + h / 8 );
            this.lbl_userManual.BackColor = Color.Transparent;
            
            this.lbl_rez.Location = new System.Drawing.Point(w / 5, h / 4 + 2*h/8 -h/25  );
            this.lbl_rez.BackColor = Color.Transparent;

            this.lbl_reset.Location = new System.Drawing.Point(w / 5, h / 4 + 3 * h / 8 - 2 *h / 25);
            this.lbl_reset.BackColor = Color.Transparent;

            this.lbl_izadji.Location = new System.Drawing.Point(w / 5, h / 5 + 4 * h / 8 );
            this.lbl_izadji.BackColor = Color.Transparent;

            this.textBox_uputstvo.Location = new System.Drawing.Point(2 * w / 4, h / 3 - h / 15);
            this.textBox_uputstvo.Size = new System.Drawing.Size(w / 5, h / 2);
            //this.textBox_uputstvo.Text;

            

            this.lbl_nazad.Location = new System.Drawing.Point(w / 5, h / 4 + 4 * h / 8);
            this.lbl_nazad.BackColor = Color.Transparent;

            this.pictureBox1.Size = new System.Drawing.Size(w, h); //pb zauzima ceo ekran jer se tu iscrtava polje za igru
            bm = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            g = Graphics.FromImage(bm);
           
        }
        private void show_hideMeni(bool val)
        {            
          /* this.BackgroundImage = null;
           this.BackColor = Color.Silver;
            */
            this.lbl_play.Visible = val;
            this.lbl_izadji.Visible = val;
            this.lbl_userManual.Visible = val;
            this.lbl_rez.Visible = val;
            this.lbl_reset.Visible = val;

            this.textBox_uputstvo.Visible = false; this.textBox_zaUpisRez.Enabled = false; textBox_zaUpisRez.Visible = false;
            lbl_lista_Rangiranjapomocna1.Visible = false;
            lbl_lista_Rangiranjapomocna2.Visible = false;           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int w=Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height; 
            //this.Location = new Point(0, 0);
            //this.Size=new Size(w,h);
        }

        //dogadjaji za dugme Igraj
        private void lbl_play_Click(object sender, EventArgs e)
        {
            show_hideMeni(false); //hide meni

           
             nivo =pamtiCirajFail.dajNivo();

            inicializacijaNivoa.InicializujNivo(ref mapa,nivo);
            mapaBack = mapa;
            this.menuStrip1.Visible = true; //gornja traka
            this.pictureBox1.Visible = true;//sada je ekran picture box
            stanje = 1;
            muzika();

            iscrtaj();
        }
        private void muzika()
        {
            if (stanje != 1 && peva == false)
            {
                Task.Run(() =>
                {
                    while (true)
                    {
                        player.Play();
                        Thread.Sleep(70000);
                        if (stanje == 1) break; //da bi izbego ponavljanje 
                    }
                });
                peva = true;
            }
            else  if (stanje == 1 )
            {
                player.Stop();
                peva = false;
            }
        }
        public void iscrtaj()
        {
            // Create image.
            Image newImage = null;

            // Create rectangle for displaying image.
            Rectangle destRect;           
            
            int wtmp = 0;
            int htmp = menuStrip1.Size.Height + 10;
            int dx = w / 20;
            int dy = (h - htmp-20) / 15;
            /*
            Rectangle destRect1 = new Rectangle(10, htmp,  90, htmp + dy)  ;
            newImage = Image.FromFile("zid.jpg"); g.DrawImage(newImage, destRect1);
            Rectangle destRect2 = new Rectangle(120, htmp, 90, htmp + dy);
            g.DrawImage(newImage, destRect2);
            */
            for (int i = 0; i < 15; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    if (mapa.getIJ(i, j) == 1)
                    {
                        newImage = Image.FromFile("Resource/zid.jpg");
                    }
                    else if (mapa.getIJ(i, j) == 2) { newImage = Image.FromFile("Resource/Image1.jpg"); }
                    else if (mapa.getIJ(i, j) == 3) { newImage = Image.FromFile("Resource/kutija.jpg"); }
                    else if (mapa.getIJ(i, j) == 6) { newImage = Image.FromFile("Resource/kutija2.jpg"); }
                    else if (mapa.getIJ(i, j) == 4) { newImage = Image.FromFile("Resource/silver.jpg"); }
                    else if (mapa.getIJ(i, j) == 5 || mapa.getIJ(i, j) == 10)
                    {  //nalazi se model
                        switch (mapa.GetOkrenut_prema())
                        {
                            case 1: newImage = Image.FromFile("Resource/model_dole.jpg");
                                break;
                            case 3: newImage = Image.FromFile("Resource/model_gore.jpg");
                                break;
                            case 2: newImage = Image.FromFile("Resource/model_desno.jpg");
                                break;
                            case 4: newImage = Image.FromFile("Resource/model_levo.jpg");
                                break;
                        }
                    }
                    destRect = new Rectangle(wtmp, htmp, dx, dy);
                    wtmp += dx;
                    g.DrawImage(newImage, destRect);

                }
                wtmp = 0;
                htmp += dy;
            }
            this.toolStripMenuItem1.Text = "Trenutni nivo: "+nivo+"/12";
            pictureBox1.Image = bm;

            if (stanje==1 && mapa.krajNivoa(brojVrsta, brojKolona))
            {
                if (nivo != krajnjiNivo)
                {
                    MessageBox.Show(this, "Cestitam. Presli ste u naredni nivo.");
                    ++nivo;
                    inicializacijaNivoa.InicializujNivo(ref mapa, nivo);
                    iscrtaj();
                }
                else
                {
                    upisiRez(krajnjiNivo);
                }
            }
                               


        }
        private void upisiRez(int nivo)
        {
            if (baza.conected==false) baza.conect();
            if (baza.conected)
            {
                int minscore = baza.MinNum(); //u bazi sa najmanjim rezultatom
                this.pictureBox1.Visible = false;
                this.menuStrip1.Visible = false;

                prikaziRezultate();
                if (nivo >= minscore)
                {
                    int pozicija = 0;
                    for (int i = rez.Count(); i <= 0; i -= 2)
                    {
                        if (Convert.ToInt32(rez[i]) <= nivo)
                        {
                            pozicija = i;
                        }
                    }
                    this.textBox_zaUpisRez.Location = new Point(w / 2, h / 4 + (pozicija / 2) * 50);
                    this.textBox_zaUpisRez.Enabled = true;
                    this.textBox_zaUpisRez.Visible = true;
                    stanje = 2;
                }

                       
            this.lbl_nazad.Visible = true;
            this.lbl_nazad.Text = "Zapamti i izađi";
            } 
            else
            {
                MessageBox.Show(this, "Doslo je do greske. Greska: Konekcija sa bazom nije uspela.");
                show_hideMeni(true);
                this.pictureBox1.Visible = false;
                stanje = 0;
            }
            pamtiCirajFail.zapamtiUFail(nivo);

        }
        private void lbl_play_MouseMove(object sender, MouseEventArgs e)
        {
            this.lbl_play.Font = new System.Drawing.Font("Rockwell", 35.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        }
        private void lbl_play_MouseLeave(object sender, EventArgs e)
        {
            this.lbl_play.Font = new System.Drawing.Font("Rockwell", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        }
        private void lbl_reset_MouseMove(object sender, MouseEventArgs e)
        {
            this.lbl_reset.Font = new System.Drawing.Font("Rockwell", 35.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

        }
        private void lbl_reset_MouseLeave(object sender, EventArgs e)
        {
            this.lbl_reset.Font = new System.Drawing.Font("Rockwell", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

        }

        //Dogadjaji za dugme Izadji
        private void lab_izadji_Click(object sender, EventArgs e)
        {
            baza.CloseConnection();
            this.Close();
        }
        private void lab_izadji_MouseMove(object sender, MouseEventArgs e)
        {
            this.lbl_izadji.Font = new System.Drawing.Font("Rockwell", 35.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        }

        private void lab_izadji_MouseLeave(object sender, EventArgs e)
        {
            this.lbl_izadji.Font = new System.Drawing.Font("Rockwell", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        }
        private void lbl_nazad_MouseMove(object sender, MouseEventArgs e)
        {
            this.lbl_nazad.Font = new System.Drawing.Font("Rockwell", 35.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

        }

        private void lbl_nazad_MouseLeave(object sender, EventArgs e)
        {
            this.lbl_nazad.Font = new System.Drawing.Font("Rockwell", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

        }

        private void lbl_userManual_Click(object sender, EventArgs e)
        {
            if (!textBox_uputstvoVisable)
            {
                this.textBox_uputstvo.Visible = true; 
                textBox_uputstvoVisable = true;
            }
            else
            {
                this.textBox_uputstvo.Visible = false; 
                textBox_uputstvoVisable = false;
            }
        }

        private void lbl_userManual_MouseMove(object sender, MouseEventArgs e)
        {
            this.lbl_userManual.Font = new System.Drawing.Font("Rockwell", 35.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

        }

        private void lbl_userManual_MouseLeave(object sender, EventArgs e)
        {
            this.lbl_userManual.Font = new System.Drawing.Font("Rockwell", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        }
        private void lbl_rez_MouseMove(object sender, MouseEventArgs e)
        {
            this.lbl_rez.Font = new System.Drawing.Font("Rockwell", 35.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

        }

        private void lbl_rez_MouseLeave(object sender, EventArgs e)
        {
            this.lbl_rez.Font = new System.Drawing.Font("Rockwell", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            mapaBack = mapaBack.MapaCopy(mapa);
            /*Moze da ide 
             * 1-U prazno polje
             * 2-Na kutiju: 2.1 kutija ide u prazno polje 2.2 kutija ide u mesto za kutiju 
             */
            if (e.KeyCode == Keys.Down)
            {
                mapa.SetPozicija(1, mapa.getX_Coveka(), mapa.getY_coveka());
                if (mapa.getIJ(mapa.getX_Coveka()+1, mapa.getY_coveka() ) == 2) //AKO JE ISPRED PRAZNO POLJE
                {
                    mapa.set(mapa.getX_Coveka()+1, mapa.getY_coveka() , 5); // sada je ovde na mapi covek
                    if (mapa.getIJ(mapa.getX_Coveka(), mapa.getY_coveka()) == 10)
                        mapa.set(mapa.getX_Coveka(), mapa.getY_coveka(), 4);
                    else mapa.set(mapa.getX_Coveka(), mapa.getY_coveka(), 2); //trenutna pozicija se oslobadja

                    mapa.SetPozicija(1, mapa.getX_Coveka()+1, mapa.getY_coveka());//pozicija coveka je nova pozicija
                }
                else if (mapa.getIJ(mapa.getX_Coveka()+1, mapa.getY_coveka() ) == 4) //AKO JE ISPRED MESTO ZA KUTIJU
                {

                    mapa.set(mapa.getX_Coveka()+1, mapa.getY_coveka() , 10); // sada je ovde na mapi covek (5*2=10)
                    if (mapa.getIJ(mapa.getX_Coveka(), mapa.getY_coveka()) == 10)
                        mapa.set(mapa.getX_Coveka(), mapa.getY_coveka(), 4);
                    else mapa.set(mapa.getX_Coveka(), mapa.getY_coveka(), 2);

                    mapa.SetPozicija(1, mapa.getX_Coveka()+1, mapa.getY_coveka() );//pozicija coveka je nova pozicija
                }
                else if (mapa.getIJ(mapa.getX_Coveka()+1, mapa.getY_coveka() ) == 3
                    || mapa.getIJ(mapa.getX_Coveka()+1, mapa.getY_coveka() ) == 6) //AKO IDE NAIDJE KUTIJU U PRAZNO POLJE ILI POLJE ZA KUTIJU
                {

                    if (mapa.getIJ(mapa.getX_Coveka()+2, mapa.getY_coveka() ) == 2) //kutija izlazi u slobodno polje
                    {
                        mapa.set(mapa.getX_Coveka()+2, mapa.getY_coveka(), 3); //kutija slobodna

                        if (mapa.getIJ(mapa.getX_Coveka(), mapa.getY_coveka()) == 10)
                        {
                            mapa.set(mapa.getX_Coveka(), mapa.getY_coveka(), 4);
                        }
                        else if (mapa.getIJ(mapa.getX_Coveka(), mapa.getY_coveka()) == 5)
                        {
                            mapa.set(mapa.getX_Coveka(), mapa.getY_coveka(), 2);
                        }
                        if (mapa.getIJ(mapa.getX_Coveka()+1, mapa.getY_coveka() ) == 3)
                            mapa.set(mapa.getX_Coveka()+1, mapa.getY_coveka() , 5);
                        if (mapa.getIJ(mapa.getX_Coveka()+1, mapa.getY_coveka()) == 6)
                            mapa.set(mapa.getX_Coveka()+1, mapa.getY_coveka(), 10);


                        mapa.SetPozicija(1, mapa.getX_Coveka()+1, mapa.getY_coveka());//pozicija coveka je nova pozicija
                    }
                    if (mapa.getIJ(mapa.getX_Coveka()+2, mapa.getY_coveka()) == 4) //kutija u mesto za kutiju
                    {
                        mapa.set(mapa.getX_Coveka()+2, mapa.getY_coveka(), 6); //kutija u mestu za kutiju

                        if (mapa.getIJ(mapa.getX_Coveka()+1, mapa.getY_coveka() ) == 6)
                        {
                            mapa.set(mapa.getX_Coveka()+1, mapa.getY_coveka() , 10); // sada je ovde na mapi covek
                        }
                        else if (mapa.getIJ(mapa.getX_Coveka()+1, mapa.getY_coveka() ) == 3)
                            mapa.set(mapa.getX_Coveka()+1, mapa.getY_coveka() , 5);

                        if (mapa.getIJ(mapa.getX_Coveka(), mapa.getY_coveka()) == 10)
                        {
                            mapa.set(mapa.getX_Coveka(), mapa.getY_coveka(), 4);
                        }
                        else if (mapa.getIJ(mapa.getX_Coveka(), mapa.getY_coveka()) == 5)
                        {
                            mapa.set(mapa.getX_Coveka(), mapa.getY_coveka(), 2);
                        }

                        mapa.SetPozicija(1, mapa.getX_Coveka()+1, mapa.getY_coveka() );//pozicija coveka je nova pozicija
                    }
                }
                

            }
            else if (e.KeyCode == Keys.Up)
            {
                mapa.SetPozicija(3, mapa.getX_Coveka(), mapa.getY_coveka());
                if (mapa.getIJ(mapa.getX_Coveka() - 1, mapa.getY_coveka()) == 2) //AKO JE ISPRED PRAZNO POLJE
                {
                    mapa.set(mapa.getX_Coveka() - 1, mapa.getY_coveka(), 5); // sada je ovde na mapi covek
                    if (mapa.getIJ(mapa.getX_Coveka(), mapa.getY_coveka()) == 10)
                        mapa.set(mapa.getX_Coveka(), mapa.getY_coveka(), 4);
                    else mapa.set(mapa.getX_Coveka(), mapa.getY_coveka(), 2); //trenutna pozicija se oslobadja

                    mapa.SetPozicija(3, mapa.getX_Coveka() - 1, mapa.getY_coveka());//pozicija coveka je nova pozicija
                }
                else if (mapa.getIJ(mapa.getX_Coveka() - 1, mapa.getY_coveka()) == 4) //AKO JE ISPRED MESTO ZA KUTIJU
                {

                    mapa.set(mapa.getX_Coveka() - 1, mapa.getY_coveka(), 10); // sada je ovde na mapi covek (5*2=10)
                    if (mapa.getIJ(mapa.getX_Coveka(), mapa.getY_coveka()) == 10)
                        mapa.set(mapa.getX_Coveka(), mapa.getY_coveka(), 4);
                    else mapa.set(mapa.getX_Coveka(), mapa.getY_coveka(), 2);

                    mapa.SetPozicija(3, mapa.getX_Coveka() - 1, mapa.getY_coveka());//pozicija coveka je nova pozicija
                }
                else if (mapa.getIJ(mapa.getX_Coveka() - 1, mapa.getY_coveka()) == 3
                    || mapa.getIJ(mapa.getX_Coveka() - 1, mapa.getY_coveka()) == 6) //AKO IDE NAIDJE KUTIJU U PRAZNO POLJE ILI POLJE ZA KUTIJU
                {

                    if (mapa.getIJ(mapa.getX_Coveka() - 2, mapa.getY_coveka()) == 2) //kutija izlazi u slobodno polje
                    {
                        mapa.set(mapa.getX_Coveka() - 2, mapa.getY_coveka(), 3); //kutija slobodna

                        if (mapa.getIJ(mapa.getX_Coveka(), mapa.getY_coveka()) == 10)
                        {
                            mapa.set(mapa.getX_Coveka(), mapa.getY_coveka(), 4);
                        }
                        else if (mapa.getIJ(mapa.getX_Coveka(), mapa.getY_coveka()) == 5)
                        {
                            mapa.set(mapa.getX_Coveka(), mapa.getY_coveka(), 2);
                        }
                        if (mapa.getIJ(mapa.getX_Coveka() - 1, mapa.getY_coveka()) == 3)
                            mapa.set(mapa.getX_Coveka() - 1, mapa.getY_coveka(), 5);
                        if (mapa.getIJ(mapa.getX_Coveka() - 1, mapa.getY_coveka()) == 6)
                            mapa.set(mapa.getX_Coveka() - 1, mapa.getY_coveka(), 10);


                        mapa.SetPozicija(3, mapa.getX_Coveka() - 1, mapa.getY_coveka());//pozicija coveka je nova pozicija
                    }
                    if (mapa.getIJ(mapa.getX_Coveka() - 2, mapa.getY_coveka()) == 4) //kutija u mesto za kutiju
                    {
                        mapa.set(mapa.getX_Coveka() - 2, mapa.getY_coveka(), 6); //kutija u mestu za kutiju

                        if (mapa.getIJ(mapa.getX_Coveka() - 1, mapa.getY_coveka()) == 6)
                        {
                            mapa.set(mapa.getX_Coveka() - 1, mapa.getY_coveka(), 10); // sada je ovde na mapi covek
                        }
                        else if (mapa.getIJ(mapa.getX_Coveka() - 1, mapa.getY_coveka()) == 3)
                            mapa.set(mapa.getX_Coveka()-1, mapa.getY_coveka() , 5);

                        if (mapa.getIJ(mapa.getX_Coveka(), mapa.getY_coveka()) == 10)
                        {
                            mapa.set(mapa.getX_Coveka(), mapa.getY_coveka(), 4);
                        }
                        else if (mapa.getIJ(mapa.getX_Coveka(), mapa.getY_coveka()) == 5)
                        {
                            mapa.set(mapa.getX_Coveka(), mapa.getY_coveka(), 2);
                        }

                        mapa.SetPozicija(3, mapa.getX_Coveka() - 1, mapa.getY_coveka());//pozicija coveka je nova pozicija
                    }
                }


            }
            else if (e.KeyCode == Keys.Right)
            {
                mapa.SetPozicija(2, mapa.getX_Coveka(), mapa.getY_coveka());
                if (mapa.getIJ(mapa.getX_Coveka(), mapa.getY_coveka()+1) == 2) //AKO JE ISPRED PRAZNO POLJE
                {
                    mapa.set(mapa.getX_Coveka(), mapa.getY_coveka()+1, 5); // sada je ovde na mapi covek
                    if (mapa.getIJ(mapa.getX_Coveka(), mapa.getY_coveka()) == 10)
                        mapa.set(mapa.getX_Coveka(), mapa.getY_coveka(), 4);
                    else mapa.set(mapa.getX_Coveka(), mapa.getY_coveka(), 2); //trenutna pozicija se oslobadja

                    mapa.SetPozicija(2, mapa.getX_Coveka(), mapa.getY_coveka()+1);//pozicija coveka je nova pozicija
                }
                else if (mapa.getIJ(mapa.getX_Coveka(), mapa.getY_coveka() + 1) == 4) //AKO JE ISPRED MESTO ZA KUTIJU
                {

                    mapa.set(mapa.getX_Coveka(), mapa.getY_coveka() + 1, 10); // sada je ovde na mapi covek (5*2=10)
                    if(mapa.getIJ(mapa.getX_Coveka(), mapa.getY_coveka())==10)
                        mapa.set(mapa.getX_Coveka(), mapa.getY_coveka(), 4);
                    else mapa.set(mapa.getX_Coveka(), mapa.getY_coveka(), 2);

                    mapa.SetPozicija(2, mapa.getX_Coveka(), mapa.getY_coveka() + 1);//pozicija coveka je nova pozicija
                }
                else if (mapa.getIJ(mapa.getX_Coveka() , mapa.getY_coveka()+1) == 3
                    || mapa.getIJ(mapa.getX_Coveka(), mapa.getY_coveka() + 1) == 6) //AKO IDE NAIDJE KUTIJU U PRAZNO POLJE ILI POLJE ZA KUTIJU
                {                   
                         
                    if (mapa.getIJ(mapa.getX_Coveka(), mapa.getY_coveka() + 2) == 2) //kutija izlazi u slobodno polje
                    {
                        mapa.set(mapa.getX_Coveka(), mapa.getY_coveka() + 2, 3); //kutija slobodna

                        if (mapa.getIJ(mapa.getX_Coveka(), mapa.getY_coveka()) == 10)
                        {
                            mapa.set(mapa.getX_Coveka(), mapa.getY_coveka(), 4);
                        }
                        else if (mapa.getIJ(mapa.getX_Coveka(), mapa.getY_coveka()) == 5)
                        {
                            mapa.set(mapa.getX_Coveka(), mapa.getY_coveka(), 2);
                        }
                         if (mapa.getIJ(mapa.getX_Coveka() , mapa.getY_coveka()+1) == 3)
                        mapa.set(mapa.getX_Coveka(), mapa.getY_coveka() + 1, 5);
                         if (mapa.getIJ(mapa.getX_Coveka(), mapa.getY_coveka() + 1) == 6)
                             mapa.set(mapa.getX_Coveka(), mapa.getY_coveka() + 1, 10);                         
                                                     

                        mapa.SetPozicija(2, mapa.getX_Coveka(), mapa.getY_coveka() + 1);//pozicija coveka je nova pozicija
                    }
                    if (mapa.getIJ(mapa.getX_Coveka(), mapa.getY_coveka() + 2) == 4) //kutija u mesto za kutiju
                    {
                        mapa.set(mapa.getX_Coveka(), mapa.getY_coveka() + 2, 6); //kutija u mestu za kutiju

                        if (mapa.getIJ(mapa.getX_Coveka(), mapa.getY_coveka() + 1) ==6){
                            mapa.set(mapa.getX_Coveka(), mapa.getY_coveka() + 1, 10); // sada je ovde na mapi covek
                        }
                        else if (mapa.getIJ(mapa.getX_Coveka(), mapa.getY_coveka() + 1) == 3) 
                            mapa.set(mapa.getX_Coveka(), mapa.getY_coveka() + 1, 5);

                        if (mapa.getIJ(mapa.getX_Coveka(), mapa.getY_coveka()) == 10)
                        {
                            mapa.set(mapa.getX_Coveka(), mapa.getY_coveka(), 4);
                        }
                        else if (mapa.getIJ(mapa.getX_Coveka(), mapa.getY_coveka()) == 5)
                        {
                            mapa.set(mapa.getX_Coveka(), mapa.getY_coveka(), 2);
                        }
                         
                        mapa.SetPozicija(2, mapa.getX_Coveka(), mapa.getY_coveka() + 1);//pozicija coveka je nova pozicija
                    }
                }
                
            }
            else if (e.KeyCode == Keys.Left)
            {
                mapa.SetPozicija(4, mapa.getX_Coveka(), mapa.getY_coveka());
                if (mapa.getIJ(mapa.getX_Coveka(), mapa.getY_coveka() - 1) == 2)
                {
                    mapa.set(mapa.getX_Coveka(), mapa.getY_coveka() - 1, 5); // sada je ovde na mapi covek
                    if (mapa.getIJ(mapa.getX_Coveka(), mapa.getY_coveka()) == 10)
                        mapa.set(mapa.getX_Coveka(), mapa.getY_coveka(), 4);
                    else mapa.set(mapa.getX_Coveka(), mapa.getY_coveka(), 2); //trenutna pozicija se oslobadja
                    mapa.SetPozicija(4, mapa.getX_Coveka(), mapa.getY_coveka() - 1);//pozicija coveka je nova pozicija
                }
                else if (mapa.getIJ(mapa.getX_Coveka(), mapa.getY_coveka() - 1) == 4)
                {

                    mapa.set(mapa.getX_Coveka(), mapa.getY_coveka() - 1, 10); // sada je ovde na mapi covek
                    if (mapa.getIJ(mapa.getX_Coveka(), mapa.getY_coveka()) == 10)
                        mapa.set(mapa.getX_Coveka(), mapa.getY_coveka(), 4);
                    else mapa.set(mapa.getX_Coveka(), mapa.getY_coveka(), 2);
                    mapa.SetPozicija(4, mapa.getX_Coveka(), mapa.getY_coveka() - 1);//pozicija coveka je nova pozicija
                
                }
                else if (mapa.getIJ(mapa.getX_Coveka(), mapa.getY_coveka() - 1) == 3
                    || mapa.getIJ(mapa.getX_Coveka(), mapa.getY_coveka() - 1) == 6) //ako ide na kutiju
                {

                    if (mapa.getIJ(mapa.getX_Coveka(), mapa.getY_coveka() - 2) == 2) //kutija izlazi u slobodno polje
                    {
                        mapa.set(mapa.getX_Coveka(), mapa.getY_coveka() - 2, 3); //kutija slobodna

                        if (mapa.getIJ(mapa.getX_Coveka(), mapa.getY_coveka()) == 10)
                        {
                            mapa.set(mapa.getX_Coveka(), mapa.getY_coveka(), 4);
                        }
                        else if (mapa.getIJ(mapa.getX_Coveka(), mapa.getY_coveka()) == 5)
                        {
                            mapa.set(mapa.getX_Coveka(), mapa.getY_coveka(), 2);
                        }
                        if (mapa.getIJ(mapa.getX_Coveka(), mapa.getY_coveka() - 1) == 3)
                            mapa.set(mapa.getX_Coveka(), mapa.getY_coveka() - 1, 5);
                        if (mapa.getIJ(mapa.getX_Coveka(), mapa.getY_coveka() - 1) == 6)
                            mapa.set(mapa.getX_Coveka(), mapa.getY_coveka() - 1, 10);


                        mapa.SetPozicija(4, mapa.getX_Coveka(), mapa.getY_coveka() - 1);//pozicija coveka je nova pozicija
                    }
                    if (mapa.getIJ(mapa.getX_Coveka(), mapa.getY_coveka() - 2) == 4) //kutija u mesto za kutiju
                    {
                        mapa.set(mapa.getX_Coveka(), mapa.getY_coveka() - 2, 6); //kutija u mestu za kutiju

                        if (mapa.getIJ(mapa.getX_Coveka(), mapa.getY_coveka() - 1) == 6)
                        {
                            mapa.set(mapa.getX_Coveka(), mapa.getY_coveka() - 1, 10); // sada je ovde na mapi covek
                        }
                        else if (mapa.getIJ(mapa.getX_Coveka(), mapa.getY_coveka() - 1) == 3)
                            mapa.set(mapa.getX_Coveka(), mapa.getY_coveka() - 1, 5);

                        if (mapa.getIJ(mapa.getX_Coveka(), mapa.getY_coveka()) == 10)
                        {
                            mapa.set(mapa.getX_Coveka(), mapa.getY_coveka(), 4);
                        }
                        else if (mapa.getIJ(mapa.getX_Coveka(), mapa.getY_coveka()) == 5)
                        {
                            mapa.set(mapa.getX_Coveka(), mapa.getY_coveka(), 2);
                        }


                        mapa.SetPozicija(4, mapa.getX_Coveka(), mapa.getY_coveka() - 1);//pozicija coveka je nova pozicija
                    }
                }
            }

            iscrtaj();
        }
       

        private void resetujNivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            inicializacijaNivoa.InicializujNivo(ref mapa, nivo);
            iscrtaj();
        }

        private void zavrsiOvdeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            upisiRez(this.nivo-1);
            muzika();
        }

        private void lbl_rez_Click(object sender, EventArgs e)
        {
            if (baza.conected == false) baza.conect(); 
            if (baza.conected)
            {
                show_hideMeni(false); this.lbl_nazad.Visible = true;
                prikaziRezultate();
                baza.CloseConnection();
            }
            else
            {
                MessageBox.Show(this, "Doslo je do greske. Greska: Konekcija sa bazom nije uspesna.");
            }
            muzika();
        }
        private void prikaziRezultate()
        {
          
                rez = baza.getRez();

                sortirajRez(ref rez);

                int br1 = 0; int br2 = 1;
                for (int j = 0; j < 10; j++) //levo labele za igrace (prebaceno iz konstruktora jer ovde znam tacan broj igraca)
                {
                    lbl_lista_Rangiranja[j] = new Label();
                    lbl_lista_Rangiranja[j].Location = new Point(w / 2, h / 4 + j * 50);
                    lbl_lista_Rangiranja[j].BackColor = Color.Transparent;
                    lbl_lista_Rangiranja[j].ForeColor = System.Drawing.Color.DarkSalmon;
                    lbl_lista_Rangiranja[j].Font = new System.Drawing.Font("Rockwell", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    lbl_lista_Rangiranja[j].BackColor = System.Drawing.Color.Gainsboro;
                    lbl_lista_Rangiranja[j].Size = new System.Drawing.Size(160, 25);

                    lbl_lista_Rangiranja[j].Text = rez[br1] + rez[br2];// " " + Convert.ToString(rez.Count()) + " ";
                    br1 += 2; br2 += 2;
                    Controls.Add(lbl_lista_Rangiranja[j]);

                }
            
            lbl_lista_Rangiranjapomocna1.Location = new Point(w / 2, h / 4 - 50); 
            lbl_lista_Rangiranjapomocna1.Font = new System.Drawing.Font("Rockwell", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lbl_lista_Rangiranjapomocna1.Size = new System.Drawing.Size(120, 40);
            lbl_lista_Rangiranjapomocna1.Text = "Nivo|Igrac";
            lbl_lista_Rangiranjapomocna1.Visible = true;            
            Controls.Add(lbl_lista_Rangiranjapomocna1);

            lbl_lista_Rangiranjapomocna2.Location = new System.Drawing.Point(w / 5, h / 4);
            lbl_lista_Rangiranjapomocna2.Font = new System.Drawing.Font("Rockwell", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lbl_lista_Rangiranjapomocna2.Visible = true;
            lbl_lista_Rangiranjapomocna2.Text = "Rang lista";
            lbl_lista_Rangiranjapomocna2.Size = new System.Drawing.Size(200, 60);
            Controls.Add(lbl_lista_Rangiranjapomocna2);
        }
        private void sortirajRez(ref List<String> rez)
        {
            for (int i = 0; i < rez.Count()-2; i += 2) //sortira ceo niz, a gore prikazuje top 10 rezultata
            {
                for (int j = i + 2; j < rez.Count(); j += 2)
                {
                    if (Int32.Parse(rez[i]) < Int32.Parse(rez[j]))
                    {
                        string rezultat = rez[i];
                        string name = rez[i + 1];
                        rez[i] = rez[j];
                        rez[i + 1] = rez[j + 1];
                        rez[j] = rezultat;
                        rez[j + 1] = name;
                    }
                }
            }

        }

        private void lbl_nazad_Click(object sender, EventArgs e)
        {
            this.lbl_nazad.Visible = false;
            this.lbl_nazad.Text = "Nazad";
            for (int i = 0; i < 10; i++)
            {
                lbl_lista_Rangiranja[i].Visible = false;
            }
             
            show_hideMeni(true);

            if (stanje == 2)
            {
                String ime = "  "+textBox_zaUpisRez.Text;
                if(nivo==krajnjiNivo)
                      baza.Insert(nivo, ime);
                else baza.Insert(nivo-1, ime);

                baza.CloseConnection();
                this.textBox_zaUpisRez.Enabled = false;
                this.textBox_zaUpisRez.Visible = false;
                
            }
            stanje = 0;
            textBox_zaUpisRez.Visible = false;
            muzika();
        }

        private void vratiPotezToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mapa = mapa.MapaCopy(mapaBack);
            iscrtaj();
        }

        private void lbl_reset_Click(object sender, EventArgs e)
        {
            pamtiCirajFail.zapamtiUFail(0);
            MessageBox.Show("Resetovali ste nivo. Sada krecete od 1. nivoa");
        }

       

     

       

              

       
       
    }
}
