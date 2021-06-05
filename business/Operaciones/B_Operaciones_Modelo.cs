using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;

namespace business.Operaciones
{
    public class B_Operaciones_Modelo
    {
        D_Modelo_Producto d_modelo_p = new D_Modelo_Producto();

        public DataTable cargarmodelos (int idmarca)
        {
            try
            {
                return d_modelo_p.Buscarmodelos(idmarca);
            }
            catch (Exception)
            {

                throw;
            }

        }



    }
}
