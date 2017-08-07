using Asociacion.DAO;
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
        public BusquedaRecibo()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ReciboDAO rec = new ReciboDAO();
            rec.Select(txtConsulta.Text, dataGridView1);
        }
    }
}
