using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vodenje_evidencije_specijalizanata_medicine.Mentor
{
    public partial class PracenjeNapMntr : UserControl
    {
        private PracenjeNapMntrDetalji pracenjeNap;
        private StupanjNapredovanja stupanjNapredovanja;
        public PracenjeNapMntr()
        {
            InitializeComponent();
        }

        private void btnDetalji_Click(object sender, EventArgs e)
        {
            pracenjeNap = new PracenjeNapMntrDetalji();
            pracenjeNap.ShowDialog();
        }

        private void btnPotpisi_Click(object sender, EventArgs e)
        {
            stupanjNapredovanja = new StupanjNapredovanja();
            stupanjNapredovanja.ShowDialog();
        }
    }
}
