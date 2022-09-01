using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sloj_podataka;
using Sloj_obrade;

namespace Vodenje_evidencije_specijalizanata_medicine.Mentor
{
    public partial class IzbornikMentor : Form
    {
        private ZajednicaLogika zajednicaLogika;
        private RasporedObavljanjaMentor rasporedObavljanja;
        private PracenjeNapMntr pracenjeNap;
        private PracenjeZahvataMntr pracenjeZahvata;
        private SpecijalizantiMntr pregledSpec;
        private Profil profil;
        public IzbornikMentor()
        {
            InitializeComponent();
            zajednicaLogika = new ZajednicaLogika();
            rasporedObavljanja = new RasporedObavljanjaMentor();
            pracenjeNap = new PracenjeNapMntr();
            pracenjeZahvata = new PracenjeZahvataMntr();
            pregledSpec = new SpecijalizantiMntr();
            profil = new Profil();
        }

        private void Pocetna_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RasporedObavljanjaLbl_Click(object sender, EventArgs e)
        {
            knjizica.Controls.Clear();
            knjizica.Controls.Add(rasporedObavljanja);
            rasporedObavljanja.UcitajZapise();
        }

        private void PracenjeNapredovanjaLbl_Click(object sender, EventArgs e)
        {
            knjizica.Controls.Clear();
            knjizica.Controls.Add(pracenjeNap);
            pracenjeNap.UcitajZapise();
        }

        private void PracenjeObavljenihZahvataLbl_Click(object sender, EventArgs e)
        {
            knjizica.Controls.Clear();
            knjizica.Controls.Add(pracenjeZahvata);
            pracenjeZahvata.UcitajZapise();
        }

        private void SpecijalizantiLbl_Click(object sender, EventArgs e)
        {
            knjizica.Controls.Clear();
            knjizica.Controls.Add(pregledSpec);
            pregledSpec.UcitajSpecijalizante();
        }

        private void Profil_Click(object sender, EventArgs e)
        {
            knjizica.Controls.Clear();
            knjizica.Controls.Add(profil);
            profil.UcitajPodatke(zajednicaLogika.DohvatiPodatkeProfil());
        }
    }
}
