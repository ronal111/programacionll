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
using System.Data.SqlClient;
using business;

namespace proyectop2
{
    public partial class FrmRegistrarEmpleado : Form
    { 
        private B_Operaciones_Empleados bopem = new B_Operaciones_Empleados();
        private B_Operaciones bop = new B_Operaciones();
        string iddomicilio;
        public FrmRegistrarEmpleado()
        {
            InitializeComponent();
            iddomicilio = "";
        }



        private void mostar_Click(object sender, EventArgs e)
        {
            llenar_empleados();
            
        }

        private bool ValidarCampos()
        {
            bool ok = true;

            if (txtrfc.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtrfc, "ingresar el rfc del empleado ");
            }
            else if (txtrfc.Text.Length != 12 && txtrfc.Text.Length != 13)
            {
                ok = false;
                errorProvider1.SetError(txtrfc, "El RFC debe de ser de 12 o 13 caracteres");
            }
            else
            {
                string cadena = @"([a-z]{3,4})([0-9]{7})([a-z])([0-9])";
                Regex rgx = new Regex(cadena);
                if (!rgx.IsMatch(txtrfc.Text))
                {
                    ok = false;
                    errorProvider1.SetError(txtrfc, "El texto no coincide con un formato RFC");
                }
            }

            if (!(cboxedad.Value > 18))
            {
                ok = false;
                errorProvider1.SetError(cboxedad, "la edad debe ser mayor a 18");
            }

            if (txtempleado.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtempleado, "ingresar nombre del empleado");
            }
            if (txtapellido.Text == "")
            {

                errorProvider1.SetError(txtapellido, "ingresar apellido del empleado");
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
            if (txtcalle.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtcalle, "ingresar sueldo");
            }

            return ok;


        }

        private void borrarmensajeerror()
        {
            errorProvider1.SetError(txtrfc, "");
            errorProvider1.SetError(txtempleado, "");
            errorProvider1.SetError(txtapellido, "");
            errorProvider1.SetError(txttelefonoe, "");
            errorProvider1.SetError(txtpuesto, "");
            errorProvider1.SetError(txtsueldo, "");
            errorProvider1.SetError(txtnumero, "");

        }

        public void conversiones()
        {

            string iddomicilio = bop.insertarDomicilio(txtnumero.Text, txtnumerointerior.Text, txtcalle.Text, txtcodigopos.Text, cboxcolonia.Text, txtmunicipio.Text,
                    txtestado.Text);
            if (iddomicilio == "error") { MessageBox.Show("Ocurrio un error al insertar empleado"); return; }
            bopem.insertarempleado(txtrfc.Text, txtempleado.Text, txtapellido.Text, txttelefonoe.Text, cboxedad.Value.ToString(), txtpuesto.Text, txtsueldo.Text, iddomicilio);


        }
        public void conversionactualizar()
        {

            bop.actualizar_Domicilio(iddomicilio, txtnumero.Text, txtnumerointerior.Text, txtcalle.Text, txtcodigopos.Text, cboxcolonia.Text, txtmunicipio.Text, txtestado.Text);
            bopem.actualizarempleado(txtrfc.Text, txtempleado.Text, txtapellido.Text, txttelefonoe.Text, cboxedad.Value.ToString(), txtpuesto.Text, txtsueldo.Text);
        }

        private void LimpiarCampos()
        {
            txtrfc.Clear();
            txtempleado.Clear();
            txtapellido.Clear();
            txtsueldo.Clear();
            txttelefonoe.Clear();
            txtpuesto.Clear();
            txtnumero.Clear();
            txtnumerointerior.Clear();
            txtcodigopos.Clear();
            cboxcolonia.Text = "";
            txtmunicipio.Clear();
            txtestado.Clear();
            txtcalle.Clear();
            cboxedad.Value =0;
            btbbuscarE.Enabled = true;
            Actualizar.Enabled = false;
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void dgvempleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            txtrfc.Text = dgvempleados.CurrentRow.Cells[0].Value.ToString();
            txtempleado.Text = dgvempleados.CurrentRow.Cells[1].Value.ToString();
            txtapellido.Text = dgvempleados.CurrentRow.Cells[2].Value.ToString();
            txttelefonoe.Text = dgvempleados.CurrentRow.Cells[3].Value.ToString();
            cboxedad.Value = Convert.ToInt32(dgvempleados.CurrentRow.Cells[4].Value);
            txtpuesto.Text = dgvempleados.CurrentRow.Cells[5].Value.ToString();
            txtsueldo.Text = dgvempleados.CurrentRow.Cells[6].Value.ToString();
            iddomicilio = dgvempleados.CurrentRow.Cells[7].Value.ToString();
            txtcalle.Text = dgvempleados.CurrentRow.Cells[8].Value.ToString();   
            txtnumero.Text = dgvempleados.CurrentRow.Cells[9].Value.ToString();    
            txtnumerointerior.Text = dgvempleados.CurrentRow.Cells[10].Value.ToString();   
            txtcodigopos.Text = dgvempleados.CurrentRow.Cells[11].Value.ToString();
            cboxcolonia.Text = dgvempleados.CurrentRow.Cells[12].Value.ToString();
            txtmunicipio.Text = dgvempleados.CurrentRow.Cells[13].Value.ToString();
            txtestado.Text = dgvempleados.CurrentRow.Cells[14].Value.ToString();
            btnguardar.Enabled = false;
            Actualizar.Enabled = true;
        }

        public void llenar_empleados()
        {
            var lista = bopem.buscarEmpleado();
            dgvempleados.DataSource = lista;
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            borrarmensajeerror();
            if (ValidarCampos())
                conversiones();
        }

        public void insertar_Domicilio(object sender, EventArgs e)
        {
            string cp = txtcodigopos.Text;
            if (cp.Length >= 4)
            {
                DataTable codigos = bop.cargarcalle(cp);
                cboxcolonia.Items.Clear();
                cboxcolonia.Text = "";
                txtmunicipio.Text = "";
                txtestado.Text = "";
                if (codigos != null)
                {
                    txtmunicipio.Text = codigos.Rows[0]["municipio"].ToString();
                    txtestado.Text = codigos.Rows[0]["estado"].ToString();
                    string[] colonias = codigos.Rows[0]["colonia"].ToString().Split(';');
                    for (int i = 0; i < colonias.Length; i++)
                    {
                        cboxcolonia.Items.Add(colonias[i]);


                    }
                    cboxcolonia.SelectedIndex = 0;
                }



            }
        }

        private void Actualizar_Click(object sender, EventArgs e)
        {
            borrarmensajeerror();
            if (ValidarCampos())
            {  conversionactualizar();
                LimpiarCampos();
                btnguardar.Enabled = true;
                Actualizar.Enabled = false;
            }
        }

        private void FrmEmpleadoReg_Load(object sender, EventArgs e)
        {
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            var lista = bopem.buscarempleadoespecifico(textBox4.Text);
            dgvempleados.DataSource = lista;
        }
    }
}
