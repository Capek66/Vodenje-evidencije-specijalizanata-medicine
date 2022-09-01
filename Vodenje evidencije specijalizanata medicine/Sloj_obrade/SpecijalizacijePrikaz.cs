using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sloj_podataka;

namespace Sloj_obrade
{
    public class SpecijalizacijePrikaz
    {
        public Specijalizacija specijalizacija { get; set; }
        public string naslov_specijalizacije { get; set; }
        public string odobrena_za { get; set; }
        public string klasa { get; set; }
        public string ubroj { get; set; }
        public DateTime? datum_rjesenja { get; set; }
        public string glavni_mentor { get; set; }
        public DateTime datum_pocetka { get; set; }
        public string potpis_gl_mentora { get; set; }
    }
}
