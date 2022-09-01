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
    public partial class SpecUsavrsavanja : UserControl
    {
        private SpecijalizantLogika specijalizantLogika;
        private SpecijalizacijaAdd specijalizacijaAdd;
        private Specijalizant.SpecDet specijalizacijaDetalji;
        public SpecUsavrsavanja()
        {
            InitializeComponent();
            specijalizantLogika = new SpecijalizantLogika();
            UcitajSpecijalizacije();
        }

        public void UcitajSpecijalizacije()
        {
            BindingSource bindingSource = new BindingSource(specijalizantLogika.SpecZapisi(), "");
            dgvSpecijalizacije.DataSource = bindingSource;
            dgvSpecijalizacije.Columns[0].Visible = false;

            if (bindingSource.Count == 0)
            {
                btnDetalji.Enabled = false;
                btnOdaberiSpec.Enabled = false;
            }
            else
            {
                btnDetalji.Enabled = true;
                btnOdaberiSpec.Enabled = true;
            }
        }

        private void btnOdaberiSpec_Click(object sender, EventArgs e)
        {
            Sloj_obrade.SpecijalizacijePrikaz odabranaSpec = dgvSpecijalizacije.CurrentRow.DataBoundItem as Sloj_obrade.SpecijalizacijePrikaz;
            Sloj_obrade.CurrentUser.OdaberiSpecijalizaciju(odabranaSpec.specijalizacija);
        }

        private void btnDetalji_Click(object sender, EventArgs e)
        {
            Sloj_obrade.SpecijalizacijePrikaz odabranaSpec = dgvSpecijalizacije.CurrentRow.DataBoundItem as Sloj_obrade.SpecijalizacijePrikaz;
            specijalizacijaDetalji = new Specijalizant.SpecDet(odabranaSpec);
            specijalizacijaDetalji.ShowDialog();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            specijalizacijaAdd = new SpecijalizacijaAdd();
            specijalizacijaAdd.ShowDialog();
            UcitajSpecijalizacije();
        }
    }
}
