using ApiParcial3.Data;
using ApiParcial3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ApiParcial3.Controllers
{
    public class EmpleadosController : ApiController
    {
        // GET: api/Empleados
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Empleados/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Empleados
        public bool Post([FromBody]EmpleadosModel value)
        {
            return EmpleadoData.Save(value);
        }

        // PUT: api/Empleados/5
        public bool Put(int id, [FromBody]EmpleadosModel value)
        {
            return EmpleadoData.Set(id, value);
        }

        // DELETE: api/Empleados/5
        public void Delete(int id)
        {
        }
    }
}
