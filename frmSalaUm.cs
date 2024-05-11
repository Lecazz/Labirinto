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
    public partial class frmSalaUm : Form
    {
        public frmSalaUm()
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

        private void btnCima_Click(object sender, EventArgs e)
        {
            frmSalaTres frmSalaTres = new frmSalaTres();

            this.Hide();

            frmSalaTres.Closed += (object s, EventArgs ev) => this.Show();

            frmSalaTres.ShowDialog();
        }

        private void btnDireito_Click(object sender, EventArgs e)
        {
            frmSalaSeis frmSalaSeis = new frmSalaSeis();

            this.Hide();

            frmSalaSeis.Closed += (object s, EventArgs ev) => this.Show();

            frmSalaSeis.ShowDialog();
        }

        private void btnBaixo_Click(object sender, EventArgs e)
        {
            frmSalaQuatro frmSalaQuatro = new frmSalaQuatro();

            this.Hide();

            frmSalaQuatro.Closed += (object s, EventArgs ev) => this.Show();

            frmSalaQuatro.ShowDialog();
        }
    }
}
