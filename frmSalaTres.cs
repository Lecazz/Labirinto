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
    public partial class frmSalaTres : Form
    {
        public frmSalaTres()
        {
            InitializeComponent();
        }

        private void btnCima_Click(object sender, EventArgs e)
        {
            frmSalaDois frmSalaDois = new frmSalaDois();
            this.Hide();
            frmSalaDois.Closed += (object s, EventArgs ev) => this.Show();

            frmSalaDois.ShowDialog();
        }

        private void btnDireito_Click(object sender, EventArgs e)
        {
            frmChegada frmChegada = new frmChegada();
            this.Hide();
            frmChegada.Closed += (object s, EventArgs ev) => this.Show();

            frmChegada.ShowDialog();
        }

        private void btnBaixo_Click(object sender, EventArgs e)
        {
            frmSalaCinco frmSalaCinco = new frmSalaCinco();
            this.Hide();
            frmSalaCinco.Closed += (object s, EventArgs ev) => this.Show();

            frmSalaCinco.ShowDialog();
        }

        private void btnEsquerda_Click(object sender, EventArgs e)
        {
            frmSalaUm frmSalaUm = new frmSalaUm();
            this.Hide();
            frmSalaUm.Closed += (object s, EventArgs ev) => this.Show();

            frmSalaUm.ShowDialog();
        }
    }
}
