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
    public partial class Form1 : Form
    {
        DBAccess user = new DBAccess();

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Anmelden_Click(object sender, EventArgs e)
        {
            int id = user.Anmelden(tb_Name.Text, tb_Pw.Text);
            if (id != -1)
            {
                ActiveForm.Hide();
                Form2 f = new Form2(id);
                f.Show();
                
            }
            else {
               DialogResult abfrage = MessageBox.Show("Anmeldung fehlgeschlagen Benutzer ist in der Datenbank nicht vorhanden! \nMöchten Sie sich neu Registrieren?","SuperSambaFehlermeldung!",MessageBoxButtons.YesNo);

               if (abfrage == DialogResult.Yes)
               {
                   user.Registrierung(tb_Name.Text, tb_Pw.Text);
               }
            }
            
            
        }



    }
}
