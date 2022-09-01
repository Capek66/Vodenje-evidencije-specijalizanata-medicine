using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sloj_podataka;

namespace Sloj_obrade
{
    public class RaspObavPrikaz
    {
        public RasporedPrograma Program { get; set; }
        public string Specijalizant { get; set; }
        public string Naziv_ustanove { get; set; }
        public string Naziv_odjela { get; set; }
        public int? Godisnji_odmor { get; set; }
        public DateTime Trajanje_od { get; set; }
        public DateTime Trajanje_do { get; set; }
        public string Pravna_Fizicka_osoba { get; set; }
        public string Ustrojstvena_jedinica { get; set; }
        public string Mentor { get; set; }
        public string Potpis_mentor { get; set; }
        public string Potpis_gl_mentor { get; set; }
        public string Specijalizacija { get; set; }
    }
}
