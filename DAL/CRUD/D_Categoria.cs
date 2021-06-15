using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class D_Categoria
    {
        private D_Conexion conectar = new D_Conexion();
        public int idcategoria { get; set; }
        public string categoria { get; set; }

        public DataTable mostaracategorias()
        {
            DataTable tablacategoria = new DataTable();
            try
            {
                conectar.abrir();
                string consulta = "select categoria.* from categoria";
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
        //public bool insertarcategoria()
        //{
        //    bool success = false;

        //    try
        //    {

        //        D_Conexion.Conectar();

        //        string insertar = "insert into categoria values ('" + categoria + "')";
        //        SqlCommand cmd = new SqlCommand(insertar, D_Conexion.Conectar());
        //        var resultado = cmd.ExecuteNonQuery();
        //        if (resultado == 1)
        //            success = true;


        //    }
        //    catch (Exception)
        //    {

        //        throw;
        //    }
        //    return success;

        //}

        public bool actualizarcategoria()
        {
            bool success = false;

            try
            {

                conectar.abrir();
                string insertar = "update categoria set categoria='" + categoria + "'  where idcategoria='" + idcategoria + "'";
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

        public DataTable mostrarCategoriaEspecifica(string categoria)
        {
            DataTable tablaempleado = new DataTable();
            try
            {
                conectar.abrir();
                string consulta = "select categoria.* from categoria where categoria  LIKE " + "'%" + categoria + "%'";
                SqlCommand cmd = new SqlCommand(consulta, conectar.Conectar);
                var reader = cmd.ExecuteReader();
                if (reader.HasRows == false)
                    return null;
                tablaempleado.Load(reader);
                conectar.cerrar();
            }
            catch (Exception)
            {

                throw;
            }
            return tablaempleado;

        }


        public bool insertarcategoria()
        {
            bool success = false;

            try
            {
                conectar.abrir();            
                var cmd = new SqlCommand("sp_categoria", conectar.Conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@categoria",categoria);
               
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
