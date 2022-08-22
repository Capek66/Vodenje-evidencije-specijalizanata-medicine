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
    public partial class PocetnaMentori : Form
    {
        private IzbornikMentor izbornikMentor;
        public PocetnaMentori()
        {
            InitializeComponent();
        }

        private void btnKnjizica_Click(object sender, EventArgs e)
        {
            izbornikMentor = new IzbornikMentor();
            this.Hide();
            izbornikMentor.ShowDialog();
            this.Show();
        }

        private void btnOdjava_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
