using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

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
            borrarmensajeerror();

            if (ValidarCampos())
            {
                MessageBox.Show("datos ingresados correctamente");
            }

        }
        private void borrarmensajeerror()
        {
            errorProvider1.SetError(txtproveedor, "");
            errorProvider1.SetError(txtcompañia, "");
            errorProvider1.SetError(txtcorreo, "");
            errorProvider1.SetError(txttelefono, "");
            errorProvider1.SetError(txtnumero, "");
            errorProvider1.SetError(txtcolonia, "");
        }
        private bool ValidarCampos()
        {
            bool ok = true;

            if (txtproveedor.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtproveedor, "ingresar el rfc del empleado ");
            }
            if (txtcompañia.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtcompañia, "ingresar el rfc del empleado ");
            }
            if (txtcorreo.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtcorreo, "ingresar el rfc del empleado ");
            }
   

            if (txttelefono.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txttelefono, "ingresar el rfc del empleado ");
            }
            string numero = @"\d{10}";
            Regex expresion = new Regex(numero);
            MatchCollection elMatch = expresion.Matches(txttelefono.Text);
            if (elMatch.Count > 0)
            {
            }
            else
            {
                errorProvider1.SetError(txttelefono, "requiere de 10 caracteres numericos");
            }

            if (txtnumero.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtnumero, "ingresar el rfc del empleado ");
            }
            if (txtcolonia.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtcolonia, "ingresar el rfc del empleado ");
            }

            return ok;
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
