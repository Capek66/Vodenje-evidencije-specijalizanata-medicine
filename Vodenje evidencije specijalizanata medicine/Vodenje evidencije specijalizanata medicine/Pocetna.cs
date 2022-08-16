using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vodenje_evidencije_specijalizanata_medicine
{
    public partial class Pocetna : Form
    {
        RasporedObavljanja rasporedObavljanja;
        public Pocetna()
        {
            InitializeComponent();
            rasporedObavljanja = new RasporedObavljanja();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            
            knjizica.Controls.Add(rasporedObavljanja);
        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {
            knjizica.Controls.Remove(rasporedObavljanja);
        }
    }
}
