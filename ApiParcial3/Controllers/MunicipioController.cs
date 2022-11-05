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
    public class MunicipioController : ApiController
    {
        // GET: api/Municipio
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Municipio/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Municipio
        public List<MunicipiosModel> Post([FromBody]MunicipiosModel value)
        {
            return MunicipioData.Get(value);
        }

        // PUT: api/Municipio/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Municipio/5
        public void Delete(int id)
        {
        }
    }
}
