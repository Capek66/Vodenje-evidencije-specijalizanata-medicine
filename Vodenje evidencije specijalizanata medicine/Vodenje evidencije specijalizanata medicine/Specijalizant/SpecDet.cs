using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sloj_obrade;
using Sloj_podataka;

namespace Vodenje_evidencije_specijalizanata_medicine.Specijalizant
{
    public partial class SpecDet : Form
    {
        private SpecijalizantLogika specijalizantLogika;
        private Sloj_obrade.SpecijalizacijePrikaz specijalizacija;
        public SpecDet(Sloj_obrade.SpecijalizacijePrikaz odabranaSpec)
        {
            InitializeComponent();
            specijalizantLogika = new SpecijalizantLogika();
            specijalizacija = odabranaSpec;
            PostaviDetalje();
        }

        private void btnZatvori_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PostaviDetalje()
        {
            lblSpec.Text = specijalizacija.naslov_specijalizacije;
            lblOsoba.Text = specijalizacija.odobrena_za;
            lblKlasa.Text = Provjeri(specijalizacija.klasa);
            lblUbroj.Text = Provjeri(specijalizacija.ubroj);
            lblDatum.Text = Provjeri(specijalizacija.datum_rjesenja.ToString());
            lvlGlMntr.Text = specijalizacija.glavni_mentor;
            lblDatumPoc.Text = specijalizacija.datum_pocetka.ToString();
            lblPotpisPoc.Text = Provjeri(specijalizacija.potpis_gl_mentora);

            ZavrsetakSpecijalizacije zavrsetakSpecijalizacije = specijalizantLogika.DohvatiZavrsetakSpec(specijalizacija.specijalizacija.id);
            rctbMisljenje.Text = Provjeri(zavrsetakSpecijalizacije.misljenje_gl_mentora);
            lblZavrsetak.Text = Provjeri(zavrsetakSpecijalizacije.datum_zavrsetka.ToString());
            lblPotpisKraj.Text = Provjeri(zavrsetakSpecijalizacije.potpis_gl_mentor);
        }

        private string Provjeri(string text)
        {
            if(text == "" || text == null)
            {
                return "Još nema zapisa!";
            }else
            {
                return text;
            }
        }
    }
}
