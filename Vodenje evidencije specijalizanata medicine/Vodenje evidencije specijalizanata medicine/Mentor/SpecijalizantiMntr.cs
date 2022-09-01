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
    public partial class SpecijalizantiMntr : UserControl
    {
        private MentorLogika mentorLogika;
        private PregledSpec pregledSpec;
        public SpecijalizantiMntr()
        {
            InitializeComponent();
            mentorLogika = new MentorLogika();
            UcitajSpecijalizante();
        } 

        public void UcitajSpecijalizante()
        {
            UcitajMentor();
            UcitajGlMentor();
            dgvGlMentor.Columns[0].Visible = false;
            dgvMentor.Columns[0].Visible = false;
            for (int i = 5; i < 15; i++)
            {
                dgvGlMentor.Columns[i].Visible = false;
                dgvMentor.Columns[i].Visible = false;
            }
        }

        private void UcitajMentor()
        {
            BindingSource bsMntr = new BindingSource(mentorLogika.SpecijalizantiMntr(), "");
            dgvMentor.DataSource = bsMntr;

            if(bsMntr.Count == 0)
            {
                btnPregMntr.Enabled = false;
            }
            else
            {
                btnPregMntr.Enabled = true;
            }
        }

        private void UcitajGlMentor()
        {
            BindingSource bsGlMntr = new BindingSource(mentorLogika.SpecijalizantiGlMntr(), "");
            dgvGlMentor.DataSource = bsGlMntr;

            if (bsGlMntr.Count == 0)
            {
                btnPregGlMntr.Enabled = false;
            }
            else
            {
                btnPregGlMntr.Enabled = true;
            }
        }

        private void btnPregGlMntr_Click(object sender, EventArgs e)
        {
            Korisnik odabraniKorisnik = dgvGlMentor.CurrentRow.DataBoundItem as Korisnik;
            pregledSpec = new PregledSpec(odabraniKorisnik, 1);
            pregledSpec.ShowDialog();
            UcitajSpecijalizante();
        }
        private void btnPregledaj_Click(object sender, EventArgs e)
        {
            Korisnik odabraniKorisnik = dgvMentor.CurrentRow.DataBoundItem as Korisnik;
            pregledSpec = new PregledSpec(odabraniKorisnik, 2);
            pregledSpec.ShowDialog();
            UcitajSpecijalizante();
        }
    }
}
