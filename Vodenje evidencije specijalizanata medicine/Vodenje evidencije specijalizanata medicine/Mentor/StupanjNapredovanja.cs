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
    public partial class StupanjNapredovanja : Form
    {
        public int odabraniStupanj;
        public StupanjNapredovanja(int forma)
        {
            InitializeComponent();
            if(forma == 1)
            {
                UcitajStupnjeveZaKompetencije();
            }
            else
            {
                UcitajStupnjeveZaZahvate();
            }
            cbStupanj.SelectedIndex = 0;
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            odabraniStupanj = 0;
            this.Close();
        }

        private void UcitajStupnjeveZaKompetencije()
        {
            cbStupanj.Items.Add(1);
            cbStupanj.Items.Add(2);
            cbStupanj.Items.Add(3);
        }

        private void UcitajStupnjeveZaZahvate()
        {
            cbStupanj.Items.Add(2);
            cbStupanj.Items.Add(3);
        }

        private void btnOdaberi_Click(object sender, EventArgs e)
        {
            odabraniStupanj = int.Parse(cbStupanj.Text);
            this.Close();
        }
    }
}
