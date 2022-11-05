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
    public class DepartamentosController : ApiController
    {
        // GET: api/Departamentos
        public List<DepartamentosModel> Get()
        {
            return DepartamentosData.Get();
        }

        // GET: api/Departamentos/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Departamentos
        public bool Post([FromBody]DepartamentosModel value)
        {
            return DepartamentosData.Save(value);
        }

        // PUT: api/Departamentos/5
        public bool Put(int id, [FromBody]DepartamentosModel value)
        {
            return DepartamentosData.Set(id, value);
        }

        // DELETE: api/Departamentos/5
        public void Delete(int id)
        {
        }
    }
}
