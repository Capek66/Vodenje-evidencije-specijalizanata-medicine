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
    public partial class SpecOdabir : Form
    {
        private KnjizicaPocetnaSpec knjizicaPocetnaSpec;
        public SpecOdabir()
        {
            InitializeComponent();
            knjizicaPocetnaSpec = new KnjizicaPocetnaSpec();
        }

        private void btnKnjizica_Click(object sender, EventArgs e)
        {
            this.Hide();
            knjizicaPocetnaSpec.ShowDialog();
            this.Show();
        }

        private void btnOdjava_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
