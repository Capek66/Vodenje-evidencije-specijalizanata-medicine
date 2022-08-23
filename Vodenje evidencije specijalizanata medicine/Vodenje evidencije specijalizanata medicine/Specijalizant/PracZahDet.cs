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
    public partial class PracZahDet : Form
    {
        private KnjizicaModel model;
        private Zahvati zahvat;
        public PracZahDet(Zahvati odabraniZahvat)
        {
            InitializeComponent();
            model = new KnjizicaModel();
            zahvat = odabraniZahvat;
            PopuniDetalje();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PopuniDetalje()
        {
            lblZahvat.Text = zahvat.naziv_zahvata;
            lblBroj.Text = zahvat.broj_zahvata.ToString();
            lblStNap.Text = ProvijeriText(zahvat.stupanj_napredovanja.ToString());
            lblPrezImeMentor.Text = zahvat.Korisnik.ime + " " + zahvat.Korisnik.prezime;
            lblDatumMntr.Text = ProvijeriText(zahvat.datum_mentor.ToString());
            lblMentPotp.Text = ProvijeriText(zahvat.potpis_mentor);
            lblGlMntr.Text = CurrentUser.odabranaSpecijalizacija.Korisnik1.ime + " " + CurrentUser.odabranaSpecijalizacija.Korisnik1.prezime;
            lblDatumGlMntr.Text = ProvijeriText(zahvat.datum_gl_mentor.ToString());
            lblPotpisGlMntr.Text = ProvijeriText(zahvat.potpis_gl_mentor);
        }
        private string ProvijeriText(string text)
        {
            if (text == "" || text == null)
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
