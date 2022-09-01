using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Sloj_podataka;

namespace Sloj_obrade
{
    public class AdministratorLogika
    {
        KnjizicaModel model;
        public AdministratorLogika()
        {
            model = new KnjizicaModel();
        }
        public List<Korisnik> DohvatiSpecijalizante()
        {
            var sql = from specijalizanti in model.Korisnik
                      where specijalizanti.uloga == 3
                      select specijalizanti;
            return sql.ToList();
        }
        public List<Korisnik> DohvatiMentore()
        {
            var sql = from mentori in model.Korisnik
                      where mentori.uloga == 2
                      select mentori;
            return sql.ToList();
        }
        public void DodajKorisnika(int uloga, string ime, string prezime, string email, DateTime god_rod, string ustanova)
        {
            if(uloga == 3)
            {
                Korisnik noviKorisnik = new Korisnik()
                {
                    id = DohvatiID(),
                    ime = ime,
                    prezime = prezime,
                    godina_rodenja = god_rod,
                    email = email,
                    lozinka = GetHash(prezime + ime + ":" + prezime.ToLower()),
                    uloga = 3
                };
                model.Korisnik.Add(noviKorisnik);

                Specijalizant noviSpecijalizant = new Specijalizant()
                {
                    korisnik = noviKorisnik.id,
                    godina_specijalizacije = 1
                };
                model.Specijalizant.Add(noviSpecijalizant);
            }
            else
            {
                Korisnik noviKorisnik = new Korisnik()
                {
                    id = DohvatiID(),
                    ime = ime,
                    prezime = prezime,
                    godina_rodenja = god_rod,
                    email = email,
                    lozinka = GetHash(prezime + ime + ":" + prezime.ToLower()),
                    uloga = 2
                };
                model.Korisnik.Add(noviKorisnik);

                Mentor noviMentor = new Mentor()
                {
                    korisnik = noviKorisnik.id,
                    ustanova = ustanova
                };
                model.Mentor.Add(noviMentor);
            }
            model.SaveChanges();
        }
        private int DohvatiID()
        {
            var sql = from korisnik in model.Korisnik
                      orderby korisnik.id descending
                      select korisnik.id;

            List<int> id = sql.ToList();
            return id[0] + 1;
        }
        private string GetHash(string salt)
        {
            using (var sha256 = new SHA256Managed())
            {
                return BitConverter.ToString(sha256.ComputeHash(Encoding.UTF8.GetBytes(salt))).Replace("-", "").ToLower();
            }
        }
    }
}
