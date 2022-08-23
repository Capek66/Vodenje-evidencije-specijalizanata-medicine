using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vodenje_evidencije_specijalizanata_medicine.Data;

namespace Vodenje_evidencije_specijalizanata_medicine
{
    public partial class PracenjeZahvataAdd : Form
    {
        private KnjizicaModel model;
        public PracenjeZahvataAdd()
        {
            InitializeComponent();
            model = new KnjizicaModel();
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
                    id = DohvatiID(),
                    naziv_zahvata = tbZahvat.Text,
                    broj_zahvata = int.Parse(tbBroj.Text),
                    mentor = (cbMentor.SelectedItem as Korisnik).id,
                    datum_mentor = null,
                    potpis_mentor = null,
                    stupanj_napredovanja = null,
                    datum_gl_mentor = null,
                    potpis_gl_mentor = null,
                    specijalizacija = CurrentUser.odabranaSpecijalizacija.id
                };

                model.Zahvati.Add(noviZahvat);
                model.SaveChanges();
                this.Close();
            }
        }

        private int DohvatiID()
        {
            var sql = from zahvat in model.Zahvati
                      orderby zahvat.id descending
                      select zahvat.id;

            if (sql.ToList().Count != 0)
            {
                List<int> id = sql.ToList();

                return id[0] + 1;
            }
            else
            {
                return 1;
            }
        }

        private void DohvatiMentore()
        {
            var sql = from mentori in model.Korisnik
                      where mentori.uloga == 2
                      select mentori;

            cbMentor.DataSource = sql.ToList();
        }
    }
}
