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
using Sloj_podataka;

namespace Vodenje_evidencije_specijalizanata_medicine
{
    public partial class PracenjeZahvataAdd : Form
    {
        private SpecijalizantLogika specijalizantLogika;
        public PracenjeZahvataAdd()
        {
            InitializeComponent();
            specijalizantLogika = new SpecijalizantLogika();
            DohvatiMentore();
        }
        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if(tbZahvat.Text != "" && tbBroj.Text != "")
            {
                Zahvati noviZahvat = new Zahvati()
                {
                    id = 0,
                    naziv_zahvata = tbZahvat.Text,
                    broj_zahvata = int.Parse(tbBroj.Text),
                    mentor = (cbMentor.SelectedItem as Korisnik).id,
                    datum_mentor = null,
                    potpis_mentor = null,
                    stupanj_napredovanja = null,
                    datum_gl_mentor = null,
                    potpis_gl_mentor = null,
                    specijalizacija = Sloj_obrade.CurrentUser.odabranaSpecijalizacija.id
                };
                specijalizantLogika.PracZahNovi(noviZahvat);
                this.Close();
            }
        }
        private void DohvatiMentore()
        {
            cbMentor.DataSource = specijalizantLogika.DohvatiMentore();
        }
    }
}
