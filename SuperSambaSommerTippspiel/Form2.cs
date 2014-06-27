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
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
            Panel assd = new Panel();
            
            Label asd = new Label();
            
            asd.Name = "asd";
            asd.Location = new System.Drawing.Point(10, 10);
        }
    }
}
