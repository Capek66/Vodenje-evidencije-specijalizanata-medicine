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
    public partial class PracenjeZahvataMntr : UserControl
    {
        private PracenjeZahvataMntrDetalji pracenjeZahvata;
        private StupanjNapredovanja stupanjNapredovanja;
        public PracenjeZahvataMntr()
        {
            InitializeComponent();
        }

        private void btnDetalji_Click(object sender, EventArgs e)
        {
            pracenjeZahvata = new PracenjeZahvataMntrDetalji();
            pracenjeZahvata.ShowDialog();
        }

        private void btnPotpisi_Click(object sender, EventArgs e)
        {
            stupanjNapredovanja = new StupanjNapredovanja();
            stupanjNapredovanja.ShowDialog();
        }
    }
}
