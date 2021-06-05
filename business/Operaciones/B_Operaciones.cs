using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;

namespace business
{
    public class B_Operaciones
    {
        D_Domicilio ddomicilio = new D_Domicilio();
    
        public string insertarDomicilio (string numero, string  numero_int, string calle, string cp, string colonia, string municipio, string estado) {

            try
            {
              
                ddomicilio.numero = numero;
                ddomicilio.numero_int = numero_int;
                ddomicilio.calle = calle;
                ddomicilio.cp = cp;
                ddomicilio.colonia = colonia;
                ddomicilio.municipio = municipio;
                ddomicilio.estado = estado;

                if (ddomicilio.insertar())
                {
                    return ddomicilio.iddomicilio;
                }
                else
                {
                    return "error";
                }
            }
            catch (Exception)
            {
                
                throw;
            }
        
        }
       
        public DataTable cargarcalle(string cp)
        {
            try
            {
               return ddomicilio.BuscarCP(cp);
            }
            catch (Exception )
            {

                throw;
            }

        }

        public string actualizar_Domicilio (string iddomicilio, string numero, string numero_int, string calle, string cp, string colonia, string municipio, string estado) 
        {
            try
            {
                ddomicilio.iddomicilio =iddomicilio;
                ddomicilio.numero = numero;
                ddomicilio.numero_int = numero_int;
                ddomicilio.calle = calle;
                ddomicilio.cp = cp;
                ddomicilio.colonia = colonia;
                ddomicilio.municipio = municipio;
                ddomicilio.estado = estado;
                if (ddomicilio.actualizardomicilio())
                    return "actualizacion correcta";
                else return "fallo actualizacion";
            }
            catch (Exception)
            {

                throw;
            }
        }




    }
}
