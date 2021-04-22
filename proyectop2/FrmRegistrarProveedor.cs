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
    public partial class FrmRegistrarProveedor : Form
    {
        public FrmRegistrarProveedor()
        {
            InitializeComponent();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btbguardar_Click(object sender, EventArgs e)
        {
            txtproveedor.Clear();
            txtcolonia.Clear();
            txtcompañia.Clear();
            txtcorreo.Clear();
            txtnumero.Clear();
            txttelefono.Clear();
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            txtproveedor.Clear();
            txtcolonia.Clear();
            txtcompañia.Clear();
            txtcorreo.Clear();
            txtnumero.Clear();
            txttelefono.Clear();
        }
    }
}
