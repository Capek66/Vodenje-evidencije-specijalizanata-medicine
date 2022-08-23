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
    public partial class PracenjeZahvata : UserControl
    {
        private KnjizicaModel model;
        private PracenjeZahvataAdd noviZahvat;
        private Specijalizant.PracZahDet zahvatDetalji;
        public PracenjeZahvata()
        {
            InitializeComponent();
            model = new KnjizicaModel();
            if(CurrentUser.odabranaSpecijalizacija != null)
            {
                UcitajZahvate();
            }
        }

        public void UcitajZahvate()
        {
            var sql = from zahv in model.Zahvati.Include("Korisnik")
                      where zahv.specijalizacija == CurrentUser.odabranaSpecijalizacija.id
                      orderby zahv.id descending
                      select zahv;

            BindingSource bindingSource = new BindingSource(sql.ToList(), "");
            dgvZahvati.DataSource = bindingSource;
            dgvZahvati.Columns[0].Visible = false;
            dgvZahvati.Columns[3].Visible = false;
            dgvZahvati.Columns[9].Visible = false;
            dgvZahvati.Columns[11].Visible = false;
            dgvZahvati.Columns[10].HeaderText = "mentor";
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
