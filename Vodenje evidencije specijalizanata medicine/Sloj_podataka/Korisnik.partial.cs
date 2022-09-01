using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sloj_podataka
{
    public partial class Korisnik
    {
        public override string ToString()
        {
            return this.ime + " " + this.prezime;
        }
    }
}
