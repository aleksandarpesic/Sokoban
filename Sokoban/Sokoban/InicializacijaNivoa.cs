using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sokoban
{
    class InicializacijaNivoa
    {
        public InicializacijaNivoa()
        {
        }

        public void InicializujNivo(ref Mapa mapa, int brojNivoa)
        {
            mapa=new Mapa();
            switch (brojNivoa)
            {
                case 1: Nivo1(ref mapa);
                break;
                case 2: Nivo2(ref mapa);
                break;
                case 3: Nivo3(ref mapa);
                break;
                case 4: Nivo4(ref mapa);
                break;
                case 5: Nivo5(ref mapa);
                break;
                case 6: Nivo6(ref mapa);
                break;
                case 7: Nivo7(ref mapa);
                break;
                case 8: Nivo8(ref mapa);
                break;
                case 9: Nivo9(ref mapa);
                break;
                case 10: Nivo10(ref mapa);
                break;
                case 11: Nivo11(ref mapa);
                break;
                case 12: Nivo12(ref mapa);
                break;
            }

        }

        private void Nivo12(ref Mapa mapa)
        {
            for (int i = 0; i < 15; i++)
            {
                if (i == 3)
                {
                    for (int j = 2; j <= 15; j++) mapa.set(i, j, 2);
                }
                if (i == 4)
                {
                    mapa.set(i, 2, 2); mapa.set(i, 4, 2); 
                    for (int j = 11; j <= 15; j++) mapa.set(i, j, 2);
                }
                if (i == 5)
                {
                    mapa.set(i, 2, 2); mapa.set(i, 14, 2); mapa.set(i, 15, 2);
                    for (int j = 4; j <= 12; j++) mapa.set(i, j, 2);
                }
                if (i == 6)
                {
                    for (int j = 4; j <= 7; j++) mapa.set(i, j, 2);
                    for (int j = 9; j <= 12; j++) mapa.set(i, j, 2);
                    mapa.set(i, 2, 2); mapa.set(i, 15, 2);
                }
                if (i == 7)
                {
                    for (int j = 6; j <= 10; j++) mapa.set(i, j, 2);
                    mapa.set(i, 2, 2); mapa.set(i, 4, 2); 
                }
                if (i == 8)
                {
                    mapa.set(i, 2, 2); 
                    for (int j = 4; j <=11; j++) mapa.set(i, j, 2);
                }
                if (i == 9)
                {
                    for (int j = 6; j <= 11; j++) mapa.set(i, j, 2);
                    mapa.set(i, 2, 2);
                }
                if (i == 10)
                {
                    for (int j = 2; j <= 6; j++) mapa.set(i, j, 2);
                    mapa.set(i, 8, 2); mapa.set(i, 11, 2);
                }
                if (i == 11)
                {
                  
                    for (int j = 6; j <= 8; j++) mapa.set(i, j, 2);
                    mapa.set(i, 11, 2);
                }
                if (i == 12)
                {
                    
                    for (int j = 10; j <= 14; j++) mapa.set(i, j, 2);
                }
                if (i == 13)
                {
                    for (int j = 10; j <= 14; j++) mapa.set(i, j, 2);
                }

            }
            //postavljam kutije

            mapa.set(5, 6, 3); mapa.set(5, 8, 3);
            mapa.set(5, 10, 3); mapa.set(5, 10, 3);
            mapa.set(5,12, 3);

            mapa.set(6, 7, 3); mapa.set(6, 9, 3);

            mapa.set(7, 6, 3); mapa.set(7, 10, 3); mapa.set(7, 8, 3);
            mapa.set(8, 7, 3); mapa.set(8, 9, 3);
            mapa.set(9, 6, 3); mapa.set(9, 7, 3);
            mapa.set(9, 8, 3); mapa.set(9, 10, 3);


            //postavljam mesto za kutije
            for (int i = 7; i <= 11; i++)
            {
                mapa.set(i, 14, 4); mapa.set(i, 15, 4); mapa.set(i, 16, 4);
            }
           
            //postavljam coveka
            mapa.set(6, 8, 5);
            mapa.SetPozicija(1, 6, 8);
        }


        private void Nivo11(ref Mapa mapa)
        {
            for (int i = 0; i < 15; i++)
            {
                if (i == 2)
                {
                    mapa.set(i, 11, 2);
                   mapa.set(i, 12, 2);
                }
                if (i == 3)
                {
                    mapa.set(i, 6, 2); mapa.set(i, 7, 2); mapa.set(i, 11, 2);
                    mapa.set(i, 12, 2);
                }
                if (i == 4)
                {
                    mapa.set(i, 6, 2); mapa.set(i, 4, 2); mapa.set(i, 5, 2);
                    for (int j = 8; j <= 12; j++) mapa.set(i, j, 2);
                }
                if (i == 5)
                {
                    for (int j = 3; j <= 8; j++) mapa.set(i, j, 2);
                    mapa.set(i, 11, 2);
                }
                if (i == 6)
                {
                    for (int j = 8; j <= 12; j++) mapa.set(i, j, 2);
                    mapa.set(i, 2, 2); mapa.set(i, 3, 2); mapa.set(i, 5, 2);

                }
                if (i == 7)
                {
                    mapa.set(i, 2, 2); mapa.set(i, 11, 2);
                    for (int j = 4; j <= 9; j++) mapa.set(i, j, 2);                    
                }
                if (i == 8)
                {
                    for (int j = 2; j <= 6; j++) mapa.set(i, j, 2);
                    mapa.set(i, 8, 2); mapa.set(i, 9, 2);
                    for (int j = 11; j <= 13; j++) mapa.set(i, j, 2); 
                }
                if (i == 9)
                {
                    for (int j = 9; j <= 13; j++) mapa.set(i, j, 2);
                    for (int j = 4; j <= 7; j++) mapa.set(i, j, 2);
                    for (int j = 15; j <= 17; j++) mapa.set(i, j, 2);
                }
                if (i == 10)
                {
                    mapa.set(i, 4, 2); 
                    for (int j = 7; j <= 17; j++) mapa.set(i, j, 2);
                }
                if (i == 11)
                {
                    mapa.set(i, 10, 2); mapa.set(i, 9, 2);
                    for (int j = 2; j <= 5; j++) mapa.set(i, j, 2);
                }
                if (i == 12)
                {
                    mapa.set(i, 3, 2); mapa.set(i, 4, 2);                   
                }
               
            }
            //postavljam kutije

            mapa.set(3, 11, 3); mapa.set(4, 10, 3);
            mapa.set(5, 5, 3); mapa.set(5, 7, 3);
            mapa.set(5, 8, 3);
            
            mapa.set(6, 5, 3);
            mapa.set(7, 5, 3); mapa.set(7, 7, 3); mapa.set(7, 8, 3);
            mapa.set(8, 5, 3); mapa.set(8, 12, 3);
            mapa.set(9, 12, 3); mapa.set(9, 11, 3);
            mapa.set(10, 8, 3);
            

            //postavljam mesto za kutije
            for (int i = 1; i <= 5; i++)
            {
                mapa.set(14, i, 4); 
            }
            mapa.set(12, 5, 4);
            mapa.set(12, 2, 4); mapa.set(12, 1, 4); mapa.set(12, 4, 4);
            mapa.set(11, 1, 4); 

            mapa.set(13, 1, 4); mapa.set(13, 2, 4); mapa.set(13, 3, 4);mapa.set(13, 5, 4);
            //postavljam coveka
            mapa.set(4,7, 5);
            mapa.SetPozicija(1, 4, 7);
        }


        private void Nivo10(ref Mapa mapa)
        {
            for (int i = 0; i < 15; i++)
            {
                if (i == 1)
                {
                    for (int j = 7; j <= 13; j++) mapa.set(i, j, 2);
                    for (int j = 15; j <= 17; j++) mapa.set(i, j, 2);
                }
                if (i == 2)
                {
                    for (int j = 1; j <= 14; j++) mapa.set(i, j, 2);
                }
                if (i == 3)
                {
                    for (int j = 1; j <= 5; j++) mapa.set(i, j, 2);
                    for (int j = 7; j <= 13; j++) mapa.set(i, j, 2);
                }
                if (i == 4)
                {
                    for (int j = 1; j <= 5; j++) mapa.set(i, j, 2);
                    for (int j = 7; j <= 13; j++) mapa.set(i, j, 2);
                }
                if (i == 5)
                {
                    for (int j = 3; j <= 5; j++) mapa.set(i, j, 2);
                    for (int j = 7; j <= 13; j++) mapa.set(i, j, 2);

                }
                if (i == 6)
                {
                    for (int j = 1; j <= 5; j++) mapa.set(i, j, 2);
                    for (int j = 7; j <= 13; j++) mapa.set(i, j, 2);
                }
                if (i == 7)
                {
                    for (int j = 1; j <= 4; j++) mapa.set(i, j, 2);
                    mapa.set(i, 11, 2);
                }
                if (i == 8)
                {
                    mapa.set(i, 2, 2); mapa.set(i, 4, 2); mapa.set(i, 5, 2);
                    for (int j = 7; j <= 13; j++) mapa.set(i, j, 2);
                }
                if (i == 9)
                {
                    mapa.set(i, 1, 2); mapa.set(i, 2, 2); mapa.set(i, 5, 2);
                    for (int j = 7; j <= 13; j++) mapa.set(i, j, 2);                  
                }
                if (i == 10)
                {
                    mapa.set(i, 1, 2); mapa.set(i, 5, 2);
                    for (int j = 7; j <= 15; j++) mapa.set(i, j, 2);
                }
                if (i == 11)
                {
                    mapa.set(i, 1, 2); mapa.set(i, 5, 2);
                    for (int j = 7; j <= 15; j++) mapa.set(i, j, 2);
                }
                if (i == 12)
                {
                    mapa.set(i, 5, 2);
                    for (int j = 7; j <= 13; j++) mapa.set(i, j, 2);
                    mapa.set(i, 15, 2);
                }
                if (i == 13)
                {
                    mapa.set(i, 5, 2);
                    mapa.set(i, 15, 2);
                }
                if (i == 14)
                {
                    for (int j = 5; j <= 15; j++) mapa.set(i, j, 2);
                }
            }
            //postavljam kutije
            
            mapa.set(2, 3, 3); mapa.set(2, 7, 3);
            mapa.set(2, 8, 3); mapa.set(2, 11, 3);
            mapa.set(2, 13, 3);
            for (int j = 2; j <= 5; j++) mapa.set(3, j, 3);
            mapa.set(3, 11, 3);
            mapa.set(4, 4, 3); mapa.set(4, 8, 3);
            mapa.set(4, 9, 3); mapa.set(4, 11, 3);
            mapa.set(4, 12, 3); 
            mapa.set(5, 9, 3);
            mapa.set(6, 8, 3); mapa.set(6, 10, 3); mapa.set(6, 12, 3);
            mapa.set(8, 9, 3); mapa.set(8, 11, 3);
            mapa.set(9, 9, 3); mapa.set(9, 11, 3);
            mapa.set(9, 8, 3); mapa.set(9, 13, 3);
            mapa.set(10, 9, 3);
            mapa.set(11, 8, 3); mapa.set(11, 9, 3); mapa.set(11, 10, 3);
            mapa.set(11, 12, 3); mapa.set(11, 13, 3); mapa.set(11, 14, 3);

            //postavljam mesto za kutije
            for (int i = 2; i <= 8; i++)
            {
                mapa.set(i, 15, 4); mapa.set(i, 16, 4); mapa.set(i, 17, 4);
            }
            mapa.set(9, 16, 4); mapa.set(9, 17, 4);
            mapa.set(10, 2, 4); mapa.set(10, 3, 4); mapa.set(10, 17, 4);
            mapa.set(11, 2, 4); mapa.set(11, 3, 4); mapa.set(11, 17, 4);

            mapa.set(12, 17, 4); mapa.set(13, 17, 4); mapa.set(14, 17, 4);
            //postavljam coveka
            mapa.set(1, 2, 5);
            mapa.SetPozicija(1, 1, 2);
        }


        private void Nivo9(ref Mapa mapa)
        {
            for (int i = 0; i < 15; i++)
            {
                if (i == 2)
                {
                    mapa.set(i, 12, 2); mapa.set(i, 13, 2);
                }
                if (i == 3)
                {
                    mapa.set(i, 12, 2); mapa.set(i, 13, 2);
                }
                if (i == 4)
                {
                    mapa.set(i, 15, 2); 
                    for (int j = 8; j <= 13; j++) mapa.set(i, j, 2);
                    
                }
                if (i == 5)
                {
                    mapa.set(i, 12, 2); mapa.set(i, 13, 2);
                    mapa.set(i, 8, 2); mapa.set(i, 9, 2);
                }
                if (i == 6)
                {
                    mapa.set(i, 9, 2); mapa.set(i, 12, 2); mapa.set(i, 13, 2);

                }
                if (i == 7)
                {
                    mapa.set(i, 9, 2);
                    
                }
                if (i == 8)
                {
                    for (int j = 7; j <= 11; j++) mapa.set(i, j, 2);
                  
                }
                if (i == 9)
                {
                    for (int j = 7; j <= 12; j++) mapa.set(i, j, 2);                    
                }
                if (i == 10)
                {
                    mapa.set(i, 3, 2); mapa.set(i, 4, 2); mapa.set(i, 5, 2); 
                    for (int j = 7; j <= 12; j++) mapa.set(i, j, 2);
                    mapa.set(i, 3, 2); mapa.set(i, 4, 2); mapa.set(i, 5, 2);
                    mapa.set(i, 14, 2); mapa.set(i, 15, 2); mapa.set(i, 16, 2);
                }
                if (i == 11)
                {
                    for (int j = 3; j <= 16; j++) mapa.set(i, j, 2);
                }
                if (i == 12)
                {
                    for (int j = 7; j <= 12; j++) mapa.set(i, j, 2);
                }
                if (i == 13)
                {
                    for (int j = 7; j <= 12; j++) mapa.set(i, j, 2);
                }
            }
            //postavljam kutije
            for (int j = 8; j <= 10; j++)  mapa.set(8, j, 3);
            mapa.set(9, 11, 3); mapa.set(9, 9, 3);
            mapa.set(10, 7, 3); mapa.set(10, 9, 3);
            mapa.set(11, 7, 3); mapa.set(11, 4, 3);
            mapa.set(11, 12, 3); mapa.set(11, 15, 3);
            mapa.set(12, 8, 3); mapa.set(12, 9, 3);
            mapa.set(12, 11, 3); 
            
            //postavljam mesto za kutije
            for (int i = 2; i <= 6; i++)
            {
                if (i == 4) {
                    mapa.set(i, 14, 4); mapa.set(i, 16, 4);
                }
                else
                {
                    mapa.set(i, 14, 4); mapa.set(i, 16, 4); mapa.set(i, 15, 4);
                }
            }


            //postavljam coveka
            mapa.set(11, 2, 5);
            mapa.SetPozicija(1, 11, 2);
        }


        private void Nivo8(ref Mapa mapa)
        {
            for (int i = 0; i < 15; i++)
            {
                if (i == 1)
                {
                    mapa.set(i, 6, 2); mapa.set(i, 5, 2); 
                }                
                if (i == 2)
                {
                    for (int j = 5; j <= 16; j++) mapa.set(i, j, 2);
                }
                if (i == 3)
                {
                    mapa.set(i, 6, 2); mapa.set(i, 5, 2);
                    for (int j = 8; j <= 10; j++) mapa.set(i, j, 2);
                    for (int j = 12; j <= 16; j++) mapa.set(i, j, 2);
                }
                if (i == 4)
                {
                    for (int j = 5; j <= 11; j++) mapa.set(i, j, 2);
                    for (int j = 13; j <= 16; j++) mapa.set(i, j, 2);
                }
                if (i == 5)
                {
                    mapa.set(i, 5, 2); mapa.set(i, 6, 2); mapa.set(i, 8, 2); mapa.set(i, 10, 2);
                    mapa.set(i, 11, 2); mapa.set(i, 16, 2);
                    
                }
                if (i == 6)
                {
                    mapa.set(i, 3, 2);
                    for (int j = 5; j <= 11; j++) mapa.set(i, j, 2);
                    for (int j = 14; j <= 16; j++) mapa.set(i, j, 2);
                }
                if (i == 7)
                {
                    for (int j = 4; j <= 8; j++) mapa.set(i, j, 2);
                    mapa.set(i, 10, 2); mapa.set(i, 16, 2);
                    for (int j = 12; j <= 14; j++) mapa.set(i, j, 2);
                }
                if (i == 8)
                {
                    for (int j = 3; j <= 16; j++) mapa.set(i, j, 2);
                }
                if (i == 9)
                {
                    mapa.set(i, 7, 2); mapa.set(i, 8, 2);
                }
                if (i == 10)
                {
                    for (int j = 5; j <= 10; j++) mapa.set(i, j, 2);
                }
                if (i == 11)
                {
                    for (int j = 5; j <= 10; j++) mapa.set(i, j, 2);
                }
            }
            //postavljam kutije
            mapa.set(2, 9, 3); mapa.set(2, 13, 3);
            mapa.set(2, 15, 3);
            mapa.set(3, 6, 3); mapa.set(3, 9, 3); mapa.set(3, 14, 3);
            mapa.set(4, 7, 3); mapa.set(4, 9, 3);
            mapa.set(5, 6, 3); mapa.set(6, 5, 3);
            mapa.set(6, 7, 3); mapa.set(6, 7, 3);
            mapa.set(7, 7, 3); mapa.set(7, 10, 3);
            mapa.set(8, 6, 3); mapa.set(8, 11, 3); mapa.set(8, 13, 3); mapa.set(8, 15, 3);
            mapa.set(6, 9, 3);
            //postavljam mesto za kutije
            for (int i = 12; i <= 14; i++)
            {
                mapa.set(i, 5, 4); mapa.set(i, 6, 4); mapa.set(i, 7, 4); mapa.set(i, 8, 4); mapa.set(i, 9, 4); mapa.set(i, 10, 4);
            }           


            //postavljam coveka
            mapa.set(7, 3, 5);
            mapa.SetPozicija(1, 7, 3);
        }

        private void Nivo7(ref Mapa mapa)
        {
            for (int i = 0; i < 15; i++)
            {
                if (i == 4)
                {
                    for (int j = 12; j <= 14; j++) mapa.set(i, j, 2);
                }
                if (i == 5)
                {
                    mapa.set(i, 6, 2); mapa.set(i, 8, 2); mapa.set(i, 12, 2); mapa.set(i, 15, 2); 
                }
                if (i == 6)
                {
                    for (int j = 5; j <= 8; j++) mapa.set(i, j, 2);
                    for (int j = 10; j <= 15; j++) mapa.set(i, j, 2);  
                }
                if (i == 7)
                {
                    mapa.set(i, 5, 2); mapa.set(i, 8, 2); mapa.set(i, 9, 2); mapa.set(i, 6, 2);
                    for (int j = 13; j <= 15; j++) mapa.set(i, j, 2);
                }
                if (i == 8)
                {
                    mapa.set(i, 7, 2);                    
                }
                if (i == 9)
                {
                    mapa.set(i, 5, 2); mapa.set(i, 7, 2);
                    mapa.set(i, 8, 2); mapa.set(i, 12, 2);

                }
                if (i == 10)
                {
                    mapa.set(i, 5, 2); mapa.set(i, 9, 2);
                    mapa.set(i,7, 2); mapa.set(i, 11, 2);
                }
                if (i == 11)
                {
                    for (int j = 5; j <= 8; j++) mapa.set(i, j, 2);
                }
                if (i == 12)
                {
                    mapa.set(i, 8, 2); mapa.set(i, 5, 2); 
                }
                if (i == 13)
                {
                    mapa.set(i, 5, 2); mapa.set(i, 6, 2);
                }
            }
            //postavljam kutije
            mapa.set(5, 13, 3); mapa.set(5, 14, 3);
            mapa.set(6, 9, 3);
            mapa.set(7, 7, 3); mapa.set(8, 13, 3); mapa.set(9, 6, 3);
            mapa.set(10, 6, 3); mapa.set(10, 8, 3);
            mapa.set(10, 10, 3); mapa.set(12, 6, 3);
            mapa.set(12, 7, 3);

            //postavljam mesto za kutije
            mapa.set(9, 13, 4); mapa.set(9, 14, 4);
            mapa.set(10, 13, 4); mapa.set(10, 14, 4); mapa.set(10, 12, 4);
            mapa.set(11, 13, 4); mapa.set(11, 14, 4); mapa.set(11, 12, 4);
            mapa.set(12, 13, 4); mapa.set(12, 14, 4); mapa.set(12, 12, 4);
            

            //postavljam coveka
            mapa.set(5, 9, 5);
            mapa.SetPozicija(1, 5, 9);
        }


        private void Nivo6(ref Mapa mapa)
        {
            for (int i = 0; i < 15; i++)
            {
                if (i == 4)
                {
                    for (int j = 7; j <= 8; j++) mapa.set(i, j, 2);
                }
                if (i == 5)
                {
                    mapa.set(i, 7, 2); mapa.set(i, 8, 2); mapa.set(i, 12, 2); mapa.set(i, 13, 2); mapa.set(i, 14, 2);
                }
                if (i == 6)
                {
                    for (int j = 7; j <= 11; j++) mapa.set(i, j, 2);
                    mapa.set(i, 14, 2);
                }
                if (i == 7)
                {
                    mapa.set(i, 7, 2); mapa.set(i, 8, 2); mapa.set(i, 10, 2); mapa.set(i, 12, 2); mapa.set(i, 14, 2);
                }
                if (i == 8)
                {
                    mapa.set(i, 10, 2); 
                    mapa.set(i, 12, 2); mapa.set(i, 14, 2);
                }
                if (i == 9)
                {
                    mapa.set(i, 10, 2); mapa.set(i, 8, 2);
                    mapa.set(i, 13, 2); mapa.set(i, 14, 2);

                }
                if (i == 10)
                {
                    mapa.set(i, 8, 2); mapa.set(i, 9, 2); 
                    mapa.set(i, 12, 2); mapa.set(i, 14, 2);
                }
                if (i == 11)
                {
                    mapa.set(i, 8, 2); mapa.set(i, 11, 2); mapa.set(i, 13, 2);
                    mapa.set(i, 14, 2); mapa.set(i, 10, 2);
                }
                if (i == 12)
                {
                    mapa.set(i, 8, 2); mapa.set(i, 12, 2); mapa.set(i, 14, 2); 
                    mapa.set(i, 9, 2); mapa.set(i, 13, 2);
                }               
            }
            //postavljam kutije
            mapa.set(6, 12, 3); mapa.set(6, 13, 3);
               mapa.set(7, 13, 3);
                mapa.set(8, 13, 3); mapa.set(9, 9, 3);mapa.set(9, 12, 3);
                mapa.set(10, 10, 3); mapa.set(10, 13, 3);
                mapa.set(11,12, 3); mapa.set(11,9, 3); 
              
             
            //postavljam mesto za kutije
            for (int j = 4; j <= 8; j++)
            {
                mapa.set(j, 5, 4); mapa.set(j, 6, 4); 
            }

            //postavljam coveka
            mapa.set(4, 13, 5);
            mapa.SetPozicija(1, 4, 13);
        }

        private void Nivo5(ref Mapa mapa)
        {
            for (int i = 0; i < 15; i++)
            {
                if (i == 3)
                {
                    for (int j = 10; j <= 12; j++) mapa.set(i, j, 2);
                }
                 if (i == 4)
                {
                    mapa.set(i, 10, 2); mapa.set(i, 15, 2); mapa.set(i, 16, 2); mapa.set(i, 12, 2);
                }
                 if (i == 5)
                {
                    for (int j = 10; j <= 16; j++) mapa.set(i, j, 2);                   
                }
                 if (i == 6)
                {
                    mapa.set(i, 10, 2); mapa.set(i, 14, 2); mapa.set(i, 15, 2); mapa.set(i, 16, 2);
                }
                 if (i == 7)
                {
                    mapa.set(i, 6, 2); mapa.set(i, 7, 2); mapa.set(i, 10, 2); mapa.set(i, 12, 2);  mapa.set(i, 13, 2);
                    mapa.set(i, 11, 2); mapa.set(i, 14, 2);
                }
                  if (i == 8)
                {
                    for (int j = 6; j <= 14; j++) mapa.set(i, j, 2);
                   
                }
                 if (i == 9)
                {
                    mapa.set(i, 6, 2); mapa.set(i, 7, 2); mapa.set(i, 11, 2);
                    mapa.set(i, 12, 2); mapa.set(i, 14, 2); mapa.set(i, 10, 2); mapa.set(i, 13, 2);
                }
                if (i == 10)
                {
                    mapa.set(i, 10, 2); mapa.set(i, 11, 2); mapa.set(i, 13, 2);
                    mapa.set(i, 14, 2); mapa.set(i, 12, 2);
                }
                if (i == 11)
                {
                    mapa.set(i, 10, 2); mapa.set(i, 12, 2); mapa.set(i, 14, 2); mapa.set(i, 15, 2);
                    mapa.set(i, 11, 2); mapa.set(i, 13, 2);
                }
                if (i == 12)
                {
                    mapa.set(i, 12, 2); mapa.set(i, 15, 2);
                }
                if (i == 13)
                {
                    for (int j = 12; j <= 15; j++) mapa.set(i, j, 2);                    
                }
            }
            //postavljam kutije
            mapa.set(4, 12, 3);
               mapa.set(5, 15, 3);
                mapa.set(7, 14, 3); mapa.set(7, 11, 3);
                mapa.set(8, 10, 3); mapa.set(8, 13, 3);
                mapa.set(8,12, 3); 
                mapa.set(9, 10, 3); mapa.set(9, 13, 3);
             mapa.set(10, 12, 3); mapa.set(11, 11, 3); mapa.set(11, 13, 3);
             
            //postavljam mesto za kutije
            for (int j = 7; j <= 9; j++)
            {
                mapa.set(j, 3, 4); mapa.set(j, 2, 4); mapa.set(j, 4, 4); mapa.set(j, 5, 4);
            }
            
            //postavljam coveka
            mapa.set(9, 15, 5);
            mapa.SetPozicija(1, 9, 15);
        }


        private void Nivo3(ref Mapa mapa)
        {
            for (int i = 0; i < 15; i++)
            {
                if (i == 5)
                {
                    for (int j = 10; j <= 14; j++)  mapa.set(i, j, 2);
                }
                if (i == 6)
                {
                    mapa.set(i, 10, 2); mapa.set(i, 14, 2); mapa.set(i, 11, 2); mapa.set(i, 13, 2);
                }
                if (i == 7)
                {
                    mapa.set(i, 10, 2); mapa.set(i, 12, 2); mapa.set(i, 13, 2); mapa.set(i, 11, 2);
                }
                if (i == 8)
                {
                    mapa.set(i, 12, 2); mapa.set(i, 14, 2); mapa.set(i, 11, 2); mapa.set(i, 13, 2);
                }
                if (i == 9)
                {
                    mapa.set(i, 10, 2); mapa.set(i, 12, 2); mapa.set(i, 14, 2); mapa.set(i, 11, 2);
                }
                if (i == 10)
                {
                    mapa.set(i, 6, 2); mapa.set(i, 7, 2); mapa.set(i, 10, 2);
                    mapa.set(i, 12, 2); mapa.set(i, 13, 2); mapa.set(i, 15, 2); mapa.set(i, 16, 2);
                    mapa.set(i, 11, 2); mapa.set(i, 14, 2);
                }
                if (i == 11)
                {
                    mapa.set(i, 6, 2); mapa.set(i, 7, 2); mapa.set(i, 8, 2);
                    mapa.set(i, 9, 2); mapa.set(i, 11, 2); mapa.set(i, 12, 2); mapa.set(i, 14, 2);
                    mapa.set(i, 15, 2); mapa.set(i, 16, 2); mapa.set(i, 10, 2); mapa.set(i, 13, 2);
                }
                if (i == 12)
                {
                    mapa.set(i, 6, 2); mapa.set(i, 7, 2);
                }
            }
            //postavljam kutije
            mapa.set(6, 11, 3);
               mapa.set(6, 13, 3);
                mapa.set(7, 14, 3); mapa.set(7, 11, 3);
                mapa.set(8, 11, 3); mapa.set(8, 13, 3);
                mapa.set(9,11, 3); 
                mapa.set(10, 11, 3); mapa.set(10, 14, 3);
                mapa.set(11, 10, 3); mapa.set(11, 13, 3);
            //postavljam mesto za kutije
            mapa.set(10, 2, 4); mapa.set(10, 3, 4);
            mapa.set(10, 4, 4); mapa.set(10, 5, 4);
            mapa.set(11, 3, 4); mapa.set(11, 4, 4);
            mapa.set(11, 5, 4);
            mapa.set(12, 2, 4); mapa.set(12, 3, 4); mapa.set(12, 4, 4); mapa.set(12, 5, 4);
            //postavljam coveka
            mapa.set(5, 15, 5);
            mapa.SetPozicija(1, 5, 15);
        }
        private void Nivo4(ref Mapa mapa)
        {
            for (int i = 0; i < 15; i++)
            {
                if (i == 2 || i==3)
                {
                    mapa.set(i, 12, 2); mapa.set(i, 13, 2);
                }
                if (i == 4)
                {
                    //for (int j = 1; j <= 13; j++) { if (j != 5 && j != 8 && j != 10) { mapa.set(i, j, 2); } }
                    mapa.set(i, 1, 2); mapa.set(i, 2, 2); mapa.set(i, 3, 2); mapa.set(i, 4, 2);
                    mapa.set(i, 6, 2); mapa.set(i, 7, 2); mapa.set(i, 9, 2); mapa.set(i, 11, 2);
                    mapa.set(i, 12, 2); mapa.set(i, 13, 2); 
                }
                if (i == 5)
                {
                    mapa.set(i, 1, 2); mapa.set(i, 7, 2);
                    mapa.set(i, 8, 2); mapa.set(i, 10, 2);
                    mapa.set(i, 12, 2); mapa.set(i, 13, 2);
                    mapa.set(i, 2, 2); mapa.set(i, 3, 2); mapa.set(i, 4, 2);
                    mapa.set(i, 6, 2); mapa.set(i, 9, 2);
                }
                if (i == 6)
                {
                    for (int j = 1; j <= 13; j++) if (j != 3 && j != 9 && j != 11) mapa.set(i, j, 2);
                    mapa.set(i, 3, 2); mapa.set(i, 9, 2);
                }
                if (i == 7)
                {
                    mapa.set(i, 1, 2); mapa.set(i, 4, 2); mapa.set(i, 7, 2); mapa.set(i, 9, 2);
                    mapa.set(i, 2, 2); mapa.set(i, 3, 2); mapa.set(i, 6, 2); mapa.set(i, 8, 2); mapa.set(i, 10, 2);
                }
                if (i == 8)
                {
                    for (int j = 1; j <= 10; j++) if (j != 3 && j != 5 && j != 11) mapa.set(i, j, 2);
                    mapa.set(i, 3, 2);
                }
                if (i == 9)
                {
                    mapa.set(i, 2, 2);
                }
                if (i == 10)
                {
                    for (int j = 1; j <= 9; j++) if (j != 5) mapa.set(i, j, 2);
                }
                if (i == 11)
                {
                    for (int j = 1; j <= 9; j++) if (j != 6) mapa.set(i, j, 2);
                    mapa.set(i, 6, 2);
                }
                if (i == 12)
                {
                    mapa.set(i, 1, 2); mapa.set(i, 2, 2); mapa.set(i, 8, 2); mapa.set(i, 9, 2);
                    mapa.set(i, 3, 2); mapa.set(i, 4, 2); mapa.set(i, 6, 2); mapa.set(i, 7, 2);
                }
                if (i == 13)
                {
                    for (int j = 1; j <= 9; j++) if (j != 5) mapa.set(i, j, 2);
                }

            }
            //postavljam kutije
            mapa.set(4, 8, 3); mapa.set(4, 10, 3);
            mapa.set(5, 2, 3); mapa.set(5, 3, 3); mapa.set(5, 4, 3); mapa.set(5, 6, 3); mapa.set(5, 9, 3);
            mapa.set(6, 3, 3); mapa.set(6, 9, 3);
            mapa.set(7, 2, 3); mapa.set(7, 3, 3); mapa.set(7, 6, 3); mapa.set(7, 8, 3); mapa.set(7, 10, 3);
            mapa.set(8, 3, 3); 
            mapa.set(11, 6, 3);
            mapa.set(12, 3, 3); mapa.set(12, 4, 3); mapa.set(12, 6, 3); mapa.set(12, 7, 3); 
            //postavljam mesto za kutije
            for (int i = 2; i <= 6; i++){ mapa.set(i, 14, 4); mapa.set(i, 15, 4); mapa.set(i, 16, 4); mapa.set(i, 17, 4);}
          
            //postavljam coveka
            mapa.set(12, 10, 5);
            mapa.SetPozicija(1, 12, 10);

        }
        private void Nivo2(ref Mapa mapa)
        {
            for (int i = 0; i < 15; i++)
            {
                if (i == 5 )
                {
                    for (int j = 4; j <= 13;j++ ) if(j!=8) mapa.set(i, j, 2); 
                }
                if (i == 6)
                {
                    for (int j = 4; j <= 15; j++) if (j != 8) mapa.set(i, j, 2);
                }
                if (i == 7)
                {
                    mapa.set(i, 4, 2); mapa.set(i, 5, 2); mapa.set(i, 6, 2); mapa.set(i, 7, 2);
                    mapa.set(i, 9, 2); mapa.set(i, 14, 2); mapa.set(i, 15, 2);
                }
                if (i == 8)
                {
                    for (int j = 4; j <= 11; j++)  mapa.set(i, j, 2);
                    mapa.set(i, 14, 2); mapa.set(i, 15, 2);
                }
                if (i == 9)
                {
                    for (int j = 4; j <= 14; j++) if (j != 8 && j!=10) mapa.set(i, j, 2);
                }
                if (i == 10)
                {
                    mapa.set(i, 9, 2); mapa.set(i, 12, 2); mapa.set(i, 13, 2); mapa.set(i, 14, 2);
                    mapa.set(i, 15, 2); 
                }
                if (i == 11)
                {
                    for (int j = 6; j <= 15; j++)  mapa.set(i, j, 2);
                }
                if (i == 12)
                {
                    for (int j = 6; j <= 15; j++) if (j != 10) mapa.set(i, j, 2);
                }
            }
            //postavljam kutije
            mapa.set(6, 10, 3);
           mapa.set(6, 13, 3);
            mapa.set(7, 9, 3); mapa.set(9, 13, 3);
            mapa.set(10, 12, 3); mapa.set(10, 14, 3);
            mapa.set(11,7 , 3); mapa.set(11, 10, 3);
            mapa.set(11, 12, 3); mapa.set(11, 14, 3);
            //postavljam mesto za kutije
            mapa.set(5, 4, 4); mapa.set(5, 5, 4);
            mapa.set(6, 4, 4); mapa.set(6, 5, 4);
            mapa.set(7, 4, 4); mapa.set(7, 5, 4);
            mapa.set(8, 4, 4); mapa.set(8, 5, 4);
            mapa.set(9, 4, 4); mapa.set(9, 5, 4);
            //postavljam coveka
            mapa.set(8, 10, 5);
            mapa.SetPozicija(1, 8, 10);


        }
        private void Nivo1(ref Mapa mapa)
        {       
            //prazna mesta
            for (int i = 0; i < 15; i++)
            {
                if (i == 4 || i == 5 || i == 6)
                {
                    mapa.set(i, 5, 2); mapa.set(i, 6, 2); mapa.set(i, 7, 2);
                }
                else if (i == 7)
                {
                    mapa.set(i, 3, 2); mapa.set(i, 4, 2); mapa.set(i, 5, 2); mapa.set(i, 6, 2); mapa.set(i, 7, 2); mapa.set(i, 8, 2);
                }
                else if (i == 8)
                {
                    mapa.set(i, 3, 2); mapa.set(i, 5, 2); mapa.set(i, 8, 2);
                }
                else if (i == 9)
                {
                    mapa.set(i, 1, 2); mapa.set(i, 2, 2); mapa.set(i, 3, 2); mapa.set(i, 5, 2); mapa.set(i, 8, 2);
                    mapa.set(i, 14, 2); mapa.set(i, 15, 2); mapa.set(i, 16, 2); mapa.set(i, 17, 2);
                }
                else if (i == 10)
                {
                    for (int j = 1; j <= 17; j++) mapa.set(i, j, 2);
                }
                else if (i == 11)
                {
                    mapa.set(i, 5, 2); mapa.set(i, 9, 2); mapa.set(i, 11, 2);
                    mapa.set(i, 14, 2); mapa.set(i, 15, 2); mapa.set(i, 16, 2); mapa.set(i, 17, 2);
                }
                else if (i == 12)
                {
                    for (int j = 5; j <= 9; j++) mapa.set(i, j, 2);
                }
            }
            //postavljam kutije
            mapa.set(5, 5, 3);
            mapa.set(6, 7, 3);
            mapa.set(7, 5, 3); mapa.set(7, 7, 3);
            mapa.set(10, 2, 3); mapa.set(10, 5, 3);
            //postavljam mesto za kutije
            mapa.set(9, 16, 4); mapa.set(9, 17, 4);
             mapa.set(10, 16, 4); ; mapa.set(10, 17, 4);
            mapa.set(11, 16, 4); mapa.set(11, 17, 4);
            //postavljam coveka
            mapa.set(11, 11, 5);
            mapa.SetPozicija(1, 11, 11);
        }
    }
}
