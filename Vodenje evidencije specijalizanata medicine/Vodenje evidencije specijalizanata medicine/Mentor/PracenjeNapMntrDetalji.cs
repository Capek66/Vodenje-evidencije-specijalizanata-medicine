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
    public partial class PracenjeNapMntrDetalji : Form
    {
        public PracenjeNapMntrDetalji()
        {
            InitializeComponent();
            cbStupanj.Items.Add("1");
            cbStupanj.Items.Add("2");
            cbStupanj.Items.Add("3");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
