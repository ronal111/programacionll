using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class D_Modelo_Producto
    {

        private D_Conexion conectar = new D_Conexion();
        public int idmodelo { get; set; }
        public string modelo { get; set; }
        public int fkmarca {get; set;}


        public DataTable llenarcombo(int idmarca)
        {
            DataTable tablamodelo = new DataTable();
            try
            {
                conectar.abrir();
                string consulta = " select idmodelo,modelo from Modelo_Producto where idmarca ='" + idmarca + "'";
                SqlCommand cmd = new SqlCommand(consulta, conectar.Conectar);
                var reader = cmd.ExecuteReader();
                if (reader.HasRows == false)
                    return null;
                tablamodelo.Load(reader);
                conectar.cerrar();
            }
            catch (Exception)
            {

                throw;
            }
            return tablamodelo;

        }
        public DataTable Buscarmodelosespecifico(string marca)
        {
            DataTable tablamodelo = new DataTable();
            try
            {
                conectar.abrir();
                string consulta = " select Modelo_Producto.idmodelo,modelo , Marca_Producto.marcaproducto from Modelo_Producto join Marca_Producto on Modelo_Producto.idmarca=Marca_Producto.idmarca  where modelo  LIKE " + "'%" + marca + "%'";
                SqlCommand cmd = new SqlCommand(consulta, conectar.Conectar);
                var reader = cmd.ExecuteReader();
                if (reader.HasRows == false)
                    return null;
                tablamodelo.Load(reader);
                conectar.cerrar();
            }
            catch (Exception)
            {

                throw;
            }
            return tablamodelo;

        }
        public DataTable Buscartodomodelo ()
        {
            DataTable tablamodelo = new DataTable();
            try
            {
                conectar.abrir();
                string consulta = " select Modelo_Producto.idmodelo,modelo , Marca_Producto.marcaproducto  from Modelo_Producto join Marca_Producto on Modelo_Producto.idmarca=Marca_Producto.idmarca";
                SqlCommand cmd = new SqlCommand(consulta, conectar.Conectar);
                var reader = cmd.ExecuteReader();
                if (reader.HasRows == false)
                    return null;
                tablamodelo.Load(reader);
                conectar.cerrar();
            }
            catch (Exception)
            {

                throw;
            }
            return tablamodelo;

        }
        public bool actualizarmodelo()
        {
            bool success = false;

            try
            {

                conectar.abrir();
                string insertar = "update Modelo_Producto set modelo ='" + modelo + "',idmarca = '" + fkmarca + "' where idmodelo ='" + idmodelo + "'";
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

        public bool insertarmodelo()
        {
            bool success = false;

            try
            {

                conectar.abrir();

                string insertar = "insert into Modelo_Producto values ('" + modelo + "','" + fkmarca + "')";
                SqlCommand cmd = new SqlCommand(insertar,conectar.Conectar);
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
    }
}
