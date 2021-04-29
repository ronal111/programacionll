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
    public partial class FrmRegistrarProductos : Form
    {
        public FrmRegistrarProductos()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            borrarmensajeerror();

            if (ValidarCampos())
            {
                MessageBox.Show("datos ingresados correctamente");
            }
        }
        private void borrarmensajeerror()
        {
            errorProvider1.SetError(txtproductocodigo, "");
            errorProvider1.SetError(txtnombreproducto, "");
            errorProvider1.SetError(txtpreciocompra, "");
            errorProvider1.SetError(txtdescripcion, "");
            errorProvider1.SetError(txtproveedor, "");
            errorProvider1.SetError(txtventa, "");
            errorProvider1.SetError(txtcolor, "");
           
        }
        private void iconButton1_Click(object sender, EventArgs e)
        {
            txtcolor.Clear();
            txtdescripcion.Clear();
            txtnombreproducto.Clear();
            txtpreciocompra.Clear();
            txtproductocodigo.Clear();
            txtproveedor.Clear();
            txtventa.Clear();
        }
        private bool ValidarCampos()
        {
            bool ok = true;

            if (txtproductocodigo.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtproductocodigo, "ingresar el rfc del empleado ");
            }

            if (txtnombreproducto.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtnombreproducto, "ingresar el rfc del empleado ");
            }

            if (txtdescripcion.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtdescripcion, "ingresar la descripcion del producto ");
            }
            if (txtpreciocompra.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtpreciocompra, "ingresar la descripcion del producto ");
            }
            if (txtventa.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtventa, "ingresar la descripcion del producto ");
            }
            if (txtproveedor.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtproveedor, "ingresar la descripcion del producto ");
            }
            if (txtcolor.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtcolor, "ingresar la descripcion del producto ");
            }



            return ok;
        }

        private void txtdescripcion_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
