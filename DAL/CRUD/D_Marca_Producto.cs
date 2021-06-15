using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace DAL
{
    public class D_Marca_Producto
    {
        D_Conexion conectar = new D_Conexion();
        public int idmarca_producto { get; set; }
        public string marcaproducto { get; set; }

        public int fk_idmodelo { get; set; }

        public DataTable cargarcomboboxMarca()
        {
            DataTable tablamarca= new DataTable();
            try
            {
                conectar.abrir();                
                string consulta = "select Marca_Producto.* from Marca_Producto;";
                SqlCommand cmd = new SqlCommand(consulta, conectar.Conectar);
                var reader = cmd.ExecuteReader();
                if (reader.HasRows == false)
                    return null;
                tablamarca.Load(reader);
                conectar.cerrar();
            }
            catch (Exception)
            {

                throw;
            }
            return tablamarca;

        }
        public DataTable mostaracategorias()
        {
            DataTable tablacategoria = new DataTable();
            try
            {
                conectar.abrir();
                string consulta = "select Marca_Producto.* from Marca_Producto;";
                SqlCommand cmd = new SqlCommand(consulta, conectar.Conectar);
                var reader = cmd.ExecuteReader();
                if (reader.HasRows == false)
                    return null;
                tablacategoria.Load(reader);
                conectar.cerrar();
            }
            catch (Exception)
            {

                throw;
            }
            return tablacategoria;

        }
        public bool insertarMarca()
        {
            bool success = false;

            try
            {

                conectar.abrir();
                string insertar = "insert into Marca_Producto values ('" + marcaproducto + "')";
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

        public bool actualizarmarca()
        {
            bool success = false;

            try
            {
                conectar.abrir();

                string insertar = "update Marca_Producto set marcaproducto='" + marcaproducto + "'  where idmarca='" + idmarca_producto + "'";
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

        public DataTable mostrarMarcaEspecifica(string marca)
        {
            DataTable tablaempleado = new DataTable();
            try
            {
                conectar.abrir();
                string consulta = "select Marca_Producto.* from Marca_Producto where marcaproducto  LIKE " + "'%" + marca + "%'";
                SqlCommand cmd = new SqlCommand(consulta, conectar.Conectar);
                var reader = cmd.ExecuteReader();
                if (reader.HasRows == false)
                    return null;
                tablaempleado.Load(reader);
            }
            catch (Exception)
            {

                throw;
            }
            return tablaempleado;

        }




    }
}
