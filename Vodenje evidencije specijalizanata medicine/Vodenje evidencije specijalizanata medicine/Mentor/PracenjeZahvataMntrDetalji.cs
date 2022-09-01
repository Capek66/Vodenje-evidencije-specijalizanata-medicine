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
    public partial class PracenjeZahvataMntrDetalji : Form
    {
        private MentorLogika mentorLogika;
        private Zahvati zahvat;
        public PracenjeZahvataMntrDetalji(Zahvati odabranZahvat)
        {
            InitializeComponent();
            mentorLogika = new MentorLogika();
            zahvat = odabranZahvat;
            PostaviStupnjeve();
            UcitajDetalje();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void PostaviStupnjeve()
        {
            cbStupanj.Items.Add("2");
            cbStupanj.Items.Add("3");
            cbStupanj.SelectedIndex = 0;
        }
        private void UcitajDetalje()
        {
            lblPrezIme.Text = zahvat.Specijalizacija1.Korisnik.ime + " " + zahvat.Specijalizacija1.Korisnik.prezime;
            lblZahvat.Text = zahvat.naziv_zahvata;
            lblBroj.Text = zahvat.broj_zahvata.ToString();
            lblPrezImeMentor.Text = zahvat.Korisnik.ime + " " + zahvat.Korisnik.prezime;
            lblDatumMntr.Text = ProvjeriText(zahvat.datum_mentor.ToString());
            lblMentPotp.Text = ProvjeriText(zahvat.potpis_mentor);
            lblGlMntr.Text = zahvat.Specijalizacija1.Korisnik1.ime + " " + zahvat.Specijalizacija1.Korisnik1.prezime;
            lblDatumGlMntr.Text = ProvjeriText(zahvat.datum_gl_mentor.ToString());
            lblPotpisGlMntr.Text = ProvjeriText(zahvat.potpis_gl_mentor);
        }
        private string ProvjeriText(string text)
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
        private void btnPotpisi_Click(object sender, EventArgs e)
        {
            int odabraniStupanjNap = int.Parse(cbStupanj.Text);

            if (zahvat.mentor == Sloj_obrade.CurrentUser.prijavljeniKorisnik.id)
            {
                mentorLogika.Pregledaj(zahvat.id, 3, 1, odabraniStupanjNap);
            }
            if (zahvat.Specijalizacija1.Korisnik1.id == Sloj_obrade.CurrentUser.prijavljeniKorisnik.id)
            {
                mentorLogika.Pregledaj(zahvat.id, 3, 2, 0);
            }
            UcitajDetalje();
        }
    }
}
