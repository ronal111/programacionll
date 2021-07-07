using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;
using System.Collections;

namespace business.Operaciones
{
   
    public class B_Operaciones_Ventas
    {
        D_Venta_Producto dventa = new D_Venta_Producto();
        
        public DataTable buscar_productoespecific(string busqueda)
        {
            try
            {
                return dventa.buscarproductosespecificos(busqueda);
            }
            catch (Exception)
            {

                throw;
            }

        }
        public DataTable Agregar(string producto)
        {
            DataTable tabla;
            try
            {
                tabla =  dventa.Agregar(producto);
            }
            catch (Exception e)
            {

                tabla = null;
            }

            return tabla;
        }
        public bool RegistrarVenta(string detalle, double subtotal, double total)
        {
            return dventa.RegistrarVenta(detalle, subtotal, total);
        }
    }

}
