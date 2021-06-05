
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace DAL
{
    public class D_Domicilio
    {


        public string iddomicilio { get; set; }
        public string numero { get; set; }
        public string numero_int { get; set; }
        public string calle { get; set; }
        public string cp { get; set; }
        public string colonia { get; set; }
        public string municipio { get; set; }
        public string estado { get; set; }

        public bool insertar()
        { bool success = false;

            try
            {

                D_Conexion.Conectar();
                string insertar = string.Format("insert into Domicilio(numero,numero_int,calle,cp,colonia,municipio,estado) values('{0}','{1}','{2}','{3}','{4}','{5}','{6}')",
                    numero, numero_int, calle, cp, colonia, municipio, estado);
                
                SqlCommand cmd = new SqlCommand(insertar, D_Conexion.Conectar());
                var resultado = cmd.ExecuteNonQuery();
                if (resultado == 1)
                    success = true;
                insertar = "select max(iddomicilio) as ultimo_id from Domicilio";
                cmd = new SqlCommand(insertar, D_Conexion.Conectar());
                var reader = cmd.ExecuteReader();
                reader.Read();
                 iddomicilio = reader.GetValue(0).ToString();


            }
            catch (Exception e)
            {

                throw;
            }
          
            return success;

        }
    
        public DataTable BuscarCP(string cp)
        {
            DataTable tablacalle = new DataTable();
            try
            {
                string consulta = "select * from codigos_postales where cp =" + cp;
                SqlCommand cmd = new SqlCommand(consulta, D_Conexion.Conectar());
                var reader = cmd.ExecuteReader();
                if (reader.HasRows == false)
                    return null;
                tablacalle.Load(reader);
            }
            catch (Exception)
            {

                throw;
            }
            return tablacalle;
              
        }
        public void borrar()
        {

        }
        public bool actualizardomicilio()
        {
            bool success = false;
         

            try
            {

                D_Conexion.Conectar();
                string insertar = "update Domicilio set numero='"+numero+"',numero_int='"+numero_int+"',calle='"+calle+"',cp='"+cp+"',colonia='"+colonia+"',municipio='"+municipio+"',estado='"+estado+"' where iddomicilio='" + iddomicilio+"'";
                SqlCommand cmd = new SqlCommand(insertar, D_Conexion.Conectar());
                var resultado = cmd.ExecuteNonQuery();
                if (resultado == 1)
                    success = true;
            }
            catch (Exception)
            {

                throw;
            }
            return success;
        }

    }
}
