using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using business;

namespace proyectop2 
{ 
    public partial class FrmBuscarEmpleado : Form
    {
        private B_Operaciones_Empleados opem = new B_Operaciones_Empleados();
      
        public FrmBuscarEmpleado()
        {
            InitializeComponent();
            
      
        }
        public void llenar_empleados()
        {

            var lista = opem.buscarEmpleado();
            dgvbempleados.DataSource = lista;
            
            
        }
        private void buscarempleado_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
         

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        public void ibtnaddempleados_Click(object sender, EventArgs e)
        {

        }

        private void btbbuscarp_Click(object sender, EventArgs e)
        {
            txtbuscarempleado.Clear();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void selecall_Click(object sender, EventArgs e)
        {
         llenar_empleados();
        }

        private void dgvbempleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
