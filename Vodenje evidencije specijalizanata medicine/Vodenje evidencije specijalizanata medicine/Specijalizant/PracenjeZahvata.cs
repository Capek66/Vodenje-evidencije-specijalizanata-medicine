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
    public partial class PracenjeZahvata : UserControl
    {
        private SpecijalizantLogika specijalizantLogika;
        private PracenjeZahvataAdd noviZahvat;
        private Specijalizant.PracZahDet zahvatDetalji;
        public PracenjeZahvata()
        {
            InitializeComponent();
            specijalizantLogika = new SpecijalizantLogika();
            if(Sloj_obrade.CurrentUser.odabranaSpecijalizacija != null)
            {
                UcitajZahvate();
            }
        }

        public void UcitajZahvate()
        {
            BindingSource bindingSource = new BindingSource(specijalizantLogika.PracZahZapisi(), "");
            dgvZahvati.DataSource = bindingSource;
            dgvZahvati.Columns[0].Visible = false;
            dgvZahvati.Columns[3].Visible = false;
            dgvZahvati.Columns[9].Visible = false;
            dgvZahvati.Columns[11].Visible = false;
            dgvZahvati.Columns[10].HeaderText = "mentor";

            if (bindingSource.Count == 0)
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
            noviZahvat = new PracenjeZahvataAdd();
            noviZahvat.ShowDialog();
            UcitajZahvate();
        }

        private void btnDetalji_Click(object sender, EventArgs e)
        {
            Zahvati odabraniZahvat = dgvZahvati.CurrentRow.DataBoundItem as Zahvati;
            zahvatDetalji = new Specijalizant.PracZahDet(odabraniZahvat);
            zahvatDetalji.ShowDialog();
        }
    }
}
