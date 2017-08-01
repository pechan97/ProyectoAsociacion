using Asociacion.BO;
using Asociacion.Entidades;
using System;
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
    public partial class ButIngreso : Form
    {
        private IngresoBO ibo;
        public ButIngreso()
        {
            InitializeComponent();
        }

        private void ButIngreso_Load(object sender, EventArgs e)
        {
            ibo = new IngresoBO();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ingreso i = new Ingreso()
            {
                Usuario = txtUsuario.Text.Trim(),
                Password = txtContrasenna.Text.Trim()
            };
            i = ibo.Autentificar(i);
            if (i.Id > 0)
            {
                Principal ventanaPrincipal = new Principal()
                {
                };
                ventanaPrincipal.Show(this);
                this.Hide();
            }
            else
            {
                lblmensaje.Text = "Usuario no admitido";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtContrasenna_TextChanged(object sender, EventArgs e)
        {
            lblmensaje.Text = "";
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            lblmensaje.Text = "";
        }
    }
}
