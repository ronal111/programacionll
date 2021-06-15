using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using business;
using business.Operaciones;

namespace proyectop2 
{
    public partial class FRM_Modelos : Form
    {

        B_Operaciones_Modelo modelo = new B_Operaciones_Modelo();
        B_Operaciones_Marcas marcas = new B_Operaciones_Marcas();
        public FRM_Modelos()
        {
            InitializeComponent();
        }

        private void dgvmodelo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            limpiarcampos();
            lblidmodelo.Text = dgvmodelo.CurrentRow.Cells[0].Value.ToString();
            txtmodelo.Text = dgvmodelo.CurrentRow.Cells[1].Value.ToString();
            cboxmarca.Text = dgvmodelo.CurrentRow.Cells[2].Value.ToString();
            btnActualizar.Enabled = true;
            btnGuardar.Enabled = false;
        }

        private void FRM_Modelos_Load(object sender, EventArgs e)
        {
         cargardatosinniciales();
        }
        public void cargardatosinniciales() {

            var lista = marcas.buscar_marca();
            cboxmarca.ValueMember = "idmarca";
            cboxmarca.DisplayMember = "marcaproducto";
            cboxmarca.DataSource = lista;
            
        }
        public void convesionesactualizar()
        {

           modelo.actualizarmodelo(Convert.ToInt32(lblidmodelo.Text), txtmodelo.Text, Convert.ToInt32(cboxmarca.SelectedValue) );
        }
        private void conversionbuscar()
        {

            var lista = modelo.buscar_modelo();
            dgvmodelo.DataSource = lista;

        }

        private void mostarmodelos_Click(object sender, EventArgs e)
        {
            conversionbuscar();
        }
        public void busquedaespecifica() {
           var lista = modelo.buscarmodeloespecifico(txtbuscarmodelos.Text);
            dgvmodelo.DataSource = lista;
        
        }
        private void txtbuscarmodelos_TextChanged(object sender, EventArgs e)
        {
            busquedaespecifica();
        }
        public void conversionguardar() {
            modelo.insertarmodelo(txtmodelo.Text, Convert.ToInt32(cboxmarca.SelectedValue) );
        
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            borrarerror();
            if (validaciones())
            {
                conversionguardar();
                btnActualizar.Enabled = false;
                limpiarcampos();

            }
        }
        public bool validaciones()
        {
            bool ok = true;
            if (txtmodelo.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtmodelo, "ingresar nombre de la marca");
            }
            
            if (cboxmarca.Text == "")
            {
                ok = false;
                errorProvider1.SetError(cboxmarca, "ingresar nombre de la marca");
            }

            return ok;
        }
        public void borrarerror()
        {
            errorProvider1.SetError(txtmodelo, "");
            errorProvider1.SetError(cboxmarca, "");
        }
        public void limpiarcampos() {
            txtmodelo.Text = "";
            cboxmarca.Text = "";
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            limpiarcampos();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            borrarerror();
            if (validaciones())
            {
                conversionactualizar();
                limpiarcampos();
                btnActualizar.Enabled = false;
                btnGuardar.Enabled = true;
            }
        }
        public void conversionactualizar() {

            modelo.actualizarmodelo(  Convert.ToInt32(lblidmodelo.Text) ,txtmodelo.Text, Convert.ToInt32(cboxmarca.SelectedValue));
        
        }
    }
}
