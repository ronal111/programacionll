using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace proyectop2
{
    class conexion
    {
                public static SqlConnection Conectar()
        {

            SqlConnection cn = new SqlConnection("data source=DESKTOP-4DL7T3L\\SQLEXPRESS;initial catalog=tiendaelectronica;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework");
            cn.Open();

            return cn;
        }
    }
}
