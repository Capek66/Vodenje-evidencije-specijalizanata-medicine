using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vodenje_evidencije_specijalizanata_medicine.Data;

namespace Vodenje_evidencije_specijalizanata_medicine
{
    public static class CurrentUser
    {
        public static Korisnik prijavljeniKorisnik { get; private set; }
        public static Specijalizacija odabranaSpecijalizacija { get; private set; }

        public static void PrijaviKorisnika(Korisnik korisnik)
        {
            prijavljeniKorisnik = korisnik;
        }

        public static void OdjaviKorisnika()
        {
            prijavljeniKorisnik = null;
        }

        public static void OdaberiSpecijalizaciju(Specijalizacija specijalizacija)
        {
            odabranaSpecijalizacija = specijalizacija;
        }

        public static void UkloniSpecifikaciju()
        {
            odabranaSpecijalizacija = null;
        }
    }
}
