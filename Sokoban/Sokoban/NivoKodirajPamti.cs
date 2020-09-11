using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Sokoban
{
    class NivoKodirajPamti
    {

        public void zapamtiUFail(int nivo)
        {
            int kodiran;
            switch (nivo)
            {
                case 0: kodiran = 258763;
                    break;
                case 1: kodiran = 192281;
                    break;
                case 2: kodiran = 333333;
                    break;
                case 3: kodiran = 434343;
                    break;
                case 4: kodiran = 562708;
                    break;
                case 5: kodiran = 112257;
                    break;
                case 6: kodiran = 366661;
                    break;
                case 7: kodiran = 288888;
                    break;
                case 8: kodiran = 121212;
                    break;
                case 9: kodiran = 1000059;
                    break;
                case 10: kodiran = 763821;
                    break;
                case 11: kodiran = 120008;
                    break;
                case 12: kodiran = 886699;
                    break;
                default: kodiran = -1;
                    break;
            }
            File.WriteAllText(@"Resource/data.dat", kodiran+""); 
        }

        public int dajNivo()
        {
            int nivo;
            if (File.Exists(@"Resource/data.dat"))
            {
                int kodiran = Convert.ToInt32(File.ReadAllText(@"Resource/data.dat"));
                switch (kodiran)
                {
                    case 258763: nivo = 1;
                        break;
                    case 192281: nivo = 2;
                        break;
                    case 333333: nivo = 3;
                        break;
                    case 434343: nivo = 4;
                        break;
                    case 562708: nivo = 5;
                        break;
                    case 112257: nivo = 6;
                        break;
                    case 366661: nivo = 7;
                        break;
                    case 288888: nivo = 8;
                        break;
                    case 121212: nivo = 9;
                        break;
                    case 1000059: nivo = 10;
                        break;
                    case 763821: nivo = 11;
                        break;
                    case 120008: nivo = 12;
                        break;
                    case 886699: nivo = 12;
                        break;
                    default: nivo = 1 ;
                        break;
                }
            }
            else
                nivo = 1;

            return nivo;
        }
    }
}
