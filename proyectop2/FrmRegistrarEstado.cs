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
    public partial class FrmRegistrarEstado : Form
    {
        public FrmRegistrarEstado()
        {
            InitializeComponent();
        }

        private void btnguardarestado_Click(object sender, EventArgs e)
        {
            txtlocalidad.Clear();
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            txtlocalidad.Clear();
        }
    }
}
