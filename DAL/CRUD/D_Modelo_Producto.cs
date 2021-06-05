using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
   public  class D_Modelo_Producto
    {
        public int idmodelo { get; set; }
        public string modelo { get; set; }
        public DataTable Buscarmodelos(int idmarca)
        {
            DataTable tablamodelo = new DataTable();
            try
            {
                string consulta = "select idmodelo, modelo from Modelo_Producto where idmarca=" + idmarca;
                SqlCommand cmd = new SqlCommand(consulta, D_Conexion.Conectar());
                var reader = cmd.ExecuteReader();
                if (reader.HasRows == false)
                    return null;
                tablamodelo.Load(reader);
            }
            catch (Exception)
            {

                throw;
            }
            return tablamodelo;

        }


        public void insertar()
        {

        }
        public void mostrar()
        {

        }
        public void borrar()
        {

        }

        public void actualizar()
        {

        }
    }
}
