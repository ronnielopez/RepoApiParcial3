using ApiParcial3.Controllers;
using ApiParcial3.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ApiParcial3.Data
{
    public class EmpleadoData
    {
        public static bool Save(EmpleadosModel oBranch)
        {

            using (SqlConnection oConnection = new SqlConnection(ConnectionController.rutaConexion))
            {
                SqlCommand cmd = new SqlCommand("createEmpleado", oConnection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombres", oBranch.nombres);
                cmd.Parameters.AddWithValue("@apellidos", oBranch.apellidos);
                cmd.Parameters.AddWithValue("@generos", oBranch.generos);
                cmd.Parameters.AddWithValue("@direccion", oBranch.direccion);
                cmd.Parameters.AddWithValue("@telefono", oBranch.telefono);
                cmd.Parameters.AddWithValue("@activo", oBranch.activo);


                try
                {
                    oConnection.Open();
                    cmd.ExecuteNonQuery();
                    oConnection.Close();
                    return true;
                }
                catch (Exception ex)
                {

                    return false;
                }

            }

        }

        public static bool Set(int id, EmpleadosModel oBranch)
        {

            using (SqlConnection oConnection = new SqlConnection(ConnectionController.rutaConexion))
            {

                SqlCommand cmd = new SqlCommand("EmpleadoCode", oConnection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idEmpleado", id);
                cmd.Parameters.AddWithValue("@salario", oBranch.salario);
                cmd.Parameters.AddWithValue("@codigoEmpleado", oBranch.codigoEmpleado);

                try
                {
                    oConnection.Open();
                    cmd.ExecuteNonQuery();
                    oConnection.Close();
                    return true;
                }
                catch (Exception ex)
                {

                    return false;
                }

            }

        }

    }
}