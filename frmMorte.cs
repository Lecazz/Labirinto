﻿using System;
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
    public partial class frmMorte : Form
    {
        public frmMorte()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmPortal frmPortal = new frmPortal();
            this.Hide();
            frmPortal.Closed += (object s, EventArgs ev) => this.Show();

            frmPortal.ShowDialog();
        }
    }
}
