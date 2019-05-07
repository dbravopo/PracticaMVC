using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PracticaMVC.Models
{
    public class ClienteEntity
    {
        public int idCliente { get; set; }

        public string nombreCliente { get; set; }

        public string genero { get; set; }

        public int idProfesion { get; set; }
    }
}