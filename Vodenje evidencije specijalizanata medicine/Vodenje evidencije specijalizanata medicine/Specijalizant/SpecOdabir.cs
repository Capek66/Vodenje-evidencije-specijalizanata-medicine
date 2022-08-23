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
    public partial class SpecOdabir : Form
    {
        private KnjizicaPocetnaSpec knjizicaPocetnaSpec;
        private KnjizicaModel model;
        public SpecOdabir()
        {
            InitializeComponent();
            knjizicaPocetnaSpec = new KnjizicaPocetnaSpec();
            model = new KnjizicaModel();
            UcitajSpecijalizacije();
        }

        private void btnKnjizica_Click(object sender, EventArgs e)
        {
            PostaviSpecijalizaciju();
            this.Hide();
            knjizicaPocetnaSpec.ShowDialog();
            this.Show();
        }

        private void btnOdjava_Click(object sender, EventArgs e)
        {
            CurrentUser.OdjaviKorisnika();
            CurrentUser.UkloniSpecifikaciju();
            this.Close();
        }

        private void UcitajSpecijalizacije()
        {
            var sql = from specijalizacije in model.Specijalizacija
                      where specijalizacije.specijalizant == CurrentUser.prijavljeniKorisnik.id
                      orderby specijalizacije.id descending
                      select specijalizacije;

            cbSpecijalizacije.DataSource = sql.ToList();
        }

        private void PostaviSpecijalizaciju()
        {
            if(cbSpecijalizacije.SelectedItem != null)
            {
                Specijalizacija odabranaSpecijalizacija = cbSpecijalizacije.SelectedItem as Specijalizacija;
                CurrentUser.OdaberiSpecijalizaciju(odabranaSpecijalizacija);
            }
            else
            {
                CurrentUser.OdaberiSpecijalizaciju(null);
            }
            
        }
    }
}
