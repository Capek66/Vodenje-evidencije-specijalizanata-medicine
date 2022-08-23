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
    public partial class RasporedObavljanja : UserControl
    {
        private KnjizicaModel model;
        private RasporedObavljanjaAdd noviRaspOb;
        private Specijalizant.RaspObjDet raspObj;
        public RasporedObavljanja()
        {
            InitializeComponent();
            model = new KnjizicaModel();
            if(CurrentUser.odabranaSpecijalizacija != null)
            {
                UcitajZapise();
            }
        }

        public void UcitajZapise()
        {
            var sql = from raspored in model.RasporedPrograma.Include("Korisnik")
                      where raspored.specijalizacija == CurrentUser.odabranaSpecijalizacija.id
                      orderby raspored.id descending
                      select raspored;

            BindingSource bindingSource = new BindingSource(sql.ToList(), "");
            dgvRaspored.DataSource = bindingSource;

            dgvRaspored.Columns[0].Visible = false;
            dgvRaspored.Columns[8].Visible = false;
            dgvRaspored.Columns[11].Visible = false;
            dgvRaspored.Columns[13].Visible = false;
            dgvRaspored.Columns[12].HeaderText = "mentor";
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
