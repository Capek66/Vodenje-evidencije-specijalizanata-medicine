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
    public partial class SpecUsavrsavanja : UserControl
    {
        private SpecijalizacijaAdd specijalizacijaAdd;
        private KnjizicaModel model;
        private Specijalizant.SpecDet specijalizacijaDetalji;
        public SpecUsavrsavanja()
        {
            InitializeComponent();
            model = new KnjizicaModel();
            UcitajSpecijalizacije();
        }

        private void UcitajSpecijalizacije()
        {
            var sql = from specijalizacije in model.Specijalizacija.Include("Korisnik1")
                        where specijalizacije.specijalizant == CurrentUser.prijavljeniKorisnik.id
                        orderby specijalizacije.id descending
                        select new Vodenje_evidencije_specijalizanata_medicine.Specijalizant.SpecijalizacijePrikaz
                        {
                            specijalizacija = specijalizacije,
                            naslov_specijalizacije = specijalizacije.specijalizacija1,
                            odobrena_za = specijalizacije.odobrena_za,
                            klasa = specijalizacije.klasa,
                            ubroj = specijalizacije.ubroj,
                            datum_rjesenja = specijalizacije.datum_rjesenja,
                            glavni_mentor = specijalizacije.Korisnik1.ime + " " + specijalizacije.Korisnik1.prezime,
                            datum_pocetka = specijalizacije.datum_pocetka,
                            potpis_gl_mentora = specijalizacije.potpis_gl_mentora
                        };

            BindingSource bindingSource = new BindingSource(sql.ToList(), "");
            dgvSpecijalizacije.DataSource = bindingSource;
            dgvSpecijalizacije.Columns[0].Visible = false;
        }

        private void btnOdaberiSpec_Click(object sender, EventArgs e)
        {
            Specijalizant.SpecijalizacijePrikaz odabranaSpec = dgvSpecijalizacije.CurrentRow.DataBoundItem as Specijalizant.SpecijalizacijePrikaz;
            CurrentUser.OdaberiSpecijalizaciju(odabranaSpec.specijalizacija);
        }

        private void btnDetalji_Click(object sender, EventArgs e)
        {
            Specijalizant.SpecijalizacijePrikaz odabranaSpec = dgvSpecijalizacije.CurrentRow.DataBoundItem as Specijalizant.SpecijalizacijePrikaz;
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
