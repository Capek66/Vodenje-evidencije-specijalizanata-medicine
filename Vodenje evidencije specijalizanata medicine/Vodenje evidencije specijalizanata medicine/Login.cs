using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vodenje_evidencije_specijalizanata_medicine.Mentor;
using Vodenje_evidencije_specijalizanata_medicine.Administator;
using Vodenje_evidencije_specijalizanata_medicine.Data;
using System.Security.Cryptography;

namespace Vodenje_evidencije_specijalizanata_medicine
{
    public partial class Login : Form
    {
        private SpecOdabir pocetnaSpec;
        private PocetnaMentori pocetnaMentori;
        private IzbornikAdm izbornikAdm;
        public Login()
        {
            InitializeComponent();
            tbEmail.Text = "pperic@gmail.com";
            tbPass.Text = "peric";
            lblPogresnaLoz.Visible = false;
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            bool ispravno = ProvijeriPodatke();
            if (ispravno)
            {
                lblPogresnaLoz.Visible = false;
                if (CurrentUser.prijavljeniKorisnik.Uloga1.uloga1 == "Administrator")
                {
                    izbornikAdm = new IzbornikAdm();
                    this.Hide();
                    izbornikAdm.ShowDialog();
                    this.Show();
                }else if(CurrentUser.prijavljeniKorisnik.Uloga1.uloga1 == "Mentor")
                {
                    pocetnaMentori = new PocetnaMentori();
                    this.Hide();
                    pocetnaMentori.ShowDialog();
                    this.Show();
                }
                else
                {
                    pocetnaSpec = new SpecOdabir();
                    this.Hide();
                    pocetnaSpec.ShowDialog();
                    this.Show();
                }
                tbEmail.Text = "";
                tbPass.Text = "";
            }
            else
            {
                lblPogresnaLoz.Visible = true;
            }
        }

        private bool ProvijeriPodatke()
        {
            string email = tbEmail.Text;
            string lozinka = tbPass.Text;
            KnjizicaModel model = new KnjizicaModel();

            var sql = from korisnik in model.Korisnik
                      where korisnik.email == email
                      select korisnik;

            Korisnik pronadeniKorisnik;
            try
            {
                pronadeniKorisnik = sql.Single();
            }
            catch(Exception e)
            {
                return false;
            }

            string salt = pronadeniKorisnik.prezime + pronadeniKorisnik.ime + ":" + lozinka;
            string hash = GetHash(salt);
            
            if (hash.Equals(pronadeniKorisnik.lozinka))
            {
                CurrentUser.PrijaviKorisnika(pronadeniKorisnik);
                return true;
            }
            else
            {
                return false;
            }
        }

        private string GetHash(string salt)
        {
            using (var sha256 = new SHA256Managed())
            {
                return BitConverter.ToString(sha256.ComputeHash(Encoding.UTF8.GetBytes(salt))).Replace("-", "").ToLower();
            }
        }
    }
}
