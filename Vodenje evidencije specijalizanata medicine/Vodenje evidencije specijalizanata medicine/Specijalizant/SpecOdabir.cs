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
    public partial class SpecOdabir : Form
    {
        private SpecijalizantLogika specijalizantLogika;
        private KnjizicaPocetnaSpec knjizicaPocetnaSpec;
        public SpecOdabir()
        {
            InitializeComponent();
            specijalizantLogika = new SpecijalizantLogika();
            UcitajSpecijalizacije();
        }

        private void btnKnjizica_Click(object sender, EventArgs e)
        {
            PostaviSpecijalizaciju();
            this.Hide();
            knjizicaPocetnaSpec = new KnjizicaPocetnaSpec();
            knjizicaPocetnaSpec.ShowDialog();
            this.Show();
        }

        private void btnOdjava_Click(object sender, EventArgs e)
        {
            Sloj_obrade.CurrentUser.OdjaviKorisnika();
            Sloj_obrade.CurrentUser.UkloniSpecifikaciju();
            this.Close();
        }

        private void UcitajSpecijalizacije()
        {
            BindingSource bindingSource = new BindingSource(specijalizantLogika.DohvatiSpec(), "");
            cbSpecijalizacije.DataSource = bindingSource;
        }

        private void PostaviSpecijalizaciju()
        {
            if(cbSpecijalizacije.SelectedItem != null)
            {
                Specijalizacija odabranaSpecijalizacija = cbSpecijalizacije.SelectedItem as Specijalizacija;
                Sloj_obrade.CurrentUser.OdaberiSpecijalizaciju(odabranaSpecijalizacija);
            }
            else
            {
                Sloj_obrade.CurrentUser.OdaberiSpecijalizaciju(null);
            }
        }
    }
}
