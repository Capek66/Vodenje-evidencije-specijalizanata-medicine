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
    public partial class RaspObjDet : Form
    {
        private RasporedPrograma odbRas;
        public RaspObjDet(RasporedPrograma odabraniRaspored)
        {
            InitializeComponent();
            odbRas = odabraniRaspored;
            PostaviDetalje();
        }
        private void PostaviDetalje()
        {
            lblUstanova.Text = odbRas.naziv_ustanove;
            lblOdjel.Text = odbRas.naziv_odjela;
            lblOdmor.Text = odbRas.godisnji_odmor.ToString();
            lblOd.Text = odbRas.trajanje_od.ToString();
            lblDo.Text = odbRas.trajanje_do.ToString();
            lblOsoba.Text = odbRas.pravna_fizicka_osoba;
            lblJedinica.Text = odbRas.ustrojstvena_jedinica;
            lblPrezImeMentor.Text = odbRas.Korisnik.ime + " " + odbRas.Korisnik.prezime;
            lblMentPotp.Text = ProvjeriText(odbRas.potpis_mentor);
            lblGlMntr.Text = CurrentUser.odabranaSpecijalizacija.Korisnik1.ime + " " + CurrentUser.odabranaSpecijalizacija.Korisnik1.prezime;
            lblPotpisGlMntr.Text = ProvjeriText(odbRas.potpis_gl_mentor);
        }

        private string ProvjeriText(string zapis)
        {
            if(zapis == null || zapis == "")
            {
                return "Još nije upisano!";
            }
            else
            {
                return zapis;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
