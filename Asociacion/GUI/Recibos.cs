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
    public partial class Recibos : Form
    {
        private ReciboBO rbo;
        public Recibos()
        {
            InitializeComponent();
        }

        private void txtRecibDe_TextChanged(object sender, EventArgs e)
        {
            lblMensaje.Text = "";
            var bl = !string.IsNullOrEmpty(txtMonto.Text) &&
                      !string.IsNullOrEmpty(txtDescripcion.Text) &&
                      !string.IsNullOrEmpty(txtRecibDe.Text);
            btnGuardar.Enabled = bl;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            lblMensaje.Text = "";
            rbo = new ReciboBO();
            Recibo a = new Recibo();
            a.Descripcion = txtDescripcion.Text.Trim();
            a.Fecha = Fecha.Value.ToString("yyyy-MM-dd");
            a.De = txtRecibDe.Text.Trim();
            a.Monto = Int32.Parse(txtMonto.Text.Trim());
            rbo.Registrar(a);
            lblMensaje.Text = "Recibo registrado exitosamente";
            btnGuardar.Enabled = false;
            Fecha.Text = "";
            txtMonto.Text = "";
            txtRecibDe.Text = "";
            txtDescripcion.Text = "";
        }

        private void txtMonto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtMonto_TextChanged(object sender, EventArgs e)
        {
            lblMensaje.Text = "";
            var bl = !string.IsNullOrEmpty(txtMonto.Text) &&
                    !string.IsNullOrEmpty(txtDescripcion.Text) &&
                    !string.IsNullOrEmpty(txtRecibDe.Text);
            btnGuardar.Enabled = bl;
        }

        private void txtDescripcion_TextChanged(object sender, EventArgs e)
        {
            lblMensaje.Text = "";
            var bl = !string.IsNullOrEmpty(txtMonto.Text) &&
                    !string.IsNullOrEmpty(txtDescripcion.Text) &&
                    !string.IsNullOrEmpty(txtRecibDe.Text);
            btnGuardar.Enabled = bl;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            BusquedaRecibo ventanabusqueda = new BusquedaRecibo()
            {
            };
            ventanabusqueda.Show(this);
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Principal ventanabusqueda = new Principal()
            {
            };
            ventanabusqueda.Show(this);
            this.Hide();
        }
    }
}
