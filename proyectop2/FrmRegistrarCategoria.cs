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

namespace proyectop2
{
    public partial class FrmRegistrarCategoria : Form
    {
        B_Operaciones_Categoria catego = new B_Operaciones_Categoria();
        FrmRegistrarProductos cargar = new FrmRegistrarProductos();
        
        public FrmRegistrarCategoria()
        {
            InitializeComponent();
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            btnActualizar.Enabled = false;
            btnGuardar.Enabled = true;
        }
        public void conversioninsertar()
        {
            catego.insertarCategoria(txtcategoria.Text);
        }

        private void FrmRegistrarCategoria_Load(object sender, EventArgs e)
        {

        }

        private void conversionbuscar() {

            var lista = catego.buscar_categoriacombo();
            dgvcategoria.DataSource = lista;

        }
          private void mostarcategoria_Click(object sender, EventArgs e)
        {
            conversionbuscar();
        }

        private void dgvcategoria_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            lblidcategoria.Text = dgvcategoria.CurrentRow.Cells[0].Value.ToString();
            txtcategoria.Text=dgvcategoria.CurrentRow.Cells[1].Value.ToString();
            btnGuardar.Enabled = false;
            btnActualizar.Enabled = true;
        }
        public bool validaciones() {
            bool ok = true;
            if (txtcategoria.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtcategoria, "ingresar nombre de la categoria");
            }
            return ok;
        }
        public void borrarerror() {
            errorProvider1.SetError(txtcategoria, "");
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            borrarerror();
            if (validaciones())
            {
                conversioninsertar();
                txtcategoria.Clear();
                lblidcategoria.Text = "";
                cargar.cargarDatosIniciales();
            }
        }

        private void gbreprod_Enter(object sender, EventArgs e)
        {

        }
        public void convesionesactualizar() {
            
            catego.actualizarcategoria(Convert.ToInt32(lblidcategoria.Text),txtcategoria.Text);
        }
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            borrarerror();
            if (validaciones())
            {
                convesionesactualizar();
                txtcategoria.Clear();
                lblidcategoria.Text = "";
                btnGuardar.Enabled = true;
                btnActualizar.Enabled = false;
                cargar.cargarDatosIniciales();
            }
        }
        private void categoriaEspecifica() {
           var lista= catego.buscarCategoriaEspecifica(txtbuscar.Text);
            dgvcategoria.DataSource = lista;
        
        }

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
            categoriaEspecifica();
        }
    }
}
