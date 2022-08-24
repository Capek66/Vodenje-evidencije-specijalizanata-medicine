using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vodenje_evidencije_specijalizanata_medicine.Data;

namespace Vodenje_evidencije_specijalizanata_medicine.Mentor
{
    public partial class PracenjeNapMntrDetalji : Form
    {
        private KnjizicaModel model;
        private Kompetencije kompetencija;
        public PracenjeNapMntrDetalji(Kompetencije odabranaKompetencija)
        {
            InitializeComponent();
            model = new KnjizicaModel();
            DohvatiKompetenciju(odabranaKompetencija);
            PostaviStupnjeve();
            UcitajDetalje();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PostaviStupnjeve()
        {
            cbStupanj.Items.Add("1");
            cbStupanj.Items.Add("2");
            cbStupanj.Items.Add("3");
            cbStupanj.SelectedIndex = 0;
        }

        private void btnPotpisi_Click(object sender, EventArgs e)
        {
            int odabraniStupanjNap = int.Parse(cbStupanj.Text);

            if (kompetencija.mentor == CurrentUser.prijavljeniKorisnik.id)
            {
                kompetencija.potpis_mentor = "Pregledano!";
                kompetencija.datum_mentor = DateTime.Now;
                kompetencija.stupanj_napredovanja = odabraniStupanjNap;
            }
            if (kompetencija.Specijalizacija1.Korisnik1.id == CurrentUser.prijavljeniKorisnik.id)
            {
                kompetencija.potpis_gl_mentor = "Pregledano!";
                kompetencija.datum_gl_mentor = DateTime.Now;
            }
            model.SaveChanges();
            UcitajDetalje();
        }

        private void UcitajDetalje()
        {
            lblPrezIme.Text = kompetencija.Specijalizacija1.Korisnik.ime + " " + kompetencija.Specijalizacija1.Korisnik.prezime;
            lblKomp.Text = kompetencija.kompetencije1;
            lblPrezImeMentor.Text = kompetencija.Korisnik.ime + " " + kompetencija.Korisnik.prezime;
            lblDatumMntr.Text = ProvijeriText(kompetencija.datum_mentor.ToString());
            lblMentPotp.Text = ProvijeriText(kompetencija.potpis_mentor);
            lblGlMntr.Text = kompetencija.Specijalizacija1.Korisnik1.ime + " " + kompetencija.Specijalizacija1.Korisnik1.prezime;
            lblDatumGlMntr.Text = ProvijeriText(kompetencija.datum_gl_mentor.ToString());
            lblPotpisGlMntr.Text = ProvijeriText(kompetencija.potpis_gl_mentor);
        }

        private string ProvijeriText(string text)
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

        private void DohvatiKompetenciju(Kompetencije odabranaKomp)
        {
            var sql = from k in model.Kompetencije
                      where k.id == odabranaKomp.id
                      select k;

            kompetencija = sql.Single();
        }
    }
}
