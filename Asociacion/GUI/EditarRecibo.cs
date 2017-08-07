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
    public partial class EditarRecibo : Form
    {
        public int Id { get; set; }
        Recibo recibo = new Recibo();
        public EditarRecibo()
        {
            InitializeComponent();
        }

        private void EditarRecibo_Load(object sender, EventArgs e)
        {
           
            ReciboDAO rec = new ReciboDAO();
           recibo = rec.SelectId(Id);
            try
            {
                lblMensaje.Text = "";

                if (recibo.Id > 0)
                {
                    Fecha.Text = recibo.Fecha;
                    txtRecibDe.Text = recibo.De;
                    txtMonto.Text = recibo.Monto.ToString();
                    txtDescripcion.Text = recibo.Descripcion;

                }

            }
            catch (Exception ex)
            {
                lblMensaje.Text = ex.Message.Replace("[0-9]*", "");
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            ReciboDAO rec = new ReciboDAO();
            recibo.Fecha = Fecha.Text;
            recibo.De =txtRecibDe.Text;
            recibo.Monto = Convert.ToInt32(txtMonto.Text);
            recibo.Descripcion = txtDescripcion.Text;
            rec.Modificar(recibo);
            BusquedaRecibo ventanabusqueda = new BusquedaRecibo()
            {
            };
            ventanabusqueda.Show(this);
            this.Hide();
        }
    }
}
