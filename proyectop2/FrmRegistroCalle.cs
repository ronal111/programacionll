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
    public partial class FrmRegistroCalle : Form
    {
        public FrmRegistroCalle()
        {
            InitializeComponent();
        }

        private void btbbuscarp_Click(object sender, EventArgs e)
        {
            txtcalle.Clear();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            txtcalle.Clear();
        }
    }
}
