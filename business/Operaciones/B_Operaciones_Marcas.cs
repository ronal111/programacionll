using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;

namespace business
{
    public class B_Operaciones_Marcas
    {
        D_Marca_Producto D_Marca_Producto = new D_Marca_Producto();



        public DataTable buscar_marcaccombo()
        {
            try
            {
                return D_Marca_Producto.cargarcomboboxMarca();
            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}
