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
    public partial class RasporedObavljanjaMentor : UserControl
    {
        private RasporedObMntDetails rasporedOb;
        private KnjizicaModel model;
        public RasporedObavljanjaMentor()
        {
            InitializeComponent();
            model = new KnjizicaModel();
            DohvatiSpecijalizante();
            UcitajZapise();
        }

        private void btnDetalji_Click(object sender, EventArgs e)
        {
            RasporedPrograma odabraniRaspored = (dgvRaspored.CurrentRow.DataBoundItem as Mentor.RaspObavPrikaz).Program;
            rasporedOb = new RasporedObMntDetails(odabraniRaspored);
            rasporedOb.ShowDialog();
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

        private void btnPregledaj_Click(object sender, EventArgs e)
        {
            RasporedPrograma odabraniRaspored = (dgvRaspored.CurrentRow.DataBoundItem as Mentor.RaspObavPrikaz).Program;
            if(odabraniRaspored.mentor == CurrentUser.prijavljeniKorisnik.id)
            {
                odabraniRaspored.potpis_mentor = "Pregledano!";
            }
            if (odabraniRaspored.Specijalizacija1.Korisnik1.id == CurrentUser.prijavljeniKorisnik.id)
            {
                odabraniRaspored.potpis_gl_mentor = "Pregledano!";
            }
            model.SaveChanges();
            UcitajZapise();
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

        private void cbSpecijalizanti_SelectedIndexChanged(object sender, EventArgs e)
        {
            UcitajZapise();
        }

        private void SaFilterom()
        {
            Korisnik odabraniKorisnik = cbSpecijalizanti.SelectedItem as Korisnik;
            var sql = from zapisi in model.RasporedPrograma.Include("Korisnik").Include("Specijalizacija1")
                      where ((zapisi.mentor == CurrentUser.prijavljeniKorisnik.id && zapisi.potpis_mentor == null) || (zapisi.Specijalizacija1.Korisnik1.id == CurrentUser.prijavljeniKorisnik.id && zapisi.potpis_gl_mentor == null)) && (zapisi.Specijalizacija1.Korisnik.id == odabraniKorisnik.id)
                      select new Mentor.RaspObavPrikaz
                      {
                          Program = zapisi,
                          Specijalizant = zapisi.Specijalizacija1.Korisnik.ime + " " + zapisi.Specijalizacija1.Korisnik.prezime,
                          Naziv_ustanove = zapisi.naziv_ustanove,
                          Naziv_odjela = zapisi.naziv_odjela,
                          Godisnji_odmor = zapisi.godisnji_odmor,
                          Trajanje_od = zapisi.trajanje_od,
                          Trajanje_do = zapisi.trajanje_do,
                          Pravna_Fizicka_osoba = zapisi.pravna_fizicka_osoba,
                          Ustrojstvena_jedinica = zapisi.ustrojstvena_jedinica,
                          Mentor = zapisi.Korisnik.ime + " " + zapisi.Korisnik.prezime,
                          Potpis_mentor = zapisi.potpis_mentor,
                          Potpis_gl_mentor = zapisi.potpis_gl_mentor,
                          Specijalizacija = zapisi.Specijalizacija1.specijalizacija1
                      };

            BindingSource bindingSource = new BindingSource(sql.ToList(), "");
            dgvRaspored.DataSource = bindingSource;
            dgvRaspored.Columns[0].Visible = false;

            if (bindingSource.Count == 0)
            {
                btnDetalji.Enabled = false;
                btnPregledaj.Enabled = false;
            }
            else
            {
                btnDetalji.Enabled = true;
                btnPregledaj.Enabled = true;
            }
        }

        private void BezFiltera()
        {
            var sql = from zapisi in model.RasporedPrograma.Include("Korisnik").Include("Specijalizacija1")
                      where (zapisi.mentor == CurrentUser.prijavljeniKorisnik.id && zapisi.potpis_mentor == null) || (zapisi.Specijalizacija1.Korisnik1.id == CurrentUser.prijavljeniKorisnik.id && zapisi.potpis_gl_mentor == null)
                      select new Mentor.RaspObavPrikaz
                      {
                          Program = zapisi,
                          Specijalizant = zapisi.Specijalizacija1.Korisnik.ime + " " + zapisi.Specijalizacija1.Korisnik.prezime,
                          Naziv_ustanove = zapisi.naziv_ustanove,
                          Naziv_odjela = zapisi.naziv_odjela,
                          Godisnji_odmor = zapisi.godisnji_odmor,
                          Trajanje_od = zapisi.trajanje_od,
                          Trajanje_do = zapisi.trajanje_do,
                          Pravna_Fizicka_osoba = zapisi.pravna_fizicka_osoba,
                          Ustrojstvena_jedinica = zapisi.ustrojstvena_jedinica,
                          Mentor = zapisi.Korisnik.ime + " " + zapisi.Korisnik.prezime,
                          Potpis_mentor = zapisi.potpis_mentor,
                          Potpis_gl_mentor = zapisi.potpis_gl_mentor,
                          Specijalizacija = zapisi.Specijalizacija1.specijalizacija1
                      };

            BindingSource bindingSource = new BindingSource(sql.ToList(), "");
            dgvRaspored.DataSource = bindingSource;
            dgvRaspored.Columns[0].Visible = false;

            if (bindingSource.Count == 0)
            {
                btnDetalji.Enabled = false;
                btnPregledaj.Enabled = false;
            }
            else
            {
                btnDetalji.Enabled = true;
                btnPregledaj.Enabled = true;
            }
        }
    }
}
