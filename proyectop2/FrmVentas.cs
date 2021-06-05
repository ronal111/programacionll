using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyectop2
{
    public partial class FrmVentas : Form
    {
        public FrmVentas()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btbbuscarp_Click(object sender, EventArgs e)
        {
            txtbuscar.Clear();
        }

        private void ibtncancelar_Click(object sender, EventArgs e)
        {
            txtbuscar.Clear();
        }

        private void dgvbproductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
