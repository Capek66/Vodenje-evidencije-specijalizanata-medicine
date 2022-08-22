using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vodenje_evidencije_specijalizanata_medicine.Mentor
{
    public partial class PregledSpec : Form
    {
        private PopisZapisa popisZapisa;
        public PregledSpec()
        {
            InitializeComponent();
            cbSpecijalizacija.Items.Add("Jedan");
        }

        private void btnZatvori_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRasporedi_Click(object sender, EventArgs e)
        {
            popisZapisa = new PopisZapisa();
            popisZapisa.ShowDialog();
        }

        private void btnKompetencije_Click(object sender, EventArgs e)
        {
            popisZapisa = new PopisZapisa();
            popisZapisa.ShowDialog();
        }

        private void btnZahvati_Click(object sender, EventArgs e)
        {
            popisZapisa = new PopisZapisa();
            popisZapisa.ShowDialog();
        }
    }
}
