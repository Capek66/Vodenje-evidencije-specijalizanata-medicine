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
    public partial class PracenjeNapredovanja : UserControl
    {
        private SpecijalizantLogika specijalizantLogika;
        private PracenjeNapredovanjaAdd napredAdd;
        private Specijalizant.PracNapDet napredovanjaDetalji;
        public PracenjeNapredovanja()
        {
            InitializeComponent();
            specijalizantLogika = new SpecijalizantLogika();
            if (Sloj_obrade.CurrentUser.odabranaSpecijalizacija != null)
            {
                UcitajKompetencije();
            }
        }

        public void UcitajKompetencije()
        {
            BindingSource bindingSource = new BindingSource(specijalizantLogika.PracNapZapisi(), "");
            dgvKompetencije.DataSource = bindingSource;
            dgvKompetencije.Columns[0].Visible = false;
            dgvKompetencije.Columns[2].Visible = false;
            dgvKompetencije.Columns[8].Visible = false;
            dgvKompetencije.Columns[10].Visible = false;
            dgvKompetencije.Columns[1].HeaderText = "kompetencije";
            dgvKompetencije.Columns[9].HeaderText = "mentor";

            if(bindingSource.Count == 0)
            {
                btnDetalji.Enabled = false;
            }
            else
            {
                btnDetalji.Enabled = true;
            }
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            napredAdd = new PracenjeNapredovanjaAdd();
            napredAdd.ShowDialog();
            UcitajKompetencije();
        }

        private void btnDetalji_Click(object sender, EventArgs e)
        {
            Kompetencije odabranaKomp = dgvKompetencije.CurrentRow.DataBoundItem as Kompetencije;
            napredovanjaDetalji = new Specijalizant.PracNapDet(odabranaKomp);
            napredovanjaDetalji.ShowDialog();
        }
    }
}
