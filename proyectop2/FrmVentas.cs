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

namespace proyectop2
{
    public partial class FrmVentas : Form
    {
        B_Operaciones_Ventas bventas = new B_Operaciones_Ventas();
        private double subtotal,total,impuesto;
        
        public FrmVentas()
        {
            InitializeComponent();
            subtotal = 0;
            total = 0;
            impuesto = 0;

        }
        public void BuscarProducto(string busqueda)
        {
            var lista = bventas.buscar_productoespecific(busqueda);
                cboxProducto.DataSource = lista;
                cboxProducto.DisplayMember = "nombrep";
                cboxProducto.ValueMember = "idproducto";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btbbuscarp_Click(object sender, EventArgs e)
        {
            txtbuscar.Clear();
        }

        private void ibtncancelar_Click(object sender, EventArgs e)
        {
            txtbuscar.Clear();
        }

        private void dgvbproductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupventa_Enter(object sender, EventArgs e)
        {

        }

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
            BuscarProducto(txtbuscar.Text);
        }

        private void ibtnvenderp_Click(object sender, EventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            // Displays the MessageBox.
            result = MessageBox.Show("Desea confirmar venta?", "Confirma", buttons);
            if (result != System.Windows.Forms.DialogResult.Yes)
                return;
                
          
            if (!(dgvbproductos.Rows.Count > 1)) { MessageBox.Show("No hay productos agregados");return; }
            DataTable dt = new DataTable();
            dt.Columns.Add("idproducto");
            dt.Columns.Add("cantidad");
            //Nuevo codigo
            string productos = "";
            string cantidades = "";
            
            foreach(DataGridViewRow fila in dgvbproductos.Rows)
            {
                DataRow row = dt.NewRow();
                if (fila.Cells[0].Value == null) break;
             
                productos += fila.Cells[0].Value.ToString() + ",";
                cantidades += fila.Cells[3].Value.ToString() + ",";
                dt.Rows.Add(row);
            }
            string detalle = productos + ";" + cantidades;
            
            

            if (!bventas.RegistrarVenta(detalle, subtotal, total)) {
                MessageBox.Show("No se pudo registrar la venta");
                }
            else { MessageBox.Show("Venta registrada correctamente!"); }

            dgvbproductos.Rows.Clear();
            lbimpuesto.Text = "0";
            lbtotal.Text = "0";
            lbsubtotal.Text = "0";
            total = 0;
            subtotal = 0;
            impuesto = 0;

        }

        private void btbbuscarp_Click_1(object sender, EventArgs e)
        {
            if (cboxProducto.Text == "") return;
            string idproducto = cboxProducto.SelectedValue.ToString();
            DataTable producto = bventas.Agregar(idproducto);
            if (producto == null) { MessageBox.Show("No se pudo agregar"); return; }
            int cantidad = Convert.ToInt32(numericUpDown2.Value);
            var pventa = Convert.ToDouble(producto.Rows[0]["pventa"].ToString());
           var totalIva = pventa * .16 * cantidad;
            var total = pventa * cantidad + totalIva;
            dgvbproductos.Rows.Insert(0,producto.Rows[0]["idproducto"], producto.Rows[0]["nombrep"].ToString(), producto.Rows[0]["pventa"].ToString(),numericUpDown2.Value, totalIva,total);
            this.total += total;
            this.subtotal += pventa * cantidad;
            this.impuesto += totalIva;
            lbimpuesto.Text = this.impuesto.ToString();
            lbsubtotal.Text = this.subtotal.ToString();
            lbtotal.Text = this.total.ToString();
        }

        private void quitarp_Click(object sender, EventArgs e)
        {
            try { 
               subtotal -= Convert.ToDouble(dgvbproductos.CurrentRow.Cells[2].Value) * Convert.ToDouble(dgvbproductos.CurrentRow.Cells[3].Value);
                impuesto -= Convert.ToDouble(dgvbproductos.CurrentRow.Cells[4].Value);
                total -= Convert.ToDouble(dgvbproductos.CurrentRow.Cells[5].Value);
                dgvbproductos.Rows.Remove(dgvbproductos.CurrentRow);
                lbimpuesto.Text = this.impuesto.ToString();
                lbsubtotal.Text = this.subtotal.ToString();
                lbtotal.Text = this.total.ToString();
            } catch (Exception ex) { MessageBox.Show("No se pudo" + ex.Message.ToString()); }

           
        }
    }
}
