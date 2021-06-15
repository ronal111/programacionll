using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class D_Productos
    {
        private D_Conexion conectar = new D_Conexion();
        public int idproducto { get; set; }
        public string nombreP { get; set; }
        public string descripcionP { get; set; }
        public string color { get; set; }
        public int cantidadp { get; set; }
        public string pventa { get; set; }
        public string estado { get; set; }
        public int fk_idproveedor { get; set; }
        public int fk_categoria { get; set; }
        public string preciocompra { get; set; }
        public int fk_idmodelo { get; set; }
        public int fk_idmarca{ get; set; }

        public DataTable mostrarProductos()
        {
            DataTable tablaProductos = new DataTable();
            try
            {
                conectar.abrir();
                
                string consulta = "select idproducto,Categoria.Categoria,nombreP,Marca_Producto.marcaproducto,Modelo_Producto.modelo,descripcionP,colorp,cantidadp,estado,preciocompra,pventa,Proveedor.nombrepv from Productos join Categoria on Productos.fk_categoria = Categoria.idcategoria join Marca_Producto on Productos.fk_idmarca = Marca_Producto.idmarca join Modelo_Producto on Productos.fk_idmodelo = Modelo_Producto.idmodelo join Proveedor on Productos.fk_idproveedor = Proveedor.idproveedor; ";
                SqlCommand cmd = new SqlCommand(consulta, conectar.Conectar);
                var reader = cmd.ExecuteReader();
                if (reader.HasRows == false)
                    return null;
                tablaProductos.Load(reader);
                conectar.cerrar();
            }
            catch (Exception)
            {

                throw; 
                
            }
            return tablaProductos;
           

        }
        public bool insertar_productos()
        {
            bool success = false;

            try
            {

                conectar.abrir();

                string insertar = "insert into productos values ('" + nombreP + "','" + descripcionP + "','" + color + "','" + cantidadp +
                    "','" + pventa + "','" + estado + "','" + fk_idproveedor + "','" + fk_categoria + "','" + preciocompra + "','" + fk_idmodelo+ "','" + fk_idmarca  + "')";
                SqlCommand cmd = new SqlCommand(insertar, conectar.Conectar);
                var resultado = cmd.ExecuteNonQuery();
                if (resultado == 1)
                    success = true;
                conectar.cerrar();

            }
            catch (Exception)
            {

                throw;
            }
            return success;

        }
        public void borrar()
        {

        }

        public bool actualizarProducto()
        {
            bool success = false;

            try
            {

                conectar.abrir();

                string insertar = "update Productos set nombreP='" + nombreP + "',descripcionP='" + descripcionP + "',colorp='" + color + "',cantidadp='" + cantidadp + "',pventa='" + pventa+
                       "',estado='" + estado + "',fk_idproveedor='" + fk_idproveedor + "',fk_categoria='" + fk_categoria + 
                    "',preciocompra='" + preciocompra + "',fk_idmodelo='" + fk_idmodelo + "',fk_idmarca='" + fk_idmarca + "'  where idproducto='" + idproducto + "'";
                SqlCommand cmd = new SqlCommand(insertar, conectar.Conectar);
                var resultado = cmd.ExecuteNonQuery();
                if (resultado == 1)
                    success = true;
                conectar.cerrar();
            }
            catch (Exception)
            {

                throw;
            }
            return success;
        }


        public DataTable buscarproductosespecificos(string nombre)
        {
            DataTable tablaProductos = new DataTable();
            try
            {
                conectar.abrir();
                string consulta = "select idproducto,Categoria.Categoria,nombreP,Marca_Producto.marcaproducto,Modelo_Producto.modelo,descripcionP,colorp,cantidadp,estado,preciocompra,pventa,Proveedor.nombrepv from Productos join Categoria on Productos.fk_categoria = Categoria.idcategoria join Marca_Producto on Productos.fk_idmarca = Marca_Producto.idmarca join Modelo_Producto on Productos.fk_idmodelo = Modelo_Producto.idmodelo join Proveedor on Productos.fk_idproveedor = Proveedor.idproveedor where nombrep  LIKE " + "'%" + nombre + "%'" ;
                SqlCommand cmd = new SqlCommand(consulta, conectar.Conectar);
                var reader = cmd.ExecuteReader();
                if (reader.HasRows == false)
                    return null;
                tablaProductos.Load(reader);
                conectar.cerrar();
            }
            catch (Exception)
            {

                throw;
            }
            return tablaProductos;

        }


    }
}
