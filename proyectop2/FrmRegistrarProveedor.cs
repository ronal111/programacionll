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
using business;

namespace proyectop2
{
    public partial class FrmRegistrarProveedor : Form
    {
        private B_Operaciones_Prov bop_proveedor = new B_Operaciones_Prov();
        private B_Operaciones bop_domicilio = new B_Operaciones();
        string iddomicilio;
        public FrmRegistrarProveedor()
        {
            InitializeComponent();
            iddomicilio = "";
        }

        public void conversiones()
        {

            string iddomicilio = bop_domicilio.insertarDomicilio(txtnumero.Text, txtnumerointerior.Text, txtcalle.Text, txtcodigopos.Text, cboxcolonia.Text, txtmunicipio.Text,
                    txtestado.Text);
            if (iddomicilio == "error") { MessageBox.Show("Ocurrio un error al insertar empleado"); return; }
            bop_proveedor.insertar_Proveedor(txtproveedor.Text, txtcompañia.Text, txtcorreo.Text, txttelefono.Text, iddomicilio);




        }
        public void llenar_dgbempleados()
        {
             var lista = bop_proveedor.buscar_Proveedor();
            dgvproveedores.DataSource = lista;


        }
        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
        private void btbguardar_Click(object sender, EventArgs e)
        {
            borrarmensajeerror();

            if (ValidarCampos())
            {
                borrarmensajeerror();
                if (ValidarCampos())
                    conversiones();
                LimpiarCampos();
              
            }

        }
        private void borrarmensajeerror()
        {
            errorProvider1.SetError(txtproveedor, "");
            errorProvider1.SetError(txtcompañia, "");
            errorProvider1.SetError(txtcorreo, "");
            errorProvider1.SetError(txttelefono, "");
            errorProvider1.SetError(txtcalle, "");
            errorProvider1.SetError(txtnumero, "");
            errorProvider1.SetError(txtcodigopos, "");
            errorProvider1.SetError(cboxcolonia, "");
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
                errorProvider1.SetError(txttelefono, "ingresar el numero telefonico del Proveedor ");
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

            if (txttelefono.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txttelefono, "ingresar el telefono ");
            }
            if (txtcalle.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtcalle, "ingresar la calle ");
            }
            if (txtnumero.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtnumero, "ingresar numero de calle ");
            }
            if (txtcodigopos.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtcodigopos, "ingresar el codigo potal ");
            }
            if (cboxcolonia.Text == "")
            {
                ok = false;
                errorProvider1.SetError(cboxcolonia, "ingresar el codigo potal ");
            }



            return ok;
        }
        private void LimpiarCampos()
        {
            lblidprov.Text = "";
            txtproveedor.Clear();
            txtcompañia.Clear();
            txtcorreo.Clear();
            txttelefono.Clear();
            txtcalle.Clear();
            txtnumero.Clear();
            txtnumerointerior.Clear();
            txtcodigopos.Clear();
            cboxcolonia.Text = "";
            txtmunicipio.Clear();
            txtestado.Clear();
            btbguardar.Enabled = true;
            Actualizar.Enabled = false;

        }
        private void btncancelar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
          
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        public void conversionactualizar()
        {           

            bop_domicilio.actualizar_Domicilio(iddomicilio , txtnumero.Text, txtnumerointerior.Text, txtcalle.Text, txtcodigopos.Text, cboxcolonia.Text, txtmunicipio.Text, txtestado.Text);
            bop_proveedor.actualizar_Proveedor( Convert.ToInt32(lblidprov.Text), txtproveedor.Text, txtcompañia.Text, txtcorreo.Text, txttelefono.Text);
        }
        private void Actualizar_Click(object sender, EventArgs e)
        {
            borrarmensajeerror();
            if (ValidarCampos())
            {
                conversionactualizar();
                LimpiarCampos();
              btbguardar.Enabled = true;
            Actualizar.Enabled = false;
            }
            
        }
        private void mostar_Click(object sender, EventArgs e)
        {
            llenar_dgbempleados();
        }
        private void dgvproveedores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {   
            lblidprov.Text = dgvproveedores.CurrentRow.Cells[0].Value.ToString();
            txtproveedor.Text= dgvproveedores.CurrentRow.Cells[1].Value.ToString();
            txtcompañia.Text = dgvproveedores.CurrentRow.Cells[2].Value.ToString();
            txtcorreo.Text = dgvproveedores.CurrentRow.Cells[3].Value.ToString();
            txttelefono.Text = dgvproveedores.CurrentRow.Cells[4].Value.ToString(); 
            txtcalle.Text = dgvproveedores.CurrentRow.Cells[6].Value.ToString();
            txtnumero.Text = dgvproveedores.CurrentRow.Cells[7].Value.ToString();
            txtnumerointerior.Text = dgvproveedores.CurrentRow.Cells[8].Value.ToString();
            txtcodigopos.Text = dgvproveedores.CurrentRow.Cells[9].Value.ToString();
            cboxcolonia.Text = dgvproveedores.CurrentRow.Cells[10].Value.ToString();
            txtmunicipio.Text = dgvproveedores.CurrentRow.Cells[11].Value.ToString();
            txtestado.Text = dgvproveedores.CurrentRow.Cells[12].Value.ToString();
            iddomicilio = dgvproveedores.CurrentRow.Cells[5].Value.ToString();
            btbguardar.Enabled = false;
            Actualizar.Enabled = true;
        }
        public void insertar_Domicilio(object sender, EventArgs e)
        {
            string cp = txtcodigopos.Text;
            if (cp.Length >= 4)
            {
                DataTable codigos = bop_domicilio.cargarcalle(cp);
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

        private void FrmRegistrarProveedor_Load(object sender, EventArgs e)
        {

        }

        private void buscarproveedor_TextChanged(object sender, EventArgs e)
        {
            var lista = bop_proveedor.buscar_Proveedorespecifico(txtbuscarproveedor.Text);
            dgvproveedores.DataSource = lista;
        }
    }
}
