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
    public partial class FRM_MARCA : Form
    {
        B_Operaciones_Marcas marcas = new B_Operaciones_Marcas();
        public FRM_MARCA()
        {
            InitializeComponent();
        }

        private void FRM_MARCA_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            borrarerror();
            if (validaciones())
            {
           conversioninsertar();
                txtmarca.Clear();
            }
            
        }
        public void convesionesactualizar()
        {

            marcas.actualizarmarca(Convert.ToInt32(lblidmarca.Text), txtmarca.Text);
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            borrarerror();

            if (validaciones())
            {
                convesionesactualizar();
                txtmarca.Clear();
                btnActualizar.Enabled = false;
                btnGuardar.Enabled = true;
                
            }
        }
        public bool validaciones()
        {
            bool ok = true;
            if (txtmarca.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtmarca, "ingresar nombre de la categoria");
            }
            return ok;
        }
        public void borrarerror()
        {
            errorProvider1.SetError(txtmarca, "");
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            btnActualizar.Enabled = false;
            btnGuardar.Enabled = true;
        }

        private void mostarmarca_Click(object sender, EventArgs e)
        {
            conversionbuscar();
        }

        private void dgvMarca_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {   lblidmarca.Text= dgvMarca.CurrentRow.Cells[0].Value.ToString();
            txtmarca.Text = dgvMarca.CurrentRow.Cells[1].Value.ToString();
            btnActualizar.Enabled = true;
            btnGuardar.Enabled = false;
        }
        private void conversionbuscar()
        {

            var lista = marcas.buscar_marca();
          dgvMarca.DataSource = lista;

        }
        public void conversioninsertar()
        {
            marcas.insertarmarca(txtmarca.Text); 
        }
        private void marcaEspecifica()
        {
            var lista = marcas.buscarmarcaespecifica(txtbuscarmarca.Text);
            dgvMarca.DataSource = lista;

        }

        private void txtbuscarmarca_TextChanged(object sender, EventArgs e)
        {
            marcaEspecifica();
        }

        private void gbreprod_Enter(object sender, EventArgs e)
        {

        }
    }
}
