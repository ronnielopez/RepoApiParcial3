using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApiParcial3.Models
{
    public class MunicipiosModel
    {
        public int idMunicipio { get; set; }
        public string nombre { get; set; }
        public int idDepartamento { get; set; }
        public string NombreDepartamento { get; set; }
        public int activo { get; set; }

    }
}