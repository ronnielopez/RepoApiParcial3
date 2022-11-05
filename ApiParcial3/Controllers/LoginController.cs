using ApiParcial3.Data;
using ApiParcial3.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ApiParcial3.Controllers
{
    public class LoginController : ApiController
    {
        // GET: api/Login
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Login/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Login
        public bool Post([FromBody]UsuariosModel value)
        {
           
                using (SqlConnection oConnection = new SqlConnection(ConnectionController.rutaConexion))
                {
                    UsuariosModel branch = new UsuariosModel();
                    SqlCommand cmd = new SqlCommand("LoginUsuarios", oConnection);
                    cmd.Parameters.AddWithValue("@email", value.email);
                    cmd.Parameters.AddWithValue("@pwd", EncriptarData.Encriptar(value.pwd));
                    cmd.CommandType = CommandType.StoredProcedure;

                    try
                    {
                        oConnection.Open();
                        cmd.ExecuteNonQuery();
                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {

                            while (dr.Read())
                            {
                            branch.email = (dr["email"]).ToString();
                            branch.activo = Convert.ToInt32(dr["activo"]);

                            }
                        }
                        oConnection.Close();
                    if (branch.email != null) {

                        return true;
                    }
                    return false;
                    }
                    catch (Exception ex)
                    {

                        return false;
                    }

                }
            
        }

        // PUT: api/Login/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Login/5
        public void Delete(int id)
        {
        }
    }
}
