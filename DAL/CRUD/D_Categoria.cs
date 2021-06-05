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
        public int idcategoria { get; set; }
        public string categoria { get; set; }

        public DataTable cargarcomboboxcategoria()
        {
            DataTable tablacategoria = new DataTable();
            try
            {
                string consulta = "select categoria.* from categoria";
                SqlCommand cmd = new SqlCommand(consulta, D_Conexion.Conectar());
                var reader = cmd.ExecuteReader();
                if (reader.HasRows == false)
                    return null;
                tablacategoria.Load(reader);
            }
            catch (Exception)
            {

                throw;
            }
            return tablacategoria;

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
