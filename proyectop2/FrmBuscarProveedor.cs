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
    public partial class FrmBuscarProveedor : Form
    {
        public FrmBuscarProveedor()
        {
            InitializeComponent();
        }

        private void btbbuscarp_Click(object sender, EventArgs e)
        {
            txtbuscarproveedor.Clear();
        }

        private void dgvbproveedores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
