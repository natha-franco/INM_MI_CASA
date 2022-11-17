using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace INM_MI_CASA.Models
{
    public class Usuario
    {
        public int id_usuario { get; set; }

        public string Correo { get; set; }

        public string Clave { get; set; }

        public string ConfirmarClave { get; set; }


    }
}