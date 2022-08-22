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
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            pocetnaSpec = new SpecOdabir();
            this.Hide();
            pocetnaSpec.ShowDialog();
            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pocetnaMentori = new PocetnaMentori();
            this.Hide();
            pocetnaMentori.ShowDialog();
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            izbornikAdm = new IzbornikAdm();
            this.Hide();
            izbornikAdm.ShowDialog();
            this.Show();
        }
    }
}
