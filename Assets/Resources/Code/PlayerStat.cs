using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Resources.Code
{
    class PlayerStat
    {
        int mod;
        int stat;

        public int getSocMod(int soc) {
            if (soc - 16 < 0) { return 0; }
            return soc - 16;
        }

        public int getInteMod(int inte) {
            switch (inte)
            {
                case 15:
                    return -2;
                case 16:
                    return -4;
                case 17:
                    return -6;
                case 18:
                    return -8;
                case 19:
                    return -10;
                case 20:
                    return -12;
                default:
                    return 0;
            }
        }

        public int getAgilMod(int agil) {
            if (agil - 14 < 0) { return 0; }
            return agil - 14;
        }
    }
}
