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

namespace Vodenje_evidencije_specijalizanata_medicine
{
    public partial class Profil : UserControl
    {
        private PasswordUpdate passwordUpdate;
        private ZajednicaLogika zajednicaLogika;
        private bool stanje;
        public Profil()
        {
            InitializeComponent();
            zajednicaLogika = new ZajednicaLogika();
            PocetnoStanje();
            UcitajPodatke(zajednicaLogika.DohvatiPodatkeProfil());
        }

        private void btnPass_Click(object sender, EventArgs e)
        {
            passwordUpdate = new PasswordUpdate();
            passwordUpdate.ShowDialog();
        }

        private void btnAzuriraj_Click(object sender, EventArgs e)
        {
            if (!stanje)
            {
                stanje = true;
                btnAzuriraj.Text = "Spremi pomjene";
                tbIme.Enabled = true;
                tbPrezime.Enabled = true;
                tbEmail.Enabled = true;
                dtpDatRod.Enabled = true;
                tbVar.Enabled = true;
            }
            else
            {
                zajednicaLogika.AzurirajPodatkeProfil(tbIme.Text, tbPrezime.Text, tbEmail.Text, dtpDatRod.Value, tbVar.Text);
                PocetnoStanje();
                UcitajPodatke(zajednicaLogika.DohvatiPodatkeProfil());
            }
        }

        private void PocetnoStanje()
        {
            stanje = false;
            btnAzuriraj.Text = "Ažuriraj podatke";
            tbIme.Enabled = false;
            tbPrezime.Enabled = false;
            tbEmail.Enabled = false;
            dtpDatRod.Enabled = false;
            tbVar.Enabled = false;
            if (Sloj_obrade.CurrentUser.DohvatiUlogu() == "Mentor")
            {
                lblVar.Text = "Ustanova:";
            }
            else if(Sloj_obrade.CurrentUser.DohvatiUlogu() == "Specijalizant")
            {
                lblVar.Text = "Godina specijalizacije:";
            }
            else
            {
                lblVar.Text = "Ne popunjava se!";
            }
        }

        public void UcitajPodatke(IDictionary<string, string> podaci)
        {
            tbIme.Text = podaci["ime"];
            tbPrezime.Text = podaci["prezime"];
            tbEmail.Text = podaci["email"];
            dtpDatRod.Value = DateTime.Parse(podaci["god_rod"]);
            if (Sloj_obrade.CurrentUser.DohvatiUlogu()== "Mentor")
            {
                tbVar.Text = podaci["var"];
            }
            else if (Sloj_obrade.CurrentUser.DohvatiUlogu() == "Specijalizant")
            {
                tbVar.Text = podaci["var"];
            }
            else
            {
                tbVar.Text = "Nepostojeći zapis!";
                tbVar.Enabled = false;
            }
        }
    }
}
