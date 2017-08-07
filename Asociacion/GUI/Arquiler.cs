using Asociacion.BO;
using Asociacion.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asociacion.GUI
{
    public partial class Arquiler : Form
    {
        private AlquilerBO abo;
        public Alquiler Alquiler { get; set; }
        public Arquiler()
        {
            InitializeComponent();
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtLugar_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtMesa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtPrecioMesas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtSilla_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtPrecioSillas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtMantel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtPrecioMantel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtLasos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtPrecioLasos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtCobertores_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtPrecioCobert_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtSobreM_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtPrecioSoMan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtSillaV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtPrecioSiVe_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtSillaB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtPrecioSiBl_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int mesas = Int32.Parse(txtMesa.Text.Trim()) * Int32.Parse(txtPrecioMesas.Text.Trim());
            int sillas = Int32.Parse(txtSilla.Text.Trim()) * Int32.Parse(txtPrecioSillas.Text.Trim());
            int mantel = Int32.Parse(txtMantel.Text.Trim()) * Int32.Parse(txtPrecioMantel.Text.Trim());
            int lasos = Int32.Parse(txtLasos.Text.Trim()) * Int32.Parse(txtPrecioLasos.Text.Trim());
            int cobertores = Int32.Parse(txtCobertores.Text.Trim()) * Int32.Parse(txtPrecioCobert.Text.Trim());
            int sobreMantel = Int32.Parse(txtSobreM.Text.Trim()) * Int32.Parse(txtPrecioSoMan.Text.Trim());
            int sillave = Int32.Parse(txtSillaV.Text.Trim()) * Int32.Parse(txtPrecioSiVe.Text.Trim());
            int sillabl = Int32.Parse(txtSillaB.Text.Trim()) * Int32.Parse(txtPrecioSiBl.Text.Trim());
            int total = mesas + sillas + mantel + lasos + cobertores + sobreMantel + sillave + sillabl;
            lblmsj.Visible = true;
            lbltotal.Visible = true;
            lblmsj.Text = total.ToString();
            btnGuardar.Enabled = true;
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            var bl = !string.IsNullOrEmpty(txtNombre.Text) &&
                       !string.IsNullOrEmpty(txtLugar.Text) &&
                       !string.IsNullOrEmpty(txtTelefono.Text);

            panel2.Enabled = bl;
        }

        private void txtLugar_TextChanged(object sender, EventArgs e)
        {
            var bl = !string.IsNullOrEmpty(txtNombre.Text) &&
                       !string.IsNullOrEmpty(txtLugar.Text) &&
                       !string.IsNullOrEmpty(txtTelefono.Text);

            panel2.Enabled = bl;
        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {
            var bl = !string.IsNullOrEmpty(txtNombre.Text) &&
                       !string.IsNullOrEmpty(txtLugar.Text) &&
                       !string.IsNullOrEmpty(txtTelefono.Text);

            panel2.Enabled = bl;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
                lblMensaje.Text = "";
                abo = new AlquilerBO();
            Alquiler a = new Alquiler();
            a.Nombre = txtNombre.Text.Trim();
            a.Fecha = Fecha.Value.ToString("yyyy-MM-dd");
            a.Lugar = txtLugar.Text.Trim();
            a.Telefono = Int32.Parse(txtTelefono.Text.Trim());
            a.Mesas = Int32.Parse(txtMesa.Text.Trim());
            a.Sillas = Int32.Parse(txtSilla.Text.Trim());
            a.Manteles = Int32.Parse(txtMantel.Text.Trim());
            a.Lasos = Int32.Parse(txtLasos.Text.Trim());
            a.Cobertores = Int32.Parse(txtCobertores.Text.Trim());
            a.SobreMantel = Int32.Parse(txtSobreM.Text.Trim());
            a.SillasVerdes = Int32.Parse(txtSillaV.Text.Trim());
            a.SillasBlancas = Int32.Parse(txtSillaB.Text.Trim());
            a.Total = Int32.Parse(lblmsj.Text.Trim());
            abo.Registrar(a);
            lblMensaje.Text = "Alquiler registrado exitosamente";
            btnGuardar.Enabled = false;
            txtNombre.Text = "";
            txtLugar.Text = "";
            txtTelefono.Text = "";
            txtMantel.Text = "";
            txtSilla.Text = "";
            txtSillaB.Text = "";
            txtSillaV.Text = "";
            txtMesa.Text = "";
            txtLasos.Text = "";
            txtCobertores.Text = "";
            txtSobreM.Text = "";
            lblmsj.Text = "";
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            busqueda ventanabusqueda = new busqueda()
            {
            };
            ventanabusqueda.Show(this);
            this.Hide();
        }

        private void Arquiler_Load(object sender, EventArgs e)
        {

        }
    }
}
