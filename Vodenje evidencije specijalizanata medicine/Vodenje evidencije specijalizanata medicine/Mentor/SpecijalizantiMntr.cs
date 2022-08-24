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

namespace Vodenje_evidencije_specijalizanata_medicine.Mentor
{
    public partial class SpecijalizantiMntr : UserControl
    {
        private PregledSpec pregledSpec;
        private KnjizicaModel model;
        public SpecijalizantiMntr()
        {
            InitializeComponent();
            model = new KnjizicaModel();
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
            List<Korisnik> mentor = new List<Korisnik>();

            var sql1 = from r in model.RasporedPrograma.Include("Specijalizacija1")
                       where r.mentor == CurrentUser.prijavljeniKorisnik.id
                       select r.Specijalizacija1.Korisnik;
            List<Korisnik> rMntr = sql1.ToList();

            var sql2 = from k in model.Kompetencije.Include("Specijalizacija1")
                       where k.mentor == CurrentUser.prijavljeniKorisnik.id
                       select k.Specijalizacija1.Korisnik;
            List<Korisnik> kMntr = sql2.ToList();

            var sql3 = from z in model.RasporedPrograma.Include("Specijalizacija1")
                       where z.mentor == CurrentUser.prijavljeniKorisnik.id
                       select z.Specijalizacija1.Korisnik;
            List<Korisnik> zMntr = sql3.ToList();

            foreach (Korisnik k in rMntr)
            {
                if (!mentor.Contains(k))
                {
                    mentor.Add(k);
                }
            }
            foreach (Korisnik k in kMntr)
            {
                if (!mentor.Contains(k))
                {
                    mentor.Add(k);
                }
            }
            foreach (Korisnik k in zMntr)
            {
                if (!mentor.Contains(k))
                {
                    mentor.Add(k);
                }
            }

            BindingSource bsMntr = new BindingSource(mentor, "");
            dgvMentor.DataSource = bsMntr;
        }

        private void UcitajGlMentor()
        {
            List<Korisnik> glMentor = new List<Korisnik>(); 
            foreach (Specijalizacija spec in CurrentUser.prijavljeniKorisnik.Specijalizacija1)
            {
                if (!glMentor.Contains(spec.Korisnik))
                {
                    glMentor.Add(spec.Korisnik);
                }
            }
            BindingSource bsGlMntr = new BindingSource(glMentor, "");
            dgvGlMentor.DataSource = bsGlMntr;
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
