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
    public partial class PracenjeNapMntr : UserControl
    {
        private MentorLogika mentorLogika;
        private PracenjeNapMntrDetalji pracenjeNap;
        private StupanjNapredovanja stupanjNapredovanja;
        public PracenjeNapMntr()
        {
            InitializeComponent();
            mentorLogika = new MentorLogika();
            DohvatiSpecijalizante();
        }

        private void btnDetalji_Click(object sender, EventArgs e)
        {
            Kompetencije odabranaKompetencija = (dgvKompetencije.CurrentRow.DataBoundItem as KompPrikaz).Kompetencije;
            pracenjeNap = new PracenjeNapMntrDetalji(odabranaKompetencija);
            pracenjeNap.ShowDialog();
            UcitajZapise();
        }

        private void btnPotpisi_Click(object sender, EventArgs e)
        {
            stupanjNapredovanja = new StupanjNapredovanja(1);
            stupanjNapredovanja.ShowDialog();
            if(stupanjNapredovanja.odabraniStupanj != 0)
            {
                int odabraniStupanjNap = stupanjNapredovanja.odabraniStupanj;
                Kompetencije odabranaKompetencija = (dgvKompetencije.CurrentRow.DataBoundItem as KompPrikaz).Kompetencije;

                if (odabranaKompetencija.mentor == Sloj_obrade.CurrentUser.prijavljeniKorisnik.id)
                {
                    mentorLogika.Pregledaj(odabranaKompetencija.id, 2, 1, odabraniStupanjNap);
                }
                if (odabranaKompetencija.Specijalizacija1.Korisnik1.id == Sloj_obrade.CurrentUser.prijavljeniKorisnik.id)
                {
                    mentorLogika.Pregledaj(odabranaKompetencija.id, 2, 2, 0);
                }
                UcitajZapise();
            }
            
        }
        private void DohvatiSpecijalizante()
        {
            cbSpecijalizanti.Items.Add("Izaberite specijalizanta");

            foreach (var specijalizant in mentorLogika.DohvatiSpecijalizante())
            {
                cbSpecijalizanti.Items.Add(specijalizant);
            }
            cbSpecijalizanti.SelectedIndex = 0;
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            cbSpecijalizanti.SelectedIndex = 0;
            UcitajZapise();
        }
        public void UcitajZapise()
        {
            if (cbSpecijalizanti.SelectedIndex != 0)
            {
                SaFilterom();
            }
            else
            {
                BezFiltera();
            }
        }
        private void cbSpecijalizanti_SelectedIndexChanged(object sender, EventArgs e)
        {
            UcitajZapise();
        }
        private void SaFilterom()
        {
            Korisnik odabraniKorisnik = cbSpecijalizanti.SelectedItem as Korisnik;

            BindingSource bindingSource = new BindingSource(mentorLogika.PracNapZapisi(true, odabraniKorisnik.id), "");
            dgvKompetencije.DataSource = bindingSource;
            dgvKompetencije.Columns[0].Visible = false;

            if(bindingSource.Count == 0)
            {
                btnDetalji.Enabled = false;
                btnPotpisi.Enabled = false;
            }
            else
            {
                btnDetalji.Enabled = true;
                btnPotpisi.Enabled = true;
            }
        }
        private void BezFiltera()
        {
            BindingSource bindingSource = new BindingSource(mentorLogika.PracNapZapisi(false, 0), "");
            dgvKompetencije.DataSource = bindingSource;
            dgvKompetencije.Columns[0].Visible = false;

            if (bindingSource.Count == 0)
            {
                btnDetalji.Enabled = false;
                btnPotpisi.Enabled = false;
            }
            else
            {
                btnDetalji.Enabled = true;
                btnPotpisi.Enabled = true;
            }
        }
    }
}
