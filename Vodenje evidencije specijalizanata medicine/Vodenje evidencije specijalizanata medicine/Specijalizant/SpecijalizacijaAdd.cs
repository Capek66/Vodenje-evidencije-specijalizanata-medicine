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
    public partial class SpecijalizacijaAdd : Form
    {
        private KnjizicaModel model;
        public SpecijalizacijaAdd()
        {
            InitializeComponent();
            model = new KnjizicaModel();
            UcitajMentore();
        }

        private void UcitajMentore()
        {
            var sql = from mentori in model.Korisnik
                      where mentori.uloga == 2
                      select mentori;

            BindingSource bindingSource = new BindingSource(sql.ToList(), "");
            cbGlMentor.DataSource = bindingSource;
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (tbSpecNaziv.Text != "" && tbOdobrenaZa.Text != "")
            {
                Specijalizacija novaSpecijalizacija = new Specijalizacija()
                {
                    id = DohvatiIDPoc(),
                    specijalizant = CurrentUser.prijavljeniKorisnik.id,
                    specijalizacija1 = tbSpecNaziv.Text,
                    odobrena_za = tbOdobrenaZa.Text,
                    klasa = null,
                    ubroj = null,
                    datum_rjesenja = null,
                    glavni_mentor = (cbGlMentor.SelectedItem as Korisnik).id,
                    datum_pocetka = dtpPocetak.Value,
                    potpis_gl_mentora = null
                };

                model.Specijalizacija.Add(novaSpecijalizacija);
                ZavrsetakSpecijalizacije zavrsetakSpecijalizacije = new ZavrsetakSpecijalizacije()
                {
                    id = DohvatiIDZav(),
                    specijalizacija = novaSpecijalizacija.id,
                    misljenje_gl_mentora = null,
                    datum_zavrsetka = null,
                    potpis_gl_mentor = null
                };
                model.ZavrsetakSpecijalizacije.Add(zavrsetakSpecijalizacije);
                model.SaveChanges();
                CurrentUser.OdaberiSpecijalizaciju(novaSpecijalizacija);
                this.Close();
            }
        }

        private int DohvatiIDPoc()
        {
            var sql = from specijalizacija in model.Specijalizacija
                      orderby specijalizacija.id descending
                      select specijalizacija.id;
            try
            {
                List<int> id = sql.ToList();

                return id[0] + 1;
            }catch (Exception e)
            {
                return 1;
            }
            
        }

        private int DohvatiIDZav()
        {
            var sql = from zavrsetakSpec in model.ZavrsetakSpecijalizacije
                      orderby zavrsetakSpec.id descending
                      select zavrsetakSpec.id;

            try
            {
                List<int> id = sql.ToList();

                return id[0] + 1;
            }
            catch (Exception e)
            {
                return 1;
            }
        }
    }
}
