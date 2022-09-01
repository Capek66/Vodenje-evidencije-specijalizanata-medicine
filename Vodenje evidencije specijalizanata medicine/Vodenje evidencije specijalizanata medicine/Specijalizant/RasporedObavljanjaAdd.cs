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
using Sloj_podataka;

namespace Vodenje_evidencije_specijalizanata_medicine
{
    public partial class RasporedObavljanjaAdd : Form
    {
        SpecijalizantLogika specijalizantLogika;
        public RasporedObavljanjaAdd()
        {
            InitializeComponent();
            specijalizantLogika = new SpecijalizantLogika();
            DohvatiMentore();
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            if(tbUstanova.Text != "" || tbOdjel.Text != "" || tbGodOdm.Text != "" || tbPravFizOsoba.Text != "" || tbUstrojJed.Text != "")
            {
                RasporedPrograma noviRO = new RasporedPrograma()
                {
                    id = 0,
                    naziv_ustanove = tbUstanova.Text,
                    naziv_odjela = tbOdjel.Text,
                    godisnji_odmor = int.Parse(tbGodOdm.Text),
                    trajanje_od = dtpOd.Value,
                    trajanje_do = dtpDo.Value,
                    pravna_fizicka_osoba = tbPravFizOsoba.Text,
                    ustrojstvena_jedinica = tbUstrojJed.Text,
                    mentor = (cbMentor.SelectedItem as Korisnik).id,
                    potpis_mentor = null,
                    potpis_gl_mentor = null,
                    specijalizacija = Sloj_obrade.CurrentUser.odabranaSpecijalizacija.id
                };
                specijalizantLogika.RaspObNovi(noviRO);
                this.Close();
            }
        }

        private void DohvatiMentore()
        {
            cbMentor.DataSource = specijalizantLogika.DohvatiMentore();
        }
    }
}
