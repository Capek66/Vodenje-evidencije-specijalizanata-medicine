using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sloj_podataka;
using Sloj_obrade;

namespace Vodenje_evidencije_specijalizanata_medicine
{
    public partial class RasporedObavljanja : UserControl
    {
        private SpecijalizantLogika specijalizantLogika;
        private RasporedObavljanjaAdd noviRaspOb;
        private Specijalizant.RaspObjDet raspObj;
        public RasporedObavljanja()
        {
            InitializeComponent();
            specijalizantLogika = new SpecijalizantLogika();
            if(Sloj_obrade.CurrentUser.ProvjeriSpecijalizaciju())
            {
                UcitajZapise();
            }
        }

        public void UcitajZapise()
        {
            BindingSource bindingSource = new BindingSource(specijalizantLogika.RaspObZapisi(), "");
            dgvRaspored.DataSource = bindingSource;
            dgvRaspored.Columns[0].Visible = false;
            dgvRaspored.Columns[8].Visible = false;
            dgvRaspored.Columns[11].Visible = false;
            dgvRaspored.Columns[13].Visible = false;
            dgvRaspored.Columns[12].HeaderText = "mentor";

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
            noviRaspOb = new RasporedObavljanjaAdd();
            noviRaspOb.ShowDialog();
            UcitajZapise();
        }

        private void btnDetalji_Click(object sender, EventArgs e)
        {
            RasporedPrograma odabraniRaspored = dgvRaspored.CurrentRow.DataBoundItem as RasporedPrograma;
            raspObj = new Specijalizant.RaspObjDet(odabraniRaspored);
            raspObj.ShowDialog();
        }
    }
}
