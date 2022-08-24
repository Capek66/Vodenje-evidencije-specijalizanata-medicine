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
    public partial class PracenjeZahvataMntrDetalji : Form
    {
        private KnjizicaModel model;
        private Zahvati zahvat;
        public PracenjeZahvataMntrDetalji(Zahvati odabranZahvat)
        {
            InitializeComponent();
            model = new KnjizicaModel();
            DohvatiZahvat(odabranZahvat);
            PostaviStupnjeve();
            UcitajDetalje();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DohvatiZahvat(Zahvati odabranZahvat)
        {
            var sql = from z in model.Zahvati
                      where z.id == odabranZahvat.id
                      select z;

            zahvat = sql.Single();
        }

        private void PostaviStupnjeve()
        {
            cbStupanj.Items.Add("2");
            cbStupanj.Items.Add("3");
            cbStupanj.SelectedIndex = 0;
        }

        private void UcitajDetalje()
        {
            lblPrezIme.Text = zahvat.Specijalizacija1.Korisnik.ime + " " + zahvat.Specijalizacija1.Korisnik.prezime;
            lblZahvat.Text = zahvat.naziv_zahvata;
            lblBroj.Text = zahvat.broj_zahvata.ToString();
            lblPrezImeMentor.Text = zahvat.Korisnik.ime + " " + zahvat.Korisnik.prezime;
            lblDatumMntr.Text = ProvjeriText(zahvat.datum_mentor.ToString());
            lblMentPotp.Text = ProvjeriText(zahvat.potpis_mentor);
            lblGlMntr.Text = zahvat.Specijalizacija1.Korisnik1.ime + " " + zahvat.Specijalizacija1.Korisnik1.prezime;
            lblDatumGlMntr.Text = ProvjeriText(zahvat.datum_gl_mentor.ToString());
            lblPotpisGlMntr.Text = ProvjeriText(zahvat.potpis_gl_mentor);
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
        private void btnPotpisi_Click(object sender, EventArgs e)
        {
            int odabraniStupanjNap = int.Parse(cbStupanj.Text);

            if (zahvat.mentor == CurrentUser.prijavljeniKorisnik.id)
            {
                zahvat.potpis_mentor = "Pregledano!";
                zahvat.datum_mentor = DateTime.Now;
                zahvat.stupanj_napredovanja = odabraniStupanjNap;
            }
            if (zahvat.Specijalizacija1.Korisnik1.id == CurrentUser.prijavljeniKorisnik.id)
            {
                zahvat.potpis_gl_mentor = "Pregledano!";
                zahvat.datum_gl_mentor = DateTime.Now;
            }
            model.SaveChanges();
            UcitajDetalje();
        }
    }
}
