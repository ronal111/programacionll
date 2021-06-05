using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;

namespace business
{
    public class B_Operaciones_Prov
    {
        private D_Proveedor d_prov = new D_Proveedor();

        public string insertar_Proveedor(string nombrepv, string compañia, string correop, string tel, string fk_iddomicilioe)
        {

            try
            {
                d_prov.nombrepv = nombrepv;
                d_prov.compañia = nombrepv;
                d_prov.correoC = correop;
                d_prov.tel = tel;
                d_prov.fk_iddomiciliop = fk_iddomicilioe;

                if (d_prov.insertarProveedor())
                {
                    return "registro exitoso";
                }
                else
                {
                    return "error verifique los datos";
                }
            }
            catch (Exception)
            {

                throw;
            }

        }

        public string actualizar_Proveedor(int idproveedor, string nombrepv, string compañia, string correop, string tel)
        {

            try
            {
                d_prov.idproveedor = idproveedor;
                d_prov.nombrepv = nombrepv;
                d_prov.compañia = compañia;
                d_prov.correoC = correop;
                d_prov.tel = tel;



                if (d_prov.actualizarProveedor())
                {
                    return "registro exitoso";
                }
                else
                {
                    return "error verifique los datos";
                }
            }
            catch (Exception)
            {

                throw;
            }

        }

        public DataTable buscar_Proveedor()
        {
            try
            {
                return d_prov.mostrarProveedor();
            }
            catch (Exception)
            {

                throw;
            }

        }
        public DataTable buscar_Proveedorcombo()
        {
            try
            {
                return d_prov.cargarcomboboxproveedor();
            }
            catch (Exception)
            {

                throw;
            }

        }



        public DataTable buscar_Proveedorespecifico(string nombrep)
        {
            try
            {
                return d_prov.mostrarProveedorespecifico(nombrep);
            }
            catch (Exception)
            {

                throw;
            }














        }
    }
}
