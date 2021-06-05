using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class D_Empleados
    {
        public string idrfc { get; set; }
        public string nombree { get; set; }
        public string apellido { get; set; }
        public string numerotel { get; set; }
        public string edad { get; set; }
        public string puesto { get; set; }
        public string sueldo { get; set; }
        public string fk_iddomicilioe { get; set; }

        public bool insertar() 
        {
            bool success = false;

            try
            {

                D_Conexion.Conectar();
                
                string insertar = "insert into Empleados values ('" + idrfc + "','" + nombree + "','" + apellido + "','" + numerotel +
                    "','" + edad + "','" + puesto + "','" + sueldo + "','" + fk_iddomicilioe + "')";
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
        public DataTable mostrarempleados()
        {
            DataTable tablaempleado = new DataTable();
            try
            {
                string consulta = "select Empleados.idrfc,nombree,apellido,numerotel,edad,puesto,sueldo, Domicilio.iddomicilio,calle,numero,numero_int,cp,colonia,municipio,estado from Empleados join Domicilio on Empleados.fk_iddomicilioe = Domicilio.iddomicilio ";
                SqlCommand cmd = new SqlCommand(consulta, D_Conexion.Conectar());
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
       
        public bool actualizarempleado () 
        {
            bool success = false;

            try
            {

                D_Conexion.Conectar();

                string insertar = "update Empleados set nombree='"+nombree+"',apellido='"+apellido+"',numerotel='"+numerotel+"',edad='"+edad+"', puesto='"+puesto+"' where idrfc='"+ idrfc + "'";
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

        public DataTable mostrarempleadosespecifico(string nombre)
        {
            DataTable tablaempleado = new DataTable();
            try
            {
                string consulta = "select Empleados.idrfc,nombree,apellido,numerotel,edad,puesto,sueldo, Domicilio.iddomicilio,calle,numero,numero_int,cp,colonia,municipio,estado from Empleados join Domicilio on Empleados.fk_iddomicilioe = Domicilio.iddomicilio where nombree  LIKE " + "'%" + nombre + "%'";
                SqlCommand cmd = new SqlCommand(consulta, D_Conexion.Conectar());
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
