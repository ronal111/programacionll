using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class D_Venta_Producto
    {
        private D_Conexion conectar = new D_Conexion();
        public int idventa { get; set; }
        public int idprodcuto { get; set; }

        public DataTable buscarproductosespecificos(string busqueda)
        {
            DataTable tablaProductos = new DataTable();
            try
            {
                conectar.abrir();
                string consulta = "select idproducto, nombrep from productos where nombrep  LIKE " + "'%" + busqueda + "%' or idproducto LIKE " + "'%" + busqueda + "%'";
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
        public DataTable Agregar(string producto)
        {
            DataTable tablaProductos = new DataTable();
            try { conectar.abrir();
                string consulta = "select productos.* from productos where idproducto = '" + producto + "'";
                SqlCommand cmd = new SqlCommand(consulta, conectar.Conectar);
                var reader = cmd.ExecuteReader();
                if (reader.HasRows == false)
                    return null;
                tablaProductos.Load(reader);
                conectar.cerrar();
            } catch(Exception) { throw; }
            return tablaProductos;
        }

        public bool RegistrarVenta(string detalle,double subtotal, double total)
        {
          //  string fecha = DateTime.Now.ToString();
            
            try
            {
                conectar.abrir();
                string consulta = "RegistrarVenta";
                SqlCommand cmd = new SqlCommand(consulta, conectar.Conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@detalle", detalle);
                cmd.Parameters.AddWithValue("@subtotal", subtotal);
                cmd.Parameters.AddWithValue("@total", total);
                var reader = cmd.ExecuteNonQuery();                    
                conectar.cerrar();
                return true;
            }
            catch (Exception) { return false;  }
           
        }

    }
}
