using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sloj_podataka;

namespace Sloj_obrade
{
    public class SpecijalizantLogika
    {
        KnjizicaModel model;
        public SpecijalizantLogika()
        {
            model = new KnjizicaModel();
        }
        public List<Specijalizacija> DohvatiSpec()
        {
            var sql = from specijalizacije in model.Specijalizacija
                      where specijalizacije.specijalizant == CurrentUser.prijavljeniKorisnik.id
                      orderby specijalizacije.id descending
                      select specijalizacije;
            return sql.ToList();
        }
        public List<RasporedPrograma> RaspObZapisi()
        {
            var sql = from raspored in model.RasporedPrograma.Include("Korisnik")
                      where raspored.specijalizacija == CurrentUser.odabranaSpecijalizacija.id
                      orderby raspored.id descending
                      select raspored;
            return sql.ToList();
        }
        public List<Korisnik> DohvatiMentore()
        {
            var sql = from mentori in model.Korisnik
                      where mentori.uloga == 2
                      select mentori;

            return sql.ToList();
        }
        public void RaspObNovi(RasporedPrograma raspored)
        {
            raspored.id = DohvatiID(1);
            model.RasporedPrograma.Add(raspored);
            model.SaveChanges();
        }
        public List<Kompetencije> PracNapZapisi()
        {
            var sql = from komp in model.Kompetencije.Include("Korisnik")
                      where komp.specijalizacija == CurrentUser.odabranaSpecijalizacija.id
                      orderby komp.id descending
                      select komp;
            return sql.ToList();
        }
        public void PracZapNovi(Kompetencije kompetencije)
        {
            kompetencije.id = DohvatiID(2);
            model.Kompetencije.Add(kompetencije);
            model.SaveChanges();
        }
        public List<Zahvati> PracZahZapisi()
        {
            var sql = from zahv in model.Zahvati.Include("Korisnik")
                      where zahv.specijalizacija == CurrentUser.odabranaSpecijalizacija.id
                      orderby zahv.id descending
                      select zahv;
            return sql.ToList();
        }
        public void PracZahNovi(Zahvati zahvati)
        {
            zahvati.id = DohvatiID(3);
            model.Zahvati.Add(zahvati);
            model.SaveChanges();
        }
        public List<SpecijalizacijePrikaz> SpecZapisi()
        {
            var sql = from specijalizacije in model.Specijalizacija.Include("Korisnik1")
                      where specijalizacije.specijalizant == CurrentUser.prijavljeniKorisnik.id
                      orderby specijalizacije.id descending
                      select new SpecijalizacijePrikaz
                      {
                          specijalizacija = specijalizacije,
                          naslov_specijalizacije = specijalizacije.specijalizacija1,
                          odobrena_za = specijalizacije.odobrena_za,
                          klasa = specijalizacije.klasa,
                          ubroj = specijalizacije.ubroj,
                          datum_rjesenja = specijalizacije.datum_rjesenja,
                          glavni_mentor = specijalizacije.Korisnik1.ime + " " + specijalizacije.Korisnik1.prezime,
                          datum_pocetka = specijalizacije.datum_pocetka,
                          potpis_gl_mentora = specijalizacije.potpis_gl_mentora
                      };
            return sql.ToList();
        }
        public void SpecNovi(Specijalizacija specijalizacija, ZavrsetakSpecijalizacije zavrsetakSpecijalizacije)
        {
            int id = DohvatiID(4);
            specijalizacija.id = id;
            zavrsetakSpecijalizacije.id = id;
            model.Specijalizacija.Add(specijalizacija);
            model.ZavrsetakSpecijalizacije.Add(zavrsetakSpecijalizacije);
            model.SaveChanges();
            CurrentUser.OdaberiSpecijalizaciju(specijalizacija);
        }
        public ZavrsetakSpecijalizacije DohvatiZavrsetakSpec(int specID)
        {
            var sql = from zavrsetak in model.ZavrsetakSpecijalizacije
                      where zavrsetak.specijalizacija == specID
                      select zavrsetak;
            return sql.Single();
        }
        private int DohvatiID(int tip)
        {
            if (tip == 1)
            {
                var sql = from raspored in model.RasporedPrograma
                          orderby raspored.id descending
                          select raspored.id;

                if (sql.ToList().Count != 0)
                {
                    List<int> id = sql.ToList();

                    return id[0] + 1;
                }
                else
                {
                    return 1;
                }
            }else if(tip == 2)
            {
                var sql = from komp in model.Kompetencije
                          orderby komp.id descending
                          select komp.id;

                if (sql.ToList().Count != 0)
                {
                    List<int> id = sql.ToList();

                    return id[0] + 1;
                }
                else
                {
                    return 1;
                }
            }else if(tip == 3)
            {
                var sql = from zahvat in model.Zahvati
                          orderby zahvat.id descending
                          select zahvat.id;

                if (sql.ToList().Count != 0)
                {
                    List<int> id = sql.ToList();

                    return id[0] + 1;
                }
                else
                {
                    return 1;
                }
            }
            else
            {
                var sql = from specijalizacija in model.Specijalizacija
                          orderby specijalizacija.id descending
                          select specijalizacija.id;
                try
                {
                    List<int> id = sql.ToList();

                    return id[0] + 1;
                }
                catch (Exception e)
                {
                    return 1;
                }
            };
            
        }
    }
}
