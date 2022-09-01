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
    public partial class SpecijalizacijaAdd : Form
    {
        SpecijalizantLogika specijalizantLogika;
        public SpecijalizacijaAdd()
        {
            InitializeComponent();
            specijalizantLogika = new SpecijalizantLogika();
            UcitajMentore();
        }

        private void UcitajMentore()
        {
            BindingSource bindingSource = new BindingSource(specijalizantLogika.DohvatiMentore(), "");
            cbGlMentor.DataSource = bindingSource;
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (tbSpecNaziv.Text != "" && tbOdobrenaZa.Text != "")
            {
                Specijalizacija novaSpecijalizacija = new Specijalizacija()
                {
                    id = 0,
                    specijalizant = CurrentUser.prijavljeniKorisnik.id,
                    specijalizacija1 = tbSpecNaziv.Text,
                    odobrena_za = tbOdobrenaZa.Text,
                    klasa = null,
                    ubroj = null,
                    datum_rjesenja = null,
                    glavni_mentor = (cbGlMentor.SelectedItem as Korisnik).id,
                    datum_pocetka = dtpPocetak.Value,
                    potpis_gl_mentora = null
                };
                ZavrsetakSpecijalizacije zavrsetakSpecijalizacije = new ZavrsetakSpecijalizacije()
                {
                    id = 0,
                    specijalizacija = novaSpecijalizacija.id,
                    misljenje_gl_mentora = null,
                    datum_zavrsetka = null,
                    potpis_gl_mentor = null
                };
                specijalizantLogika.SpecNovi(novaSpecijalizacija, zavrsetakSpecijalizacije);
                this.Close();
            }
        }
    }
}
