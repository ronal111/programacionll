using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace proyectop2
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
            InicializarMenu();
        }
        #region pantalla

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        
        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        #endregion

        #region Metodos de inicializacion
        private void InicializarMenu()
        {
            submenuempleados.Visible = false;
            submenuproductos.Visible = false;
            submenuproveedor.Visible = false;
            submenureportes.Visible = false;
            pbxRestaurar.Visible = false;
        }
        #endregion

        #region Metodos para ocultar y mostrar 


        private void OcultarSubMenu()
        {
            if (submenuempleados.Visible == true)
            {
                submenuempleados.Visible = false;
            }
            if (submenuproductos.Visible == true)
            {
                submenuproductos.Visible = false;
            }
            if (submenuproveedor.Visible == true)
            {
                submenuproveedor.Visible = false;
            }
            if (submenureportes.Visible == true)
            {
                submenureportes.Visible = false;
            }
        }

        private void OcultarMostrarSubmenu(Panel Submenu)
        {
            if (Submenu.Visible == false)
            {
                OcultarSubMenu();
                Submenu.Visible = true;
            }
            else
            {
                Submenu.Visible = false;
            }
        }
        #endregion
        public void abrirformuhijo(object formulariohijo)
        {
            if (this.panelcontenedor2.Controls.Count > 0)
                this.panelcontenedor2.Controls.RemoveAt(0);
            Form frmhija= formulariohijo as Form;
            frmhija.TopLevel = false;
            frmhija.Dock = DockStyle.Fill;
            this.panelcontenedor2.Controls.Add(frmhija);
            this.panelcontenedor2.Tag = frmhija;
            frmhija.Show();

        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ibtnproductos_Click(object sender, EventArgs e)
        {
            OcultarMostrarSubmenu(submenuproductos);
        }

        private void ibtnEmpleados_Click(object sender, EventArgs e)
        {
            OcultarMostrarSubmenu(submenuempleados);
        }

        private void ibtnProveedores_Click(object sender, EventArgs e)
        {
            OcultarMostrarSubmenu(submenuproveedor);
        }

        private void ibtnReportes_Click(object sender, EventArgs e)
        {
            OcultarMostrarSubmenu(submenureportes);
        }

        private void pbxCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pbxMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            
            pbxRestaurar.Visible = true;
            pbxMaximizar.Visible = false;
        }

        private void pbxRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            pbxMaximizar.Visible = true;
            pbxRestaurar.Visible = false;
        }

        private void pbxMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            abrirformuhijo(new FrmBuscarProducto());
        }

        private void panelcontenedor2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void iconButton6_Click(object sender, EventArgs e)
        {
            abrirformuhijo(new FrmBuscarEmpleado());
        }

        private void ibtnaddproductos_Click(object sender, EventArgs e)
        {
            abrirformuhijo(new FrmRegistrarProductos());
        }

        private void formmenu_Load(object sender, EventArgs e)
        {

        }
        private void ibtnaddempleados_Click(object sender, EventArgs e)
        {
            abrirformuhijo(new FrmRegistrarEmpleado());
        }

        private void ibtnaddproveedor_Click(object sender, EventArgs e)
        {
            abrirformuhijo(new FrmBuscarProveedor());
        }

        private void iconButton8_Click(object sender, EventArgs e)
        {
            abrirformuhijo(new FrmRegistrarProveedor());
        }

        private void ibtnventas_Click(object sender, EventArgs e)
        {
            abrirformuhijo(new FrmVentas());
        }

        private void ibtnrepvd_Click(object sender, EventArgs e)
        {
            abrirformuhijo(new FrmReporteVentas());
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            abrirformuhijo(new FrmReporteCompra());
        }

        private void iconButton2_Click_1(object sender, EventArgs e)
        {
            abrirformuhijo(new FrmReporteProductoMasVendido());
        }
    } }