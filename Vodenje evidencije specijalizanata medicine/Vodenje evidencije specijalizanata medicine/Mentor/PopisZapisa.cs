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

namespace Vodenje_evidencije_specijalizanata_medicine.Mentor
{
    public partial class PopisZapisa : Form
    {
        private MentorLogika mentorLogika;
        private int tipZapisa;
        private int odabraniKorisnik;
        private int odabranaSpec;
        public PopisZapisa(int vrstaZapisa, int korisnikID, int specijalizacijaID)
        {
            InitializeComponent();
            mentorLogika = new MentorLogika();
            tipZapisa = vrstaZapisa;
            odabraniKorisnik = korisnikID;
            odabranaSpec = specijalizacijaID;
            UcitajZapise();
        }
        private void btnZatovi_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void UcitajZapise()
        {
            if(tipZapisa == 1)
            {
                BindingSource bindingSource = new BindingSource(mentorLogika.RaspObSviZap(odabraniKorisnik, odabranaSpec), "");
                dgvZapisi.DataSource = bindingSource;
                dgvZapisi.Columns[0].Visible = false;
            }
            else if(tipZapisa == 2)
            {
                BindingSource bindingSource = new BindingSource(mentorLogika.PracNapSviZapisi(odabraniKorisnik, odabranaSpec), "");
                dgvZapisi.DataSource = bindingSource;
                dgvZapisi.Columns[0].Visible = false;
            }
            else
            {
                BindingSource bindingSource = new BindingSource(mentorLogika.PracZahSviZapisi(odabraniKorisnik, odabranaSpec), "");
                dgvZapisi.DataSource = bindingSource;
                dgvZapisi.Columns[0].Visible = false;
            }
        }
        private void btnDetalji_Click(object sender, EventArgs e)
        {
            if(tipZapisa == 1)
            {
                RasporedPrograma odabraniZapis = (dgvZapisi.CurrentRow.DataBoundItem as RaspObavPrikaz).Program;
                RasporedObMntDetails detalji = new RasporedObMntDetails(odabraniZapis);
                detalji.ShowDialog();
                UcitajZapise();
            }else if(tipZapisa == 2)
            {
                Kompetencije odabraniZapis = (dgvZapisi.CurrentRow.DataBoundItem as KompPrikaz).Kompetencije;
                PracenjeNapMntrDetalji detalji = new PracenjeNapMntrDetalji(odabraniZapis);
                detalji.ShowDialog();
                UcitajZapise();
            }
            else
            {
                Zahvati odabraniZapis = (dgvZapisi.CurrentRow.DataBoundItem as ZahvatiPrikaz).Zahvati;
                PracenjeZahvataMntrDetalji detalji = new PracenjeZahvataMntrDetalji(odabraniZapis);
                detalji.ShowDialog();
                UcitajZapise();
            }
        }
    }
}
