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
using System.Security.Cryptography;

namespace Vodenje_evidencije_specijalizanata_medicine.Administator
{
    public partial class DodajKorisnika : UserControl
    {
        private KnjizicaModel model;
        public DodajKorisnika()
        {
            InitializeComponent();
            model = new KnjizicaModel();
            rbSpecijalizant.Checked = true;
            lblError.Visible = false;
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (rbSpecijalizant.Checked)
            {
                if (ProvijeriFormu("Spec"))
                {
                    lblError.Visible = false;
                    DodajSpecijalizanta();
                }
                else
                {
                    lblError.Visible = true;
                }
            }
            else
            {
                if(ProvijeriFormu("Ment"))
                {
                    lblError.Visible = false;
                    DodajMentora();
                }
                else
                {
                    lblError.Visible = true;
                }
            }
            OsvjeziFormu();
        }

        private void DodajSpecijalizanta()
        {
            model.Korisnik.Add(new Korisnik()
            {
                id = DohvatiID(),
                ime = tbIme.Text,
                prezime = tbPrezime.Text,
                godina_rodenja = dtpGodRod.Value,
                email = tbEmail.Text,
                lozinka = GetHash(tbPrezime.Text + tbIme.Text + ":" + tbPrezime.Text.ToLower()),
                uloga = 3
            });
            model.SaveChanges();

            var sql = from korisnik in model.Korisnik
                      where korisnik.email == tbEmail.Text
                      select korisnik.id;

            int noviSpec_id = sql.Single();

            model.Specijalizant.Add(new Vodenje_evidencije_specijalizanata_medicine.Data.Specijalizant()
            {
                korisnik = noviSpec_id,
                godina_specijalizacije = 1
            });
            model.SaveChanges();
        }

        private void DodajMentora()
        {
            model.Korisnik.Add(new Korisnik()
            {
                id = DohvatiID(),
                ime = tbIme.Text,
                prezime = tbPrezime.Text,
                godina_rodenja = dtpGodRod.Value,
                email = tbEmail.Text,
                lozinka = GetHash(tbPrezime.Text + tbIme.Text + ":" + tbPrezime.Text.ToLower()),
                uloga = 2
            });
            model.SaveChanges();

            var sql = from korisnik in model.Korisnik
                      where korisnik.email == tbEmail.Text
                      select korisnik.id;

            int noviMentor_id = sql.Single();

            model.Mentor.Add(new Data.Mentor
            {
                korisnik = noviMentor_id,
                ustanova = tbUstanova.Text
            });
            model.SaveChanges();
        }

        private string GetHash(string salt)
        {
            using (var sha256 = new SHA256Managed())
            {
                return BitConverter.ToString(sha256.ComputeHash(Encoding.UTF8.GetBytes(salt))).Replace("-", "").ToLower();
            }
        }

        private int DohvatiID()
        {
            var sql = from korisnik in model.Korisnik
                      orderby korisnik.id descending
                      select korisnik.id;

            List<int> id = sql.ToList();

            return id[0] + 1;
        }

        private void OsvjeziFormu()
        {
            tbIme.Text = "";
            tbPrezime.Text = "";
            tbEmail.Text = "";
            tbUstanova.Text = "";
            rbSpecijalizant.Checked = true;
            rbMentor.Checked = false;
        }

        private bool ProvijeriFormu(string uloga)
        {
            if(tbIme.Text == "" || tbPrezime.Text == "" || tbEmail.Text == "")
            {
                return false;
            }
            else
            {
                if(uloga == "Ment")
                {
                    if(tbUstanova.Text == "")
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
                else
                {
                    return true;
                }
            }
            
        }
    }
}
