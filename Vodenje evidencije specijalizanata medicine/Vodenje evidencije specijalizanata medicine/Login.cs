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
using Sloj_obrade;

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
            lblPogresnaLoz.Visible = false;
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            ZajednicaLogika zajednicaLogika = new ZajednicaLogika();
            bool ispravno = zajednicaLogika.ProvjeriPodatke(tbEmail.Text, tbPass.Text);
            if (ispravno)
            {
                lblPogresnaLoz.Visible = false;
                if (Sloj_obrade.CurrentUser.DohvatiUlogu() == "Administrator")
                {
                    izbornikAdm = new IzbornikAdm();
                    this.Hide();
                    izbornikAdm.ShowDialog();
                    this.Show();
                }else if(Sloj_obrade.CurrentUser.DohvatiUlogu() == "Mentor")
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
    }
}
