using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApiParcial3.Models
{
    public class UsuariosModel
    {
        public int idUsuario { get; set; }
        public string email { get; set; }
        public string pwd { get; set; }
        public int activo { get; set; }

    }
}