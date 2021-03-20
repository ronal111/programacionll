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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void abrirformuhijo(object formulariohijo) {
            if (this.panelcontenedor.Controls.Count > 0)
                this.panelcontenedor.Controls.RemoveAt(0);
            Form fh = formulariohijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelcontenedor.Controls.Add(fh);
            this.panelcontenedor.Tag = fh;
            fh.Show();
        
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
           
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            pictureBox2.Visible = false;
            btnrestaurar.Visible = true;
        }

        private void btnrestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            pictureBox2.Visible = true;
            btnrestaurar.Visible = false;

        }

        private void btnmini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void productos_Click(object sender, EventArgs e)
        {
            submenuproductos.Visible = true;

            submenuventas.Visible = false;
            submenureportes.Visible = false;
        }

        private void btnreportes_Click(object sender, EventArgs e)
        {
            submenureportes.Visible = true;
            submenuproductos.Visible = false;
            submenuventas.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            submenureportes.Visible = false;
        }

        private void repcompras_Click(object sender, EventArgs e)
        {
            submenureportes.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            submenureportes.Visible = false;
        }

        private void btnventas_Click(object sender, EventArgs e)
        {
            submenureportes.Visible = false;
            submenuventas.Visible = true;
            submenuproductos.Visible = false;

        }

        private void menuvertical_Paint(object sender, PaintEventArgs e)

        {
         
        }

        private void button5_Click(object sender, EventArgs e)
        {
            submenuproductos.Visible = false;

            abrirformuhijo(new productos());
                    }

        private void button4_Click(object sender, EventArgs e)
        {
            submenuproductos.Visible = false;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            submenuproductos.Visible = false;
            abrirformuhijo(new buscarproducto());

        }

        private void button8_Click(object sender, EventArgs e)
        {
            abrirformuhijo(new ventas());
            submenuventas.Visible = false;
         
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            abrirformuhijo(new ventas());
            submenuventas.Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
           
        
        }

        private void panelcontenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Pagos_Click(object sender, EventArgs e)
        {

        }
    }
}
