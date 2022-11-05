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
    public class MunicipioData
    {
        public static List<MunicipiosModel> Get(MunicipiosModel id)
        {

            using (SqlConnection oConnection = new SqlConnection(ConnectionController.rutaConexion))
            {
                List<MunicipiosModel> listBranch = new List<MunicipiosModel>();
                SqlCommand cmd = new SqlCommand("getMunicipioByDepa", oConnection);
                cmd.Parameters.AddWithValue("@idDepartamento", id.idDepartamento);
                cmd.CommandType = CommandType.StoredProcedure;
                

                try
                {
                    oConnection.Open();
                    cmd.ExecuteNonQuery();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {

                        while (dr.Read())
                        {
                            listBranch.Add(new MunicipiosModel()
                            {
                                idMunicipio = Convert.ToInt32(dr["idMunicipio"]),
                                nombre = (dr["nombre"]).ToString(),
                                idDepartamento = Convert.ToInt32(dr["idDepartamento"]),
                                NombreDepartamento = (dr["NombreDepartamento"]).ToString(),
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
    }
}