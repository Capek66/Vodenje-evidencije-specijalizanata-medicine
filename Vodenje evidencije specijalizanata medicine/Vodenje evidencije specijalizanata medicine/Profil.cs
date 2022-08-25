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

namespace Vodenje_evidencije_specijalizanata_medicine
{
    public partial class Profil : UserControl
    {
        private PasswordUpdate passwordUpdate;
        private KnjizicaModel model;
        private bool stanje;
        private Korisnik korisnik;
        public Profil()
        {
            InitializeComponent();
            model = new KnjizicaModel();
            PocetnoStanje();
            PronadiKorisnika();
            UcitajPodatke();
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
                korisnik.ime = tbIme.Text;
                korisnik.prezime = tbPrezime.Text;
                korisnik.email = tbEmail.Text;
                korisnik.godina_rodenja = dtpDatRod.Value;
                if(korisnik.uloga == 2)
                {
                    korisnik.Mentor.ustanova = tbVar.Text;
                }
                else if(korisnik.uloga == 3)
                {
                    korisnik.Specijalizant.godina_specijalizacije = int.Parse(tbVar.Text);
                }
                model.SaveChanges();
                PocetnoStanje();
                UcitajPodatke();
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
            if (CurrentUser.prijavljeniKorisnik.uloga == 2)
            {
                lblVar.Text = "Ustanova:";
            }
            else if(CurrentUser.prijavljeniKorisnik.uloga == 3)
            {
                lblVar.Text = "Godina specijalizacije:";
            }
            else
            {
                lblVar.Text = "Ne popunjava se!";
            }
        }

        public void UcitajPodatke()
        {
            tbIme.Text = korisnik.ime;
            tbPrezime.Text = korisnik.prezime;
            tbEmail.Text = korisnik.email;
            dtpDatRod.Value = korisnik.godina_rodenja;
            if (korisnik.uloga == 2)
            {
                tbVar.Text = korisnik.Mentor.ustanova;
            }
            else if (korisnik.uloga == 3)
            {
                tbVar.Text = korisnik.Specijalizant.godina_specijalizacije.ToString();
            }
            else
            {
                tbVar.Text = "Nepostojeći zapis!";
                tbVar.Enabled = false;
            }
        }

        private void PronadiKorisnika()
        {
            var sql = from k in model.Korisnik.Include("Mentor").Include("Specijalizant")
                      where k.id == CurrentUser.prijavljeniKorisnik.id
                      select k;

            korisnik = sql.Single();
        }
    }
}
