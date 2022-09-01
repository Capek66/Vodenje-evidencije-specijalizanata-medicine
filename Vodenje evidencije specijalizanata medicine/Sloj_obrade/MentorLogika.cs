using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sloj_podataka;

namespace Sloj_obrade
{
    public class MentorLogika
    {
        KnjizicaModel model;
        public MentorLogika()
        {
            model = new KnjizicaModel();
        }
        public List<RaspObavPrikaz> RaspObZapisi(bool filter, int specID)
        {
            if (filter)
            {
                var sql = from zapisi in model.RasporedPrograma.Include("Korisnik").Include("Specijalizacija1")
                          where ((zapisi.mentor == CurrentUser.prijavljeniKorisnik.id && zapisi.potpis_mentor == null) || (zapisi.Specijalizacija1.Korisnik1.id == CurrentUser.prijavljeniKorisnik.id && zapisi.potpis_gl_mentor == null)) && (zapisi.Specijalizacija1.Korisnik.id == specID)
                          select new RaspObavPrikaz
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
                return sql.ToList();
            }
            else
            {
                var sql = from zapisi in model.RasporedPrograma.Include("Korisnik").Include("Specijalizacija1")
                          where (zapisi.mentor == CurrentUser.prijavljeniKorisnik.id && zapisi.potpis_mentor == null) || (zapisi.Specijalizacija1.Korisnik1.id == CurrentUser.prijavljeniKorisnik.id && zapisi.potpis_gl_mentor == null)
                          select new RaspObavPrikaz
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
                return sql.ToList();
            }
        }
        public List<KompPrikaz> PracNapZapisi(bool filter, int specID)
        {
            if (filter)
            {
                var sql = from zapisi in model.Kompetencije.Include("Korisnik").Include("Specijalizacija1")
                          where ((zapisi.mentor == CurrentUser.prijavljeniKorisnik.id && zapisi.potpis_mentor == null) || (zapisi.Specijalizacija1.Korisnik1.id == CurrentUser.prijavljeniKorisnik.id && zapisi.potpis_gl_mentor == null)) && (zapisi.Specijalizacija1.Korisnik.id == specID)
                          select new KompPrikaz
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
                return sql.ToList();
            }
            else
            {
                var sql = from zapisi in model.Kompetencije.Include("Korisnik").Include("Specijalizacija1")
                          where (zapisi.mentor == CurrentUser.prijavljeniKorisnik.id && zapisi.potpis_mentor == null) || (zapisi.Specijalizacija1.Korisnik1.id == CurrentUser.prijavljeniKorisnik.id && zapisi.potpis_gl_mentor == null)
                          select new KompPrikaz
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
                return sql.ToList();
            }
        }
        public List<ZahvatiPrikaz> PracZahZapisi(bool filter, int specID)
        {
            if (filter)
            {
                var sql = from zapisi in model.Zahvati.Include("Korisnik").Include("Specijalizacija1")
                          where ((zapisi.mentor == CurrentUser.prijavljeniKorisnik.id && zapisi.potpis_mentor == null) || (zapisi.Specijalizacija1.Korisnik1.id == CurrentUser.prijavljeniKorisnik.id && zapisi.potpis_gl_mentor == null)) && (zapisi.Specijalizacija1.Korisnik.id == specID)
                          select new ZahvatiPrikaz
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
                return sql.ToList();
            }
            else
            {
                var sql = from zapisi in model.Zahvati.Include("Korisnik").Include("Specijalizacija1")
                          where (zapisi.mentor == CurrentUser.prijavljeniKorisnik.id && zapisi.potpis_mentor == null) || (zapisi.Specijalizacija1.Korisnik1.id == CurrentUser.prijavljeniKorisnik.id && zapisi.potpis_gl_mentor == null)
                          select new ZahvatiPrikaz
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
                return sql.ToList();
            }
        }
        public List<Korisnik> DohvatiSpecijalizante()
        {
            var sql = from spec in model.Korisnik
                      where spec.uloga == 3
                      select spec;
            return sql.ToList();
        }
        public List<Korisnik> SpecijalizantiMntr()
        {
            List<Korisnik> mentor = new List<Korisnik>();

            var sql1 = from r in model.RasporedPrograma.Include("Specijalizacija1")
                       where r.mentor == CurrentUser.prijavljeniKorisnik.id
                       select r.Specijalizacija1.Korisnik;
            List<Korisnik> rMntr = sql1.ToList();

            var sql2 = from k in model.Kompetencije.Include("Specijalizacija1")
                       where k.mentor == CurrentUser.prijavljeniKorisnik.id
                       select k.Specijalizacija1.Korisnik;
            List<Korisnik> kMntr = sql2.ToList();

            var sql3 = from z in model.RasporedPrograma.Include("Specijalizacija1")
                       where z.mentor == CurrentUser.prijavljeniKorisnik.id
                       select z.Specijalizacija1.Korisnik;
            List<Korisnik> zMntr = sql3.ToList();

            foreach (Korisnik k in rMntr)
            {
                if (!mentor.Contains(k))
                {
                    mentor.Add(k);
                }
            }
            foreach (Korisnik k in kMntr)
            {
                if (!mentor.Contains(k))
                {
                    mentor.Add(k);
                }
            }
            foreach (Korisnik k in zMntr)
            {
                if (!mentor.Contains(k))
                {
                    mentor.Add(k);
                }
            }
            return mentor;
        }
        public List<Korisnik> SpecijalizantiGlMntr()
        {
            List<Korisnik> glMentor = new List<Korisnik>();
            foreach (Specijalizacija spec in CurrentUser.prijavljeniKorisnik.Specijalizacija1)
            {
                if (!glMentor.Contains(spec.Korisnik))
                {
                    glMentor.Add(spec.Korisnik);
                }
            }
            return glMentor;
        }
        public List<Specijalizacija> SpecijalizacijeSpecijalizanta(int specID)
        {
            var sql = from s in model.Specijalizacija
                      where s.Korisnik.id == specID
                      orderby s.id descending
                      select s;

            return sql.ToList();
        }
        public void SpremiSpecijalizaciju(int specID, string klasa, string ubroj, DateTime datum_rjesenja)
        {
            var sql = from z in model.Specijalizacija
                      where z.id == specID
                      select z;
            Specijalizacija specijalizacija = sql.Single();
            specijalizacija.klasa = klasa;
            specijalizacija.ubroj = ubroj;
            specijalizacija.datum_rjesenja = datum_rjesenja;
            specijalizacija.potpis_gl_mentora = "Potpisano!";
            model.SaveChanges();
        }
        public void SpremiZavrsetak(int specID, string misljenje, DateTime datum_zavrsetka)
        {
            var sql = from z in model.ZavrsetakSpecijalizacije
                      where z.id == specID
                      select z;
            ZavrsetakSpecijalizacije zavrsetakSpecijalizacije = sql.Single();
            zavrsetakSpecijalizacije.misljenje_gl_mentora = misljenje;
            zavrsetakSpecijalizacije.datum_zavrsetka = datum_zavrsetka;
            zavrsetakSpecijalizacije.potpis_gl_mentor = "Potpisano!";
            model.SaveChanges();
        }
        public List<RaspObavPrikaz> RaspObSviZap(int korID, int specID)
        {
            var sql = from zapisi in model.RasporedPrograma.Include("Korisnik").Include("Specijalizacija1")
                      where zapisi.Specijalizacija1.Korisnik.id == korID && zapisi.Specijalizacija1.id == specID
                      orderby zapisi.id descending
                      select new RaspObavPrikaz
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
            return sql.ToList();
        }
        public List<KompPrikaz> PracNapSviZapisi(int korID, int specID)
        {
            var sql = from zapisi in model.Kompetencije.Include("Korisnik").Include("Specijalizacija1")
                      where zapisi.Specijalizacija1.Korisnik.id == korID && zapisi.Specijalizacija1.id == specID
                      select new KompPrikaz
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
            return sql.ToList();
        }
        public List<ZahvatiPrikaz> PracZahSviZapisi(int korID, int specID)
        {
            var sql = from zapisi in model.Zahvati.Include("Korisnik").Include("Specijalizacija1")
                      where zapisi.Specijalizacija1.Korisnik.id == korID && zapisi.Specijalizacija1.id == specID
                      select new ZahvatiPrikaz
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
            return sql.ToList();
        }
        public void Pregledaj(int zapisID, int tip, int mntrTip, int stupanj)
        {
            if(tip == 1)
            {
                var sql = from z in model.RasporedPrograma
                          where z.id == zapisID
                          select z;

                RasporedPrograma rasporedPrograma = sql.Single();
                if(mntrTip == 1)
                {
                    rasporedPrograma.potpis_mentor = "Pregledano!";
                }
                else
                {
                    rasporedPrograma.potpis_gl_mentor = "Pregledano!";
                }
            }else if (tip == 2)
            {
                var sql = from z in model.Kompetencije
                          where z.id == zapisID
                          select z;

                Kompetencije kompetencije = sql.Single();
                if (mntrTip == 1)
                {
                    kompetencije.potpis_mentor = "Pregledano!";
                    kompetencije.datum_mentor = DateTime.Now;
                    kompetencije.stupanj_napredovanja = stupanj;
                }
                else
                {
                    kompetencije.potpis_gl_mentor = "Pregledano!";
                    kompetencije.datum_gl_mentor = DateTime.Now;
                }
            }
            else
            {
                var sql = from z in model.Zahvati
                          where z.id == zapisID
                          select z;

                Zahvati zahvati = sql.Single();
                if (mntrTip == 1)
                {
                    zahvati.potpis_mentor = "Pregledano!";
                    zahvati.datum_mentor = DateTime.Now;
                    zahvati.stupanj_napredovanja = stupanj;
                }
                else
                {
                    zahvati.potpis_gl_mentor = "Pregledano!";
                    zahvati.datum_gl_mentor = DateTime.Now;
                }
            }
            model.SaveChanges();
        }
    }
}
