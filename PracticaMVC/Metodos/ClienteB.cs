using PracticaMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PracticaMVC.Metodos
{
    public class ClienteB
    {
        public List<ClienteEntity> ListarClienteXProfesion(int idProfesion)
        {
            List<ClienteEntity> lstClienteXProf = new List<ClienteEntity>();
            using (PracticaMVCEntities1 db = new PracticaMVCEntities1())
            {
                lstClienteXProf = (from c in db.Cliente
                                   join pc in db.ProfesionCliente
                                   on c.idCliente equals pc.idCliente
                                   where pc.idProfesion == idProfesion

                                   select new PracticaMVC.Models.ClienteEntity
                                   {
                                       nombreCliente = c.nombreCliente,
                                       genero = c.Genero.Trim()

                                   }

                                   ).ToList();
            }
            return lstClienteXProf;

        }
    }
}