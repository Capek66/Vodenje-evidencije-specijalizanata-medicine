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

namespace Vodenje_evidencije_specijalizanata_medicine.Administator
{
    public partial class TrenutniKor : UserControl
    {
        private KnjizicaModel model;
        public TrenutniKor()
        {
            InitializeComponent();
            model = new KnjizicaModel();
            UcitajSpecijalizante();
            UcitajMentore();
        }

        private void UcitajSpecijalizante()
        {
            var sql = from specijalizanti in model.Korisnik
                      where specijalizanti.uloga == 3
                      select specijalizanti;

            BindingSource bindingSource = new BindingSource(sql.ToList(), "");
            dgvSpecijalizanti.DataSource = bindingSource;
            dgvSpecijalizanti.Columns[0].Visible = false;
            dgvSpecijalizanti.Columns[5].Visible = false;
            dgvSpecijalizanti.Columns[6].Visible = false;
            dgvSpecijalizanti.Columns[7].Visible = false;
            dgvSpecijalizanti.Columns[8].Visible = false;
            dgvSpecijalizanti.Columns[9].Visible = false;
            dgvSpecijalizanti.Columns[10].Visible = false;
            dgvSpecijalizanti.Columns[11].Visible = false;
            dgvSpecijalizanti.Columns[12].Visible = false;
            dgvSpecijalizanti.Columns[13].Visible = false;
            dgvSpecijalizanti.Columns[14].Visible = false;
        }

        private void UcitajMentore()
        {
            var sql = from mentori in model.Korisnik
                      where mentori.uloga == 2
                      select mentori;

            BindingSource bindingSource = new BindingSource(sql.ToList(), "");
            dgvMentori.DataSource = bindingSource;
            dgvMentori.Columns[0].Visible = false;
            dgvMentori.Columns[5].Visible = false;
            dgvMentori.Columns[6].Visible = false;
            dgvMentori.Columns[7].Visible = false;
            dgvMentori.Columns[8].Visible = false;
            dgvMentori.Columns[9].Visible = false;
            dgvMentori.Columns[10].Visible = false;
            dgvMentori.Columns[11].Visible = false;
            dgvMentori.Columns[12].Visible = false;
            dgvMentori.Columns[13].Visible = false;
            dgvMentori.Columns[14].Visible = false;
        }
    }
}
