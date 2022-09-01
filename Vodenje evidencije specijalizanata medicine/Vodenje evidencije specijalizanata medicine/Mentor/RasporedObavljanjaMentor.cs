using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sloj_podataka;
using Sloj_obrade;

namespace Vodenje_evidencije_specijalizanata_medicine.Mentor
{
    public partial class RasporedObavljanjaMentor : UserControl
    {
        private MentorLogika mentorLogika;
        private RasporedObMntDetails rasporedOb;
        public RasporedObavljanjaMentor()
        {
            InitializeComponent();
            mentorLogika = new MentorLogika();
            DohvatiSpecijalizante();
            UcitajZapise();
        }

        private void btnDetalji_Click(object sender, EventArgs e)
        {
            RasporedPrograma odabraniRaspored = (dgvRaspored.CurrentRow.DataBoundItem as RaspObavPrikaz).Program;
            rasporedOb = new RasporedObMntDetails(odabraniRaspored);
            rasporedOb.ShowDialog();
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

        private void btnPregledaj_Click(object sender, EventArgs e)
        {
            RasporedPrograma odabraniRaspored = (dgvRaspored.CurrentRow.DataBoundItem as RaspObavPrikaz).Program;
            
            if(odabraniRaspored.mentor == Sloj_obrade.CurrentUser.prijavljeniKorisnik.id)
            {
                mentorLogika.Pregledaj(odabraniRaspored.id, 1, 1, 0);
            }
            if (odabraniRaspored.Specijalizacija1.Korisnik1.id == Sloj_obrade.CurrentUser.prijavljeniKorisnik.id)
            {
                mentorLogika.Pregledaj(odabraniRaspored.id, 1, 2, 0);
            }
            UcitajZapise();
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

        private void cbSpecijalizanti_SelectedIndexChanged(object sender, EventArgs e)
        {
            UcitajZapise();
        }

        private void SaFilterom()
        {
            Korisnik odabraniKorisnik = cbSpecijalizanti.SelectedItem as Korisnik;
            BindingSource bindingSource = new BindingSource(mentorLogika.RaspObZapisi(true, odabraniKorisnik.id), "");
            dgvRaspored.DataSource = bindingSource;
            dgvRaspored.Columns[0].Visible = false;

            if (bindingSource.Count == 0)
            {
                btnDetalji.Enabled = false;
                btnPregledaj.Enabled = false;
            }
            else
            {
                btnDetalji.Enabled = true;
                btnPregledaj.Enabled = true;
            }
        }

        private void BezFiltera()
        {
            BindingSource bindingSource = new BindingSource(mentorLogika.RaspObZapisi(false, 0), "");
            dgvRaspored.DataSource = bindingSource;
            dgvRaspored.Columns[0].Visible = false;

            if (bindingSource.Count == 0)
            {
                btnDetalji.Enabled = false;
                btnPregledaj.Enabled = false;
            }
            else
            {
                btnDetalji.Enabled = true;
                btnPregledaj.Enabled = true;
            }
        }
    }
}
