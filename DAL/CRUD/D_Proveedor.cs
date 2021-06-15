﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace DAL
{
   public  class D_Proveedor
    {
        private D_Conexion conectar = new D_Conexion();
        public int idproveedor { get; set; }
        public string nombrepv { get; set; }
        public string compañia { get; set; }
        public string correoC { get; set; }
        public string tel { get; set; }
        public string fk_iddomiciliop { get; set; }

        public bool insertarProveedor()
        {
            bool success = false;

            try
            {

                conectar.abrir();

                string insertar = "insert into Empleados values ('" + idproveedor + "','" + nombrepv + "','" + compañia + "','" + correoC +
                    "','" + tel + "','" + fk_iddomiciliop + "')";
                SqlCommand cmd = new SqlCommand(insertar, conectar.Conectar);
                var resultado = cmd.ExecuteNonQuery();
                if (resultado == 1)
                    success = true;
                conectar.cerrar();


            }
            catch (Exception)
            {

                throw;
            }
            return success;

        }
       
        public DataTable mostrarProveedor()
        {
            DataTable tablaPreovedor = new DataTable();
            try
            {
                conectar.abrir();
                string consulta = "select Proveedor.idproveedor,nombrepv,compañia,correop,tel, Domicilio.iddomicilio,calle,numero,numero_int,cp,colonia,municipio,estado from Proveedor join Domicilio on Proveedor.fk_iddomiciliop= Domicilio.iddomicilio;";
                SqlCommand cmd = new SqlCommand(consulta, conectar.Conectar);
                var reader = cmd.ExecuteReader();
                if (reader.HasRows == false)
                    return null;
                tablaPreovedor.Load(reader);
                conectar.cerrar();
            }
            catch (Exception)
            {

                throw;
            }
            return tablaPreovedor;

        }

        public bool actualizarProveedor()
        {
            bool success = false;

            try
            {

                conectar.abrir();

                string insertar = "update Proveedor set nombrepv='" + nombrepv + "',compañia='" + compañia + "',correop='" + correoC + "',tel='" + tel + "' where idproveedor='" + idproveedor + "'";
                SqlCommand cmd = new SqlCommand(insertar, conectar.Conectar);
                var resultado = cmd.ExecuteNonQuery();
                if (resultado == 1)
                    success = true;
                conectar.cerrar();
            }
            catch (Exception)
            {

                throw;
            }
            return success;
        }

        public DataTable cargarcomboboxproveedor()
        {
            DataTable tablaPreovedor = new DataTable();
            try
            {
                conectar.abrir();
                string consulta = "select idproveedor,nombrepv from Proveedor";
                SqlCommand cmd = new SqlCommand(consulta, conectar.Conectar);
                var reader = cmd.ExecuteReader();
                if (reader.HasRows == false)
                    return null;
                tablaPreovedor.Load(reader);
                conectar.cerrar();
            }
            catch (Exception)
            {

                throw;
            }
            return tablaPreovedor;

        }

        public DataTable mostrarProveedorespecifico(string nombrep)
        {
            DataTable tablaPreovedor = new DataTable();
            try
            {
                conectar.abrir();
                string consulta = "select Proveedor.idproveedor,nombrepv,compañia,correop,tel, Domicilio.iddomicilio,calle,numero,numero_int,cp,colonia,municipio,estado from Proveedor join Domicilio on Proveedor.fk_iddomiciliop= Domicilio.iddomicilio where nombrepv  LIKE " + "'%" + nombrep + "%'";
                SqlCommand cmd = new SqlCommand(consulta, conectar.Conectar);
                var reader = cmd.ExecuteReader();
                if (reader.HasRows == false)
                    return null;
                tablaPreovedor.Load(reader);
                conectar.cerrar();
            }
            catch (Exception)
            {

                throw;
            }
            return tablaPreovedor;

        }





    }
}
