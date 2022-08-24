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
    public partial class RasporedObMntDetails : Form
    {
        private RasporedPrograma program;
        private KnjizicaModel model;
        public RasporedObMntDetails(RasporedPrograma odabraniRaspored)
        {
            InitializeComponent();
            model = new KnjizicaModel();
            DohvatiRaspored(odabraniRaspored);
            PopuniDetalje();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PopuniDetalje()
        {
            lblPrezIme.Text = program.Specijalizacija1.Korisnik.ime + " " + program.Specijalizacija1.Korisnik.prezime;
            lblUstanova.Text = program.naziv_ustanove;
            lblOdjel.Text = program.naziv_odjela;
            lblOdmor.Text = program.godisnji_odmor.ToString();
            lblOd.Text = program.trajanje_od.ToString();
            lblDo.Text = program.trajanje_do.ToString();
            lblOsoba.Text = program.pravna_fizicka_osoba;
            lblJedinica.Text = program.ustrojstvena_jedinica;
            lblPrezImeMentor.Text = program.Korisnik.ime + " " + program.Korisnik.prezime;
            lblMentPotp.Text = ProvjeriText(program.potpis_mentor);
            lblGlMntr.Text = program.Specijalizacija1.Korisnik1.ime + " " + program.Specijalizacija1.Korisnik1.prezime;
            lblPotpisGlMntr.Text = ProvjeriText(program.potpis_gl_mentor);
        }

        private string ProvjeriText(string zapis)
        {
            if (zapis == null || zapis == "")
            {
                return "Još nije upisano!";
            }
            else
            {
                return zapis;
            }
        }

        private void btnPotpisi_Click(object sender, EventArgs e)
        {
            if (program.mentor == CurrentUser.prijavljeniKorisnik.id)
            {
                program.potpis_mentor = "Pregledano!";
            }
            if (program.Specijalizacija1.Korisnik1.id == CurrentUser.prijavljeniKorisnik.id)
            {
                program.potpis_gl_mentor = "Pregledano!";
            }
            model.SaveChanges();
            PopuniDetalje();
        }

        private void DohvatiRaspored(RasporedPrograma odabraniRaspored)
        {
            var sql = from p in model.RasporedPrograma
                      where p.id == odabraniRaspored.id
                      select p;

            program = sql.Single();
        }
    }
}
