using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sloj_obrade;

namespace Vodenje_evidencije_specijalizanata_medicine
{
    public partial class KnjizicaPocetnaSpec : Form
    {
        private ZajednicaLogika zajednicaLogika;
        private RasporedObavljanja rasporedObavljanja;
        private PracenjeNapredovanja pracenjeNapredovanja;
        private PracenjeZahvata pracenjeZahvata;
        private SpecUsavrsavanja specUsavrsavanja;
        private Profil profil;
        public KnjizicaPocetnaSpec()
        {
            InitializeComponent();
            zajednicaLogika = new ZajednicaLogika();
            rasporedObavljanja = new RasporedObavljanja();
            pracenjeNapredovanja = new PracenjeNapredovanja();
            pracenjeZahvata = new PracenjeZahvata();
            specUsavrsavanja = new SpecUsavrsavanja();
            profil = new Profil();
            ProvjeriSpecijalizaciju();
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
            knjizica.Controls.Add(pracenjeNapredovanja);
            pracenjeNapredovanja.UcitajKompetencije();
        }

        private void Profil_Click(object sender, EventArgs e)
        {
            knjizica.Controls.Clear();
            knjizica.Controls.Add(profil);
            profil.UcitajPodatke(zajednicaLogika.DohvatiPodatkeProfil());
        }

        private void Pocetna_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PracenjeObavljenihZahvataLbl_Click(object sender, EventArgs e)
        {
            knjizica.Controls.Clear();
            knjizica.Controls.Add(pracenjeZahvata);
            pracenjeZahvata.UcitajZahvate();
        }

        private void SpecijalistickaUsavrsavanjaLbl_Click(object sender, EventArgs e)
        {
            knjizica.Controls.Clear();
            knjizica.Controls.Add(specUsavrsavanja);
            specUsavrsavanja.UcitajSpecijalizacije();
            ProvjeriSpecijalizaciju();
        }

        private void ProvjeriSpecijalizaciju()
        {
            if(!Sloj_obrade.CurrentUser.ProvjeriSpecijalizaciju())
            {
                RasporedObavljanjaLbl.Enabled = false;
                PracenjeNapredovanjaLbl.Enabled = false;
                PracenjeObavljenihZahvataLbl.Enabled = false;
            }
            else
            {
                RasporedObavljanjaLbl.Enabled = true;
                PracenjeNapredovanjaLbl.Enabled = true;
                PracenjeObavljenihZahvataLbl.Enabled = true;
            }
        }
    }
}
