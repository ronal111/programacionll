using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;


namespace business
{

   public  class B_Operaciones_Empleados
    {
    
        public D_Empleados dempleado = new DAL.D_Empleados();
       
        public string insertarempleado(string idrfc,string nombree, string apellido, string numerotel,string  edad, string puesto, string sueldo, string fk_iddomicilioe)
        {

            try
            {
                dempleado.idrfc = idrfc;
                dempleado.nombree = nombree;
                dempleado.apellido = apellido;
                dempleado.numerotel = numerotel;
                dempleado.edad = edad;
                dempleado.puesto = puesto;
                dempleado.sueldo = sueldo;
                dempleado.fk_iddomicilioe = fk_iddomicilioe;

                if (dempleado.insertar())
                {
                    return "registro exitoso";
                }
                else
                {
                    return "error verifique los datos";
                }
            }
            catch (Exception)
            {

                throw;
            }

        }
        public string actualizarempleado(string idrfc, string nombree, string apellido, string numerotel, string edad, string puesto, string sueldo)
        {

            try
            {
                dempleado.idrfc = idrfc;
                dempleado.nombree = nombree;
                dempleado.apellido = apellido;
                dempleado.numerotel = numerotel;
                dempleado.edad = edad;
                dempleado.puesto = puesto;
                dempleado.sueldo = sueldo;
                

                if (dempleado.actualizarempleado())
                {
                    return "registro exitoso";
                }
                else
                {
                    return "error verifique los datos";
                }
            }
            catch (Exception)
            {

                throw;
            }

        }

        public DataTable buscarempleadoespecifico(string nombre) {
            try
            {

                return dempleado.mostrarempleadosespecifico(nombre);
            }
            catch (Exception)
            {

                throw;
            }
        
        }
        public DataTable buscarEmpleado()
        {
            try
            {
                return dempleado.mostrarempleados();
            }
            catch (Exception)
            {

                throw;
            }

        }


    }
}
