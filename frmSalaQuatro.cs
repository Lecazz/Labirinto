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
    public partial class frmSalaQuatro : Form
    {
        public frmSalaQuatro()
        {
            InitializeComponent();
        }

        private void btnBaixo_Click(object sender, EventArgs e)
        {
            frmSalaDois frmSalaDois = new frmSalaDois();
            this.Hide();
            frmSalaDois.Closed += (object s, EventArgs ev) => this.Show();

            frmSalaDois.ShowDialog();
        }

        private void btnEsquerda_Click(object sender, EventArgs e)
        {
            frmSalaTres frmSalaTres = new frmSalaTres();
            this.Hide();
            frmSalaTres.Closed += (object s, EventArgs ev) => this.Show();

            frmSalaTres.ShowDialog();
        }

        private void btnDireita_Click(object sender, EventArgs e)
        {
            frmSalaSeis frmSalaSeis = new frmSalaSeis();
            this.Hide();
            frmSalaSeis.Closed += (object s, EventArgs ev) => this.Show();

            frmSalaSeis.ShowDialog();
        }

        private void btnCima_Click(object sender, EventArgs e)
        {
            frmMorte frmMorte = new frmMorte();
            this.Hide();
            frmMorte.Closed += (object s, EventArgs ev) => this.Show();

            frmMorte.ShowDialog()
        }
    }
}
