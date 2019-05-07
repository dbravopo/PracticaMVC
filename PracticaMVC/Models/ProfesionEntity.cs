using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PracticaMVC.Models
{
    public class ProfesionEntity
    {
        public int idProfesion { get; set; }

        public string nombreProfesion { get; set; }

        public string descripcion { get; set; }

        public string nombreCliente { get; set; }
    }
}