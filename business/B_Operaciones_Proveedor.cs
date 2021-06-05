using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;
namespace business
{
    public class B_Operaciones_Proveedor
    {
        public D_Proveedor opprov = new D_Proveedor();

        public string insertarempleado(string nombrepv, string compañia, string correop, string tel,string fk_iddomiciliop)
        {

            try
            {
                opprov.nombrepv = nombrepv;
                opprov.compañia = compañia;
                opprov.correoC = correop;
                opprov.tel = tel;
                opprov.fk_iddomiciliop = fk_iddomiciliop;



                if (opprov.insertarProveedor())
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
