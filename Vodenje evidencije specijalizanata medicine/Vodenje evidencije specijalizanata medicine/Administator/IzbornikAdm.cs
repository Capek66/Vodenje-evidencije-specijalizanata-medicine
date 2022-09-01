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

namespace Vodenje_evidencije_specijalizanata_medicine.Administator
{
    public partial class IzbornikAdm : Form
    {
        private ZajednicaLogika zajednicaLogika;
        private DodajKorisnika dodajKorisnika;
        private TrenutniKor trenutniKor;
        private Profil profil;
        public IzbornikAdm()
        {
            InitializeComponent();
            zajednicaLogika = new ZajednicaLogika();
            dodajKorisnika = new DodajKorisnika();
            trenutniKor = new TrenutniKor();
            profil = new Profil();
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
            trenutniKor.UcitajSpecijalizante();
            trenutniKor.UcitajMentore();
        }

        private void lblProfil_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            panel.Controls.Add(profil);
            profil.UcitajPodatke(zajednicaLogika.DohvatiPodatkeProfil());
        }
    }
}
