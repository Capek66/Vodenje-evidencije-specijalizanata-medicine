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
    public partial class IzbornikMentor : Form
    {
        private RasporedObavljanjaMentor rasporedObavljanja;
        private PracenjeNapMntr pracenjeNap;
        private PracenjeZahvataMntr pracenjeZahvata;
        private SpecijalizantiMntr pregledSpec;
        private Profil profil;
        public IzbornikMentor()
        {
            InitializeComponent();
            rasporedObavljanja = new RasporedObavljanjaMentor();
            pracenjeNap = new PracenjeNapMntr();
            pracenjeZahvata = new PracenjeZahvataMntr();
            pregledSpec = new SpecijalizantiMntr();
            profil = new Profil();
            dohvatiSpecijalizante();
        }

        private void Pocetna_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RasporedObavljanjaLbl_Click(object sender, EventArgs e)
        {
            knjizica.Controls.Clear();
            knjizica.Controls.Add(rasporedObavljanja);
        }

        private void PracenjeNapredovanjaLbl_Click(object sender, EventArgs e)
        {
            knjizica.Controls.Clear();
            knjizica.Controls.Add(pracenjeNap);
        }

        private void PracenjeObavljenihZahvataLbl_Click(object sender, EventArgs e)
        {
            knjizica.Controls.Clear();
            knjizica.Controls.Add(pracenjeZahvata);
        }

        private void SpecijalizantiLbl_Click(object sender, EventArgs e)
        {
            knjizica.Controls.Clear();
            knjizica.Controls.Add(pregledSpec);
        }

        private void Profil_Click(object sender, EventArgs e)
        {
            knjizica.Controls.Clear();
            knjizica.Controls.Add(profil);
        }

        private void dohvatiSpecijalizante()
        {
            cbSpecijalizanti.Items.Add("Izaberite specijalizanta");
            cbSpecijalizanti.Items.Add("Mišo");
            cbSpecijalizanti.Items.Add("Mirko");
        }

        private void tslReset_Click(object sender, EventArgs e)
        {
            cbSpecijalizanti.SelectedIndex = 0;
        }
    }
}
