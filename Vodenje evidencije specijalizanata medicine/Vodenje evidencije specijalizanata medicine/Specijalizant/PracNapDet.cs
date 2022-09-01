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
    public partial class PracNapDet : Form
    {
        private Kompetencije kompetencija;
        public PracNapDet(Kompetencije odabranaKomp)
        {
            InitializeComponent();
            kompetencija = odabranaKomp;
            PopuniDetalje();
        }
        private void PopuniDetalje()
        {
            lblKomp.Text = kompetencija.kompetencije1;
            lblStupanj.Text = ProvjeriText(kompetencija.stupanj_napredovanja.ToString());
            lblPrezImeMentor.Text = kompetencija.Korisnik.ime + " " + kompetencija.Korisnik.prezime;
            lblDatumMntr.Text = ProvjeriText(kompetencija.datum_mentor.ToString());
            lblMentPotp.Text = ProvjeriText(kompetencija.potpis_mentor);
            lblGlMntr.Text = Sloj_obrade.CurrentUser.odabranaSpecijalizacija.Korisnik1.ime + " " + Sloj_obrade.CurrentUser.odabranaSpecijalizacija.Korisnik1.prezime;
            lblDatumGlMntr.Text = ProvjeriText(kompetencija.datum_gl_mentor.ToString());
            lblPotpisGlMntr.Text = ProvjeriText(kompetencija.potpis_gl_mentor);
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private string ProvjeriText(string text)
        {
            if(text == "" || text == null)
            {
                return "Još nema zapisa!";
            }
            else
            {
                return text;
            }
        }
    }
}
