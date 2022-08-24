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
    public partial class PopisZapisa : Form
    {
        private KnjizicaModel model;
        private int tipZapisa;
        private Korisnik odabraniKorisnik;
        private Specijalizacija odabranaSpec;
        public PopisZapisa(int vrstaZapisa, int korisnikID, int specijalizacijaID)
        {
            InitializeComponent();
            model = new KnjizicaModel();
            tipZapisa = vrstaZapisa;
            DohvatiKorisnikaiSpec(korisnikID, specijalizacijaID);
            UcitajZapise();
        }

        private void btnZatovi_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DohvatiKorisnikaiSpec(int korisnikID, int specID)
        {
            var sql1 = from k in model.Korisnik
                      where k.id == korisnikID
                      select k;

            odabraniKorisnik = sql1.Single();

            var sql2 = from s in model.Specijalizacija
                       where s.id == specID
                       select s;

            odabranaSpec = sql2.Single();
        }

        private void UcitajZapise()
        {
            if(tipZapisa == 1)
            {
                var sql = from zapisi in model.RasporedPrograma.Include("Korisnik").Include("Specijalizacija1")
                          where zapisi.Specijalizacija1.Korisnik.id == odabraniKorisnik.id && zapisi.Specijalizacija1.id == odabranaSpec.id
                          orderby zapisi.id descending
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
                dgvZapisi.DataSource = bindingSource;
                dgvZapisi.Columns[0].Visible = false;
            }
            else if(tipZapisa == 2)
            {
                var sql = from zapisi in model.Kompetencije.Include("Korisnik").Include("Specijalizacija1")
                          where zapisi.Specijalizacija1.Korisnik.id == odabraniKorisnik.id && zapisi.Specijalizacija1.id == odabranaSpec.id
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
                dgvZapisi.DataSource = bindingSource;
                dgvZapisi.Columns[0].Visible = false;
            }
            else
            {
                var sql = from zapisi in model.Zahvati.Include("Korisnik").Include("Specijalizacija1")
                          where zapisi.Specijalizacija1.Korisnik.id == odabraniKorisnik.id && zapisi.Specijalizacija1.id == odabranaSpec.id
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
                dgvZapisi.DataSource = bindingSource;
                dgvZapisi.Columns[0].Visible = false;
            }
        }

        private void btnDetalji_Click(object sender, EventArgs e)
        {
            if(tipZapisa == 1)
            {
                RasporedPrograma odabraniZapis = (dgvZapisi.CurrentRow.DataBoundItem as Mentor.RaspObavPrikaz).Program;
                RasporedObMntDetails detalji = new RasporedObMntDetails(odabraniZapis);
                detalji.ShowDialog();
                UcitajZapise();
            }else if(tipZapisa == 2)
            {
                Kompetencije odabraniZapis = (dgvZapisi.CurrentRow.DataBoundItem as Mentor.KompPrikaz).Kompetencije;
                PracenjeNapMntrDetalji detalji = new PracenjeNapMntrDetalji(odabraniZapis);
                detalji.ShowDialog();
                UcitajZapise();
            }
            else
            {
                Zahvati odabraniZapis = (dgvZapisi.CurrentRow.DataBoundItem as Mentor.ZahvatiPrikaz).Zahvati;
                PracenjeZahvataMntrDetalji detalji = new PracenjeZahvataMntrDetalji(odabraniZapis);
                detalji.ShowDialog();
                UcitajZapise();
            }
        }
    }
}
