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
using Sloj_obrade;

namespace Vodenje_evidencije_specijalizanata_medicine
{
    public partial class PasswordUpdate : Form
    {
        ZajednicaLogika zajednicaLogika;
        public PasswordUpdate()
        {
            InitializeComponent();
            zajednicaLogika = new ZajednicaLogika();
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
                zajednicaLogika.AzurirajLozinku(tbLozinka.Text);
                lblError.Visible = false;
                this.Close();
            }
            else
            {
                lblError.Visible = true;
            }
        }
    }
}
