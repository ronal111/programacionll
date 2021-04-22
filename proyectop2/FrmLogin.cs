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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }
        Form formulario = new FrmMenu();

        private void btnmini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
       
        }

        private void btnrestaurar_Click(object sender, EventArgs e)
        {
           
        }

        private void btnacceder_Click(object sender, EventArgs e)
        {
            if ((txtuser.Text == "admin") && (txtcontraseña.Text == "admin"))
            {
                

                this.Hide();

               formulario.Show();
            }
            else
            {
                MessageBox.Show("Datos incorrectos o inválidos", "ERROR", MessageBoxButtons.OK);
            }
        }

        private void txtcontraseña_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void txtuser_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
