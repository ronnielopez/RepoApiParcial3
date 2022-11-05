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
    public class ControlEmpleadoController : ApiController
    {
        // GET: api/ControleEmpleado
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/ControleEmpleado/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/ControleEmpleado
        public bool Post([FromBody]controlEmpleados value)
        {
                using (SqlConnection oConnection = new SqlConnection(ConnectionController.rutaConexion))
                {
                    SqlCommand cmd = new SqlCommand("inactiveEmpleado", oConnection);
                    cmd.Parameters.AddWithValue("@idEmpleado", value.idEmpleado);
                    cmd.Parameters.AddWithValue("@motivo", value.Motivo);
                     cmd.CommandType = CommandType.StoredProcedure;


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

        // PUT: api/ControleEmpleado/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/ControleEmpleado/5
        public void Delete(int id)
        {
        }
    }
}
