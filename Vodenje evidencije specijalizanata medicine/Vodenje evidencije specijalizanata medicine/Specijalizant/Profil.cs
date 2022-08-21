using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vodenje_evidencije_specijalizanata_medicine
{
    public partial class Profil : UserControl
    {
        private PasswordUpdate passwordUpdate;
        private ProfilUpdate profilUpdate;
        public Profil()
        {
            InitializeComponent();
            passwordUpdate = new PasswordUpdate();
            profilUpdate = new ProfilUpdate();
        }

        private void btnPass_Click(object sender, EventArgs e)
        {
            passwordUpdate.ShowDialog();
        }

        private void btnAzuriraj_Click(object sender, EventArgs e)
        {
            profilUpdate.ShowDialog();
        }
    }
}
