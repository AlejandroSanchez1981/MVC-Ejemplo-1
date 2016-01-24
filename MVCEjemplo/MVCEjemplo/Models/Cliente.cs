using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCEjemplo.Models
{
    public class Cliente
    {

        public int ClienteId { get; set; }
        public string Nombre { get; set; }
        public string  Celular { get; set; }
        public string Direccion { get; set; }
        public string Email { get; set; }
        public string Imagen { get; set; }



    }

}
