using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vodenje_evidencije_specijalizanata_medicine.Data;

namespace Vodenje_evidencije_specijalizanata_medicine.Mentor
{
    public class KompPrikaz
    {
        public Kompetencije Kompetencije { get; set; }
        public string Specijalizant { get; set; }
        public string Kompetencija { get; set; }
        public int? Stupanj_napredovanja { get; set; }
        public string Mentor { get; set; }
        public DateTime? Datum_mentor { get; set; }
        public string Potpis_mentor { get; set; }
        public DateTime? Datum_gl_mentor { get; set; }
        public string Potpis_gl_mentor { get; set; }
        public string Specijalizacija { get; set; }
    }
}
