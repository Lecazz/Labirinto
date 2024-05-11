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
    public partial class frmSalaCinco : Form
    {
        public frmSalaCinco()
        {
            InitializeComponent();
        }

        private void btnCima_Click(object sender, EventArgs e)
        {
            frmSalaSeis frmSalaSeis = new frmSalaSeis();
            this.Hide();
            frmSalaSeis.Closed += (object s, EventArgs ev) => this.Show();

            frmSalaSeis.ShowDialog()
        }

        private void btnDireita_Click(object sender, EventArgs e)
        {
            frmSalaQuatro frmSalaQuatro = new frmSalaSeis();
            this.Hide();
            frmSalaSeis.Closed += (object s, EventArgs ev) => this.Show();

            frmSalaSeis.ShowDialog()
        }
    }
}
