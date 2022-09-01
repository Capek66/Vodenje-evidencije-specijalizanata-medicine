using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Sloj_podataka;

namespace Sloj_obrade
{
    public class ZajednicaLogika
    {
        private KnjizicaModel model;
        public ZajednicaLogika()
        {
            model = new KnjizicaModel();
        }
        public bool ProvjeriPodatke(string email, string lozinka)
        {
            var sql = from korisnik in model.Korisnik
                      where korisnik.email == email
                      select korisnik;

            Korisnik pronadeniKorisnik;
            try
            {
                pronadeniKorisnik = sql.Single();
            }
            catch (Exception e)
            {
                return false;
            }

            string salt = pronadeniKorisnik.prezime + pronadeniKorisnik.ime + ":" + lozinka;
            string hash = GetHash(salt);

            if (hash.Equals(pronadeniKorisnik.lozinka))
            {
                CurrentUser.PrijaviKorisnika(pronadeniKorisnik);
                return true;
            }
            else
            {
                return false;
            }
        }
        public IDictionary<string, string> DohvatiPodatkeProfil()
        {
            Korisnik korisnik = PronadiKorisnika();
            Dictionary<string, string> podaci = new Dictionary<string, string>();
            podaci["ime"] = korisnik.ime;
            podaci["prezime"] = korisnik.prezime;
            podaci["email"] = korisnik.email;
            podaci["god_rod"] = korisnik.godina_rodenja.ToString();
            if(korisnik.uloga == 2)
            {
                podaci["var"] = korisnik.Mentor.ustanova;
            }
            if(korisnik.uloga == 3)
            {
                podaci["var"] = korisnik.Specijalizant.godina_specijalizacije.ToString();
            }
            return podaci;
        }
        public void AzurirajPodatkeProfil(string ime, string prezime, string email, DateTime god_rod, string var)
        {
            Korisnik korisnik = PronadiKorisnika();
            korisnik.ime = ime;
            korisnik.prezime = prezime;
            korisnik.email = email;
            korisnik.godina_rodenja = god_rod;
            if (korisnik.uloga == 2)
            {
                korisnik.Mentor.ustanova = var;
            }
            if (korisnik.uloga == 3)
            {
                korisnik.Specijalizant.godina_specijalizacije = int.Parse(var);
            }
            model.SaveChanges();
        }
        public void AzurirajLozinku(string novaLoz)
        {
            Korisnik korisnik = PronadiKorisnika();
            string salt = korisnik.prezime + korisnik.ime + ":" + novaLoz;
            korisnik.lozinka = GetHash(salt);
            model.SaveChanges();
        }
        private Korisnik PronadiKorisnika()
        {
            var sql = from k in model.Korisnik.Include("Mentor").Include("Specijalizant")
                      where k.id == CurrentUser.prijavljeniKorisnik.id
                      select k;

            return sql.Single();
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
