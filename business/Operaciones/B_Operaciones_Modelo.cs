using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;

namespace business.Operaciones
{
    public class B_Operaciones_Modelo
    {
        D_Modelo_Producto d_modelo_p = new D_Modelo_Producto();

        public DataTable llenarcombo(int idmarca)
        {
            try
            {
                return d_modelo_p.llenarcombo(idmarca);
            }
            catch (Exception)
            {

                throw;
            }
        }

                public DataTable buscarmodeloespecifico (string modelo)
        {
            try
            {
                return d_modelo_p.Buscarmodelosespecifico(modelo);
            }
            catch (Exception)
            {

                throw;
            }

        }

        public DataTable buscar_modelo()
        {
            try
            {
                return d_modelo_p.Buscartodomodelo();
            }
            catch (Exception)
            {

                throw;
            }
        }
        public string insertarmodelo(string modelo, int idmarca)
        {

            try
            {
                d_modelo_p.modelo = modelo;
                d_modelo_p.fkmarca = idmarca;




                if (d_modelo_p.insertarmodelo())
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

        public string actualizarmodelo(int idmodelo, string modelo, int idmarca)
        {

            try
            {
                d_modelo_p.idmodelo = idmodelo;
                d_modelo_p.modelo = modelo;
                d_modelo_p.fkmarca = idmarca;



                if (d_modelo_p.insertarmodelo())
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

    }
}
