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
    public partial class busqueda : Form
    {
        public String Id;
        public Alquiler alquiler { get; set; }
        public int a;
        public busqueda()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AlquilerDAO alq = new AlquilerDAO();
            alq.Select(txtConsulta.Text, dataGridView1);
        }

        private void busqueda_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtConsulta_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            EditarAlquiler ventanaJuego = new EditarAlquiler()
            {
                Id = a
            };
            ventanaJuego.Show(this);
            this.Hide();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Id = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            a = Convert.ToInt32(Id);
            if (a > 0)
            {
                btnActualizar.Enabled = true;
                btnEliminar.Enabled = true;
            }
            else
            {
                btnEliminar.Enabled = true;
                btnActualizar.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Principal ventanabusqueda = new Principal()
            {
            };
            ventanabusqueda.Show(this);
            this.Hide();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            AlquilerDAO rec = new AlquilerDAO();
            rec.BorrarAlquiler(a);
            rec.Select("todo", dataGridView1);
            btnActualizar.Enabled = false;
            btnEliminar.Enabled = false;
        }
    }
}
