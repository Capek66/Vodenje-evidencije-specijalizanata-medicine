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
    public partial class RasporedObavljanjaAdd : Form
    {
        private KnjizicaModel model;
        public RasporedObavljanjaAdd()
        {
            InitializeComponent();
            model = new KnjizicaModel();
            DohvatiMentore();
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            if(tbUstanova.Text != "" || tbOdjel.Text != "" || tbGodOdm.Text != "" || tbPravFizOsoba.Text != "" || tbUstrojJed.Text != "")
            {
                RasporedPrograma noviRO = new RasporedPrograma()
                {
                    id = DohvatiID(),
                    naziv_ustanove = tbUstanova.Text,
                    naziv_odjela = tbOdjel.Text,
                    godisnji_odmor = int.Parse(tbGodOdm.Text),
                    trajanje_od = dtpOd.Value,
                    trajanje_do = dtpDo.Value,
                    pravna_fizicka_osoba = tbPravFizOsoba.Text,
                    ustrojstvena_jedinica = tbUstrojJed.Text,
                    mentor = (cbMentor.SelectedItem as Korisnik).id,
                    potpis_mentor = null,
                    potpis_gl_mentor = null,
                    specijalizacija = CurrentUser.odabranaSpecijalizacija.id
                };
                model.RasporedPrograma.Add(noviRO);
                model.SaveChanges();
                this.Close();
            }
        }

        private void DohvatiMentore()
        {
            var sql = from mentori in model.Korisnik
                      where mentori.uloga == 2
                      select mentori;

            cbMentor.DataSource = sql.ToList();
        }

        private int DohvatiID()
        {
            var sql = from raspored in model.RasporedPrograma
                      orderby raspored.id descending
                      select raspored.id;

            if(sql.ToList().Count != 0)
            {
                List<int> id = sql.ToList();

                return id[0] + 1;
            }
            else
            {
                return 1;
            }
        }
    }
}
