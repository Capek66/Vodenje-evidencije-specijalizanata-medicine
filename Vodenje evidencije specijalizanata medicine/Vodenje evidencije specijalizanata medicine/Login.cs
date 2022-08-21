﻿using System;
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
    public partial class Login : Form
    {
        private SpecOdabir pocetnaSpec;
        public Login()
        {
            InitializeComponent();
            pocetnaSpec = new SpecOdabir();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            this.Hide();
            pocetnaSpec.ShowDialog();
            this.Show();
        }
    }
}
