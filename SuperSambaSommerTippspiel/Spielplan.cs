using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SuperSambaSommerTippspiel
{
    class Spielplan
    {
        int[][] gruppenSpiele = new int[6][];
        DBAccess datenbank = new DBAccess();

        public int[][] setGruppe(int[] gruppe)
        {
            gruppenSpiele[1][0] = gruppe[0];
            gruppenSpiele[1][1] = gruppe[1];
            gruppenSpiele[2][0] = gruppe[2];
            gruppenSpiele[2][1] = gruppe[3];
            gruppenSpiele[3][0] = gruppe[0];
            gruppenSpiele[3][1] = gruppe[2];
            gruppenSpiele[4][0] = gruppe[3];
            gruppenSpiele[4][1] = gruppe[1];
            gruppenSpiele[5][0] = gruppe[3];
            gruppenSpiele[5][1] = gruppe[0];
            gruppenSpiele[6][0] = gruppe[1];
            gruppenSpiele[6][1] = gruppe[2];

            this.setPaarung(gruppe[0], gruppe[1]);
            this.setPaarung(gruppe[2], gruppe[3]);
            this.setPaarung(gruppe[0], gruppe[2]);
            this.setPaarung(gruppe[3], gruppe[1]);
            this.setPaarung(gruppe[3], gruppe[0]);
            this.setPaarung(gruppe[1], gruppe[2]);

            return gruppenSpiele;
        }

        public void setPaarung(int M_ID1, int M_ID2)
        {
            datenbank.setPaarung(M_ID1, M_ID2);
        }

    }
}
