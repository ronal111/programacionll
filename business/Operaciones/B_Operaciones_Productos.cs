using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;
namespace business
{
    public class B_Operaciones_Productos
    {
        D_Productos d_prodcto = new D_Productos();
        D_Proveedor D_Proveedor = new D_Proveedor();


        public DataTable buscar_Proveedor()
        {
            try
            {
                return D_Proveedor.cargarcomboboxproveedor();
            }
            catch (Exception)
            {

                throw;
            }

        }
        public DataTable buscar_Productos()
        {
            try
            {
                return d_prodcto.mostrarProductos();
            }
            catch (Exception)
            {

                throw;
            }

        }

        public string insertarproductos(string nombre, string descripcion, string color, int cantidad, string venta, string estado, int fk_idproveedor, int fk_idcategoria, string compra, int fk_idmodelo, int fk_idmarca) {

            try
            {
                d_prodcto.nombreP = nombre;
                d_prodcto.descripcionP = descripcion;
                d_prodcto.color = color;
                d_prodcto.cantidadp = cantidad;
                d_prodcto.pventa = venta;
                d_prodcto.estado = estado;
                d_prodcto.fk_idproveedor = fk_idproveedor;
                d_prodcto.fk_categoria = fk_idcategoria;
                d_prodcto.preciocompra = compra;
                d_prodcto.fk_idmodelo = fk_idmodelo;
                d_prodcto.fk_idmarca = fk_idmarca;
                if (d_prodcto.insertar_productos())
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
       
        public string actualizarempleado(int idproducto,string nombre, string descripcion, string color, int cantidad, string venta, string estado, int fk_idproveedor, int fk_idcategoria, string compra, int fk_idmodelo, int fk_idmarca)
        {

            try
            {
                d_prodcto.idproducto = idproducto;
                d_prodcto.nombreP = nombre;
                d_prodcto.descripcionP = descripcion;
                d_prodcto.color = color;
                d_prodcto.cantidadp = cantidad;
                d_prodcto.pventa = venta;
                d_prodcto.estado = estado;
                d_prodcto.fk_idproveedor = fk_idproveedor;
                d_prodcto.fk_categoria = fk_idcategoria;
                d_prodcto.preciocompra = compra;
                d_prodcto.fk_idmodelo = fk_idmodelo;
                d_prodcto.fk_idmarca = fk_idmarca;


                if (d_prodcto.actualizarProducto())
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

        public DataTable buscar_productoespecific(string nombre)
        {
            try
            {
                return d_prodcto.buscarproductosespecificos(nombre);
            }
            catch (Exception)
            {

                throw;
            }

        }




    }
	}







    

