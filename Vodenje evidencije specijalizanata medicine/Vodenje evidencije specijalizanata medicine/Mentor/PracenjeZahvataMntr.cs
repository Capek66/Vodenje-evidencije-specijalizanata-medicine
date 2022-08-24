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
    public partial class PracenjeZahvataMntr : UserControl
    {
        private PracenjeZahvataMntrDetalji pracenjeZahvata;
        private StupanjNapredovanja stupanjNapredovanja;
        private KnjizicaModel model;
        public PracenjeZahvataMntr()
        {
            InitializeComponent();
            model = new KnjizicaModel();
            DohvatiSpecijalizante();
            UcitajZapise();
        }

        private void btnDetalji_Click(object sender, EventArgs e)
        {
            Zahvati odabranZahvat = (dgvZahvati.CurrentRow.DataBoundItem as ZahvatiPrikaz).Zahvati;
            pracenjeZahvata = new PracenjeZahvataMntrDetalji(odabranZahvat);
            pracenjeZahvata.ShowDialog();
            UcitajZapise();
        }

        private void btnPotpisi_Click(object sender, EventArgs e)
        {
            stupanjNapredovanja = new StupanjNapredovanja(2);
            stupanjNapredovanja.ShowDialog();

            if (stupanjNapredovanja.odabraniStupanj != 0)
            {
                int odabraniStupanjNap = stupanjNapredovanja.odabraniStupanj;
                Zahvati izabranZahvat = (dgvZahvati.CurrentRow.DataBoundItem as Mentor.ZahvatiPrikaz).Zahvati;

                if (izabranZahvat.mentor == CurrentUser.prijavljeniKorisnik.id)
                {
                    izabranZahvat.potpis_mentor = "Pregledano!";
                    izabranZahvat.datum_mentor = DateTime.Now;
                    izabranZahvat.stupanj_napredovanja = odabraniStupanjNap;
                }
                if (izabranZahvat.Specijalizacija1.Korisnik1.id == CurrentUser.prijavljeniKorisnik.id)
                {
                    izabranZahvat.potpis_gl_mentor = "Pregledano!";
                    izabranZahvat.datum_gl_mentor = DateTime.Now;
                }
                model.SaveChanges();
                UcitajZapise();
            }
        }

        private void DohvatiSpecijalizante()
        {
            cbSpecijalizanti.Items.Add("Izaberite specijalizanta");

            var sql = from spec in model.Korisnik
                      where spec.uloga == 3
                      select spec;

            foreach (var specijalizant in sql.ToList())
            {
                cbSpecijalizanti.Items.Add(specijalizant);
            }
            cbSpecijalizanti.SelectedIndex = 0;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            cbSpecijalizanti.SelectedIndex = 0;

        }

        public void UcitajZapise()
        {
            if (cbSpecijalizanti.SelectedIndex != 0)
            {
                SaFilterom();
            }
            else
            {
                BezFiltera();
            }
        }

        private void cbSpecijalizanti_SelectedIndexChanged(object sender, EventArgs e)
        {
            UcitajZapise();
        }

        private void SaFilterom()
        {
            Korisnik odabraniKorisnik = cbSpecijalizanti.SelectedItem as Korisnik;
            var sql = from zapisi in model.Zahvati.Include("Korisnik").Include("Specijalizacija1")
                      where ((zapisi.mentor == CurrentUser.prijavljeniKorisnik.id && zapisi.potpis_mentor == null) || (zapisi.Specijalizacija1.Korisnik1.id == CurrentUser.prijavljeniKorisnik.id && zapisi.potpis_gl_mentor == null)) && (zapisi.Specijalizacija1.Korisnik.id == odabraniKorisnik.id)
                      select new Mentor.ZahvatiPrikaz
                      {
                          Zahvati = zapisi,
                          Specijalizant = zapisi.Specijalizacija1.Korisnik.ime + " " + zapisi.Specijalizacija1.Korisnik.prezime,
                          Naziv_zahvata = zapisi.naziv_zahvata,
                          Broj_zahvata = zapisi.broj_zahvata,
                          Stupanj_napredovanja = zapisi.stupanj_napredovanja,
                          Mentor = zapisi.Korisnik.ime + " " + zapisi.Korisnik.prezime,
                          Datum_mentor = zapisi.datum_mentor,
                          Potpis_mentor = zapisi.potpis_mentor,
                          Datum_gl_mentor = zapisi.datum_gl_mentor,
                          Potpis_gl_mentor = zapisi.potpis_gl_mentor,
                          Specijalizacija = zapisi.Specijalizacija1.specijalizacija1
                      };

            BindingSource bindingSource = new BindingSource(sql.ToList(), "");
            dgvZahvati.DataSource = bindingSource;
            dgvZahvati.Columns[0].Visible = false;
        }
        
        private void BezFiltera()
        {
            var sql = from zapisi in model.Zahvati.Include("Korisnik").Include("Specijalizacija1")
                      where (zapisi.mentor == CurrentUser.prijavljeniKorisnik.id && zapisi.potpis_mentor == null) || (zapisi.Specijalizacija1.Korisnik1.id == CurrentUser.prijavljeniKorisnik.id && zapisi.potpis_gl_mentor == null)
                      select new Mentor.ZahvatiPrikaz
                      {
                          Zahvati = zapisi,
                          Specijalizant = zapisi.Specijalizacija1.Korisnik.ime + " " + zapisi.Specijalizacija1.Korisnik.prezime,
                          Naziv_zahvata = zapisi.naziv_zahvata,
                          Broj_zahvata = zapisi.broj_zahvata,
                          Stupanj_napredovanja = zapisi.stupanj_napredovanja,
                          Mentor = zapisi.Korisnik.ime + " " + zapisi.Korisnik.prezime,
                          Datum_mentor = zapisi.datum_mentor,
                          Potpis_mentor = zapisi.potpis_mentor,
                          Datum_gl_mentor = zapisi.datum_gl_mentor,
                          Potpis_gl_mentor = zapisi.potpis_gl_mentor,
                          Specijalizacija = zapisi.Specijalizacija1.specijalizacija1
                      };

            BindingSource bindingSource = new BindingSource(sql.ToList(), "");
            dgvZahvati.DataSource = bindingSource;
            dgvZahvati.Columns[0].Visible = false;
        }
    }
}
