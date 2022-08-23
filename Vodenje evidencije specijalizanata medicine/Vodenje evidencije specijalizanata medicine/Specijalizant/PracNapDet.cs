using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vodenje_evidencije_specijalizanata_medicine.Data;

namespace Vodenje_evidencije_specijalizanata_medicine.Specijalizant
{
    public partial class PracNapDet : Form
    {
        private KnjizicaModel model;
        private Kompetencije kompetencija;
        public PracNapDet(Kompetencije odabranaKomp)
        {
            InitializeComponent();
            model = new KnjizicaModel();
            kompetencija = odabranaKomp;
            PopuniDetalje();
        }
        private void PopuniDetalje()
        {
            lblKomp.Text = kompetencija.kompetencije1;
            lblStupanj.Text = ProvijeriText(kompetencija.stupanj_napredovanja.ToString());
            lblPrezImeMentor.Text = kompetencija.Korisnik.ime + " " + kompetencija.Korisnik.prezime;
            lblDatumMntr.Text = ProvijeriText(kompetencija.datum_mentor.ToString());
            lblMentPotp.Text = ProvijeriText(kompetencija.potpis_mentor);
            lblGlMntr.Text = CurrentUser.odabranaSpecijalizacija.Korisnik1.ime + " " + CurrentUser.odabranaSpecijalizacija.Korisnik1.prezime;
            lblDatumGlMntr.Text = ProvijeriText(kompetencija.datum_gl_mentor.ToString());
            lblPotpisGlMntr.Text = ProvijeriText(kompetencija.potpis_gl_mentor);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private string ProvijeriText(string text)
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
