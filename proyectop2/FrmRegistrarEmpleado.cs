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
    public partial class FrmRegistrarEmpleado : Form
    {
        public FrmRegistrarEmpleado()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void lblrfc_Click(object sender, EventArgs e)
        {

        }

        private void btnaddlocalidad_Click(object sender, EventArgs e)
        {

        }

        private void btbbuscarp_Click(object sender, EventArgs e)
        {
            borrarmensajeerror();
          
            if (ValidarCampos())
            {
                MessageBox.Show("datos ingresados correctamente");
            }


        }
     
        
        

        private void iconButton1_Click(object sender, EventArgs e)
        {
            txtrfc.Clear();
            txtempleado.Clear();
            txtapellido.Clear();
            txtpass.Clear();
            txtsueldo.Clear();
            txttelefonoe.Clear();
            txtuser.Clear();
            txtpuesto.Clear();
            txtnumero.Clear();
            txtcolonia.Clear();
        }

        private bool ValidarCampos () 
        {
                       bool ok = true;

            if (txtrfc.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtrfc, "ingresar el rfc del empleado ");
            }
            string cadena1 = @"[a-z]{3,4}[\d]{6}[a-z]{2}[\d]{1}";
            Regex cadena = new Regex(cadena1);
            MatchCollection Match = cadena.Matches(txtrfc.Text);
            if (Match.Count > 0)
            {
            }
            else
            {
                errorProvider1.SetError(txtrfc, "requiere de 13 caracteres");
            }

            if (txtempleado.Text == "") 
            {      ok = false;
            errorProvider1.SetError(txtempleado,"ingresar nombre del empleado"); }
            if (txtapellido.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtapellido, "ingresar apellido del empleado");
            }
            if (txtuser.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtuser, "ingresar nombre de usuario");
            }
            if (txtpass.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtpass, "ingresar contraseña");
            }


            if (txttelefonoe.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txttelefonoe, "ingresar el telefono a 10 digitos");
            }
            string numero = @"\d{10}";
            Regex expresion = new Regex(numero);
            MatchCollection elMatch = expresion.Matches(txttelefonoe.Text);
            if (elMatch.Count > 0)
            {
            }
            else
            {
                errorProvider1.SetError(txttelefonoe, "requiere de 10 caracteres numericos");
            }

            if (txtpuesto.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtpuesto, "ingresar el puesto de trabajo");
            }
            if (txtsueldo.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtsueldo, "ingresar sueldo");
            }
            if (txtnumero.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtnumero, "ingresar numero de casa");
            }
          
            if (txtcolonia.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtcolonia, "ingresar nombre de tu colonia");
            }
           


            return ok;

          
                }
        private void borrarmensajeerror (){
            errorProvider1.SetError(txtrfc, "");
            errorProvider1.SetError(txtempleado,"");
            errorProvider1.SetError(txtapellido, "");
            errorProvider1.SetError(txtuser, "");
            errorProvider1.SetError(txtpass, "");
            errorProvider1.SetError(txttelefonoe, "");
            errorProvider1.SetError(txtpuesto, "");
            errorProvider1.SetError(txtsueldo, "");
            errorProvider1.SetError(txtnumero, "");
            errorProvider1.SetError(txtcolonia, "");
        }
      
        private void txtnumero_TextChanged(object sender, EventArgs e)
        {

        }

        private void txttelefonoe_Validating(object sender, CancelEventArgs e)
        {
            int num;
            if (int.TryParse(txttelefonoe.Text, out num))
            {
                errorProvider1.SetError(txttelefonoe, "ingrese valor en numero");
            }
            else {
                errorProvider1.SetError(txttelefonoe, "");


            }
        }

   

        
    }
}
