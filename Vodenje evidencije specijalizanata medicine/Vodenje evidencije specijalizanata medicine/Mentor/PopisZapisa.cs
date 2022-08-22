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
    public partial class PopisZapisa : Form
    {
        public PopisZapisa()
        {
            InitializeComponent();
            rbSvi.Checked = true;
            rbPotpisani.Checked = false;
            rbNepotp.Checked = false;
        }

        private void btnZatovi_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
