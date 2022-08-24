﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vodenje_evidencije_specijalizanata_medicine.Data;

namespace Vodenje_evidencije_specijalizanata_medicine.Mentor
{
    public partial class IzbornikMentor : Form
    {
        private RasporedObavljanjaMentor rasporedObavljanja;
        private PracenjeNapMntr pracenjeNap;
        private PracenjeZahvataMntr pracenjeZahvata;
        private SpecijalizantiMntr pregledSpec;
        private Profil profil;
        private KnjizicaModel model;
        public IzbornikMentor()
        {
            InitializeComponent();
            model = new KnjizicaModel();
            rasporedObavljanja = new RasporedObavljanjaMentor();
            pracenjeNap = new PracenjeNapMntr();
            pracenjeZahvata = new PracenjeZahvataMntr();
            pregledSpec = new SpecijalizantiMntr();
            profil = new Profil();
        }

        private void Pocetna_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RasporedObavljanjaLbl_Click(object sender, EventArgs e)
        {
            knjizica.Controls.Clear();
            knjizica.Controls.Add(rasporedObavljanja);
            rasporedObavljanja.UcitajZapise();
        }

        private void PracenjeNapredovanjaLbl_Click(object sender, EventArgs e)
        {
            knjizica.Controls.Clear();
            knjizica.Controls.Add(pracenjeNap);
            pracenjeNap.UcitajZapise();
        }

        private void PracenjeObavljenihZahvataLbl_Click(object sender, EventArgs e)
        {
            knjizica.Controls.Clear();
            knjizica.Controls.Add(pracenjeZahvata);
        }

        private void SpecijalizantiLbl_Click(object sender, EventArgs e)
        {
            knjizica.Controls.Clear();
            knjizica.Controls.Add(pregledSpec);
        }

        private void Profil_Click(object sender, EventArgs e)
        {
            knjizica.Controls.Clear();
            knjizica.Controls.Add(profil);
        }
    }
}
