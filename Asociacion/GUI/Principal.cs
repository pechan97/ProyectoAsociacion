﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asociacion.GUI
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void btnAlquiler_Click(object sender, EventArgs e)
        {
            Arquiler ventanaarquiler = new Arquiler()
            {
            };
            ventanaarquiler.Show(this);
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Recibos ventanarecibo = new Recibos()
            {
            };
            ventanarecibo.Show(this);
            this.Hide();
        }
    }
}
