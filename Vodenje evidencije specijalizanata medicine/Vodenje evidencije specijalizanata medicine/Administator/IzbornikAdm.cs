using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vodenje_evidencije_specijalizanata_medicine.Administator
{
    public partial class IzbornikAdm : Form
    {
        private DodajKorisnika dodajKorisnika;
        private TrenutniKor trenutniKor;
        public IzbornikAdm()
        {
            InitializeComponent();
            dodajKorisnika = new DodajKorisnika();
            trenutniKor = new TrenutniKor();
        }

        private void lblOdjava_Click(object sender, EventArgs e)
        {
            CurrentUser.OdjaviKorisnika();
            this.Close();
        }

        private void lblNovi_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            panel.Controls.Add(dodajKorisnika);
        }

        private void lblTrenutni_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            panel.Controls.Add(trenutniKor);
        }
    }
}
