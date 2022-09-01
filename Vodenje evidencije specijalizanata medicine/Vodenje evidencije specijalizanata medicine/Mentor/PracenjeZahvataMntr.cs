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
    public partial class PracenjeZahvataMntr : UserControl
    {
        private MentorLogika mentorLogika;
        private PracenjeZahvataMntrDetalji pracenjeZahvata;
        private StupanjNapredovanja stupanjNapredovanja;
        public PracenjeZahvataMntr()
        {
            InitializeComponent();
            mentorLogika = new MentorLogika();
            DohvatiSpecijalizante();
            UcitajZapise();
        }

        private void btnDetalji_Click(object sender, EventArgs e)
        {
            Zahvati odabranZahvat = (dgvZahvati.CurrentRow.DataBoundItem as ZahvatiPrikaz).Zahvati;
            pracenjeZahvata = new PracenjeZahvataMntrDetalji(odabranZahvat);
            pracenjeZahvata.ShowDialog();
            UcitajZapise();
        }

        private void btnPotpisi_Click(object sender, EventArgs e)
        {
            stupanjNapredovanja = new StupanjNapredovanja(2);
            stupanjNapredovanja.ShowDialog();

            if (stupanjNapredovanja.odabraniStupanj != 0)
            {
                int odabraniStupanjNap = stupanjNapredovanja.odabraniStupanj;
                Zahvati izabranZahvat = (dgvZahvati.CurrentRow.DataBoundItem as ZahvatiPrikaz).Zahvati;

                if (izabranZahvat.mentor == Sloj_obrade.CurrentUser.prijavljeniKorisnik.id)
                {
                    mentorLogika.Pregledaj(izabranZahvat.id, 3, 1, odabraniStupanjNap);
                }
                if (izabranZahvat.Specijalizacija1.Korisnik1.id == Sloj_obrade.CurrentUser.prijavljeniKorisnik.id)
                {
                    mentorLogika.Pregledaj(izabranZahvat.id, 3, 2, 0);
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

            BindingSource bindingSource = new BindingSource(mentorLogika.PracZahZapisi(true, odabraniKorisnik.id), "");
            dgvZahvati.DataSource = bindingSource;
            dgvZahvati.Columns[0].Visible = false;

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
        private void BezFiltera()
        {
            BindingSource bindingSource = new BindingSource(mentorLogika.PracZahZapisi(false, 0), "");
            dgvZahvati.DataSource = bindingSource;
            dgvZahvati.Columns[0].Visible = false;

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
