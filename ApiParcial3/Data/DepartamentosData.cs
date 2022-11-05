using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using ApiParcial3.Controllers;
using ApiParcial3.Models;

namespace ApiParcial3.Data
{
    public class DepartamentosData
    {
        public static bool Save(DepartamentosModel oBranch)
        {

            using (SqlConnection oConnection = new SqlConnection(ConnectionController.rutaConexion))
            {
                SqlCommand cmd = new SqlCommand("createDepartamentos", oConnection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombre", oBranch.nombre);
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

        public static List<DepartamentosModel> Get()
        {

            using (SqlConnection oConnection = new SqlConnection(ConnectionController.rutaConexion))
            {
                List<DepartamentosModel> listBranch = new List<DepartamentosModel>();
                SqlCommand cmd = new SqlCommand("selectDepartamentos", oConnection);
                cmd.CommandType = CommandType.StoredProcedure;

                try
                {
                    oConnection.Open();
                    cmd.ExecuteNonQuery();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {

                        while (dr.Read())
                        {
                            listBranch.Add(new DepartamentosModel()
                            {
                                idDepartamento = Convert.ToInt32(dr["idDepartamento"]),
                                nombre = (dr["nombre"]).ToString(),
                                activo = Convert.ToInt32(dr["activo"])
                            });
                        }
                    }
                    oConnection.Close();
                    return listBranch;
                }
                catch (Exception ex)
                {

                    return listBranch;
                }

            }

        }

        public static bool Set(int id, DepartamentosModel oBranch)
        {

            using (SqlConnection oConnection = new SqlConnection(ConnectionController.rutaConexion))
            {

                SqlCommand cmd = new SqlCommand("updateDepartamentos", oConnection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idDepartamento", id);
                cmd.Parameters.AddWithValue("@activo", oBranch.activo);
                cmd.Parameters.AddWithValue("@nombre", oBranch.nombre);

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