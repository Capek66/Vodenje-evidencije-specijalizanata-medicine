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
using System.Security.Cryptography;

namespace Vodenje_evidencije_specijalizanata_medicine.Administator
{
    public partial class DodajKorisnika : UserControl
    {
        private AdministratorLogika administratorLogika;
        public DodajKorisnika()
        {
            InitializeComponent();
            administratorLogika = new AdministratorLogika();
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
            administratorLogika.DodajKorisnika(3, tbIme.Text, tbPrezime.Text, tbEmail.Text, dtpGodRod.Value, null);
        }
        private void DodajMentora()
        {
            administratorLogika.DodajKorisnika(2, tbIme.Text, tbPrezime.Text, tbEmail.Text, dtpGodRod.Value, tbUstanova.Text);
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
