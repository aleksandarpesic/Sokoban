using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace Sokoban
{
    class Mapa
    {
        /*
        Vrednosti u promenljivu polje:
         * 1 zid
         * 2 prazno
         * 3 kutija
         * 4 mesto za kutiju (gde treba da se smesti)
         * 5 pozicija coveka
         * 6 KUTIJA STOJI NA MESTO ZA KUTIJU (vrednost: 3*2)
         * 10 COVEK STOJI NA MESTU ZA KUTIJE (vrednost: 5*2)
         --------
         * okrenut prema:
         * 1 ide ka nama(gledamu mu facu), 3 ide od nas (gladamo mu ledja)
         * 2 ide desno, 4 ide levo
        */
        private List<List<int>> polje = new List<List<int>>();
        private int okrenut_prema,x,y;
        SoundPlayer sndPing = new SoundPlayer("Resource/move.wav");
        public Mapa()
        {
            for (int i = 0; i < 17; i++)
            {
                List<int> tmp = new List<int>();
                for (int j = 0; j < 22; j++)
                {
                    tmp.Add(1);
                }
                polje.Add(tmp);
            }
            okrenut_prema = 1;
          
        }

        public void set(int i, int j, int val)
        {
            polje[i][j] = val;
            if (val == 3 || val == 6) sndPing.Play();
        }
        public void setNoVoice(int i, int j, int val)
        {
            polje[i][j] = val;           
        }
        public int getIJ(int i, int j) 
        {
            return polje[i][j];
        }
        public int GetOkrenut_prema() { return okrenut_prema; }
        public void SetPozicija(int okrenut, int xx, int yy){
            okrenut_prema=okrenut;
            x = xx;
            y = yy;
        }
        public int getX_Coveka() { return x; }
        public int getY_coveka() { return y; }
        public bool krajNivoa(int iTable,int jTable)
        {
            bool kraj = true;
            for (int i = 0; i < iTable; i++)
            {
                for (int j = 0; j < jTable; j++)
                {
                    if (polje[i][j] == 3) kraj = false; //ako ima kutija koja nije na mestu za kutije nije kraj igre jos
                }
            }
            return kraj;
        }

        public Mapa MapaCopy(Mapa copy)
        {
            Mapa tmp=new Mapa();

            for (int i = 0; i < 17; i++)
            {
                List<int> tmplist = new List<int>();
                for (int j = 0; j < 22; j++)
                {
                    tmp.setNoVoice(i, j, copy.getIJ(i, j));
                }                
            }

            tmp.okrenut_prema = copy.okrenut_prema;
            tmp.sndPing = copy.sndPing;
            tmp.x = copy.x;
            tmp.y = copy.y;

            return tmp;
        }
    }
}
