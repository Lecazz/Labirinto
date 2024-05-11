using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labirinto
{
    public partial class frmSalaDois : Form
    {
        public frmSalaDois()
        {
            InitializeComponent();
        }

        private void btnEsquerda_Click(object sender, EventArgs e)
        {
            frmPortal frmPortal = new frmPortal();
            this.Hide();
            frmPortal.Closed += (object s, EventArgs ev) => this.Show();

            frmPortal.ShowDialog();
        }

        private void btnDireita_Click(object sender, EventArgs e)
        {
            frmSalaSeis frmSalaSeis = new frmSalaSeis();
            this.Hide();
            frmSalaSeis.Closed += (object s, EventArgs ev) => this.Show();

            frmSalaSeis.ShowDialog();
        }

        private void btnBaixo_Click(object sender, EventArgs e)
        {
            frmSalaSete frmSalaSete = new frmSalaSete();
            this.Hide();
            frmSalaSete.Closed += (object s, EventArgs ev) => this.Show();

            frmSalaSete.ShowDialog();
        }

        private void btnCima_Click(object sender, EventArgs e)
        {
            frmSalaCinco frmSalaCinco = new frmSalaCinco();
            this.Hide();
            frmSalaCinco.Closed += (object s, EventArgs ev) => this.Show();

            frmSalaCinco.ShowDialog();
        }
    }
}
