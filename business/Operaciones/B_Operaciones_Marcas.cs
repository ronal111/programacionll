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



        public DataTable buscar_marca()
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

        public string insertarmarca(string marca)
        {

            try
            {
                D_Marca_Producto.marcaproducto = marca;




                if (D_Marca_Producto.insertarMarca())
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

        public string actualizarmarca(int idmarca, string marca)
        {

            try
            {
                D_Marca_Producto.idmarca_producto = idmarca;
                D_Marca_Producto.marcaproducto = marca;
           


                if (D_Marca_Producto.actualizarmarca())
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

        public DataTable buscarmarcaespecifica(string marca)
        {
            try
            {

                return D_Marca_Producto.mostrarMarcaEspecifica(marca);
            }
            catch (Exception)
            {

                throw;
            }

        }



    }
}
