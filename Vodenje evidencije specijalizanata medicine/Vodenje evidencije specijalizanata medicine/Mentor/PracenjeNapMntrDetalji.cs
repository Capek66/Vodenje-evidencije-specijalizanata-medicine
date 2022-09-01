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

namespace Vodenje_evidencije_specijalizanata_medicine.Mentor
{
    public partial class PracenjeNapMntrDetalji : Form
    {
        private MentorLogika mentorLogika;
        private Kompetencije kompetencija;
        public PracenjeNapMntrDetalji(Kompetencije odabranaKompetencija)
        {
            InitializeComponent();
            mentorLogika = new MentorLogika();
            kompetencija = odabranaKompetencija;
            PostaviStupnjeve();
            UcitajDetalje();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void PostaviStupnjeve()
        {
            cbStupanj.Items.Add("1");
            cbStupanj.Items.Add("2");
            cbStupanj.Items.Add("3");
            cbStupanj.SelectedIndex = 0;
        }
        private void btnPotpisi_Click(object sender, EventArgs e)
        {
            int odabraniStupanjNap = int.Parse(cbStupanj.Text);

            if (kompetencija.mentor == Sloj_obrade.CurrentUser.prijavljeniKorisnik.id)
            {
                mentorLogika.Pregledaj(kompetencija.id, 2, 1, odabraniStupanjNap);
            }
            if (kompetencija.Specijalizacija1.Korisnik1.id == Sloj_obrade.CurrentUser.prijavljeniKorisnik.id)
            {
                mentorLogika.Pregledaj(kompetencija.id, 2, 2, odabraniStupanjNap);
            }
            UcitajDetalje();
        }
        private void UcitajDetalje()
        {
            lblPrezIme.Text = kompetencija.Specijalizacija1.Korisnik.ime + " " + kompetencija.Specijalizacija1.Korisnik.prezime;
            lblKomp.Text = kompetencija.kompetencije1;
            lblPrezImeMentor.Text = kompetencija.Korisnik.ime + " " + kompetencija.Korisnik.prezime;
            lblDatumMntr.Text = ProvijeriText(kompetencija.datum_mentor.ToString());
            lblMentPotp.Text = ProvijeriText(kompetencija.potpis_mentor);
            lblGlMntr.Text = kompetencija.Specijalizacija1.Korisnik1.ime + " " + kompetencija.Specijalizacija1.Korisnik1.prezime;
            lblDatumGlMntr.Text = ProvijeriText(kompetencija.datum_gl_mentor.ToString());
            lblPotpisGlMntr.Text = ProvijeriText(kompetencija.potpis_gl_mentor);
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
