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
                return d_Categoria.mostaracategorias();
            }
            catch (Exception)
            {

                throw;
            }

        }


        public string insertarCategoria(string categoria)
        {

            try
            {
                d_Categoria.categoria = categoria;




                if (d_Categoria.insertarcategoria())
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


        public string actualizarcategoria(int idcategoria, string categoria)
        {

            try
            {
                d_Categoria.idcategoria = idcategoria;
                d_Categoria.categoria = categoria;


                if (d_Categoria.actualizarcategoria())
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

        public DataTable buscarCategoriaEspecifica(string categoria)
        {
            try
            {

                return d_Categoria.mostrarCategoriaEspecifica(categoria);
            }
            catch (Exception)
            {

                throw;
            }

        }
    }



}

