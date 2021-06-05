using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;

namespace business
{
    public class B_Operaciones_Categoria
    {
        D_Categoria d_Categoria = new D_Categoria();
        public DataTable buscar_categoriacombo()
        {
            try
            {
                return d_Categoria.cargarcomboboxcategoria();
            }
            catch (Exception)
            {

                throw;
            }

        }


    }
}
