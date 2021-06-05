using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using business.Operaciones;
using business;

namespace proyectop2
{
    public partial class FrmRegistrarProductos : Form
    {
        private B_Operaciones_Productos b_opeprod = new B_Operaciones_Productos();
        private B_Operaciones_Prov b_provedores = new B_Operaciones_Prov();
        private B_Operaciones_Categoria b_categoria = new B_Operaciones_Categoria();
        private B_Operaciones_Modelo b_modelos = new B_Operaciones_Modelo();
        private B_Operaciones_Marcas b_marcas = new B_Operaciones_Marcas();
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
            errorProvider1.SetError(cbocproveedor, "");
            errorProvider1.SetError(txtventa, "");
            errorProvider1.SetError(txtcolor, "");

        }
        public void limpiar_campos() {
            txtproductocodigo.Clear();
            cboxcat.Text = "";
            txtnombreproducto.Clear();
            cboxmarca.Text = "";
            cboxmodelo.Text = "";
            txtdescripcion.Clear();
            txtcolor.Clear();
            numericUpDown2.Value =0;
            cboxest.Text = "";
            txtpreciocompra.Clear();
            txtventa.Clear();
            cbocproveedor.Text = "";



        }
        private void iconButton1_Click(object sender, EventArgs e)
        {
            limpiar_campos();
        }
        private bool ValidarCampos()
        {
            bool ok = true;

         

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
            if (cbocproveedor.Text == "")
            {
                ok = false;
                errorProvider1.SetError(cbocproveedor, "ingresar la descripcion del producto ");
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

        public void cargarDatosIniciales()
        {

            var lista = b_provedores.buscar_Proveedorcombo();
            cbocproveedor.DataSource = lista;
            cbocproveedor.DisplayMember = "nombrepv";
            cbocproveedor.ValueMember = "idproveedor";

            var lista2 = b_categoria.buscar_categoriacombo();
            cboxcat.DataSource = lista2;
            cboxcat.DisplayMember = "categoria";
            cboxcat.ValueMember = "idcategoria";

            var lista3 = b_marcas.buscar_marcaccombo();
            cboxmarca.ValueMember = "idmarca";
            cboxmarca.DisplayMember = "marcaproducto";
            cboxmarca.DataSource = lista3;
        }


        private void FrmRegistrarProductos_Load(object sender, EventArgs e)
        {
            cargarDatosIniciales();
        }

        private void gbreprod_Enter(object sender, EventArgs e)
        {

        }
        public void insertar_modelo(object sender, EventArgs e)

        {
            int marca = Convert.ToInt32(cboxmarca.SelectedValue);
            if (marca > 0)
            {
                var modelos = b_modelos.cargarmodelos(marca);
                cboxmodelo.DataSource = null;
                cboxmarca.Text = "";

                if (modelos != null)
                {
                    cboxmodelo.DataSource = modelos;
                    cboxmodelo.DisplayMember = "modelo";
                    cboxmodelo.ValueMember = "idmodelo";

                    /*
                                        for (int i = 0; i < modelos.Rows.Count; i++)
                                        {
                                            cboxmodelo.Items.Add(modelos.Rows[i]["modelo"]);


                                        }*/

                    cboxmodelo.SelectedIndex = 0;
                }



            }
        }
        public void llenar_productos()
        {
            var lista = b_opeprod.buscar_Productos();
            dgvproductos.DataSource = lista;
        }

        private void mostarprodutos_Click(object sender, EventArgs e)
        {
            llenar_productos();
        }

        private void dgvproductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtproductocodigo.Text = dgvproductos.CurrentRow.Cells[0].Value.ToString();
            cboxcat.Text = dgvproductos.CurrentRow.Cells[1].Value.ToString();
            txtnombreproducto.Text = dgvproductos.CurrentRow.Cells[2].Value.ToString();
            cboxmarca.Text = dgvproductos.CurrentRow.Cells[3].Value.ToString();
            cboxmodelo.Text = dgvproductos.CurrentRow.Cells[4].Value.ToString();
            txtdescripcion.Text = dgvproductos.CurrentRow.Cells[5].Value.ToString();
            txtcolor.Text = dgvproductos.CurrentRow.Cells[6].Value.ToString();
            numericUpDown2.Value = Convert.ToInt32(dgvproductos.CurrentRow.Cells[7].Value);
            cboxest.Text = dgvproductos.CurrentRow.Cells[8].Value.ToString();
            txtpreciocompra.Text = dgvproductos.CurrentRow.Cells[9].Value.ToString();
            txtventa.Text = dgvproductos.CurrentRow.Cells[10].Value.ToString();
            cbocproveedor.Text = dgvproductos.CurrentRow.Cells[11].Value.ToString();

            btnGuardar.Enabled = false;
            btnActualizar.Enabled = true;



        }
        public void conversion_actualizar() {

            int cantidad = Convert.ToInt32(numericUpDown2.Value);
            int idprov = Convert.ToInt32(cbocproveedor.SelectedValue);
            int marca = Convert.ToInt32(cboxmarca.SelectedValue);
            int modelo = Convert.ToInt32(cboxmodelo.SelectedValue);
            int categoria = Convert.ToInt32(cboxcat.SelectedValue);
            int idproducto = Convert.ToInt32(txtproductocodigo.Text);

            b_opeprod.actualizarempleado(idproducto,txtnombreproducto.Text, txtdescripcion.Text, txtcolor.Text,
            cantidad, txtventa.Text, cboxest.Text, idprov, categoria,
            txtpreciocompra.Text, modelo, marca);


        }
        public void conversiones()
        {
            int cantidad = Convert.ToInt32(numericUpDown2.Value);
            int idprov = Convert.ToInt32(cbocproveedor.SelectedValue);
            int marca = Convert.ToInt32(cboxmarca.SelectedValue);
            int modelo = Convert.ToInt32(cboxmodelo.SelectedValue);
            int categoria = Convert.ToInt32(cboxcat.SelectedValue);

            b_opeprod.insertarproductos(txtnombreproducto.Text,txtdescripcion.Text,txtcolor.Text, 
            cantidad,txtventa.Text,cboxest.Text, idprov,categoria,
            txtpreciocompra.Text,modelo ,marca) ;

                                     




        }

        public void buscarproductosespecificos(object sender, EventArgs e)
        {
                 
            
            string nombre= txtbuscar.Text;

            if (nombre.Length > 1)

            {
                b_opeprod.buscar_productoespecific(nombre);
                dgvproductos.DataSource = nombre;
            }
            else { 
            
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            borrarmensajeerror();
            if (ValidarCampos())
            {
                conversiones();
                btnActualizar.Enabled = true;
                limpiar_campos();
              

                
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            borrarmensajeerror();
            if (ValidarCampos())
            {
                conversion_actualizar();
                btnGuardar.Enabled = true;
                btnActualizar.Enabled = false;
                limpiar_campos();


            }
        }

        private void txtbuscar_KeyPress(object sender, KeyPressEventArgs e)
        {

            
        
        }

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
            var lista = b_opeprod.buscar_productoespecific(txtbuscar.Text);
            dgvproductos.DataSource = lista;

        }
    }
}
