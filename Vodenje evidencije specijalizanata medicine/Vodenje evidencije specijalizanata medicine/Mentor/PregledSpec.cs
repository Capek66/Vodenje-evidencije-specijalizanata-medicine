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

namespace Vodenje_evidencije_specijalizanata_medicine.Mentor
{
    public partial class PregledSpec : Form
    {
        private MentorLogika mentorLogika;
        private PopisZapisa popisZapisa;
        private Korisnik korisnik;
        private Specijalizacija odabranaSpecijalizacija;
        private ZavrsetakSpecijalizacije zavrsetakOdabraneSpec;
        int vrstaMentora;
        public PregledSpec(Korisnik odabraniKorisnik, int vrsta)
        {
            InitializeComponent();
            mentorLogika = new MentorLogika();
            vrstaMentora = vrsta;
            ZakljucajFunkcije(vrsta);
            korisnik = odabraniKorisnik;
            DohvatiSpecijalizacije();
            PopuniDetalje();
        }
        private void PopuniDetalje()
        {
            odabranaSpecijalizacija = cbSpecijalizacija.SelectedItem as Specijalizacija;
            zavrsetakOdabraneSpec = odabranaSpecijalizacija.ZavrsetakSpecijalizacije.Single();
            lblPrezIme.Text = korisnik.ime + " " + korisnik.prezime;
            lblSpec.Text = odabranaSpecijalizacija.specijalizacija1;
            lblOsoba.Text = odabranaSpecijalizacija.odobrena_za;
            tbKlasa.Text = odabranaSpecijalizacija.klasa;
            tbUbroj.Text = odabranaSpecijalizacija.ubroj;
            if(odabranaSpecijalizacija.datum_rjesenja != null)
            {
                dtpDatumPocetak.Value = DateTime.Parse(odabranaSpecijalizacija.datum_rjesenja.ToString());
            }
            lvlGlMntr.Text = odabranaSpecijalizacija.Korisnik1.ime + " " + odabranaSpecijalizacija.Korisnik1.prezime;
            lblDatumPoc.Text = odabranaSpecijalizacija.datum_pocetka.ToString();
            lblPotpisPoc.Text = ProvjeriText(odabranaSpecijalizacija.potpis_gl_mentora);

            rtbMisljenje.Text = zavrsetakOdabraneSpec.misljenje_gl_mentora;
            if (zavrsetakOdabraneSpec.datum_zavrsetka != null)
            {
                dtpDatumKraj.Value = DateTime.Parse(zavrsetakOdabraneSpec.datum_zavrsetka.ToString());
            }
            lblPotpisKraj.Text = ProvjeriText(zavrsetakOdabraneSpec.potpis_gl_mentor);
        }
        private void DohvatiSpecijalizacije()
        {
            BindingSource bindingSource = new BindingSource(mentorLogika.SpecijalizacijeSpecijalizanta(korisnik.id), "");
            cbSpecijalizacija.DataSource = bindingSource;
            cbSpecijalizacija.SelectedIndex = 0;
        }
        private void btnZatvori_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnRasporedi_Click(object sender, EventArgs e)
        {
            popisZapisa = new PopisZapisa(1, korisnik.id, odabranaSpecijalizacija.id);
            popisZapisa.ShowDialog();
        }
        private void btnKompetencije_Click(object sender, EventArgs e)
        {
            popisZapisa = new PopisZapisa(2, korisnik.id, odabranaSpecijalizacija.id);
            popisZapisa.ShowDialog();
        }
        private void btnZahvati_Click(object sender, EventArgs e)
        {
            popisZapisa = new PopisZapisa(3, korisnik.id, odabranaSpecijalizacija.id);
            popisZapisa.ShowDialog();
        }
        private string ProvjeriText(string text)
        {
            if (text == "" || text == null)
            {
                return "Još nema zapisa!";
            }
            else
            {
                return text;
            }
        }
        private void cbSpecijalizacija_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopuniDetalje();
        }
        private void ZakljucajFunkcije(int vrsta)
        {
            if (vrsta == 1)
            {
                btnSpremiPocetak.Enabled = true;
                btnSpremiKraj.Enabled = true;
                tbKlasa.Enabled = true;
                tbUbroj.Enabled = true;
                dtpDatumPocetak.Enabled = true;
                dtpDatumKraj.Enabled = true;
                rtbMisljenje.Enabled = true;
            }

            if (vrsta == 2)
            {
                btnSpremiPocetak.Enabled = false;
                btnSpremiKraj.Enabled = false;
                tbKlasa.Enabled = false;
                tbUbroj.Enabled = false;
                dtpDatumPocetak.Enabled = false;
                dtpDatumKraj.Enabled = false;
                rtbMisljenje.Enabled = false;
            }
        }
        private void btnSpremiPocetak_Click(object sender, EventArgs e)
        {
            if(tbKlasa.Text != "" && tbUbroj.Text != "")
            {
                mentorLogika.SpremiSpecijalizaciju(odabranaSpecijalizacija.id, tbKlasa.Text, tbUbroj.Text, dtpDatumPocetak.Value);
                PopuniDetalje();
            }
        }
        private void btnSpremiKraj_Click(object sender, EventArgs e)
        {
            if(rtbMisljenje.Text != "")
            {
                mentorLogika.SpremiZavrsetak(odabranaSpecijalizacija.id, rtbMisljenje.Text, dtpDatumKraj.Value);
                PopuniDetalje();
            }
        }
    }
}
