using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApiParcial3.Models
{
    public class EmpleadosModel
    {
        public int idEmpleado { get; set; }
        public string nombres { get; set; }
        public string apellidos { get; set; }
        public string generos { get; set; }
        public string direccion { get; set; }
        public string telefono { get; set; }
        public double salario { get; set; }
        public string codigoEmpleado { get; set; }
        public int activo { get; set; }
    }
}