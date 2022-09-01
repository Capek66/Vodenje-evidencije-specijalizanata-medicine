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

namespace Vodenje_evidencije_specijalizanata_medicine.Administator
{
    public partial class TrenutniKor : UserControl
    {
        private AdministratorLogika administratorLogika;
        public TrenutniKor()
        {
            InitializeComponent();
            administratorLogika = new AdministratorLogika();
            UcitajSpecijalizante();
            UcitajMentore();
        }
        public void UcitajSpecijalizante()
        {
            BindingSource bindingSource = new BindingSource(administratorLogika.DohvatiSpecijalizante(), "");
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
        public void UcitajMentore()
        {
            BindingSource bindingSource = new BindingSource(administratorLogika.DohvatiMentore(), "");
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
