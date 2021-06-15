using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace DAL
{

    public class D_Conexion
    {
        
        //Cadena de Conexion
        private readonly string cadena = "data source=DESKTOP-4DL7T3L\\SQLEXPRESS;initial catalog=tiendaelectronica;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework";

        public SqlConnection Conectar = new SqlConnection();

        //Constructor
        public D_Conexion()
        {
            Conectar.ConnectionString = cadena;
        }

        //Metodo para abrir la conexion
        public void abrir()
        {
            try
            {
                Conectar.Open();
                Console.WriteLine("Conexion abierta");
            }
            catch (Exception ex)
            {
                Console.WriteLine("error al abrir BD " + ex.Message);
            }
        }

        //Metodo para cerrar la conexion
        public void cerrar()
        {
            Conectar.Close();
        }


    }
}
    
