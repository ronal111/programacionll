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


namespace proyectop2
{
    public partial class FrmRegistroCalle : Form
    {
        public FrmRegistroCalle()
        {
            InitializeComponent();
            conexion.Conectar();
            
           
        }

       private void btbbuscarp_Click(object sender, EventArgs e)
        {
            registrarcalle();
            txtcalle.Clear();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            txtcalle.Clear();
            this.Close();
        }
        public  void registrarcalle()
        {
            conexion.Conectar();
            string insertar = "insert into calle (calle) values (@calle)";
            SqlCommand cmd = new SqlCommand(insertar, conexion.Conectar());
            cmd.Parameters.AddWithValue("@calle", txtcalle.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("datos insertados correctamente");
        

        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
