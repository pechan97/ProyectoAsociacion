using Asociacion.DAO;
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
    public partial class EditarAlquiler : Form
    {
        public int Id { get; set; }
        Alquiler alquiler = new Alquiler();
        public EditarAlquiler()
        {
            InitializeComponent();
        }

        private void EditarAlquiler_Load(object sender, EventArgs e)
        {
            AlquilerDAO rec = new AlquilerDAO();
            alquiler = rec.SelectId(Id);
            try
            {
                lblMensaje.Text = "";

                if (alquiler.Id > 0)
                {
                    Fecha.Text = alquiler.Fecha;
                    txtNombre.Text = alquiler.Nombre;
                    txtLugar.Text = alquiler.Lugar;
                    txtTelefono.Text = alquiler.Telefono.ToString();
                    txtMesa.Text = alquiler.Mesas.ToString();
                    txtSilla.Text = alquiler.Sillas.ToString();
                    txtMantel.Text = alquiler.Manteles.ToString();
                    txtLasos.Text = alquiler.Lasos.ToString();
                    txtCobertores.Text = alquiler.Cobertores.ToString();
                    txtSobreM.Text = alquiler.SobreMantel.ToString();
                    txtSillaV.Text = alquiler.SillasVerdes.ToString();
                    txtSillaB.Text = alquiler.SillasBlancas.ToString();

                }

            }
            catch (Exception ex)
            {
                lblMensaje.Text = ex.Message.Replace("[0-9]*", "");
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
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
            AlquilerDAO rec = new AlquilerDAO();
            alquiler.Fecha = Fecha.Value.ToString("yyyy-MM-dd");
            alquiler.Nombre = txtNombre.Text;
            alquiler.Lugar = txtLugar.Text;
            alquiler.Telefono = Convert.ToInt32(txtTelefono.Text);
            alquiler.Mesas = Convert.ToInt32(txtMesa.Text);
            alquiler.Sillas = Convert.ToInt32(txtSilla.Text);
            alquiler.Manteles = Convert.ToInt32(txtMantel.Text);
            alquiler.Lasos = Convert.ToInt32(txtLasos.Text);
            alquiler.Cobertores = Convert.ToInt32(txtCobertores.Text);
            alquiler.SobreMantel = Convert.ToInt32(txtSobreM.Text);
            alquiler.SillasVerdes = Convert.ToInt32(txtSillaV.Text);
            alquiler.SillasBlancas = Convert.ToInt32(txtSillaB.Text);
            alquiler.Total = Convert.ToInt32(lblmsj.Text);
            rec.Modificar(alquiler);
            busqueda ventanaPrincipal = new busqueda()
            {
            };
            ventanaPrincipal.Show(this);
            this.Hide();
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
