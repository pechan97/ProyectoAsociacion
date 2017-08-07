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
    public partial class BusquedaRecibo : Form
    {
        public String Id;
        public Recibo Recibo { get; set; }
        public int a;
        public BusquedaRecibo()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ReciboDAO rec = new ReciboDAO();
            rec.Select(txtConsulta.Text, dataGridView1);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Id = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            a = Convert.ToInt32(Id);
            if (a > 0)
            {
                btnActualizar.Enabled = true;
            } else
            {
                btnActualizar.Enabled = false;
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            EditarRecibo ventanaJuego = new EditarRecibo()
            {
              Id = a
            };
            ventanaJuego.Show(this);
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
