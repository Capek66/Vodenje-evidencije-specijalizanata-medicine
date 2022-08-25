using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vodenje_evidencije_specijalizanata_medicine.Data;

namespace Vodenje_evidencije_specijalizanata_medicine
{
    public partial class PasswordUpdate : Form
    {
        private KnjizicaModel model;
        private Korisnik korisnik;
        public PasswordUpdate()
        {
            InitializeComponent();
            model = new KnjizicaModel();
            PronadiKorisnika();
            lblError.Visible = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(tbLozinka.Text == tbPonovljenaLoz.Text)
            {
                lblError.Visible = false;
                string novaLozinka = tbLozinka.Text;
                string salt = korisnik.prezime + korisnik.ime + ":" + novaLozinka;
                korisnik.lozinka = GetHash(salt);
                model.SaveChanges();
                this.Close();
            }
            else
            {
                lblError.Visible = true;
            }
        }

        private void PronadiKorisnika()
        {
            var sql = from k in model.Korisnik
                      where k.id == CurrentUser.prijavljeniKorisnik.id
                      select k;

            korisnik = sql.Single();
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
