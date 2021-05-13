using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace proyectop2 
{
    public partial class FrmBuscarEmpleado : Form
    {
        public FrmBuscarEmpleado()
        {
            InitializeComponent();
            conexion.Conectar();
      
        }
        public DataTable llenar_empleados()
        {
            conexion.Conectar();
            DataTable dt = new DataTable();
            string consulta = "select Empleados.nombree,apellido,usuario,contraseña,numerotel,edad,puesto,sueldo,Domicilio.numero,Estado.estado,Localidad.localidad,Calle.calle from Empleados inner join Domicilio on Empleados.fk_iddomicilioe = Domicilio.iddomicilio inner join Estado on Domicilio.fk_estado = Estado.fk_localidad inner join Localidad on Estado.fk_localidad = Localidad.idlocalidad inner join Calle on Localidad.fk_calles = Calle.idcalle";
            SqlCommand cmd = new SqlCommand(consulta, conexion.Conectar());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
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
            dgvbempleados.DataSource = llenar_empleados();
        }
    }
}
