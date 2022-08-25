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
    public partial class PracenjeNapMntr : UserControl
    {
        private PracenjeNapMntrDetalji pracenjeNap;
        private StupanjNapredovanja stupanjNapredovanja;
        private KnjizicaModel model;
        public PracenjeNapMntr()
        {
            InitializeComponent();
            model = new KnjizicaModel();
            DohvatiSpecijalizante();
        }

        private void btnDetalji_Click(object sender, EventArgs e)
        {
            Kompetencije odabranaKompetencija = (dgvKompetencije.CurrentRow.DataBoundItem as Mentor.KompPrikaz).Kompetencije;
            pracenjeNap = new PracenjeNapMntrDetalji(odabranaKompetencija);
            pracenjeNap.ShowDialog();
            UcitajZapise();
        }

        private void btnPotpisi_Click(object sender, EventArgs e)
        {
            stupanjNapredovanja = new StupanjNapredovanja(1);
            stupanjNapredovanja.ShowDialog();
            if(stupanjNapredovanja.odabraniStupanj != 0)
            {
                int odabraniStupanjNap = stupanjNapredovanja.odabraniStupanj;
                Kompetencije odabranaKompetencija = (dgvKompetencije.CurrentRow.DataBoundItem as Mentor.KompPrikaz).Kompetencije;

                if (odabranaKompetencija.mentor == CurrentUser.prijavljeniKorisnik.id)
                {
                    odabranaKompetencija.potpis_mentor = "Pregledano!";
                    odabranaKompetencija.datum_mentor = DateTime.Now;
                    odabranaKompetencija.stupanj_napredovanja = odabraniStupanjNap;
                }
                if (odabranaKompetencija.Specijalizacija1.Korisnik1.id == CurrentUser.prijavljeniKorisnik.id)
                {
                    odabranaKompetencija.potpis_gl_mentor = "Pregledano!";
                    odabranaKompetencija.datum_gl_mentor = DateTime.Now;
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
            UcitajZapise();
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
            var sql = from zapisi in model.Kompetencije.Include("Korisnik").Include("Specijalizacija1")
                      where ((zapisi.mentor == CurrentUser.prijavljeniKorisnik.id && zapisi.potpis_mentor == null) || (zapisi.Specijalizacija1.Korisnik1.id == CurrentUser.prijavljeniKorisnik.id && zapisi.potpis_gl_mentor == null)) && (zapisi.Specijalizacija1.Korisnik.id == odabraniKorisnik.id)
                      select new Mentor.KompPrikaz
                      {
                          Kompetencije = zapisi,
                          Specijalizant = zapisi.Specijalizacija1.Korisnik.ime + " " + zapisi.Specijalizacija1.Korisnik.prezime,
                          Kompetencija = zapisi.kompetencije1,
                          Stupanj_napredovanja = zapisi.stupanj_napredovanja,
                          Mentor = zapisi.Korisnik.ime + " " + zapisi.Korisnik.prezime,
                          Datum_mentor = zapisi.datum_mentor,
                          Potpis_mentor = zapisi.potpis_mentor,
                          Datum_gl_mentor = zapisi.datum_gl_mentor,
                          Potpis_gl_mentor = zapisi.potpis_gl_mentor,
                          Specijalizacija = zapisi.Specijalizacija1.specijalizacija1
                      };

            BindingSource bindingSource = new BindingSource(sql.ToList(), "");
            dgvKompetencije.DataSource = bindingSource;
            dgvKompetencije.Columns[0].Visible = false;

            if(bindingSource.Count == 0)
            {
                btnDetalji.Enabled = false;
                btnPotpisi.Enabled = false;
            }
            else
            {
                btnDetalji.Enabled = true;
                btnPotpisi.Enabled = true;
            }
        }

        private void BezFiltera()
        {
            var sql = from zapisi in model.Kompetencije.Include("Korisnik").Include("Specijalizacija1")
                      where (zapisi.mentor == CurrentUser.prijavljeniKorisnik.id && zapisi.potpis_mentor == null) || (zapisi.Specijalizacija1.Korisnik1.id == CurrentUser.prijavljeniKorisnik.id && zapisi.potpis_gl_mentor == null)
                      select new Mentor.KompPrikaz
                      {
                          Kompetencije = zapisi,
                          Specijalizant = zapisi.Specijalizacija1.Korisnik.ime + " " + zapisi.Specijalizacija1.Korisnik.prezime,
                          Kompetencija = zapisi.kompetencije1,
                          Stupanj_napredovanja = zapisi.stupanj_napredovanja,
                          Mentor = zapisi.Korisnik.ime + " " + zapisi.Korisnik.prezime,
                          Datum_mentor = zapisi.datum_mentor,
                          Potpis_mentor = zapisi.potpis_mentor,
                          Datum_gl_mentor = zapisi.datum_gl_mentor,
                          Potpis_gl_mentor = zapisi.potpis_gl_mentor,
                          Specijalizacija = zapisi.Specijalizacija1.specijalizacija1
                      };

            BindingSource bindingSource = new BindingSource(sql.ToList(), "");
            dgvKompetencije.DataSource = bindingSource;
            dgvKompetencije.Columns[0].Visible = false;

            if (bindingSource.Count == 0)
            {
                btnDetalji.Enabled = false;
                btnPotpisi.Enabled = false;
            }
            else
            {
                btnDetalji.Enabled = true;
                btnPotpisi.Enabled = true;
            }
        }
    }
}
