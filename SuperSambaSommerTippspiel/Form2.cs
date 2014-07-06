using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SuperSambaSommerTippspiel
{
    public partial class Form2 : Form
    {
        private int id;

        public Form2(int id)
        {
            InitializeComponent();

            this.id = id;
            DBAccess datenbank = new DBAccess();
            Spielplan spielplan = new Spielplan();

            int[][] gruppe = new int[8][];
            Array[][] gruppenSpiele = new Array[8][];
            
            for(int i = 1; i <= gruppe.Length; i++)
            {
                gruppe[i] = datenbank.getGruppe(i);
                gruppenSpiele[i] = spielplan.setGruppe(gruppe[i]);
            }

            for(int j = 0; j < gruppe.Length; j++)
            {

            }
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();

            Panel assd = new Panel();
            
            Label asd = new Label();
            
            asd.Name = "asd";
            asd.Location = new System.Drawing.Point(10,10);
        }

        private void tab ()
        {

        }

        
    }
}
