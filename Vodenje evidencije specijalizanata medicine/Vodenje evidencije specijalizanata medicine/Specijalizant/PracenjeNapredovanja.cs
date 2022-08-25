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
    public partial class PracenjeNapredovanja : UserControl
    {
        private KnjizicaModel model;
        private PracenjeNapredovanjaAdd napredAdd;
        private Specijalizant.PracNapDet napredovanjaDetalji;
        public PracenjeNapredovanja()
        {
            InitializeComponent();
            model = new KnjizicaModel();
            if (CurrentUser.odabranaSpecijalizacija != null)
            {
                UcitajKompetencije();
            }
        }

        public void UcitajKompetencije()
        {
            var sql = from komp in model.Kompetencije.Include("Korisnik")
                      where komp.specijalizacija == CurrentUser.odabranaSpecijalizacija.id
                      orderby komp.id descending
                      select komp;

            BindingSource bindingSource = new BindingSource(sql.ToList(), "");
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
